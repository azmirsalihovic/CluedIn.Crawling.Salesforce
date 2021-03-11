using System;
using System.Collections.Generic;
using CluedIn.Core.Crawling;
using CluedIn.Core.Security;
using Newtonsoft.Json.Linq;

namespace CluedIn.Crawling.Salesforce.Core
{
    public class SalesforceCrawlJobData : CrawlJobData
    {
        public string ApiKey { get; set; }
        public string GrantType { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string KUKCustomerID { get; set; }
        public string FilePath { get; set; }
        public string FilePathOutput { get; set; }
        public string CreateCSVFile { get; set; }
    }
}
