using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CluedIn.Core.Crawling;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Infrastructure.Factories;
using static CluedIn.Crawling.Salesforce.Infrastructure.SalesforceClient;

namespace CluedIn.Crawling.Salesforce
{
    public class SalesforceCrawler : ICrawlerDataGenerator
    {
        private readonly ISalesforceClientFactory _clientFactory;
        private bool createCSVFile = false;

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
            createCSVFile = client.createCSVFile;

            if (createCSVFile)
            {
                client.GetCSVOutput();
            }
            else
            {

                foreach (var item in client.GetById<Account>("0121t000000Dy89AAC", default)) //Account Organization
                {
                    yield return item;
                }

                foreach (var item in client.GetById<Account>("0122o0000007pMrAAI", default)) //Account Person
                {
                    yield return item;
                }

                foreach (var item in client.Get<Contact>("0121t0000010SSoAAM", default, default)) //Contact Organization
                {
                    yield return item;
                }
            }

            // Test a specific customer 
            //foreach (var item in client.Get<Account>(default, "32501887"))
            //{
            //    yield return item;
            //}
        }
    }
}
