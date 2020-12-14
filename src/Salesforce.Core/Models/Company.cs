using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Company")]
    public class Company : SystemObject
    {

        public const string SObjectTypeName = "Company";
        public string Address { get; set; }
        public string City { get; set; }
        public string CompanyCurrencyIsoCode { get; set; }
        public string Country { get; set; }
        public string CountryAccessCode { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public string DomesticUltimateBusinessName { get; set; }
        public string DomesticUltimateDunsNumber { get; set; }
        public string DunsNumber { get; set; }
        public string EmployeeQuantityGrowthRate { get; set; }
        public string EmployeesHere { get; set; }
        public string EmployeesHereReliability { get; set; }
        public string EmployeesTotal { get; set; }
        public string EmployeesTotalReliability { get; set; }
        public string FamilyMembers { get; set; }
        public string Fax { get; set; }
        public string FifthNaics { get; set; }
        public string FifthNaicsDesc { get; set; }
        public string FifthSic { get; set; }
        public string FifthSic8 { get; set; }
        public string FifthSic8Desc { get; set; }
        public string FifthSicDesc { get; set; }
        public string FipsMsaCode { get; set; }
        public string FipsMsaDesc { get; set; }
        public string FortuneRank { get; set; }
        public string FourthNaics { get; set; }
        public string FourthNaicsDesc { get; set; }
        public string FourthSic { get; set; }
        public string FourthSic8 { get; set; }
        public string FourthSic8Desc { get; set; }
        public string FourthSicDesc { get; set; }
        public string GeoCodeAccuracy { get; set; }
        public string GlobalUltimateBusinessName { get; set; }
        public string GlobalUltimateDunsNumber { get; set; }
        public string GlobalUltimateTotalEmployees { get; set; }
        public string ImportExportAgent { get; set; }
        public string IncludedInSnP500 { get; set; }
        public string Latitude { get; set; }
        public string LegalStatus { get; set; }
        public string LocationStatus { get; set; }
        public string Longitude { get; set; }
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingCountry { get; set; }
        public string MailingPostalCode { get; set; }
        public string MailingState { get; set; }
        public string MailingStreet { get; set; }
        public string MarketingPreScreen { get; set; }
        public string MarketingSegmentationCluster { get; set; }
        public string MinorityOwned { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string NationalIdType { get; set; }
        public string OutOfBusiness { get; set; }
        public string OwnOrRent { get; set; }
        public string ParentOrHqBusinessName { get; set; }
        public string ParentOrHqDunsNumber { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string PremisesMeasure { get; set; }
        public string PremisesMeasureReliability { get; set; }
        public string PremisesMeasureUnit { get; set; }
        public string PrimaryNaics { get; set; }
        public string PrimaryNaicsDesc { get; set; }
        public string PrimarySic { get; set; }
        public string PrimarySic8 { get; set; }
        public string PrimarySic8Desc { get; set; }
        public string PrimarySicDesc { get; set; }
        public string PriorYearEmployees { get; set; }
        public string PriorYearRevenue { get; set; }
        public string PublicIndicator { get; set; }
        public string SalesTurnoverGrowthRate { get; set; }
        public string SalesVolume { get; set; }
        public string SalesVolumeReliability { get; set; }
        public string SecondNaics { get; set; }
        public string SecondNaicsDesc { get; set; }
        public string SecondSic { get; set; }
        public string SecondSic8 { get; set; }
        public string SecondSic8Desc { get; set; }
        public string SecondSicDesc { get; set; }
        public string SixthNaics { get; set; }
        public string SixthNaicsDesc { get; set; }
        public string SixthSic { get; set; }
        public string SixthSic8 { get; set; }
        public string SixthSic8Desc { get; set; }
        public string SixthSicDesc { get; set; }
        public string SmallBusiness { get; set; }
        public string State { get; set; }
        public string StockExchange { get; set; }
        public string StockSymbol { get; set; }
        public string Street { get; set; }
        public string Subsidiary { get; set; }
        public string ThirdNaics { get; set; }
        public string ThirdNaicsDesc { get; set; }
        public string ThirdSic { get; set; }
        public string ThirdSic8 { get; set; }
        public string ThirdSic8Desc { get; set; }
        public string ThirdSicDesc { get; set; }
        public string TradeStyle1 { get; set; }
        public string TradeStyle2 { get; set; }
        public string TradeStyle3 { get; set; }
        public string TradeStyle4 { get; set; }
        public string TradeStyle5 { get; set; }
        public string URL { get; set; }
        public string UsTaxId { get; set; }
        public string WomenOwned { get; set; }
        public string YearStarted { get; set; }

    }
}
