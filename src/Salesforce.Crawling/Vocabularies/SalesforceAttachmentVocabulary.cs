// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceAttachmentVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceAttachmentVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce attachment vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceAttachmentVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceAttachmentVocabulary"/> class.
        /// </summary>
        public SalesforceAttachmentVocabulary()
        {
            VocabularyName = "Salesforce Attachment";
            KeyPrefix      = "salesforce.attachment";
            KeySeparator   = ".";
            Grouping       = EntityType.Files.File;

            AddGroup("Salesforce Attachment Details", group =>
            {
                SystemModstamp       = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                AccountNumber        = group.Add(new VocabularyKey("accountNumber"));
                Body                 = group.Add(new VocabularyKey("body", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Hidden));
                BodyLength           = group.Add(new VocabularyKey("bodyLength", VocabularyKeyVisibility.Hidden));
                ConnectionReceivedId = group.Add(new VocabularyKey("connectionReceivedId", VocabularyKeyVisibility.Hidden));
                ConnectionSentId     = group.Add(new VocabularyKey("connectionSentId", VocabularyKeyVisibility.Hidden));
                ContentType          = group.Add(new VocabularyKey("contentType", VocabularyKeyVisibility.Hidden));
                IsEncrypted          = group.Add(new VocabularyKey("isEncrypted", VocabularyKeyDataType.Boolean));
                IsPartnerShared      = group.Add(new VocabularyKey("isPartnerShared", VocabularyKeyDataType.Boolean));
                IsPrivate            = group.Add(new VocabularyKey("isPrivate", VocabularyKeyDataType.Boolean));
                EditUrl              = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey AccountNumber { get; protected set; }
        public VocabularyKey Body { get; protected set; }
        public VocabularyKey BodyLength { get; protected set; }
        public VocabularyKey ConnectionReceivedId { get; protected set; }
        public VocabularyKey ConnectionSentId { get; protected set; }
        public VocabularyKey ContentType { get; protected set; }
        public VocabularyKey IsEncrypted { get; protected set; }
        public VocabularyKey IsPartnerShared { get; protected set; }
        public VocabularyKey IsPrivate { get; protected set; }
        public VocabularyKey EditUrl { get; protected set; }
    }
}