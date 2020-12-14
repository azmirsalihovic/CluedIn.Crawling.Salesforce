using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Contract")]
    public class Contract : SystemObject
    {
        public const string SObjectTypeName = "Contract";
        public string AccountId { get; set; }
        public string ActivatedById { get; set; }
        public string ActivatedDate { get; set; }
            [QueryIgnore]
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        [QueryIgnore]
        public string BillingCountryCode { get; set; }
          [QueryIgnore]
        public string BillingLatitude { get; set; }
          [QueryIgnore]
        public string BillingLongitude { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        [QueryIgnore]
        public string BillingStateCode { get; set; }
        public string BillingStreet { get; set; }
        public string CompanySignedDate { get; set; }
        public string CompanySignedId { get; set; }
        public string ContractNumber { get; set; }
        public string ContractTerm { get; set; }
        public string CustomerSignedDate { get; set; }
        public string CustomerSignedId { get; set; }
        public string CustomerSignedTitle { get; set; }
        public string Description { get; set; }
        public string EndDate { get; set; }
        public string IsDeleted { get; set; }
        public string LastActivityDate { get; set; }
        public string LastApprovedDate { get; set; }
            [QueryIgnore]
        public string LastReferencedDate { get; set; }
        [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string OwnerExpirationNotice { get; set; }
        public string OwnerId { get; set; }
         [QueryIgnore]
        public string Pricebook2Id { get; set; }
        [QueryIgnore]
        public string RecordTypeId { get; set; }
        [QueryIgnore]
        public string ShippingAddress { get; set; }
        [QueryIgnore]
        public string ShippingCity { get; set; }
        [QueryIgnore]
        public string ShippingCountry { get; set; }
        [QueryIgnore]
        public string ShippingCountryCode { get; set; }
        [QueryIgnore]
        public string ShippingLatitude { get; set; }
        [QueryIgnore]
        public string ShippingLongitude { get; set; }
        [QueryIgnore]
        public string ShippingPostalCode { get; set; }
        [QueryIgnore]
        public string ShippingState { get; set; }
        [QueryIgnore]
        public string ShippingStateCode { get; set; }
        [QueryIgnore]
        public string ShippingStreet { get; set; }
        [QueryIgnore]
        public string SpecialTerms { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        [QueryIgnore]
        public string TotalAmount { get; set; }
        [QueryIgnore]
        public string Type { get; set; }
    }
}
