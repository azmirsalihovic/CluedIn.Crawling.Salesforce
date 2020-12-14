using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using CluedIn.Core;
using CluedIn.Server.Common.WebApi.OAuth;
using CluedIn.Crawling.Salesforce.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace CluedIn.Provider.Salesforce.WebApi
{
    [Authorize(Roles = "Admin, OrganizationAdmin")]
    [Route("api/providers/" + SalesforceConstants.ProviderName)]
    public class SalesforceController : OAuthCluedInApiController
    {
        public SalesforceController([NotNull] SalesforceProviderComponent component) : base(component)
        {
        }

        // GET: Authenticate and Fetch Data
        public IActionResult Get(string authError)
        {
            using (var context = CreateRequestExecutionContext(UserPrincipal))
            {
                if (authError != null)
                {
                    // Tell the OAuth provider where to redirect to once you have the code.
                    var redirectUri = new Uri($"{Request.Scheme}://{Request.Host}/api/{SalesforceConstants.ProviderName}/oauth");

                    var state = GenerateState(context, UserPrincipal.Identity.UserId, redirectUri.AbsoluteUri, context.Organization.Id);


                    return Ok($"https://login.salesforce.com/services/oauth2/authorize?response_type=code&client_id={ConfigurationManager.AppSettings["Providers.SalesforceClientId"]}&redirect_uri={redirectUri}&state={state}&prompt=consent");
                }



                return Ok("Salesforce Provider Crawled");
            }
        }

    }
}
