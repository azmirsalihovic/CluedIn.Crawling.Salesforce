using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("CollaborationGroup")]
    public class CollaborationGroup : SystemObject
    {
        public const string SObjectTypeName = "CollaborationGroup";
        [QueryIgnore]
        public string AnnouncementId { get; set; }
        [QueryIgnore]
        public string BannerPhotoUrl { get; set; }
        public string CanHaveGuests { get; set; }
        public string CollaborationType { get; set; }
        public string Description { get; set; }
        public string FullPhotoUrl { get; set; }
        [QueryIgnore]
        public string GroupEmail { get; set; }
        public string HasPrivateFieldsAccess { get; set; }
        public string InformationBody { get; set; }
        public string InformationTitle { get; set; }
        [QueryIgnore]
        public string IsArchived { get; set; }
        [QueryIgnore]
        public string IsAutoArchiveDisabled { get; set; }
        [QueryIgnore]
        public string IsBroadcast { get; set; }
        public string LastFeedModifiedDate { get; set; }
        public string LastReferencedDate { get; set; }
        public string LastViewedDate { get; set; }
        public string MemberCount { get; set; }
        public string Name { get; set; }
        public string NetworkId { get; set; }
        public string OwnerId { get; set; }
        public string SmallPhotoUrl { get; set; }




    }
}
