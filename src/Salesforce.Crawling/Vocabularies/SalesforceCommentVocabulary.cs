// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceCommentVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceCommentVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce comment vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceCommentVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceCommentVocabulary"/> class.
        /// </summary>
        public SalesforceCommentVocabulary()
        {
            VocabularyName = "Salesforce Comment";
            KeyPrefix      = "salesforce.comment";
            KeySeparator   = ".";
            Grouping       = EntityType.Comment;

            AddGroup("Salesforce Case Details", group =>
            {
                Type                = group.Add(new VocabularyKey("type"));
                IsDeleteRestricted  = group.Add(new VocabularyKey("isDeleteRestricted", VocabularyKeyVisibility.Hidden));
                RelativeCreatedDate = group.Add(new VocabularyKey("relativeCreatedDate", VocabularyKeyDataType.DateTime));
                EditUrl             = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
        }

        public VocabularyKey Type { get; protected set; }
        public VocabularyKey IsDeleteRestricted { get; protected set; }
        public VocabularyKey RelativeCreatedDate { get; protected set; }
        public VocabularyKey EditUrl { get; protected set; }
      
    }
}