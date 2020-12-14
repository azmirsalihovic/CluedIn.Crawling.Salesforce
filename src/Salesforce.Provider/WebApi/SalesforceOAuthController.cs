using System;
using System.Configuration;

using CluedIn.Core;
using CluedIn.Server.Common.WebApi.OAuth;
using CluedIn.Crawling.Salesforce.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using CluedIn.Core.Security;
using RestSharp;
using System.Web;
using CluedIn.Core.Data.Relational;
using System.Linq;
using CluedIn.Core.Configuration;
using System.Net.Http;
using System.Text;

namespace CluedIn.Provider.Salesforce.WebApi
{
    [Route("api/" + SalesforceConstants.ProviderName + "/oauth")]
    public class SalesforceOAuthController : OAuthCluedInApiController
    {
        private const string NoStateFoundInCluedIn = "No state found in CluedIn";
        private const string NoStateWasReturnedFromAuthenticator = "No state was returned from authenticator";

        public SalesforceOAuthController([NotNull] SalesforceProviderComponent component)
          : base(component)
        {
        }

        // This method will be invoked as a call-back from an authentication service (e.g., https://login.windows.net/).
        // It is not intended to be called directly, only as a redirect from the authorization request.
        // On completion, the method will cache the refresh token and access tokens, and redirect to the URL
        // specified in the state parameter.
        public IActionResult Get(string code, string state)
        {
            using (var context = CreateRequestSystemExecutionContext())
            {
                // NOTE: In production, OAuth must be done over a secure HTTPS connection.
                if (this.Request.Scheme != "https" && Url.IsLocalUrl(this.Request.GetDisplayUrl()))
                    return Get("Endpoint is not HTTPS");

                // Ensure there is a state value on the response.  If there is none, stop OAuth processing and display an error.
                if (state == null)
                    Get(NoStateWasReturnedFromAuthenticator);

                if (code == null)
                    Get("No code was returned from authenticator");

                var stateObject = ValidateState(context, state);

                if (stateObject == null)
                {
                    using(context.Log.BeginScope(new { code, state }))
                    {
                        context.Log.LogError(NoStateFoundInCluedIn);
                    }
                    return Get(NoStateFoundInCluedIn);
                }


                var client = new RestClient("https://login.salesforce.com");
                var request = new RestRequest("services/oauth2/token", Method.POST);
                request.AddQueryParameter("grant_type", "authorization_code"); // adds to POST or URL querystring based on Method
                request.AddQueryParameter("code", code); // adds to POST or URL querystring based on Method
                request.AddQueryParameter("redirect_uri", $"{Request.Scheme}://{Request.Host}/api/{SalesforceConstants.ProviderName}/oauth");  // adds to POST or URL querystring based on Method
                request.AddQueryParameter("client_id", ConfigurationManager.AppSettings["Providers.SalesforceClientId"]); // adds to POST or URL querystring based on Method
                request.AddQueryParameter("client_secret", ConfigurationManager.AppSettings["Providers.SalesforceClientSecret"]); // adds to POST or URL querystring based on Method

                // execute the request
                var responseFromSalesforce = client.Execute<SalesforceTokenResponse>(request);

                if (responseFromSalesforce.Data == null)
                    return BadRequest("No Result from Token Handshake");

                var accessToken = responseFromSalesforce.Data.access_token;
                var refreshtoken = responseFromSalesforce.Data.refresh_token;
                var instanceUrl = responseFromSalesforce.Data.instance_url;

                // TODO: Expire date is not saved

                var id = responseFromSalesforce.Data.id;

                if (stateObject.OrganizationId == null)
                    return BadRequest("No Organization in Salesforce State");

                if (stateObject.UserId == null)
                    return BadRequest("No UserId in Salesforce State");


                var tokenStore = context.Organization.DataStores.GetDataStore<Token>();
                if (tokenStore == null)
                    return BadRequest("Could not access token store");

                var salesforceProviderId = Core.Constants.Providers.SalesforceId;

                var tokenCheck = tokenStore.Select(context, t => t.ProviderId == salesforceProviderId && t.AccountId == null && t.UserId == stateObject.UserId).ToList();

                if (tokenCheck.Any())
                {
                    context.Log.LogInformation("Deleting Salesforce Token that is not associated with an organization Provider.");
                    tokenStore.Delete(context, tokenCheck);
                }

                string accountId = string.Empty;
                try
                {
                    accountId = id.Substring(id.LastIndexOf("/", System.StringComparison.Ordinal),
                        id.Length - id.LastIndexOf("/", System.StringComparison.Ordinal)).TrimStart('/');
                }
                catch (Exception exception)
                {
                    context.Log.LogWarning("Could not get details on account from Salesforce provider", exception);
                    return BadRequest("Could not get details on account from Salesforce provider");
                }

                if (stateObject.UserId == null)
                {
                    context.Log.LogWarning("Could not get UserId from Salesforce State");
                    return BadRequest("Could not get UserId from Salesforce State");
                }

                if (stateObject.OrganizationId == null)
                {
                    context.Log.LogWarning("Could not get OrganizationId from Salesforce State");
                    return BadRequest("Could not get OrganizationId from Salesforce State");
                }

                var tokenCheck2 = tokenStore.Select(context, t => t.ProviderId == salesforceProviderId && t.AccountId == accountId && t.UserId == stateObject.UserId && t.ConfigurationId != null).ToList();

                var providerEnabledCheck = tokenCheck2.FirstOrDefault();
                if (providerEnabledCheck != null)
                {
                    if (providerEnabledCheck.ConfigurationId != null)
                    {
                        var organizationProviderDataStore = context.Organization.DataStores.GetDataStore<ProviderDefinition>();
                        var organizationProvider = organizationProviderDataStore.GetById(context, providerEnabledCheck.ConfigurationId.Value);
                        if (organizationProvider != null)
                        {
                            if (organizationProvider.Approved == false)
                            {
                                if (tokenCheck2.Any())
                                {
                                    //Delete the connected token
                                    tokenStore.Delete(context, tokenCheck2);
                                    //Delete the thing the token is connected to
                                    organizationProviderDataStore.Delete(context, organizationProvider);
                                }
                            }
                        }
                        else
                        {
                            context.Log.LogInformation("Salesforce Provider Definition not found.");
                        }
                    }
                    else
                    {
                        context.Log.LogInformation("Configuration Id null for Salesforce Provider Definition.");
                    }
                }

                bool reAuthenticated = false;
                var reAuthenticateCheck = tokenStore.Select(context, t => t.ProviderId == salesforceProviderId && t.AccountId == accountId && t.UserId == stateObject.UserId).ToList();

                if (reAuthenticateCheck.Any())
                {
                    context.Log.LogInformation("ReAuthenticating Salesforce Token.");
                    var oldToken = tokenStore.GetById(context, reAuthenticateCheck.First().Id);
                    oldToken.AccessToken = accessToken;
                    oldToken.RefreshToken = refreshtoken;
                    oldToken.AccessTokenCreationDate = DateTimeOffset.UtcNow;
                    tokenStore.Update(context, oldToken);
                    reAuthenticated = true;

                    if (oldToken.ConfigurationId.HasValue)
                        context.Organization.Providers.ClearProviderDefinitionAuthenticationError(context, oldToken.ConfigurationId.Value);
                }
                else
                {
                    tokenStore.Insert(context, new Token(context)
                    {
                        Id = Guid.NewGuid(),
                        OrganizationId = stateObject.OrganizationId,
                        UserId = stateObject.UserId,
                        AccessToken = accessToken,
                        RefreshToken = refreshtoken,
                        ExpiresIn = 3600,
                        ProviderId = salesforceProviderId,
                        AccessTokenCreationDate = DateTimeOffset.UtcNow,
                        AccountId = accountId,
                        ConfigurationId = null,
                        Data = instanceUrl
                    });

                    context.Log.LogInformation("Inserting Salesforce Token.");
                }

                // Return to the originating page where the user triggered the sign-in
                var response = Ok(new StringContent("Ok"));
                
                var organization = context.Organization;

                // TODO: Get base url from config
                if (ConfigurationManager.AppSettings.GetFlag("NewRedirectUrl", false))
                {
                    response.Value = new StringContent(string.Format("<script>window.location = \"https://{0}.{1}/admin/integrations/callback/salesforce\";</script>", organization.ApplicationSubDomain, ConfigurationManager.AppSettings.GetValue("Domain", Constants.Configuration.Defaults.Domain)), Encoding.UTF8, "text/html");
                    if (reAuthenticated)
                    {
                        response.Value = new StringContent(string.Format("<script>window.location = \"https://{0}.{1}/\";</script>", organization.ApplicationSubDomain, ConfigurationManager.AppSettings.GetValue("Domain", Constants.Configuration.Defaults.Domain)), Encoding.UTF8, "text/html");
                        return response;
                    }
                }
                else
                {
                    // TODO: Get base url from config
                    response.Value = new StringContent(string.Format("<script>window.location = \"https://{0}.{1}/admin/#/administration/integration/salesforce/callback\";</script>", organization.ApplicationSubDomain, ConfigurationManager.AppSettings.GetValue("Domain", Constants.Configuration.Defaults.Domain)), Encoding.UTF8, "text/html");
                    if (reAuthenticated)
                    {
                        response.Value = new StringContent(string.Format("<script>window.location = \"https://{0}.{1}/\";</script>", organization.ApplicationSubDomain, ConfigurationManager.AppSettings.GetValue("Domain", Constants.Configuration.Defaults.Domain)), Encoding.UTF8, "text/html");
                        return response;
                    }
                }

                return response;
            }
        }

