using System.Collections.Generic;

namespace CluedIn.Crawling.Salesforce.Core.Models.Descriptions
{
    public class ChildRelationship
    {
        public ChildRelationship()
        {
        }

        public bool CascadeDelete { get; set; }
        public string ChildSObject { get; set; }
        public bool DeprecatedAndHidden { get; set; }
        public string Field { get; set; }
        public string JunctionIdListName { get; set; }
        public List<object> JunctionReferenceTo { get; set; }
        public string RelationshipName { get; set; }
        public bool RestrictedDelete { get; set; }
    }
}