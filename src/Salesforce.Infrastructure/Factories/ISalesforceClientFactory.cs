using CluedIn.Crawling.Salesforce.Core;

namespace CluedIn.Crawling.Salesforce.Infrastructure.Factories
{
    public interface ISalesforceClientFactory
    {
        SalesforceClient CreateNew(SalesforceCrawlJobData salesforceCrawlJobData);
    }
}
