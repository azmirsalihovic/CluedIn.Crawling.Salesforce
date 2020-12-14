using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Domain")]
    public class DomainObject : SystemObject
    {
        public const string SObjectTypeName = "Domain";
        public string Domain { get; set; }
        public string DomainType { get; set; }
        public string OptionsExternalHttps { get; set; }
        
    }
}
