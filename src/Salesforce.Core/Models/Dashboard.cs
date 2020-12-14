using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Dashboard")]
    public class Dashboard : SystemObject
    {
        public const string SObjectTypeName = "Dashboard";
        public string BackgroundDirection { get; set; }
        public string BackgroundEnd { get; set; }
        public string BackgroundStart { get; set; }
        public string Description { get; set; }
        public string DeveloperName { get; set; }
        public string FolderId { get; set; }
        [QueryIgnore]
        public string FolderName { get; set; }
        public string IsDeleted { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
        [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string LeftSize { get; set; }
        public string MiddleSize { get; set; }
        public string NamespacePrefix { get; set; }
        public string RightSize { get; set; }
        public string RunningUserId { get; set; }
        public string TextColor { get; set; }
        public string Title { get; set; }
        public string TitleColor { get; set; }
        public string TitleSize { get; set; }
        public string Type { get; set; }

    }
}
