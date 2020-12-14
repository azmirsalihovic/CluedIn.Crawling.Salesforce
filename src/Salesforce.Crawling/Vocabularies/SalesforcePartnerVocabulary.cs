// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforcePartnerVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforcePartnerVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce partner vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforcePartnerVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforcePartnerVocabulary"/> class.
        /// </summary>
        public SalesforcePartnerVocabulary()
        {
            VocabularyName = "Salesforce Partner";
            KeyPrefix      = "salesforce.partner";
            KeySeparator   = ".";
            Grouping       = EntityType.Partner;

            AddGroup("Salesforce Partner Details", group =>
            {
                Role           = group.Add(new VocabularyKey("role", VocabularyKeyDataType.Boolean));
                IsDeleted      = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                IsPrimary      = group.Add(new VocabularyKey("isPrimary", VocabularyKeyDataType.Boolean));
                SystemModstamp = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                EditUrl        = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey Role { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey IsPrimary { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
    }
}