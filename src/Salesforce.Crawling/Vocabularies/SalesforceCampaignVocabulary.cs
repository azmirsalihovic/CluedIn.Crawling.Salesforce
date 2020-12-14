// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceCampaignVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceCampaignVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce campaign vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceCampaignVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceCampaignVocabulary"/> class.
        /// </summary>
        public SalesforceCampaignVocabulary()
        {
            VocabularyName = "Salesforce Campaign";
            KeyPrefix      = "salesforce.campaign";
            KeySeparator   = ".";
            Grouping       = EntityType.Marketing.Campaign;

            AddGroup("Salesforce Campaign Details", group =>
            {
                SystemModstamp     = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                RecordTypeId       = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                LastReferencedDate = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate     = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                EditUrl            = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
                Type = group.Add(new VocabularyKey("type"));
                Status = group.Add(new VocabularyKey("status"));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey Status { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey EditUrl { get; protected set; }

        public VocabularyKey Type { get; protected set; }
    }
}