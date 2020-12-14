// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceSolutionVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceSolutionVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce solution vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceSolutionVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceSolutionVocabulary"/> class.
        /// </summary>
        public SalesforceSolutionVocabulary()
        {
            VocabularyName = "Salesforce Solution";
            KeyPrefix      = "salesforce.solution";
            KeySeparator   = ".";
            Grouping       = EntityType.Note;

            AddGroup("Salesforce Solution Details", group =>
            {
                SystemModstamp        = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                LastReferencedDate    = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate        = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                Status                = group.Add(new VocabularyKey("status"));
                CreatedByName         = group.Add(new VocabularyKey("createdByName"));
                ID                    = group.Add(new VocabularyKey("id"));
                IsDeleted             = group.Add(new VocabularyKey("isDeleted", VocabularyKeyDataType.Boolean));
                IsHtml                = group.Add(new VocabularyKey("isHtml", VocabularyKeyDataType.Boolean));
                IsOutOfDate           = group.Add(new VocabularyKey("isOutOfDate", VocabularyKeyDataType.Boolean));
                IsPublished           = group.Add(new VocabularyKey("isPublished", VocabularyKeyDataType.Boolean));
                IsPublishedInPublicKb = group.Add(new VocabularyKey("isPublishedInPublicKb", VocabularyKeyDataType.Boolean));
                IsReviewed            = group.Add(new VocabularyKey("isReviewed", VocabularyKeyDataType.Boolean));
                OwnedByName           = group.Add(new VocabularyKey("ownedByName"));
                ParentId              = group.Add(new VocabularyKey("parentId"));
                RecordTypeId          = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                SolutionLanguage      = group.Add(new VocabularyKey("solutionLanguage"));
                SolutionNumber        = group.Add(new VocabularyKey("solutionNumber"));
                TimesUsed             = group.Add(new VocabularyKey("timesUsed", VocabularyKeyDataType.Duration));
                EditUrl               = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey CreatedByName { get; protected set; }
        public VocabularyKey ID { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey IsHtml { get; protected set; }
        public VocabularyKey IsOutOfDate { get; protected set; }
        public VocabularyKey IsPublished { get; protected set; }
        public VocabularyKey IsPublishedInPublicKb { get; protected set; }
        public VocabularyKey IsReviewed { get; protected set; }
        public VocabularyKey OwnedByName { get; protected set; }
        public VocabularyKey ParentId { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey SolutionLanguage { get; protected set; }
        public VocabularyKey SolutionNumber { get; protected set; }
        public VocabularyKey TimesUsed { get; protected set; }
    }
}