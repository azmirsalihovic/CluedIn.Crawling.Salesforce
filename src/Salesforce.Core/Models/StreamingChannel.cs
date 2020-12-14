
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("StreamingChannel")]
    public class StreamingChannel : SystemObject
    {
        public const string SObjectTypeName = "StreamingChannel";
        public string IsDeleted { get; set; }
        public string IsDynamic { get; set; }
        public string Description { get; set; }
        public string LastReferencedDate { get; set; }
        public string LastViewedDate { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
    }
}



