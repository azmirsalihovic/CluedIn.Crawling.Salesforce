using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("ContentDocument")]
    public class ContentDocument : SystemObject
    {
        public const string SObjectTypeName = "ContentDocument";
        public string ArchivedById { get; set; }
        public string ArchivedDate { get; set; }
        [QueryIgnore]
        public string ContentModifiedDate { get; set; }
        [QueryIgnore]
        public string ContentSize { get; set; }
        [QueryIgnore]
        public string Description { get; set; }
        [QueryIgnore]
        public string Division { get; set; }
        [QueryIgnore]
        public string FileExtension { get; set; }
        public string FileType { get; set; }
        public string IsArchived { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
        [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string LatestPublishedVersionId { get; set; }
        public string OwnerId { get; set; }
        public string ParentId { get; set; }
        public string PublishStatus { get; set; }
        public string SharingOption { get; set; }
        public string Title { get; set; }

    }
}
