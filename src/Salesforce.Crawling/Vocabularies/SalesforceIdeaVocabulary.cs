// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceIdeaVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceIdeaVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce idea vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceIdeaVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceIdeaVocabulary"/> class.
        /// </summary>
        public SalesforceIdeaVocabulary()
        {
            VocabularyName = "Salesforce Idea";
            KeyPrefix      = "salesforce.idea";
            KeySeparator   = ".";
            Grouping       = EntityType.Idea;

            AddGroup("Salesforce Idea Details", group =>
            {
                AttachmentBody        = group.Add(new VocabularyKey("attachmentBody", VocabularyKeyDataType.Html));
                AttachmentContentType = group.Add(new VocabularyKey("attachmentContentType", VocabularyKeyVisibility.Hidden));
                AttachmentLength      = group.Add(new VocabularyKey("attachmentLength", VocabularyKeyVisibility.Hidden));
                AttachmentName        = group.Add(new VocabularyKey("attachmentName"));
                Categories            = group.Add(new VocabularyKey("categories"));
                Category              = group.Add(new VocabularyKey("category"));
                CreatorFullPhotoUrl   = group.Add(new VocabularyKey("creatorFullPhotoUrl", VocabularyKeyVisibility.Hidden));
                CreatorName           = group.Add(new VocabularyKey("creatorName"));
                CreatorSmallPhotoUrl  = group.Add(new VocabularyKey("creatorSmallPhotoUrl", VocabularyKeyVisibility.Hidden));
                CurrencyIsoCode       = group.Add(new VocabularyKey("currencyIsoCode"));
                IdeaThemeID           = group.Add(new VocabularyKey("ideaThemeID", VocabularyKeyVisibility.Hidden));
                IsDeleted             = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                IsHtml                = group.Add(new VocabularyKey("isHtml", VocabularyKeyVisibility.Hidden));
                IsMerged              = group.Add(new VocabularyKey("isMerged", VocabularyKeyVisibility.Hidden));
                LastCommentDate       = group.Add(new VocabularyKey("lastCommentDate", VocabularyKeyDataType.DateTime));
                LastReferencedDate    = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate        = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                NumComments           = group.Add(new VocabularyKey("numComments", VocabularyKeyDataType.Number));
                ParentIdeaId          = group.Add(new VocabularyKey("parentIdeaId", VocabularyKeyVisibility.Hidden));
                RecordTypeId          = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                Status                = group.Add(new VocabularyKey("status"));
                VoteScore             = group.Add(new VocabularyKey("voteScore", VocabularyKeyDataType.Number));
                VoteTotal             = group.Add(new VocabularyKey("voteTotal", VocabularyKeyDataType.Number));
                SystemModstamp        = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                EditUrl               = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey AttachmentBody { get; protected set; }
        public VocabularyKey AttachmentContentType { get; protected set; }
        public VocabularyKey AttachmentLength { get; protected set; }
        public VocabularyKey AttachmentName { get; protected set; }
        public VocabularyKey Categories { get; protected set; }
        public VocabularyKey Category { get; protected set; }
        public VocabularyKey CreatorFullPhotoUrl { get; protected set; }
        public VocabularyKey CreatorName { get; protected set; }
        public VocabularyKey CreatorSmallPhotoUrl { get; protected set; }
        public VocabularyKey CurrencyIsoCode { get; protected set; }
        public VocabularyKey IdeaThemeID { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey IsHtml { get; protected set; }
        public VocabularyKey IsMerged { get; protected set; }
        public VocabularyKey LastCommentDate { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey NumComments { get; protected set; }
        public VocabularyKey ParentIdeaId { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey VoteScore { get; protected set; }
        public VocabularyKey VoteTotal { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        
    }
}