        /// <summary>Gets the specified error.</summary>
        /// <param name="error">The error.</param>
        /// <returns></returns>
        public IActionResult Get([NotNull] string error)
        {
            if (error == null)
                throw new ArgumentNullException(nameof(error));

            using (var system = CreateRequestSystemExecutionContext())
            {
                system.Log.LogWarning("Salesforce received an error on OAuth : {error}", error);


                //I am not passed the state back, so I have nowhere to know where I came from, hence the redirection to app.cluedin.net
                var redirect = $"<script>window.location = \"https://app.{ConfigurationManager.AppSettings["Domain"]}/admin/#/administration/integration/error/salesforce\";</script>";

                var response = this.Content(redirect, "text/html");
                response.StatusCode = StatusCodes.Status417ExpectationFailed;

                // Ensure there is a state value on the response.  If there is none, stop OAuth processing and display an error.
                return response;
            }
        }

        public AgentToken RefreshToken(string refreshToken, Guid userId, Guid organizationId)
        {
            //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var client = new RestClient("https://login.salesforce.com");
            var request = new RestRequest("services/oauth2/token", Method.POST);
            request.AddQueryParameter("grant_type", "refresh_token"); // adds to POST or URL querystring based on Method
            request.AddQueryParameter("refresh_token", refreshToken); // adds to POST or URL querystring based on Method
            request.AddQueryParameter("client_id", ConfigurationManager.AppSettings["Providers.SalesforceClientId"]); // adds to POST or URL querystring based on Method
            request.AddQueryParameter("client_secret", ConfigurationManager.AppSettings["Providers.SalesforceClientSecret"]); // adds to POST or URL querystring based on Method

            // execute the request
            var responseFromSalesforce = client.Execute<SalesforceTokenResponse>(request);

            var accessToken = responseFromSalesforce.Data.access_token;
            var refreshtoken = refreshToken;

            return new AgentToken() { AccessToken = accessToken, RefreshToken = refreshtoken, ExpiresIn = 0 };
        }

    }
}
