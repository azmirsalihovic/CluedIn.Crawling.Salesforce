using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Report")]
    public class Report : SystemObject
    {
        public const string SObjectTypeName = "Report";
        public string Description { get; set; }
        public string DeveloperName { get; set; }
            [QueryIgnore]
        public string FolderName { get; set; }
            [QueryIgnore]
        public string Format { get; set; }
        public string IsDeleted { get; set; }
        [QueryIgnore]
        public string LastReferenceDate { get; set; }
        public string LastRunDate { get; set; }
          [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string Name { get; set; }
        public string NamespacePrefix { get; set; }
        public string OwnerId { get; set; }
    }
}
