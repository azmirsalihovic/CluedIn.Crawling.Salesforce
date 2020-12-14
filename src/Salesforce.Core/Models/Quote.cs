using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Quote")]
    public class Quote : SystemObject
    {
        public const string SObjectTypeName = "Quote";
        [QueryIgnore]
        public string AccountId { get; set; }
        [QueryIgnore]
        public string AdditionalAddress { get; set; }
        public string AdditionalCity { get; set; }
        public string AdditionalCountry { get; set; }
        [QueryIgnore]
        public string AdditionalCountryCode { get; set; }
        [QueryIgnore]
        public string AdditionalLatitude { get; set; }
        [QueryIgnore]
        public string AdditionalLongitude { get; set; }
        public string AdditionalName { get; set; }
        public string AdditionalPostalCode { get; set; }
        public string AdditionalState { get; set; }
        [QueryIgnore]
        public string AdditionalStateCode { get; set; }
        public string AdditionalStreet { get; set; }

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
        public string BillingName { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        [QueryIgnore]
        public string BillingStateCode { get; set; }
        public string BillingStreet { get; set; }
        public string ContactId { get; set; }
        [QueryIgnore]
        public string ContractId { get; set; }
        [QueryIgnore]
        public string CurrencyIsoCode { get; set; }
        public string Description { get; set; }
        public string Discount { get; set; }
        public string Email { get; set; }
        public string ExpirationDate { get; set; }
        public string Fax { get; set; }
        public string GrandTotal { get; set; }
        public string IsSyncing { get; set; }
        public string LastReferencedDate { get; set; }
        public string LastViewedDate { get; set; }
        public string LineItemCount { get; set; }
        public string Name { get; set; }
        public string OpportunityId { get; set; }
        public string Phone { get; set; }
        public string Pricebook2Id { get; set; }
        public string QuoteNumber { get; set; }
        public string QuoteToAddress { get; set; }
        public string QuoteToCity { get; set; }
        public string QuoteToCountry { get; set; }
        [QueryIgnore]
        public string QuoteToLatitude { get; set; }
        [QueryIgnore]
        public string QuoteToLongitude { get; set; }
        public string QuoteToName { get; set; }
        public string QuoteToPostalCode { get; set; }
        public string QuoteToState { get; set; }
        public string QuoteToStreet { get; set; }
        [QueryIgnore]
        public string RecordTypeID { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        [QueryIgnore]
        public string ShippingCountryCode { get; set; }
        public string ShippingHandling { get; set; }
        [QueryIgnore]
        public string ShippingLatitude { get; set; }
        [QueryIgnore]
        public string ShippingLongitude { get; set; }
        public string ShippingName { get; set; }
        [QueryIgnore]
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        [QueryIgnore]
        public string ShippingStateCode { get; set; }
        public string ShippingStreet { get; set; }
        public string Status { get; set; }
        public string Subtotal { get; set; }
        public string Tax { get; set; }
        public string TotalPrice { get; set; }
    }
}
