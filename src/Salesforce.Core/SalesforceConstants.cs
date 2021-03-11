using System;
using System.Collections.Generic;
using CluedIn.Core.Net.Mail;
using CluedIn.Core.Providers;

namespace CluedIn.Crawling.Salesforce.Core
{
    public class SalesforceConstants
    {
        public struct KeyName
        {
            public const string ApiKey = nameof(ApiKey);
            public const string GrantType = nameof(GrantType);
            public const string ClientId = nameof(ClientId);
            public const string ClientSecret = nameof(ClientSecret);
            public const string UserName = nameof(UserName);
            public const string Password = nameof(Password);
            public const string KUKCustomerID = nameof(KUKCustomerID);
            public const string FilePath = nameof(FilePath);
            public const string FilePathOutput = nameof(FilePathOutput);
            public const string CreateCSVFile = nameof(CreateCSVFile);
        }

        // TODO Complete the following section
        // Please see https://cluedin-io.github.io/CluedIn.Documentation/docs/1-Integration/build-integration.html
        public const string CrawlerDescription = "Salesforce is a web and mobile application designed to enable teamwork without email.";
        public const string Instructions = "Provide authentication instructions here, if applicable";
        public const IntegrationType Type = IntegrationType.Cloud;
        public const string Uri = "https://login.salesforce.com/"; //Uri of remote tool if applicable

        // To change the icon see embedded resource
        // src\Salesforce.Provider\Resources\cluedin.png
        public const string IconResourceName = "Resources.cluedin.png";

        public static IList<string> ServiceType = new List<string> { "" };
        public static IList<string> Aliases = new List<string> { "" };
        public const string Category = "";
        public const string Details = "";
        public static AuthMethods AuthMethods = new AuthMethods()
        {
            token = new Control[]
            {
                // You can define controls to show in the GUI in order to authenticate with this integration
                new Control()
                {
                    displayName = "API key",
                    isRequired = true,
                    name = nameof(KeyName.ApiKey),
                    type = "text"
                },
                new Control()
                {
                    displayName = "Grant type",
                    isRequired = true,
                    name = nameof(KeyName.GrantType),
                    type = "text"
                },
                new Control()
                {
                    displayName = "Client id",
                    isRequired = true,
                    name = nameof(KeyName.ClientId),
                    type = "text"
                },
                new Control()
                {
                    displayName = "Client secret",
                    isRequired = true,
                    name = nameof(KeyName.ClientSecret),
                    type = "text"
                },
                new Control()
                {
                    displayName = "Username",
                    isRequired = true,
                    name = nameof(KeyName.UserName),
                    type = "text"
                },
                new Control()
                {
                    displayName = "Password",
                    isRequired = true,
                    name = nameof(KeyName.Password),
                    type = "text"
                },
                new Control()
                {
                    displayName = "Only search dealers with these IDs. Separate with comma, if there's more",
                    isRequired = false,
                    name = nameof(KeyName.KUKCustomerID),
                    type = "text"
                },
                new Control()
                {
                    displayName = "List with KUKCustomerIDs",
                    isRequired = false,
                    name = nameof(KeyName.FilePath),
                    type = "text"
                },
                new Control()
                {
                    displayName = "Outpt list with KUKCustomerIDs",
                    isRequired = false,
                    name = nameof(KeyName.FilePathOutput),
                    type = "text"
                },
                new Control()
                {
                    displayName = "Created the output csv file with KUKCustomerIDs",
                    isRequired = false,
                    name = nameof(KeyName.CreateCSVFile),
                    type = "text"
                }
            }
        };


        public const bool SupportsConfiguration = true;
        public const bool SupportsWebHooks = false;
        public const bool SupportsAutomaticWebhookCreation = true;

        public const bool RequiresAppInstall = false;
        public const string AppInstallUrl = null;
        public const string ReAuthEndpoint = null;

        #region Autogenerated constants
        public const string CodeOrigin = "Salesforce";
        public const string ProviderRootCodeValue = "Salesforce";
        public const string CrawlerName = "SalesforceCrawler";
        public const string CrawlerComponentName = "SalesforceCrawler";
        public static readonly Guid ProviderId = Guid.Parse("a9648b02-23e1-47f6-a870-6c97c371f2a6");
        public const string ProviderName = "Salesforce";

        


        public static readonly ComponentEmailDetails ComponentEmailDetails = new ComponentEmailDetails
        {
            Features = new Dictionary<string, string>
            {
                                       { "Tracking",        "Expenses and Invoices against customers" },
                                       { "Intelligence",    "Aggregate types of invoices and expenses against customers and companies." }
                                   },
            Icon = ProviderIconFactory.CreateConnectorUri(ProviderId),
            ProviderName = ProviderName,
            ProviderId = ProviderId,
            Webhooks = SupportsWebHooks
        };

        public static IProviderMetadata CreateProviderMetadata()
        {
            return new ProviderMetadata
            {
                Id = ProviderId,
                ComponentName = CrawlerName,
                Name = ProviderName,
                Type = Type.ToString(),
                SupportsConfiguration = SupportsConfiguration,
                SupportsWebHooks = SupportsWebHooks,
                SupportsAutomaticWebhookCreation = SupportsAutomaticWebhookCreation,
                RequiresAppInstall = RequiresAppInstall,
                AppInstallUrl = AppInstallUrl,
                ReAuthEndpoint = ReAuthEndpoint,
                ComponentEmailDetails = ComponentEmailDetails
            };
        }
        #endregion
    }
}
