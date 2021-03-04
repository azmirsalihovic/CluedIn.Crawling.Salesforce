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
        [InlineData("/Organization", 18470)] //18.470 / 376.163
        [InlineData("/Infrastructure/User", 84475)] //84.475 / 1.631.574
        [InlineData("/Infrastructure/Contact", 2465)] //0 / 2.465
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
