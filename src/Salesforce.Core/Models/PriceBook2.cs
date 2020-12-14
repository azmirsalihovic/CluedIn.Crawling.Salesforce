using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("PriceBook2")]
    public class PriceBook2 : SystemObject
    {
        public const string SObjectTypeName = "PriceBook2";
        public string Description { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string IsStandard { get; set; }
        public string Name { get; set; }
    }
}
