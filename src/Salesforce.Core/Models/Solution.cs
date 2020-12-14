using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Solution")]
    public class Solution : SystemObject
    {
        public const string SObjectTypeName = "Solution";
        public string IsDeleted { get; set; }
        public string IsHtml { get; set; }
            [QueryIgnore]
        public string IsOutOfDate { get; set; }
        public string IsPublished { get; set; }
        public string IsPublishedInPublicKb { get; set; }
        public string IsReviewed { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
          [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string OwnerId { get; set; }
            [QueryIgnore]
        public string ParentId { get; set; }
          [QueryIgnore]
        public string RecordTypeId { get; set; }
          [QueryIgnore]
        public string SolutionLanguage { get; set; }
        public string SolutionName { get; set; }
        public string SolutionNote { get; set; }
        public string SolutionNumber { get; set; }
        public string Status { get; set; }
        public string TimesUsed { get; set; }
    }
}
