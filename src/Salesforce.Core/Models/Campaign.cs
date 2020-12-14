using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Campaign")]
    public class Campaign : SystemObject
    {
        public const string SObjectTypeName = "Campaign";
        public string ActualCost { get; set; }
        public string AmountAllOpportunities { get; set; }
        public string AmountWonOpportunities { get; set; }
        public string BudgetedCost { get; set; }
        public string CampaignMemberRecordTypeId { get; set; }
            [QueryIgnore]
        public string CurrencyIsoCode { get; set; }
        public string Description { get; set; }
        public string EndDate { get; set; }
        public string ExpectedResponse { get; set; }
        public string ExpectedRevenue { get; set; }
            [QueryIgnore]
        public string HierarchyActualCost { get; set; }
        [QueryIgnore]
        public string HierarchyBudgetedCost { get; set; }
        [QueryIgnore]
        public string HierarchyExpectedRevenue { get; set; }
        [QueryIgnore]
        public string HierarchyNumberSent { get; set; }
        public string IsActive { get; set; }
        public string LastActivityDate { get; set; }
          [QueryIgnore]
        public string LastReferencedDate { get; set; }
          [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string Name { get; set; }
        public string NumberOfContacts { get; set; }
        public string NumberOfConvertedLeads { get; set; }
        public string NumberOfLeads { get; set; }
        public string NumberOfOpportunities { get; set; }
        public string NumberOfResponses { get; set; }
        public string NumberOfWonOpportunities { get; set; }
        public string NumberSent { get; set; }
        public string OwnerId { get; set; }
            [QueryIgnore]
        public string ParentCampaign { get; set; }
        public string ParentId { get; set; }
            [QueryIgnore]
        public string RecordTypeId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
          [QueryIgnore]
        public string TotalAmountAllOpportunities { get; set; }
          [QueryIgnore]
        public string TotalAmountAllWonOpportunities { get; set; }
          [QueryIgnore]
        public string TotalNumberofContacts { get; set; }
          [QueryIgnore]
        public string TotalNumberofConvertedLeads { get; set; }
          [QueryIgnore]
        public string TotalNumberofLeads { get; set; }
          [QueryIgnore]
        public string TotalNumberofOpportunties { get; set; }
          [QueryIgnore]
        public string TotalNumberofResponses { get; set; }
          [QueryIgnore]
        public string TotalNumberofWonOpportunities { get; set; }
        public string Type { get; set; }
    }
}
