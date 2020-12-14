using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Case")]
    public class Case : SystemObject
    {
        public const string SObjectTypeName = "Case";
        public string AccountId { get; set; }
        public string CaseNumber { get; set; }
        public string ClosedDate { get; set; }
        [QueryIgnore]
        public string CommunityId { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
        [QueryIgnore]
        public string ConnectionSentId { get; set; }
        public string ContactId { get; set; }
        [QueryIgnore]
        public string CreatorFullPhotoUrl { get; set; }
        [QueryIgnore]
        public string CreatorName { get; set; }
        [QueryIgnore]
        public string CreatorSmallPhotoUrl { get; set; }
        public string Description { get; set; }
        [QueryIgnore]
        public string FeedItemId { get; set; }
        [QueryIgnore]
        public string HasCommentsUnreadByOwner { get; set; }
        [QueryIgnore]
        public string HasSelfServiceComments { get; set; }
        public string IsClosed { get; set; }
        [QueryIgnore]
        public string IsClosedOnCreate { get; set; }
        public string IsDeleted { get; set; }
        [QueryIgnore]
        public string IsEscalated { get; set; }
        [QueryIgnore]
        public string IsSelfServiceClosed { get; set; }
        [QueryIgnore]
        public string IsStopped { get; set; }
        [QueryIgnore]
        public string IsVisibleInSelfService { get; set; }
        [QueryIgnore]
        public string LastReferencedDate { get; set; }
                [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string Origin { get; set; }
        public string OwnerId { get; set; }

[QueryIgnore]
        public string ParentId { get; set; }
        public string Priority { get; set; }
        [QueryIgnore]
        public string QuestionId { get; set; }
        public string Reason { get; set; }
        [QueryIgnore]
        public string RecordTypeId { get; set; }
        [QueryIgnore]
        public string SlaStartDate { get; set; }
        public string Status { get; set; }
        [QueryIgnore]
        public string StopStartDate { get; set; }
        public string Subject { get; set; }
        public string SuppliedCompany { get; set; }
        public string SuppliedEmail { get; set; }
        public string SuppliedName { get; set; }
        public string SuppliedPhone { get; set; }
        public string Type { get; set; }
    }
}
