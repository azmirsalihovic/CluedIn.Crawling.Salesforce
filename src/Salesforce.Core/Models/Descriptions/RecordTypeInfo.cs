namespace CluedIn.Crawling.Salesforce.Core.Models.Descriptions
{
    public class RecordTypeInfo
    {
        public RecordTypeInfo()
        {
        }

        public bool                 Available { get; set; }
        public bool                 DefaultRecordTypeMapping { get; set; }
        public string               Name { get; set; }
        public string               RecordTypeId { get; set; }
        public RecordTypeInfoUrls   Urls { get; set; }
    }
}