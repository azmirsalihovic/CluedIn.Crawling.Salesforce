
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Idea")]
    public class Idea : SystemObject
    {
        public const string SObjectTypeName = "Idea";

         [QueryIgnore]
        public string AttachmentBody { get; set; }
         [QueryIgnore]
        public string AttachmentContentType { get; set; }
         [QueryIgnore]
        public string AttachmentLength { get; set; }
         [QueryIgnore]
        public string AttachmentName { get; set; }
        public string Body { get; set; }
        public string Categories { get; set; }
          [QueryIgnore]
        public string Category { get; set; }
        public string CommunityId { get; set; }
          [QueryIgnore]
        public string CreatorFullPhotoUrl { get; set; }
                  [QueryIgnore]
        public string CreatorName { get; set; }
          [QueryIgnore]
        public string CreatorSmallPhotoUrl { get; set; }
         [QueryIgnore]
        public string CurrencyIsoCode { get; set; }
         [QueryIgnore]
        public string IdeaThemeID { get; set; }
         [QueryIgnore]
        public string IsDeleted { get; set; }
          [QueryIgnore]
        public string IsHtml { get; set; }
          [QueryIgnore]
        public string IsMerged { get; set; }
        public string LastCommentDate { get; set; }
        public string LastCommentId { get; set; }
         [QueryIgnore]
        public string LastReferencedDate { get; set; }
         [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string NumComments { get; set; }
        public string ParentIdeaId { get; set; }
        [QueryIgnore]
        public string RecordTypeId { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string VoteScore { get; set; }
        public string VoteTotal { get; set; }

    }
}
