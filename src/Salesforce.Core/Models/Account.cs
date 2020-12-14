
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Account")]
    public class Account : SystemObject
    {
        public const string SObjectTypeName = "Account";

        public string Name { get; set; }
        [QueryIgnore]
        public string AccountNumber { get; set; }
        public string AccountSource { get; set; }
        public string AnnualRevenue { get; set; }
        [QueryIgnore]
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        [QueryIgnore]
        public string BillingCountryCode { get; set; }
        [QueryIgnore]
        public string BillingGeocodeAccuracy { get; set; }
        [QueryIgnore]
        public string BillingLatitude { get; set; }
        [QueryIgnore]
        public string BillingLongitude { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        [QueryIgnore]
        public string BillingStateCode { get; set; }
        public string BillingStreet { get; set; }
        public string CleanStatus { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
        [QueryIgnore]
        public string ConnectionSentId { get; set; }
        public string Description { get; set; }
        public string DunsNumber { get; set; }
        public string Fax { get; set; }
        public string Industry { get; set; }
        [QueryIgnore]
        public string IsCustomerPortal { get; set; }
        public string IsDeleted { get; set; }
        [QueryIgnore]
        public string IsPartner { get; set; }
        [QueryIgnore]
        public string IsPersonAccount { get; set; }
        public string Jigsaw { get; set; }
        public string LastActivityDate { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
        [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string MasterRecordId { get; set; }
        public string NaicsCode { get; set; }
        public string NaicsDesc { get; set; }

        [QueryIgnore]
        public string NumberOfEmployees { get; set; }

        public string OwnerId { get; set; }
        public string Ownership { get; set; }
        public string ParentId { get; set; }
        public string Phone { get; set; }
        [QueryIgnore]
        public string PhotoUrl { get; set; }
        public string Rating { get; set; }
        [QueryIgnore]
        public string RecordTypeId { get; set; }
        [QueryIgnore]
        public string Salutation { get; set; }
        [QueryIgnore]
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        [QueryIgnore]
        public string ShippingCountryCode { get; set; }
        [QueryIgnore]
        public string ShippingGeocodeAccuracy { get; set; }
        [QueryIgnore]
        public string ShippingLatitude { get; set; }
        [QueryIgnore]
        public string ShippingLongitude { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        [QueryIgnore]
        public string ShippingStateCode { get; set; }
        public string ShippingStreet { get; set; }
        public string Sic { get; set; }
        public string SicDesc { get; set; }
        [QueryIgnore]
        public string Site { get; set; }
        [QueryIgnore]
        public string TickerSymbol { get; set; }
        [QueryIgnore]
        public string Tradestyle { get; set; }
        public string Type { get; set; }
        [QueryIgnore]
        public string Website { get; set; }
        [QueryIgnore]
        public string YearStarted { get; set; }
        [QueryIgnore]
        public string FirstName { get; set; }
        [QueryIgnore]
        public string LastName { get; set; }
        [QueryIgnore]
        public string MiddleName { get; set; }
        [QueryIgnore]
        public string PersonAssistantName { get; set; }
        [QueryIgnore]
        public string PersonAssistantPhone { get; set; }
        [QueryIgnore]
        public string PersonBirthDate { get; set; }
        [QueryIgnore]
        public string PersonContactId { get; set; }
        [QueryIgnore]
        public string PersonDepartment { get; set; }
        [QueryIgnore]
        public string PersonEmail { get; set; }
        [QueryIgnore]
        public string PersonEmailBouncedDate { get; set; }
        [QueryIgnore]
        public string PersonHasOptedOutOfEmail { get; set; }
        [QueryIgnore]
        public string PersonHomePhone { get; set; }
        [QueryIgnore]
        public string PersonLastCURequestDate { get; set; }
        [QueryIgnore]
        public string PersonLastCUUpdateDate { get; set; }
        [QueryIgnore]
        public string PersonLeadSource { get; set; }
        [QueryIgnore]
        public string PersonMailingAddress { get; set; }
        [QueryIgnore]
        public string PersonMailingCity { get; set; }
        [QueryIgnore]
        public string PersonMailingGeocodeAccuracy { get; set; }
        [QueryIgnore]
        public string PersonMailingLatitude { get; set; }
        [QueryIgnore]
        public string PersonMailingLongitude { get; set; }
        [QueryIgnore]
        public string PersonMailingStreet { get; set; }
        [QueryIgnore]
        public string PersonMobilePhone { get; set; }
        [QueryIgnore]
        public string PersonOtherCity { get; set; }
        [QueryIgnore]
        public string PersonOtherCountry { get; set; }
        [QueryIgnore]
        public string PersonOtherPostalCode { get; set; }
        [QueryIgnore]
        public string PersonOtherState { get; set; }
        [QueryIgnore]
        public string PersonOtherCountryCode { get; set; }
        [QueryIgnore]
        public string PersonOtherStateCode { get; set; }
        [QueryIgnore]
        public string PersonOtherLatitude { get; set; }
        [QueryIgnore]
        public string PersonOtherLongitude { get; set; }
        [QueryIgnore]
        public string PersonOtherPhone { get; set; }
        [QueryIgnore]
        public string PersonOtherStreet { get; set; }
        [QueryIgnore]
        public string PersonTitle { get; set; }
        [QueryIgnore]
        public string Suffix { get; set; }
        public string AgePc { get; set; }
        public string AudiIdC { get; set; }
        public string BouncedPc { get; set; }
        public string BrandPc { get; set; }
        public string Brand2Pc { get; set; }
        public string BuyingTimeframePc { get; set; }
        public string CompanySizePc { get; set; }
        public string ContactRolePc { get; set; }
        public string CurrentCarBrandPc { get; set; }
        public string CustomerCityC { get; set; }
        public string CvrC { get; set; }
        public string DeadC { get; set; }
        public string DealershipidC { get; set; }
        public string HashedEmailPc { get; set; }
        public string IdEmailC { get; set; }
        public string IdEmailPc { get; set; }
        public string IdentityKitIdPc { get; set; }
        public string IdentityKitIdC { get; set; }
        public string IdNgC { get; set; }
        public string IdNgPc { get; set; }
        public string IndustryPc { get; set; }
        public string InteractionScoreCalculatedPc { get; set; }
        public string InteractionScoreLastUpdatedPc { get; set; }
        public string InteractionScorePc { get; set; }
        public string IsActiveUserPc { get; set; }
        public string IsKukCustomerC { get; set; }
        public string IsMarketingContactPc { get; set; }
        public string IsPartnerPc { get; set; }
        public string KukCodeC { get; set; }
        public string KukCustomerIdC { get; set; }
        public string LeadReassignmentC { get; set; }
        public string MarketingContactHemKeyC { get; set; }
        public string MarketingContactKeyC { get; set; }
        public string McApiErrorPc { get; set; }
        public string McApiStatusPc { get; set; }
        public string NumberOfCarsPc { get; set; }
        public string OrderedLicensesC { get; set; }
        public string PartnerExtidC { get; set; }
        public string PhoneFormulaC { get; set; }
        public string PostBoxNameC { get; set; }
        public string PreferedOwnershipPc { get; set; }
        public string ResidenseRegionPc { get; set; }
        public string RobinsonC { get; set; }
        public string SeatIdC { get; set; }
        public string SkodaIdC { get; set; }
        public string StartedUsingSfC { get; set; }
        public string VwEIdCC { get; set; }
        public string VwIdC { get; set; }
        public string PersonContactIdC { get; set; }
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
