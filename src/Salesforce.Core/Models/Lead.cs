using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Lead")]
    public class Lead : SystemObject
    {
        public const string SObjectTypeName = "Lead";
        [QueryIgnore]
        public string Address { get; set; }
        [QueryIgnore]
        public string AnnualRevenue { get; set; }
        public string City { get; set; }
        [QueryIgnore]
        public string CleanStatus { get; set; }
        public string Company { get; set; }
        [QueryIgnore]
        public string CompanyDunsNumber { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
        [QueryIgnore]
        public string ConnectionSentId { get; set; }
        public string ConvertedAccountId { get; set; }
        public string ConvertedContactId { get; set; }
        public string ConvertedDate { get; set; }
        public string ConvertedOpportunityId { get; set; }
        public string Country { get; set; }
        [QueryIgnore]
        public string CountryCode { get; set; }
        [QueryIgnore]
        public string CurrencyIsoCode { get; set; }
        public string Description { get; set; }
        [QueryIgnore]
        public string Division { get; set; }
        public string Email { get; set; }
        public string EmailBouncedDate { get; set; }
        public string EmailBouncedReason { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        [QueryIgnore]
        public string HasOptedOutOfEmail { get; set; }
        [QueryIgnore]
        public string GeocodeAccuracy { get; set; }
        public string Industry { get; set; }
        public string IsConverted { get; set; }
        public string IsDeleted { get; set; }
        public string IsUnreadByOwner { get; set; }
        public string Jigsaw { get; set; }
        public string LastActivityDate { get; set; }
        public string LastName { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
                [QueryIgnore]
        public string LastViewedDate { get; set; }
         [QueryIgnore]
        public string Latitude { get; set; }
         [QueryIgnore]
        public string Longitude { get; set; }
        public string LeadSource { get; set; }
        public string MasterRecordId { get; set; }
        [QueryIgnore]
        public string MiddleName { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        [QueryIgnore]
        public string NumberOfEmployees { get; set; }
        public string OwnerId { get; set; }
        [QueryIgnore]
        public string PartnerAccountId { get; set; }
        public string Phone { get; set; }
           [QueryIgnore]
        public string PhotoUrl { get; set; }
        public string PostalCode { get; set; }
        public string Rating { get; set; }
        [QueryIgnore]
        public string RecordTypeId { get; set; }
        public string Salutation { get; set; }
        public string State { get; set; }
        [QueryIgnore]
        public string StateCode { get; set; }
        public string Status { get; set; }
        public string Street { get; set; }
        [QueryIgnore]
        public string Suffix { get; set; }
        public string Title { get; set; }
        public string Website { get; set; }
    }
}
