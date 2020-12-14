// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceQuoteVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceQuoteVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce quote vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceQuoteVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceQuoteVocabulary"/> class.
        /// </summary>
        public SalesforceQuoteVocabulary()
        {
            VocabularyName = "Salesforce Quote";
            KeyPrefix      = "salesforce.quote";
            KeySeparator   = ".";
            Grouping       = EntityType.Sales.Quote;

            AddGroup("Salesforce Quote Details", group =>
            {
                BillingName           = group.Add(new VocabularyKey("billingName"));
                BillingCity           = group.Add(new VocabularyKey("billingCity", VocabularyKeyDataType.GeographyCity));
                BillingStateCode      = group.Add(new VocabularyKey("billingStateCode"));
                BillingCountry        = group.Add(new VocabularyKey("billingCountry", VocabularyKeyDataType.GeographyCountry));
                BillingCountryCode    = group.Add(new VocabularyKey("billingCountryCode", VocabularyKeyDataType.GeographyCountry));
                BillingLatitude       = group.Add(new VocabularyKey("billingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                BillingLongitude      = group.Add(new VocabularyKey("billingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                BillingPostalCode     = group.Add(new VocabularyKey("billingPostalCode", VocabularyKeyDataType.GeographyLocation));
                BillingState          = group.Add(new VocabularyKey("billingState", VocabularyKeyDataType.GeographyLocation));
                BillingStreet         = group.Add(new VocabularyKey("billingStreet", VocabularyKeyDataType.GeographyLocation));
                AdditionalAddress     = group.Add(new VocabularyKey("additionalAddress", VocabularyKeyDataType.GeographyLocation));
                AdditionalCity        = group.Add(new VocabularyKey("additionalCity", VocabularyKeyDataType.GeographyCity));
                AdditionalCountry     = group.Add(new VocabularyKey("additionalCountry", VocabularyKeyDataType.GeographyCountry));
                AdditionalCountryCode = group.Add(new VocabularyKey("additionalCountryCode", VocabularyKeyDataType.GeographyLocation));
                AdditionalLatitude    = group.Add(new VocabularyKey("additionalLatitude", VocabularyKeyDataType.GeographyCoordinates));
                AdditionalLongitude   = group.Add(new VocabularyKey("additionalLongitude", VocabularyKeyDataType.GeographyCoordinates));
                AdditionalName        = group.Add(new VocabularyKey("additionalName"));
                AdditionalPostalCode  = group.Add(new VocabularyKey("additionalPostalCode"));
                AdditionalState       = group.Add(new VocabularyKey("additionalState", VocabularyKeyDataType.GeographyLocation));
                AdditionalStateCode   = group.Add(new VocabularyKey("additionalStateCode", VocabularyKeyDataType.GeographyLocation));
                AdditionalStreet      = group.Add(new VocabularyKey("additionalStreet", VocabularyKeyDataType.GeographyLocation));
                BillingAddress        = group.Add(new VocabularyKey("billingAddress", VocabularyKeyDataType.GeographyLocation));
                CurrencyIsoCode       = group.Add(new VocabularyKey("currencyIsoCode"));
                Discount              = group.Add(new VocabularyKey("discount"));
                ExpirationDate        = group.Add(new VocabularyKey("expirationDate", VocabularyKeyDataType.DateTime));
                Fax                   = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.PhoneNumber));
                GrandTotal            = group.Add(new VocabularyKey("grandTotal", VocabularyKeyDataType.Number));
                IsSyncing             = group.Add(new VocabularyKey("isSyncing", VocabularyKeyVisibility.Hidden));
                LastReferencedDate    = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate        = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                LineItemCount         = group.Add(new VocabularyKey("lineItemCount", VocabularyKeyDataType.Number));
                QuoteNumber           = group.Add(new VocabularyKey("quoteNumber", VocabularyKeyDataType.Number));
                QuoteToAddress        = group.Add(new VocabularyKey("quoteToAddress", VocabularyKeyDataType.GeographyLocation));
                QuoteToCity           = group.Add(new VocabularyKey("quoteToCity", VocabularyKeyDataType.GeographyCity));
                QuoteToCountry        = group.Add(new VocabularyKey("quoteToCountry", VocabularyKeyDataType.GeographyCountry));
                QuoteToLatitude       = group.Add(new VocabularyKey("quoteToLatitude", VocabularyKeyDataType.GeographyCoordinates));
                QuoteToLongitude      = group.Add(new VocabularyKey("quoteToLongitude", VocabularyKeyDataType.GeographyCoordinates));
                QuoteToName           = group.Add(new VocabularyKey("quoteToName"));
                QuoteToPostalCode     = group.Add(new VocabularyKey("quoteToPostalCode", VocabularyKeyDataType.GeographyLocation));
                QuoteToState          = group.Add(new VocabularyKey("quoteToState", VocabularyKeyDataType.GeographyLocation));
                QuoteToStreet         = group.Add(new VocabularyKey("quoteToStreet", VocabularyKeyDataType.GeographyLocation));
                RecordTypeID          = group.Add(new VocabularyKey("recordTypeID", VocabularyKeyVisibility.Hidden));
                ShippingAddress       = group.Add(new VocabularyKey("shippingAddress", VocabularyKeyDataType.GeographyLocation));
                ShippingStreet        = group.Add(new VocabularyKey("shippingStreet"));
                ShippingCity          = group.Add(new VocabularyKey("shippingCity", VocabularyKeyDataType.GeographyCity));
                ShippingCountry       = group.Add(new VocabularyKey("shippingCountry", VocabularyKeyDataType.GeographyCountry));
                ShippingCountryCode   = group.Add(new VocabularyKey("shippingCountryCode", VocabularyKeyDataType.GeographyLocation));
                ShippingHandling      = group.Add(new VocabularyKey("shippingHandling"));
                ShippingLatitude      = group.Add(new VocabularyKey("shippingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                ShippingLongitude     = group.Add(new VocabularyKey("shippingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                ShippingName          = group.Add(new VocabularyKey("shippingName"));
                ShippingPostalCode    = group.Add(new VocabularyKey("shippingPostalCode", VocabularyKeyDataType.GeographyLocation));
                ShippingState         = group.Add(new VocabularyKey("shippingState", VocabularyKeyDataType.GeographyLocation));
                ShippingStateCode     = group.Add(new VocabularyKey("shippingStateCode", VocabularyKeyDataType.GeographyLocation));
                Status                = group.Add(new VocabularyKey("status"));
                Subtotal              = group.Add(new VocabularyKey("subtotal", VocabularyKeyDataType.Number));
                Tax                   = group.Add(new VocabularyKey("tax", VocabularyKeyDataType.Number));
                TotalPrice            = group.Add(new VocabularyKey("totalPrice", VocabularyKeyDataType.Number));
                SystemModstamp        = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                Email                 = group.Add(new VocabularyKey("email", VocabularyKeyDataType.Email));
                Phone                 = group.Add(new VocabularyKey("phone", VocabularyKeyDataType.PhoneNumber));
                EditUrl               = group.Add(new VocabularyKey("editUrl"));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey BillingCity { get; protected set; }
        public VocabularyKey BillingCountry { get; protected set; }
        public VocabularyKey BillingLatitude { get; protected set; }
        public VocabularyKey BillingLongitude { get; protected set; }
        public VocabularyKey BillingPostalCode { get; protected set; }
        public VocabularyKey BillingState { get; protected set; }
        public VocabularyKey BillingStreet { get; protected set; }
        public VocabularyKey AdditionalAddress { get; protected set; }
        public VocabularyKey AdditionalCity { get; protected set; }
        public VocabularyKey AdditionalCountry { get; protected set; }
        public VocabularyKey AdditionalCountryCode { get; protected set; }
        public VocabularyKey AdditionalLatitude { get; protected set; }
        public VocabularyKey AdditionalLongitude { get; protected set; }
        public VocabularyKey AdditionalName { get; protected set; }
        public VocabularyKey AdditionalPostalCode { get; protected set; }
        public VocabularyKey AdditionalState { get; protected set; }
        public VocabularyKey AdditionalStateCode { get; protected set; }
        public VocabularyKey AdditionalStreet { get; protected set; }
        public VocabularyKey BillingAddress { get; protected set; }
        public VocabularyKey BillingCountryCode { get; protected set; }
        public VocabularyKey BillingName { get; protected set; }
        public VocabularyKey BillingStateCode { get; protected set; }
        public VocabularyKey CurrencyIsoCode { get; protected set; }
        public VocabularyKey Discount { get; protected set; }
        public VocabularyKey ExpirationDate { get; protected set; }
        public VocabularyKey Fax { get; protected set; }
        public VocabularyKey GrandTotal { get; protected set; }
        public VocabularyKey IsSyncing { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey LineItemCount { get; protected set; }
        public VocabularyKey QuoteNumber { get; protected set; }
        public VocabularyKey QuoteToAddress { get; protected set; }
        public VocabularyKey QuoteToCity { get; protected set; }
        public VocabularyKey QuoteToCountry { get; protected set; }
        public VocabularyKey QuoteToLatitude { get; protected set; }
        public VocabularyKey QuoteToLongitude { get; protected set; }
        public VocabularyKey QuoteToName { get; protected set; }
        public VocabularyKey QuoteToPostalCode { get; protected set; }
        public VocabularyKey QuoteToState { get; protected set; }
        public VocabularyKey QuoteToStreet { get; protected set; }
        public VocabularyKey RecordTypeID { get; protected set; }
        public VocabularyKey ShippingAddress { get; protected set; }
        public VocabularyKey ShippingCity { get; protected set; }
        public VocabularyKey ShippingCountry { get; protected set; }
        public VocabularyKey ShippingCountryCode { get; protected set; }
        public VocabularyKey ShippingHandling { get; protected set; }
        public VocabularyKey ShippingLatitude { get; protected set; }
        public VocabularyKey ShippingLongitude { get; protected set; }
        public VocabularyKey ShippingName { get; protected set; }
        public VocabularyKey ShippingPostalCode { get; protected set; }
        public VocabularyKey ShippingState { get; protected set; }
        public VocabularyKey ShippingStateCode { get; protected set; }
        public VocabularyKey ShippingStreet { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey Subtotal { get; protected set; }
        public VocabularyKey Tax { get; protected set; }
        public VocabularyKey TotalPrice { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey Email { get; protected set; }
        public VocabularyKey Phone { get; protected set; }
    }
}