using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Profile")]
    public class Profile : SystemObject
    {
        public const string SObjectTypeName = "Profile";
        public string Description { get; set; }
        [QueryIgnore]
        public string IsSsoEnabled { get; set; }
                [QueryIgnore]
        public string LastReferencedDate { get; set; }
                [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string Name { get; set; }
                        [QueryIgnore]
        public string PermissionsPermissionName { get; set; }
        public string UserLicenseId { get; set; }
        public string UserType { get; set; }
    }
}
