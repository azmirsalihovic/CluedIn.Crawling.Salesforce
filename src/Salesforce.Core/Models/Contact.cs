
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Contact")]
    public class Contact : SystemObject
    {
        public const string SObjectTypeName = "Contact";

        public string AccountId { get; set; }
        public string AssistantName { get; set; }
        public string AssistantPhone { get; set; }
        public string Birthdate { get; set; }
        [QueryIgnore]
        public string CanAllowPortalSelfReg { get; set; }
        [QueryIgnore]
        public string CleanStatus { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
        [QueryIgnore]
        public string ConnectionSentId { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string DoNotCall { get; set; }
        public string Email { get; set; }
        [QueryIgnore]
        public string EmailBouncedDate { get; set; }
        [QueryIgnore]
        public string EmailBouncedReason { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        [QueryIgnore]
        public string HasOptedOutOfEmail { get; set; }
        [QueryIgnore]
        public string HasOptedOutOfFax { get; set; }
        public string HomePhone { get; set; }
        public string IsDeleted { get; set; }
        public string IsEmailBounced { get; set; }
        public string IsPersonAccount { get; set; }
        [QueryIgnore]
        public string Jigsaw { get; set; }
        public string LastActivityDate { get; set; }
        public string LastCURequestDate { get; set; }
        public string LastCUUpdateDate { get; set; }
        public string LastName { get; set; }
        public string LastReferencedDate { get; set; }
        public string LastViewedDate { get; set; }
        public string LeadSource { get; set; }
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingCountry { get; set; }
        public string MailingPostalCode { get; set; }
        public string MailingStateCode { get; set; }
        public string MailingCountryCode { get; set; }
        public string MailingStreet { get; set; }
        public string MailingGeocodeAccuracy { get; set; }
        public string MailingLatitude { get; set; }
        public string MailingLongitude { get; set; }
        public string MasterRecordId { get; set; }
        [QueryIgnore]
        public string MiddleName { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        public string OtherAddress { get; set; }
        public string OtherCity { get; set; }
        public string OtherCountry { get; set; }
        public string OtherPostalCode { get; set; }
        public string OtherState { get; set; }
        public string OtherCountryCode { get; set; }
        public string OtherStateCode { get; set; }
        [QueryIgnore]
        public string OtherGeocodeAccuracy { get; set; }
        [QueryIgnore]
        public string OtherLatitude { get; set; }
        [QueryIgnore]
        public string OtherLongitude { get; set; }
        public string OtherPhone { get; set; }
        public string OtherStreet { get; set; }
        public string OwnerId { get; set; }
        public string Phone { get; set; }
        public string PhotoUrl { get; set; }
        public string RecordTypeId { get; set; }
        public string ReportsToId { get; set; }
        public string Salutation { get; set; }
        [QueryIgnore]
        public string Suffix { get; set; }
        public string Title { get; set; }
        public string AgeC { get; set; }
        public string BouncedC { get; set; }
        public string BrandC { get; set; }
        public string Brand2C { get; set; }
        public string BuyingTimeframeC { get; set; }
        public string CompanySizeC { get; set; }
        public string ContactRoleC { get; set; }
        public string CurrentCarBrandC { get; set; }
        public string HashedEmailC { get; set; }
        public string IdEmailC { get; set; }
        public string IdentityKitIdC { get; set; }
        public string IdNgC { get; set; }
        public string IndustryC { get; set; }
        public string InteractionScoreC { get; set; }
        public string InteractionScoreCalculatedC { get; set; }
        public string InteractionScoreLastUpdatedC { get; set; }
        public string IsActiveUserC { get; set; }
        public string IsMarketingContactC { get; set; }
        public string IsPartnerC { get; set; }
        public string McApiErrorC { get; set; }
        public string McApiStatusC { get; set; }
        public string NumberOfCarsC { get; set; }
        public string PreferedOwnershipC { get; set; }
        public string ResidenseRegionC { get; set; }
    }
}
