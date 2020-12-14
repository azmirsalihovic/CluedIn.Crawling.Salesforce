using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CluedIn.Core;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data.Relational;
using CluedIn.Core.Providers;
using CluedIn.Core.Webhooks;
using System.Configuration;
using System.Linq;
using CluedIn.Core.Configuration;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Salesforce.Infrastructure.Factories;
using CluedIn.Providers.Models;
using Newtonsoft.Json;
using CluedIn.Core.DataStore;
using CluedIn.Core.Security;
using Salesforce.Force;
using RestSharp;
using CluedIn.Crawling.Salesforce.Core.Models;
using Salesforce.Common;
using CluedIn.Provider.Salesforce.WebApi;

namespace CluedIn.Provider.Salesforce
{
    public class SalesforceProvider : ProviderBase, IExtendedProviderMetadata
    {
        private readonly ISalesforceClientFactory _salesforceClientFactory;

        public SalesforceProvider([NotNull] ApplicationContext appContext, ISalesforceClientFactory salesforceClientFactory)
            : base(appContext, SalesforceConstants.CreateProviderMetadata())
        {
            _salesforceClientFactory = salesforceClientFactory;
        }

        public override async Task<CrawlJobData> GetCrawlJobData(
            ProviderUpdateContext context,
            IDictionary<string, object> configuration,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            #region oldauth
            //var salesforceproviderid = id;
            //var tokenstore = context.organization.datastores.getdatastore<token>();

            //if (tokenstore == null)
            //    return null;

            //var configurationdatastore = context.applicationcontext.container.resolve<iconfigurationrepository>();
            //var accounts = tokenstore.select(context, account => account.providerid == salesforceproviderid && account.organizationid == organizationid && account.userid == userid && account.configurationid == providerdefinitionid).tolist();
            //if (!accounts.any())
            //{
            //    accounts.foreach (t => t.context = context.applicationcontext)
            //        ;

            //    // todo: i should not be able to have more than one provider per user per organization
            //    accounts = tokenstore.select(context,
            //        account =>
            //            account.providerid == salesforceproviderid && account.organizationid == organizationid &&
            //            account.userid == userid && account.configurationid == null).tolist();

            //    if (accounts.count() == 1)
            //    {
            //        if (accounts.first().configurationid == null)
            //        {
            //            accounts.first().configurationid = providerdefinitionid;
            //            tokenstore.update(context, accounts.first());
            //        }
            //    }
            //}

            ////add authetnication for all accounts here
            //var agenttoken = accounts.select(i => new extendedagenttoken() { accesstoken = i.accesstoken, refreshtoken = i.refreshtoken, expiresin = i.expiresin, data = i.data, accountid = i.accountid }).firstordefault();
            //if (agenttoken == null)
            //    return null;

            //if (!configuration.containskey("accounts"))
            //    configuration.add("accounts", agenttoken);

            //if (!configuration.containskey("baseuri"))
            //    configuration.add("baseuri", "https://www.salesforce.com");

            //var client = new forceclient(accounts.first().data, agenttoken.accesstoken, "v26.0");
            //try
            //{
            //    // todo: make async : yourkit shows that it takes up quite a lot of cycles.
            //    const string qry = "select id, name from account";
            //    var results = client.queryasync<account>(qry).result;

            //    //authentication failed
            //    if (results == null)
            //    {
            //        var newtoken = await this.refreshtoken(agenttoken.refreshtoken);

            //        if (configuration.containskey("accounts"))
            //            configuration["accounts"] = new extendedagenttoken() { accesstoken = newtoken.accesstoken, expiresin = null, refreshtoken = agenttoken.refreshtoken, accountid = agenttoken.accountid, data = agenttoken.data };

            //        var token = accounts.first();

            //        token.accesstoken = newtoken.accesstoken;
            //        token.refreshtoken = agenttoken.refreshtoken;
            //        token.accesstokencreationdate = datetimeoffset.utcnow;
            //        token.data = agenttoken.data;
            //        token.accountid = agenttoken.accountid;

            //        tokenstore.update(context, token);

            //        results = await client.queryasync<account>(qry);

            //        var providerdefinition = context.organization.providers.getproviderdefinition(context, providerdefinitionid);

            //        if (providerdefinition != null)
            //        {
            //            configurationdatastore.updateconfiguration(context, providerdefinition.id, configuration);

            //        }
            //        else
            //            throw new notfoundexception("provider definition was not found: " + providerdefinitionid);
            //    }
            //    else
            //    {
            //        context.organization.providers.clearproviderdefinitionauthenticationerror(context, providerdefinitionid);
            //    }
            //}
            //catch (exception)
            //{
            //    if (agenttoken.refreshtoken == null)
            //    {
            //        return new crawljobdata() { errors = new dictionary<string, string>() { { "error", "please contact cluedin support in the top menu to help you authenticate with salesforce." } } };
            //    }

            //    var newtoken = this.refreshtoken(agenttoken.refreshtoken).result;

            //    if (configuration.containskey("accounts"))
            //        configuration["accounts"] = new extendedagenttoken() { accesstoken = newtoken.accesstoken, expiresin = null, refreshtoken = agenttoken.refreshtoken, accountid = agenttoken.accountid, data = agenttoken.data };

            //    var token = accounts.first();

            //    token.accesstoken = newtoken.accesstoken;
            //    token.refreshtoken = agenttoken.refreshtoken;
            //    token.accesstokencreationdate = datetimeoffset.utcnow;
            //    token.data = agenttoken.data;
            //    token.accountid = agenttoken.accountid;

            //    try
            //    {
            //        if (newtoken.accesstoken == null)
            //        {
            //            context.organization.providers.setproviderdefinitionauthenticationerror(context, providerdefinitionid, "failed to refresh the access token for salesforce");
            //            return new crawljobdata() { errors = new dictionary<string, string>() { { "error", "please contact cluedin support in the top menu to help you setup with salesforce." } } };
            //        }

            //        client = new forceclient(agenttoken.data, newtoken.accesstoken, "v26.0");

            //        // todo: make async : yourkit shows that it takes up quite a lot of cycles.

            //        const string qry = "select id, name from account";
            //        var results = await client.queryasync<account>(qry);
            //    }
            //    catch (forceexception ex)
            //    {

            //        context.organization.providers.setproviderdefinitionauthenticationerror(context, providerdefinitionid, ex);

            //    }
            //    catch (exception ex)
            //    {
            //        context.organization.providers.setproviderdefinitionauthenticationerror(context, providerdefinitionid, ex);
            //    }
            //}
            #endregion

            var jobData = new SalesforceCrawlJobData();
            if (configuration.ContainsKey(SalesforceConstants.KeyName.ApiKey))
            { jobData.ApiKey = configuration[SalesforceConstants.KeyName.ApiKey].ToString(); }

            if (configuration.ContainsKey(SalesforceConstants.KeyName.GrantType))
            { jobData.GrantType = configuration[SalesforceConstants.KeyName.GrantType].ToString(); }

            if (configuration.ContainsKey(SalesforceConstants.KeyName.ClientId))
            { jobData.ClientId = configuration[SalesforceConstants.KeyName.ClientId].ToString(); }

            if (configuration.ContainsKey(SalesforceConstants.KeyName.ClientSecret))
            { jobData.ClientSecret = configuration[SalesforceConstants.KeyName.ClientSecret].ToString(); }

            if (configuration.ContainsKey(SalesforceConstants.KeyName.UserName))
            { jobData.UserName = configuration[SalesforceConstants.KeyName.UserName].ToString(); }

            if (configuration.ContainsKey(SalesforceConstants.KeyName.Password))
            { jobData.Password = configuration[SalesforceConstants.KeyName.Password].ToString(); }

            //if (!jobData.IsAuthenticated)
            //    return null;


            return await Task.FromResult(jobData);
        }

