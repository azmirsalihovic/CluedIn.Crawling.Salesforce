using System.Collections.Generic;

namespace CluedIn.Crawling.Salesforce.Core.Models.Descriptions
{
    public class ObjectDescription
    {
        public ObjectDescription()
        {
        }

        public List<object> ActionOverrides { get; set; }
        public bool Activateable { get; set; }
        public List<ChildRelationship> ChildRelationships { get; set; }
        public bool CompactLayoutable { get; set; }
        public bool Createable { get; set; }
        public bool Custom { get; set; }
        public bool CustomSetting { get; set; }
        public bool Deletable { get; set; }
        public bool DeprecatedAndHidden { get; set; }
        public bool FeedEnabled { get; set; }
        public List<Field> Fields { get; set; }
        public string keyPrefix { get; set; }
        public string label { get; set; }
        public string labelPlural { get; set; }
        public bool layoutable { get; set; }
        public object listviewable { get; set; }
        public object lookupLayoutable { get; set; }
        public bool mergeable { get; set; }
        public string name { get; set; }
        public List<object> namedLayoutInfos { get; set; }
        public bool queryable { get; set; }
        public List<RecordTypeInfo> recordTypeInfos { get; set; }
        public bool replicateable { get; set; }
        public bool retrieveable { get; set; }
        public bool searchLayoutable { get; set; }
        public bool searchable { get; set; }
        public bool triggerable { get; set; }
        public bool undeletable { get; set; }
        public bool updateable { get; set; }
        public ObjectDescriptionUrls urls { get; set; }

    }
}