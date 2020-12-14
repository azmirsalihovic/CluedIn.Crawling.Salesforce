using CluedIn.Core.Webhooks;
using CluedIn.Crawling.Salesforce.Core;

namespace CluedIn.Provider.Salesforce.WebHooks
{
    public class Name_WebhookPreValidator : BaseWebhookPrevalidator
    {
        public Name_WebhookPreValidator()
            : base(SalesforceConstants.ProviderId, SalesforceConstants.ProviderName)
        {
        }
    }
}
