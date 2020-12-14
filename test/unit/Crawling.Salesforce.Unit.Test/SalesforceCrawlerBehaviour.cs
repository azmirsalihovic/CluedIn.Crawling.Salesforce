using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Salesforce;
using CluedIn.Crawling.Salesforce.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Salesforce.Unit.Test
{
    public class SalesforceCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public SalesforceCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<ISalesforceClientFactory>();

            _sut = new SalesforceCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
