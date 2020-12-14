using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Group")]
    public class Group : SystemObject
    {
        public const string SObjectTypeName = "Group";
        [QueryIgnore]
        public string DefaultDivision { get; set; }
        public string DeveloperName { get; set; }
        public string DoesIncludeBosses { get; set; }
        public string DoesSendEmailToMembers { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public string RelatedId { get; set; }
        public string Type { get; set; }
    }
}
