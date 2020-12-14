// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceProfileVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceProfileVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce profile vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceProfileVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceProfileVocabulary"/> class.
        /// </summary>
        public SalesforceProfileVocabulary()
        {
            VocabularyName = "Salesforce Profile";
            KeyPrefix      = "salesforce.profile";
            KeySeparator   = ".";
            Grouping       = EntityType.Person;

            AddGroup("Salesforce Profile Details", group =>
            {
                IsSsoEnabled              = group.Add(new VocabularyKey("isSsoEnabled", VocabularyKeyDataType.Boolean));
                LastReferencedDate        = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate            = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                PermissionsPermissionName = group.Add(new VocabularyKey("permissionsPermissionName"));
                UserType                  = group.Add(new VocabularyKey("userType"));
                SystemModstamp            = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                EditUrl                   = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey IsSsoEnabled { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey PermissionsPermissionName { get; protected set; }
        public VocabularyKey UserType { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
    }
}