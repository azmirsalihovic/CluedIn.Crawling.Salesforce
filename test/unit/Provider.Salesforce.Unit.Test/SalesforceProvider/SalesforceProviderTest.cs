using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Salesforce.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Salesforce.Unit.Test.SalesforceProvider
{
    public abstract class SalesforceProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<ISalesforceClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected SalesforceProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<ISalesforceClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Salesforce.SalesforceProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
