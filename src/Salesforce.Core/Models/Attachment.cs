using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Attachment")]
    public class Attachment : SystemObject
    {
        public const string SObjectTypeName = "Attachment";
        public string Body { get; set; }
        public string BodyLength { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
        [QueryIgnore]
        public string ConnectionSentId { get; set; }
        public string ContentType { get; set; }
        public string Description { get; set; }
                [QueryIgnore]
        public string IsEncrypted { get; set; }
                        [QueryIgnore]
        public string IsPartnerShared { get; set; }
        public string IsPrivate { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public string ParentId { get; set; }
    }
}
