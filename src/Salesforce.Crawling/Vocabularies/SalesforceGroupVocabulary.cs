// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceGroupVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceGroupVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce group vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceGroupVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceGroupVocabulary"/> class.
        /// </summary>
        public SalesforceGroupVocabulary()
        {
            VocabularyName = "Salesforce Group";
            KeyPrefix      = "salesforce.group";
            KeySeparator   = ".";
            Grouping       = EntityType.Infrastructure.Group;

            AddGroup("Salesforce Group Details", group =>
            {
                DefaultDivision        = group.Add(new VocabularyKey("defaultDivision"));
                DeveloperName          = group.Add(new VocabularyKey("developerName"));
                DoesIncludeBosses      = group.Add(new VocabularyKey("doesIncludeBosses", VocabularyKeyDataType.Boolean));
                DoesSendEmailToMembers = group.Add(new VocabularyKey("doesSendEmailToMembers", VocabularyKeyDataType.Boolean));
                RelatedId              = group.Add(new VocabularyKey("relatedId", VocabularyKeyVisibility.Hidden));
                Type                   = group.Add(new VocabularyKey("type"));
                SystemModstamp         = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                Email                  = group.Add(new VocabularyKey("email", VocabularyKeyDataType.Email));
            });

            EditUrl = Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            
            AddMapping(Email,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInGroup.Email);
            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey DefaultDivision { get; protected set; }
        public VocabularyKey DeveloperName { get; protected set; }
        public VocabularyKey DoesIncludeBosses { get; protected set; }
        public VocabularyKey DoesSendEmailToMembers { get; protected set; }
        public VocabularyKey RelatedId { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey Email { get; protected set; }
        
    }
}