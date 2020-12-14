using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Partner")]
    public class Partner : SystemObject
    {
        public const string SObjectTypeName = "Partner";
        public string AccountFromId { get; set; }
        public string AccountToId { get; set; }
        public string IsDeleted { get; set; }
        public string IsPrimary { get; set; }
        public string OpportunityId { get; set; }
        public string Role { get; set; }
    }
}
