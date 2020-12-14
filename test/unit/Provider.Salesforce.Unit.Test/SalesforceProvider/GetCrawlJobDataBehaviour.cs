using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Salesforce.Core;
using Xunit;

namespace CluedIn.Provider.Salesforce.Unit.Test.SalesforceProvider
{
    public class GetCrawlJobDataBehaviour : SalesforceProviderTest
    {
        private readonly ProviderUpdateContext _context;

        public GetCrawlJobDataBehaviour()
        {
            _context = null;
        }

        [Theory]
        [InlineAutoData]
        public async Task ReturnsData(Dictionary<string, object> dictionary, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            Assert.NotNull(
                await Sut.GetCrawlJobData(_context, dictionary, organizationId, userId, providerDefinitionId));
        }

        [Theory]
        [InlineAutoData(SalesforceConstants.KeyName.ApiKey, nameof(SalesforceCrawlJobData.ApiKey))]
        public async Task InitializesProperties(string key, string propertyName, string sampleValue, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            var dictionary = new Dictionary<string, object>()
            {
                [key] = sampleValue
            };

            var sut = await Sut.GetCrawlJobData(_context, dictionary, organizationId, userId, providerDefinitionId);
            Assert.Equal(sampleValue, sut.GetType().GetProperty(propertyName).GetValue(sut));
        }

        [Theory]
        [InlineAutoData]
        public async Task SalesforceCrawlJobDataReturned(Dictionary<string, object> dictionary, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            Assert.IsType<CluedIn.Crawling.Salesforce.Core.SalesforceCrawlJobData>(
                await Sut.GetCrawlJobData(_context, dictionary, organizationId, userId, providerDefinitionId));
        }
    }
}
