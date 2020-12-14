using System.Collections.Generic;

namespace CluedIn.Crawling.Salesforce.Core.Models.Descriptions
{
    public class Field
    {
        public Field()
        {
        }

        public bool             AutoNumber { get; set; }
        public int              ByteLength { get; set; }
        public bool             Calculated { get; set; }
        public string           CalculatedFormula { get; set; }
        public bool             CascadeDelete { get; set; }
        public bool             CaseSensitive { get; set; }
        public string           ControllerName { get; set; }
        public bool             Createable { get; set; }
        public bool             Custom { get; set; }
        public object           DefaultValue { get; set; }
        public object           DefaultValueFormula { get; set; }
        public bool             DefaultedOnCreate { get; set; }
        public bool             DependentPicklist { get; set; }
        public bool             DeprecatedAndHidden { get; set; }
        public int              Digits { get; set; }
        public bool             DisplayLocationInDecimal { get; set; }
        public bool             Encrypted { get; set; }
        public bool             ExternalId { get; set; }
        public string           ExtraTypeInfo { get; set; }
        public bool             Filterable { get; set; }
        public object           FilteredLookupInfo { get; set; }
        public bool             Groupable { get; set; }
        public bool             HighScaleNumber { get; set; }
        public bool             HtmlFormatted { get; set; }
        public bool             IdLookup { get; set; }
        public string           InlineHelpText { get; set; }
        public string           Label { get; set; }
        public int              Length { get; set; }
        public string           Mask { get; set; }
        public string           MaskType { get; set; }
        public string           Name { get; set; }
        public bool             NameField { get; set; }
        public bool             NamePointing { get; set; }
        public bool             Nillable { get; set; }
        public bool             Permissionable { get; set; }
        public List<PicklistValue>  PicklistValues { get; set; }
        public int              Precision { get; set; }
        public bool             QueryByDistance { get; set; }
        public object           ReferenceTargetField { get; set; }
        public List<string>     ReferenceTo { get; set; }
        public string           RelationshipName { get; set; }
        public object           RelationshipOrder { get; set; }
        public bool             RestrictedDelete { get; set; }
        public bool             RestrictedPicklist { get; set; }
        public int              Scale { get; set; }
        public string           SoapType { get; set; }
        public bool             Sortable { get; set; }
        public string           Type { get; set; }
        public bool             Unique { get; set; }
        public bool             Updateable { get; set; }
        public bool             WriteRequiresMasterRead { get; set; }
    }
}