using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Opportunity")]
    public class Opportunity : SystemObject
    {
        public const string SObjectTypeName = "Opportunity";
        public string AccountId { get; set; }
        public string Amount { get; set; }
        public string CampaignId { get; set; }
        public string CloseDate { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
         [QueryIgnore]
        public string ConnectionSentId { get; set; }
            [QueryIgnore]
        public string ContractId { get; set; }
            [QueryIgnore]
        public string CurrencyIsoCode { get; set; }
        public string Description { get; set; }
        [QueryIgnore]
        public string ExpectedRevenue { get; set; }
        public string Fiscal { get; set; }
        public string FiscalQuarter { get; set; }
        public string FiscalYear { get; set; }
        public string ForecastCategory { get; set; }
        public string ForecastCategoryName { get; set; }
        [QueryIgnore]
        public string HasOpenActivity { get; set; }
        [QueryIgnore]
        public string HasOpportunityLineItem { get; set; }
        [QueryIgnore]
        public string HasOverdueTask { get; set; }
        public string IsClosed { get; set; }
        public string IsDeleted { get; set; }
          [QueryIgnore]
        public string IsExcludedFromTerritory2Filter { get; set; }
            [QueryIgnore]
        public string IsSplit { get; set; }
        public string IsWon { get; set; }
        public string LastActivityDate { get; set; }
          [QueryIgnore]
        public string LastReferencedDate { get; set; }
          [QueryIgnore]
        public string LastViewedDate { get; set; }
        [QueryIgnore]
        public string LeadSource { get; set; }
        public string Name { get; set; }
        public string NextStep { get; set; }
        public string OwnerId { get; set; }
        public string Pricebook2Id { get; set; }
          [QueryIgnore]
        public string PricebookId { get; set; }
        [QueryIgnore]
        public string Probability { get; set; }
         [QueryIgnore]
        public string RecordTypeId { get; set; }
        public string StageName { get; set; }
          [QueryIgnore]
        public string SyncedQuoteID { get; set; }
           [QueryIgnore]
        public string Territory2Id { get; set; }
        [QueryIgnore]
        public string TotalOpportunityQuantity { get; set; }
        public string Type { get; set; }
           [QueryIgnore]
        public string SpecialTerms { get; set; }
          [QueryIgnore]
        public string StartDate { get; set; }
         [QueryIgnore]
        public string Status { get; set; }
         [QueryIgnore]
        public string StatusCode { get; set; }
          [QueryIgnore]
        public string TotalAmount { get; set; }
    }
}
