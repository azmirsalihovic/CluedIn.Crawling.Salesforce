using System;
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

            //Get the list with customer id's from CSV file
            var KUKCustomerIDList = client.GetKUKCustomerIDList();

            //retrieve data from provider and yield objects
            foreach (var item in client.Get<Account>("Account", "'0122o0000007pMrAAI'")) //Person
            {
                if(KUKCustomerIDList != null)
                {
                    if (KUKCustomerIDList.Contains(item.KUKCustomerID__c) || KUKCustomerIDList.Count == 0)
                        yield return item;
                }
                else
                    yield return item;
            }

            foreach (var item in client.Get<Account>("Account", "'0121t000000Dy89AAC'")) //Organization
            {
                if (KUKCustomerIDList != null)
                {
                    if (KUKCustomerIDList.Contains(item.KUKCustomerID__c) || KUKCustomerIDList.Count == 0)
                        yield return item;
                }
                else
                    yield return item;
            }

            foreach (var item in client.Get<Contact>("Contact", "'0121t0000010SSoAAM'")) //Organization
            {
                yield return item;
            }
        }
    }
}
