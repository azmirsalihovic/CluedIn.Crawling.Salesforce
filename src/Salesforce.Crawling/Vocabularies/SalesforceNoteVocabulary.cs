// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceNoteVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceNoteVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce note vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceNoteVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceNoteVocabulary"/> class.
        /// </summary>
        public SalesforceNoteVocabulary()
        {
            VocabularyName = "Salesforce Note";
            KeyPrefix      = "salesforce.note";
            KeySeparator   = ".";
            Grouping       = EntityType.Note;

            AddGroup("Salesforce Note Details", group =>
            {
                IsDeleted      = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                IsPrivate      = group.Add(new VocabularyKey("isPrivate", VocabularyKeyDataType.Boolean));
                SystemModstamp = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                EditUrl        = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
                TalkingAbout = group.Add(new VocabularyKey("talkingAbout", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey TalkingAbout { get; protected set; }
        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey IsPrivate { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
    }
}