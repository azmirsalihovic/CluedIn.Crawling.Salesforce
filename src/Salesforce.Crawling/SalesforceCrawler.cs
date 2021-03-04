using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

            foreach (var item in client.GetById<Account>("0121t000000Dy89AAC", default)) //Organization
            {
                yield return item;
            }

            foreach (var item in client.GetById<Account>("0122o0000007pMrAAI", default)) //Person
            {
                yield return item;
            }

            foreach (var item in client.Get<Contact>("0121t0000010SSoAAM", default)) //Organization
            {
                yield return item;
            }

            // Test a specific customer 
            //foreach (var item in client.Get<Account>(default, "32501887"))
            //{
            //    yield return item;
            //}
        }
    }
}
