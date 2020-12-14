// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceProductVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceProductVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce product vocabulary.</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceProductVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceProductVocabulary"/> class.
        /// </summary>
        public SalesforceProductVocabulary()
        {
            VocabularyName = "Salesforce Product";
            KeyPrefix      = "salesforce.product";
            KeySeparator   = ".";
            Grouping       = EntityType.Product;

            AddGroup("Salesforce Product Details", group =>
            {
                CanUseQuantitySchedule       = group.Add(new VocabularyKey("canUseQuantitySchedule", VocabularyKeyDataType.Boolean));
                CanUseRevenueSchedule        = group.Add(new VocabularyKey("canUseRevenueSchedule", VocabularyKeyDataType.Boolean));
                LastReferencedDate           = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                ConnectionSentId             = group.Add(new VocabularyKey("connectionSentId", VocabularyKeyVisibility.Hidden));
                ConnectionReceivedId         = group.Add(new VocabularyKey("connectionReceivedId", VocabularyKeyVisibility.Hidden));
                CurrencyIsoCode              = group.Add(new VocabularyKey("currencyIsoCode"));
                DefaultPrice                 = group.Add(new VocabularyKey("defaultPrice", VocabularyKeyDataType.Money));
                IsActive                     = group.Add(new VocabularyKey("isActive", VocabularyKeyDataType.Boolean));
                IsDeleted                    = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                LastViewedDate               = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                NumberOfQuantityInstallments = group.Add(new VocabularyKey("numberOfQuantityInstallments", VocabularyKeyDataType.Number));
                NumberOfRevenueInstallments  = group.Add(new VocabularyKey("numberOfRevenueInstallments", VocabularyKeyDataType.Number));
                ProductCode                  = group.Add(new VocabularyKey("productCode"));
                QuantityInstallmentPeriod    = group.Add(new VocabularyKey("quantityInstallmentPeriod"));
                QuantityScheduleType         = group.Add(new VocabularyKey("quantityScheduleType"));
                RecalculateTotalPrice        = group.Add(new VocabularyKey("recalculateTotalPrice", VocabularyKeyDataType.Money));
                RevenueInstallmentPeriod     = group.Add(new VocabularyKey("revenueInstallmentPeriod"));
                RevenueScheduleType          = group.Add(new VocabularyKey("revenueScheduleType"));
                SystemModstamp               = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                Family                       = group.Add(new VocabularyKey("family"));
                EditUrl                      = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(Family,            CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInProduct.Family);
            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey CanUseQuantitySchedule { get; protected set; }
        public VocabularyKey CanUseRevenueSchedule { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey ConnectionSentId { get; protected set; }
        public VocabularyKey ConnectionReceivedId { get; protected set; }
        public VocabularyKey CurrencyIsoCode { get; protected set; }
        public VocabularyKey DefaultPrice { get; protected set; }
        public VocabularyKey IsActive { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey NumberOfQuantityInstallments { get; protected set; }
        public VocabularyKey NumberOfRevenueInstallments { get; protected set; }
        public VocabularyKey ProductCode { get; protected set; }
        public VocabularyKey QuantityInstallmentPeriod { get; protected set; }
        public VocabularyKey QuantityScheduleType { get; protected set; }
        public VocabularyKey RecalculateTotalPrice { get; protected set; }
        public VocabularyKey RevenueInstallmentPeriod { get; protected set; }
        public VocabularyKey RevenueScheduleType { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey Family { get; protected set; }
    }
}