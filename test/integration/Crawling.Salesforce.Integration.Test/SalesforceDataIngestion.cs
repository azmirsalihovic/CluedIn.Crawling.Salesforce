using System.Linq;
using CrawlerIntegrationTesting.Clues;
using Xunit;
using Xunit.Abstractions;

namespace CluedIn.Crawling.Salesforce.Integration.Test
{
    public class DataIngestion : IClassFixture<SalesforceTestFixture>
    {
        private readonly SalesforceTestFixture fixture;
        private readonly ITestOutputHelper output;

        public DataIngestion(SalesforceTestFixture fixture, ITestOutputHelper output)
        {
            this.fixture = fixture;
            this.output = output;
        }

        [Theory]
        [InlineData("/Provider/Root", 1)]
        [InlineData("/Organization", 376163)] //True
        [InlineData("/Infrastructure/User", 1631574)] //foundCount 717.000/ 431.000
        [InlineData("/Infrastructure/Contact", 1847)] //True
        //TODO: Add details for the count of entityTypes your test produces
        //[InlineData("SOME_ENTITY_TYPE", 1)]
        public void CorrectNumberOfEntityTypes(string entityType, int expectedCount)
        {
            //var foundCount = fixture.ClueStorage.CountOfType(entityType);

            var foundCount = fixture.Entities.Count(x => x == entityType);

            //You could use this method to output the logs inside the test case
            fixture.PrintLogs(output);

            Assert.True(expectedCount <= foundCount);
        }

        [Fact]
        public void EntityCodesAreUnique()
        {
            var count = fixture.ClueStorage.Clues.Count();
            var unique = fixture.ClueStorage.Clues.Distinct(new ClueComparer()).Count();

            //You could use this method to output info of all clues
            fixture.PrintClues(output);

            Assert.Equal(unique, count);
        }

       
    }
}
