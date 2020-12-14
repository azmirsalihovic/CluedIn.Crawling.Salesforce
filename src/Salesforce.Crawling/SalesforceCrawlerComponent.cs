using CluedIn.Core;
using CluedIn.Crawling.Salesforce.Core;

using ComponentHost;

namespace CluedIn.Crawling.Salesforce
{
    [Component(SalesforceConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class SalesforceCrawlerComponent : CrawlerComponentBase
    {
        public SalesforceCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

