using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Document")]
    public class Document : SystemObject
    {
        public const string SObjectTypeName = "Document";
        public string AuthorId { get; set; }
        public string Body { get; set; }
        public string BodyLength { get; set; }
        public string ContentType { get; set; }
        public string Description { get; set; }
        public string DeveloperName { get; set; }
        public string FolderId { get; set; }
        public string IsBodySearchable { get; set; }
        public string IsDeleted { get; set; }
        public string IsInternalUseOnly { get; set; }
        public string IsPublic { get; set; }
        public string Keywords { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
           [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string Name { get; set; }
        public string NamespacePrefix { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }
}
