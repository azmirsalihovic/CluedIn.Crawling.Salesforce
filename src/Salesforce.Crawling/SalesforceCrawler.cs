using System.Collections.Generic;
using CluedIn.Core.Crawling;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Infrastructure.Factories;

namespace CluedIn.Crawling.Salesforce
{
    public class SalesforceCrawler : ICrawlerDataGenerator
    {
        private readonly ISalesforceClientFactory _clientFactory;

        public SalesforceCrawler(ISalesforceClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is SalesforceCrawlJobData salesforcecrawlJobData))
            {
                yield break;
            }

            var client = _clientFactory.CreateNew(salesforcecrawlJobData);

            //retrieve data from provider and yield objects

            foreach (var item in client.Get<Account>("Account"))
            {
                yield return item;
            }

            //foreach (var item in client.Get<PrivateCustomer>("Account"))
            //{
            //    //if (bool.Parse(item.IsPersonAccount))
            //    //If RecordTypeId "0122o0000007pMrAAI" is true, then it's a private customer, otherwise it's an Organization
            //    if (item.RecordTypeId == "0122o0000007pMrAAI")
            //        yield return item;
            //    else if (item.RecordTypeId == "0121t000000Dy89AAC")
            //    {
            //        var organization = new BusinessCustomer();
            //        foreach (var property in organization.GetType().GetProperties())
            //        {
            //            property.SetValue(organization, item.GetType().GetProperty(property.Name).GetValue(item));
            //        }
            //        yield return organization;
            //    }
            //}

            foreach (var item in client.Get<Contact>("Contact"))
            {
                //Return only if Contact is an Organization (We don't want private customers)
                if (item.RecordTypeId == "0121t0000010SSoAAM")
                    yield return item;
            }
        }       
    }
}
