using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Order")]
    public class Order : SystemObject
    {
        public const string SObjectTypeName = "Order";
        public string AccountId { get; set; }
        public string ActivatedById { get; set; }
        public string ActivatedDate { get; set; }
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
        [QueryIgnore]
        public string BillToContactId { get; set; }
        public string CompanyAuthorizedById { get; set; }
        [QueryIgnore]
        public string CompanyAuthorizedDate { get; set; }
        public string ContractId { get; set; }
        public string CustomerAuthorizedById { get; set; }
        public string CustomerAuthorizedDate { get; set; }
        public string Description { get; set; }
        public string EffectiveDate { get; set; }
        public string EndDate { get; set; }
        public string IsReductionOrder { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
                [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string Name { get; set; }
        [QueryIgnore]
        public string OpportunityId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderReferenceNumber { get; set; }
              [QueryIgnore]
        public string OriginalOrderId { get; set; }
           [QueryIgnore]
        public string OwnerId { get; set; }
        public string PoDate { get; set; }
        public string PoNumber { get; set; }
         [QueryIgnore]
        public string Pricebook2Id { get; set; }
        [QueryIgnore]
        public string QuoteId { get; set; }
        [QueryIgnore]
        public string RecordTypeId { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        [QueryIgnore]
        public string ShippingCountryCode { get; set; }
          [QueryIgnore]
        public string ShippingLatitude { get; set; }
          [QueryIgnore]
        public string ShippingLongitude { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        [QueryIgnore]
        public string ShippingStateCode { get; set; }
        public string ShippingStreet { get; set; }
        public string ShipToContactId { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public string TotalAmount { get; set; }
        public string Type { get; set; }
    }
}
