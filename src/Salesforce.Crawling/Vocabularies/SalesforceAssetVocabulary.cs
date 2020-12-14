// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceAssetVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceAssetVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce asset vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceAssetVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceAssetVocabulary"/> class.
        /// </summary>
        public SalesforceAssetVocabulary()
        {
            VocabularyName = "Salesforce Asset";
            KeyPrefix      = "salesforce.asset";
            KeySeparator   = ".";
            Grouping       = EntityType.Note;

            AddGroup("Salesforce Asset Details", group =>
            {
                InstallDate         = group.Add(new VocabularyKey("installDate", VocabularyKeyVisibility.Hidden));
                IsCompetitorProduct = group.Add(new VocabularyKey("isCompetitorProduct", VocabularyKeyDataType.Boolean));
                Price               = group.Add(new VocabularyKey("price", VocabularyKeyDataType.Money));
                PurchaseDate        = group.Add(new VocabularyKey("purchaseDate", VocabularyKeyDataType.DateTime));
                Quantity            = group.Add(new VocabularyKey("quantity", VocabularyKeyDataType.Number));
                RecordTypeId        = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                SerialNumber        = group.Add(new VocabularyKey("serialNumber"));
                Status              = group.Add(new VocabularyKey("status"));
                UsageEndDate        = group.Add(new VocabularyKey("usageEndDate", VocabularyKeyDataType.DateTime));
                EditUrl             = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey InstallDate { get; protected set; }
        public VocabularyKey IsCompetitorProduct { get; protected set; }
        public VocabularyKey Price { get; protected set; }
        public VocabularyKey PurchaseDate { get; protected set; }
        public VocabularyKey Quantity { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey SerialNumber { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey UsageEndDate { get; protected set; }
    }
}
