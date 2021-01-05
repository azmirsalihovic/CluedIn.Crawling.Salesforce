
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Account")]
    public class Account : SystemObject
    {
        public const string SObjectTypeName = "Account";

        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string AccountSource { get; set; }
        public string AnnualRevenue { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string BillingCountryCode { get; set; }
        [QueryIgnore]
        public string BillingGeocodeAccuracy { get; set; }
        [QueryIgnore]
        public string BillingLatitude { get; set; }
        [QueryIgnore]
        public string BillingLongitude { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingStateCode { get; set; }
        public string BillingStreet { get; set; }
        [QueryIgnore]
        public string CleanStatus { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
        [QueryIgnore]
        public string ConnectionSentId { get; set; }
        public string Description { get; set; }
        [QueryIgnore]
        public string DunsNumber { get; set; }
        [QueryIgnore]
        public string Fax { get; set; }
        public string Industry { get; set; }
        [QueryIgnore]
        public string IsCustomerPortal { get; set; }
        public string IsDeleted { get; set; }
        public string IsPartner { get; set; }
        public string IsPersonAccount { get; set; }
        [QueryIgnore]
        public string Jigsaw { get; set; }
        public string LastActivityDate { get; set; }
        public string LastReferencedDate { get; set; }
        public string LastViewedDate { get; set; }
        [QueryIgnore]
        public string MasterRecordId { get; set; }
        [QueryIgnore]
        public string NaicsCode { get; set; }
        [QueryIgnore]
        public string NaicsDesc { get; set; }
        public string NumberOfEmployees { get; set; }
        public string OwnerId { get; set; }
        public string Ownership { get; set; }
        public string ParentId { get; set; }
        public string Phone { get; set; }
        public string PhotoUrl { get; set; }
        public string Rating { get; set; }
        public string RecordTypeId { get; set; }
        public string Salutation { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingCountryCode { get; set; }
        [QueryIgnore]
        public string ShippingGeocodeAccuracy { get; set; }
        [QueryIgnore]
        public string ShippingLatitude { get; set; }
        [QueryIgnore]
        public string ShippingLongitude { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingStateCode { get; set; }
        public string ShippingStreet { get; set; }
        [QueryIgnore]
        public string Sic { get; set; }
        [QueryIgnore]
        public string SicDesc { get; set; }
        public string Site { get; set; }
        public string TickerSymbol { get; set; }
        [QueryIgnore]
        public string Tradestyle { get; set; }
        public string Type { get; set; }
        public string Website { get; set; }
        [QueryIgnore]
        public string YearStarted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [QueryIgnore]
        public string MiddleName { get; set; }
        [QueryIgnore]
        public string PersonAssistantName { get; set; }
        public string PersonAssistantPhone { get; set; }
        public string PersonBirthDate { get; set; }
        public string PersonContactId { get; set; }
        public string PersonDepartment { get; set; }
        public string PersonEmail { get; set; }
        public string PersonEmailBouncedDate { get; set; }
        public string PersonHasOptedOutOfEmail { get; set; }
        public string PersonHomePhone { get; set; }
        [QueryIgnore]
        public string PersonLastCURequestDate { get; set; }
        [QueryIgnore]
        public string PersonLastCUUpdateDate { get; set; }
        public string PersonLeadSource { get; set; }
        public string PersonMailingAddress { get; set; }
        public string PersonMailingCity { get; set; }
        [QueryIgnore]
        public string PersonMailingGeocodeAccuracy { get; set; }
        [QueryIgnore]
        public string PersonMailingLatitude { get; set; }
        [QueryIgnore]
        public string PersonMailingLongitude { get; set; }
        public string PersonMailingStreet { get; set; }
        public string PersonMobilePhone { get; set; }
        public string PersonOtherCity { get; set; }
        public string PersonOtherCountry { get; set; }
        public string PersonOtherPostalCode { get; set; }
        public string PersonOtherState { get; set; }
        public string PersonOtherCountryCode { get; set; }
        public string PersonOtherStateCode { get; set; }
        [QueryIgnore]
        public string PersonOtherLatitude { get; set; }
        [QueryIgnore]
        public string PersonOtherLongitude { get; set; }
        public string PersonOtherPhone { get; set; }
        public string PersonOtherStreet { get; set; }
        public string PersonTitle { get; set; }
        [QueryIgnore]
        public string Suffix { get; set; }
        public string Age__pc { get; set; }
        public string AudiIdC { get; set; }
        public string Bounced__pc { get; set; }
        public string Brand__pc { get; set; }
        [QueryIgnore]
        public string Brand2__pc { get; set; }
        public string Buying_timeframe__pc { get; set; }
        public string Company_Size__pc { get; set; }
        public string Contact_Role__pc { get; set; }
        public string Current_Car_Brand__pc { get; set; }
        public string CustomerCity__c { get; set; }
        public string CVR__c { get; set; }
        public string Dead__c { get; set; }
        public string DealershipID__c { get; set; }
        public string HashedEmail__pc { get; set; }
        public string ID_Email__c { get; set; }
        public string ID_Email__pc { get; set; }
        public string Identity_Kit_Id__pc { get; set; }
        public string IdentityKitId__c { get; set; }
        public string ID_NG__c { get; set; }
        public string ID_NG__pc { get; set; }
        public string Industry__pc { get; set; }
        public string InteractionScoreCalculated__pc { get; set; }
        public string InteractionScoreLastUpdated__pc { get; set; }
        public string InteractionScore__pc { get; set; }
        public string IsActiveUser__pc { get; set; }
        public string IsKUKCustomer__c { get; set; }
        public string IsMarketingContact__pc { get; set; }
        public string Is_Partner__pc { get; set; }
        public string KUKCode__c { get; set; }
        public string KUKCustomerID__c { get; set; }
        public string LeadReassignment__c { get; set; }
        public string MarketingContactHEMKey__c { get; set; }
        public string MarketingContactKey__c { get; set; }
        public string MC_API_Error__pc { get; set; }
        public string MC_API_Status__pc { get; set; }
        public string Number_of_Cars__pc { get; set; }
        public string OrderedLicenses__c { get; set; }
        [QueryIgnore]
        public string Partner_ExtId__c { get; set; }
        public string PhoneFormula__c { get; set; }
        public string PostboxName__c { get; set; }
        public string Prefered_Ownership__pc { get; set; }
        public string Residense_region__pc { get; set; }
        public string Robinson__c { get; set; }
        public string Seat_Id__c { get; set; }
        public string Skoda_Id__c { get; set; }
        public string Started_using_SF__c { get; set; }
        public string VW_E_Id_c__c { get; set; }
        public string VW_Id__c { get; set; }
        public string PersonContactId__c { get; set; }
        public string PersonDonotCall { get; set; }
        public string PersonEmailBouncedReason { get; set; }
        public string PersonHasOptedOutOfFax { get; set; }
        public string PersonMailingCountry { get; set; }
        public string PersonMailingCountryCode { get; set; }
        public string PersonMailingPostalCode { get; set; }
        public string PersonMailingState { get; set; }
        public string PersonMailingStateCode { get; set; }
        public string PersonOtherAddress { get; set; }
    }
}
