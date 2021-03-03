using CluedIn.Core.Webhooks;
using CluedIn.Crawling.Salesforce.Core;

namespace CluedIn.Provider.Salesforce.WebHooks
{
    public class SaleForceWebhookPreValidator : BaseWebhookPrevalidator
    {
        public SaleForceWebhookPreValidator()
            : base(SalesforceConstants.ProviderId, SalesforceConstants.ProviderName)
        {
        }
    }
}
