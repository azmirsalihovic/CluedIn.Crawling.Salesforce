using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Note")]
    public class Note : SystemObject
    {
        public const string SObjectTypeName = "Note";
        public string Body { get; set; }
        public string IsDeleted { get; set; }
        public string IsPrivate { get; set; }
        public string OwnerId { get; set; }
        public string ParentId { get; set; }
        public string Title { get; set; }
    }
}
