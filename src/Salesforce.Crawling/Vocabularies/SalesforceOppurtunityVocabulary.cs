// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceOppurtunityVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceOppurtunityVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce oppurtunity vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceOppurtunityVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceOppurtunityVocabulary"/> class.
        /// </summary>
        public SalesforceOppurtunityVocabulary()
        {
            VocabularyName = "Salesforce Opportunity";
            KeyPrefix      = "salesforce.Opportunity";
            KeySeparator   = ".";
            Grouping       = EntityType.Sales.Opportunity;

            AddGroup("Salesforce Opportunity Details", group =>
            {
                Amount                         = group.Add(new VocabularyKey("amount", VocabularyKeyDataType.Money));
                CloseDate                      = group.Add(new VocabularyKey("closeDate", VocabularyKeyDataType.DateTime));
                ConnectionReceivedId           = group.Add(new VocabularyKey("connectionReceivedId", VocabularyKeyVisibility.Hidden));
                ConnectionSentId               = group.Add(new VocabularyKey("connectionSentId", VocabularyKeyVisibility.Hidden));
                CurrencyIsoCode                = group.Add(new VocabularyKey("currencyIsoCode"));
                ExpectedRevenue                = group.Add(new VocabularyKey("expectedRevenue", VocabularyKeyDataType.Money));
                Fiscal                         = group.Add(new VocabularyKey("fiscal"));
                FiscalQuarter                  = group.Add(new VocabularyKey("fiscalQuarter", VocabularyKeyDataType.Number));
                FiscalYear                     = group.Add(new VocabularyKey("fiscalYear", VocabularyKeyDataType.Number));
                ForecastCategory               = group.Add(new VocabularyKey("forecastCategory"));
                ForecastCategoryName           = group.Add(new VocabularyKey("forecastCategoryName"));
                HasOpenActivity                = group.Add(new VocabularyKey("hasOpenActivity", VocabularyKeyDataType.Boolean));
                HasOpportunityLineItem         = group.Add(new VocabularyKey("hasOpportunityLineItem", VocabularyKeyDataType.Boolean));
                HasOverdueTask                 = group.Add(new VocabularyKey("hasOverdueTask", VocabularyKeyDataType.Boolean));
                IsClosed                       = group.Add(new VocabularyKey("isClosed", VocabularyKeyDataType.Boolean));
                IsDeleted                      = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                IsExcludedFromTerritory2Filter = group.Add(new VocabularyKey("isExcludedFromTerritory2Filter", VocabularyKeyVisibility.Hidden));
                IsSplit                        = group.Add(new VocabularyKey("isSplit", VocabularyKeyDataType.Boolean));
                IsWon                          = group.Add(new VocabularyKey("isWon", VocabularyKeyDataType.Boolean));
                LastActivityDate               = group.Add(new VocabularyKey("lastActivityDate", VocabularyKeyDataType.DateTime));
                LastReferencedDate             = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate                 = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                LeadSource                     = group.Add(new VocabularyKey("leadSource"));
                NextStep                       = group.Add(new VocabularyKey("nextStep"));
                RecordTypeId                   = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                SpecialTerms                   = group.Add(new VocabularyKey("specialTerms"));
                StageName                      = group.Add(new VocabularyKey("stageName"));
                StartDate                      = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.DateTime));
                StatusCode                     = group.Add(new VocabularyKey("statusCode"));
                SyncedQuoteID                  = group.Add(new VocabularyKey("syncedQuoteID", VocabularyKeyVisibility.Hidden));
                TotalAmount                    = group.Add(new VocabularyKey("totalAmount", VocabularyKeyDataType.Money));
                TotalOpportunityQuantity       = group.Add(new VocabularyKey("totalOpportunityQuantity", VocabularyKeyDataType.Number));
                SystemModstamp                 = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                Type                           = group.Add(new VocabularyKey("type"));
                Probability                    = group.Add(new VocabularyKey("probability"));
                Status                         = group.Add(new VocabularyKey("status"));
                EditUrl                        = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey Amount { get; protected set; }
        public VocabularyKey CloseDate { get; protected set; }
        public VocabularyKey ConnectionReceivedId { get; protected set; }
        public VocabularyKey ConnectionSentId { get; protected set; }
        public VocabularyKey CurrencyIsoCode { get; protected set; }
        public VocabularyKey ExpectedRevenue { get; protected set; }
        public VocabularyKey Fiscal { get; protected set; }
        public VocabularyKey FiscalQuarter { get; protected set; }
        public VocabularyKey FiscalYear { get; protected set; }
        public VocabularyKey ForecastCategory { get; protected set; }
        public VocabularyKey ForecastCategoryName { get; protected set; }
        public VocabularyKey HasOpenActivity { get; protected set; }
        public VocabularyKey HasOpportunityLineItem { get; protected set; }
        public VocabularyKey HasOverdueTask { get; protected set; }
        public VocabularyKey IsClosed { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey IsExcludedFromTerritory2Filter { get; protected set; }
        public VocabularyKey IsSplit { get; protected set; }
        public VocabularyKey IsWon { get; protected set; }
        public VocabularyKey LastActivityDate { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey LeadSource { get; protected set; }
        public VocabularyKey NextStep { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey SpecialTerms { get; protected set; }
        public VocabularyKey StageName { get; protected set; }
        public VocabularyKey StartDate { get; protected set; }
        public VocabularyKey StatusCode { get; protected set; }
        public VocabularyKey SyncedQuoteID { get; protected set; }
        public VocabularyKey TotalAmount { get; protected set; }
        public VocabularyKey TotalOpportunityQuantity { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey Probability { get; protected set; }
        public VocabularyKey Status { get; protected set; }
    }
}