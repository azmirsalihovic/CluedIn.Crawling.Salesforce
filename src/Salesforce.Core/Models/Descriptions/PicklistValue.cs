namespace CluedIn.Crawling.Salesforce.Core.Models.Descriptions
{
    public class PicklistValue
    {
        public PicklistValue()
        {
        }

        public bool     Active { get; set; }
        public bool     DefaultValue { get; set; }
        public string   Label { get; set; }
        //public object   ValidFor { get; set; }
        public string   Value { get; set; }
    }
}