        public override Task<bool> TestAuthentication(
            ProviderUpdateContext context,
            IDictionary<string, object> configuration,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public override Task<ExpectedStatistics> FetchUnSyncedEntityStatistics(ExecutionContext context, IDictionary<string, object> configuration, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public override async Task<IDictionary<string, object>> GetHelperConfiguration(
            ProviderUpdateContext context,
            [NotNull] CrawlJobData jobData,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));

            var dictionary = new Dictionary<string, object>();

            if (jobData is SalesforceCrawlJobData salesforceCrawlJobData)
            {
                //TODO add the transformations from specific CrawlJobData object to dictionary
                // add tests to GetHelperConfigurationBehaviour.cs
                dictionary.Add(SalesforceConstants.KeyName.ApiKey, salesforceCrawlJobData.ApiKey);
            }

            return await Task.FromResult(dictionary);
        }

        public override Task<IDictionary<string, object>> GetHelperConfiguration(
            ProviderUpdateContext context,
            CrawlJobData jobData,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId,
            string folderId)
        {
            throw new NotImplementedException();
        }

        public override async Task<AccountInformation> GetAccountInformation(ExecutionContext context, [NotNull] CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));

            if (!(jobData is SalesforceCrawlJobData salesforceCrawlJobData))
            {
                throw new Exception("Wrong CrawlJobData type");
            }

