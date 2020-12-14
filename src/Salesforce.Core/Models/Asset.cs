
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Asset")]
    public class Asset : SystemObject
    {
        public const string SObjectTypeName = "Asset";

        public string InstallDate { get; set; }
        public string IsCompetitorProduct { get; set; }
        public string Price { get; set; }
        public string PurchaseDate { get; set; }
        public string Quantity { get; set; }
        [QueryIgnore]
        public string RecordTypeId { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
        public string UsageEndDate { get; set; }

        public string AccountId { get; set; }
        public string ContactId { get; set; }
        public string Description { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
        [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string Name { get; set; }
        [QueryIgnore]
        public string OwnerId { get; set; }
        [QueryIgnore]
        public string ParentId { get; set; }
        public string Product2Id { get; set; }

    }
}
