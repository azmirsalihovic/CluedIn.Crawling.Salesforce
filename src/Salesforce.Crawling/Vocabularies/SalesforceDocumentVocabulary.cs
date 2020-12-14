// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceDocumentVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceDocumentVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce document vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceDocumentVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceDocumentVocabulary"/> class.
        /// </summary>
        public SalesforceDocumentVocabulary()
        {
            VocabularyName = "Salesforce Document";
            KeyPrefix      = "salesforce.document";
            KeySeparator   = ".";
            Grouping       = EntityType.Files.File;
            
            AddGroup("Salesforce Document Details", group =>
            {
                Body               = group.Add(new VocabularyKey("body", VocabularyKeyDataType.Html));
                BodyLength         = group.Add(new VocabularyKey("bodyLength", VocabularyKeyVisibility.Hidden));
                ContentType        = group.Add(new VocabularyKey("contentType"));
                DeveloperName      = group.Add(new VocabularyKey("developerName"));
                SystemModstamp     = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                IsBodySearchable   = group.Add(new VocabularyKey("isBodySearchable", VocabularyKeyVisibility.Hidden));
                IsDeleted          = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                IsInternalUseOnly  = group.Add(new VocabularyKey("isInternalUseOnly", VocabularyKeyDataType.Boolean));
                IsPublic           = group.Add(new VocabularyKey("isPublic", VocabularyKeyDataType.Boolean));
                Keywords           = group.Add(new VocabularyKey("keywords"));
                LastReferencedDate = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate     = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                NamespacePrefix    = group.Add(new VocabularyKey("namespacePrefix"));
                Type               = group.Add(new VocabularyKey("type"));
                EmbedUrl           = group.Add(new VocabularyKey("embedUrl", VocabularyKeyDataType.Uri));
                EditUrl            = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);

            AddMapping(EmbedUrl,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EmbedUrl);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey Body { get; protected set; }
        public VocabularyKey BodyLength { get; protected set; }
        public VocabularyKey ContentType { get; protected set; }
        public VocabularyKey DeveloperName { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey IsBodySearchable { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey IsInternalUseOnly { get; protected set; }
        public VocabularyKey IsPublic { get; protected set; }
        public VocabularyKey Keywords { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey NamespacePrefix { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey EmbedUrl { get; protected set; }
    }
}