            var client = _salesforceClientFactory.CreateNew(salesforceCrawlJobData);
            return await Task.FromResult(client.GetAccountInformation());
        }

        public override string Schedule(DateTimeOffset relativeDateTime, bool webHooksEnabled)
        {
            return webHooksEnabled && ConfigurationManager.AppSettings.GetFlag("Feature.Webhooks.Enabled", false) ? $"{relativeDateTime.Minute} 0/23 * * *"
                : $"{relativeDateTime.Minute} 0/4 * * *";
        }

        public override Task<IEnumerable<WebHookSignature>> CreateWebHook(ExecutionContext context, [NotNull] CrawlJobData jobData, [NotNull] IWebhookDefinition webhookDefinition, [NotNull] IDictionary<string, object> config)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));
            if (webhookDefinition == null)
                throw new ArgumentNullException(nameof(webhookDefinition));
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            throw new NotImplementedException();
        }

        public override Task<IEnumerable<WebhookDefinition>> GetWebHooks(ExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteWebHook(ExecutionContext context, [NotNull] CrawlJobData jobData, [NotNull] IWebhookDefinition webhookDefinition)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));
            if (webhookDefinition == null)
                throw new ArgumentNullException(nameof(webhookDefinition));

            throw new NotImplementedException();
        }

        public override IEnumerable<string> WebhookManagementEndpoints([NotNull] IEnumerable<string> ids)
        {
            if (ids == null)
            {
                throw new ArgumentNullException(nameof(ids));
            }

            if (!ids.Any())
            {
                throw new ArgumentException(nameof(ids));
            }

            throw new NotImplementedException();
        }

        public override async Task<CrawlLimit> GetRemainingApiAllowance(ExecutionContext context, [NotNull] CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));


            //There is no limit set, so you can pull as often and as much as you want.
            return await Task.FromResult(new CrawlLimit(-1, TimeSpan.Zero));
        }

        //public async Task<ExtendedAgentToken> RefreshToken([NotNull] string refreshToken)
        //{

        //}

        // TODO Please see https://cluedin-io.github.io/CluedIn.Documentation/docs/1-Integration/build-integration.html
        public string Icon => SalesforceConstants.IconResourceName;
        public string Domain { get; } = SalesforceConstants.Uri;
        public string About { get; } = SalesforceConstants.CrawlerDescription;
        public AuthMethods AuthMethods { get; } = SalesforceConstants.AuthMethods;
        public IEnumerable<Control> Properties => null;
        public string ServiceType { get; } = JsonConvert.SerializeObject(SalesforceConstants.ServiceType);
        public string Aliases { get; } = JsonConvert.SerializeObject(SalesforceConstants.Aliases);
        public Guide Guide { get; set; } = new Guide
        {
            Instructions = SalesforceConstants.Instructions,
            Value = new List<string> { SalesforceConstants.CrawlerDescription },
            Details = SalesforceConstants.Details

        };

        public string Details { get; set; } = SalesforceConstants.Details;
        public string Category { get; set; } = SalesforceConstants.Category;
        public new IntegrationType Type { get; set; } = SalesforceConstants.Type;
    }
}
