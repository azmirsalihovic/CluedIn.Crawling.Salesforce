using CluedIn.Crawling.Salesforce.Core;

namespace CluedIn.Crawling.Salesforce
{
    public class SalesforceCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<SalesforceCrawlJobData>
    {
        public SalesforceCrawlerJobProcessor(SalesforceCrawlerComponent component) : base(component)
        {
        }
    }
}
