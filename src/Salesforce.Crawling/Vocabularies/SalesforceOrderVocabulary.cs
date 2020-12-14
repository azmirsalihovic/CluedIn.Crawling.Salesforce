// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceOrderVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceOrderVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce order vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceOrderVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceOrderVocabulary"/> class.
        /// </summary>
        public SalesforceOrderVocabulary()
        {
            VocabularyName = "Salesforce Order";
            KeyPrefix      = "salesforce.order";
            KeySeparator   = ".";
            Grouping       = EntityType.Sales.Order;

            AddGroup("Salesforce Order Details", group =>
            {
                ActivatedDate          = group.Add(new VocabularyKey("activatedDate", VocabularyKeyDataType.DateTime));
                BillingCity            = group.Add(new VocabularyKey("billingCity", VocabularyKeyDataType.GeographyCity));
                BillingCountry         = group.Add(new VocabularyKey("billingCountry", VocabularyKeyDataType.GeographyCountry));
                BillingCountryCode     = group.Add(new VocabularyKey("billingCountryCode", VocabularyKeyDataType.GeographyLocation));
                BillingLatitude        = group.Add(new VocabularyKey("billingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                BillingLongitude       = group.Add(new VocabularyKey("billingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                BillingPostalCode      = group.Add(new VocabularyKey("billingPostalCode"));
                BillingState           = group.Add(new VocabularyKey("billingState", VocabularyKeyDataType.GeographyLocation));
                BillingStateCode       = group.Add(new VocabularyKey("billingStateCode", VocabularyKeyDataType.GeographyLocation));
                BillingStreet          = group.Add(new VocabularyKey("billingStreet", VocabularyKeyDataType.GeographyLocation));
                CompanyAuthorizedDate  = group.Add(new VocabularyKey("companyAuthorizedDate", VocabularyKeyDataType.DateTime));
                CustomerAuthorizedDate = group.Add(new VocabularyKey("customerAuthorizedDate", VocabularyKeyDataType.DateTime));
                EffectiveDate          = group.Add(new VocabularyKey("effectiveDate", VocabularyKeyDataType.DateTime));
                EndDate                = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.DateTime));
                IsReductionOrder       = group.Add(new VocabularyKey("isReductionOrder", VocabularyKeyDataType.Boolean));
                LastReferencedDate     = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate         = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                OrderNumber            = group.Add(new VocabularyKey("orderNumber", VocabularyKeyDataType.Number));
                OrderReferenceNumber   = group.Add(new VocabularyKey("orderReferenceNumber", VocabularyKeyDataType.Number));
                PoDate                 = group.Add(new VocabularyKey("poDate", VocabularyKeyDataType.DateTime));
                PoNumber               = group.Add(new VocabularyKey("poNumber", VocabularyKeyDataType.Number));
                RecordTypeId           = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                ShippingCity           = group.Add(new VocabularyKey("shippingCity", VocabularyKeyDataType.GeographyCity));
                ShippingCountry        = group.Add(new VocabularyKey("shippingCountry", VocabularyKeyDataType.GeographyCountry));
                ShippingCountryCode    = group.Add(new VocabularyKey("shippingCountryCode"));
                ShippingLatitude       = group.Add(new VocabularyKey("shippingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                ShippingLongitude      = group.Add(new VocabularyKey("shippingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                ShippingPostalCode     = group.Add(new VocabularyKey("shippingPostalCode", VocabularyKeyDataType.GeographyLocation));
                ShippingState          = group.Add(new VocabularyKey("shippingState", VocabularyKeyDataType.GeographyLocation));
                ShippingStateCode      = group.Add(new VocabularyKey("shippingStateCode", VocabularyKeyDataType.GeographyLocation));
                ShippingStreet         = group.Add(new VocabularyKey("shippingStreet", VocabularyKeyDataType.GeographyLocation));
                Status                 = group.Add(new VocabularyKey("status"));
                StatusCode             = group.Add(new VocabularyKey("statusCode", VocabularyKeyVisibility.Hidden));
                TotalAmount            = group.Add(new VocabularyKey("totalAmount", VocabularyKeyDataType.Money));
                Type                   = group.Add(new VocabularyKey("type"));
                SystemModstamp         = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                EditUrl                = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey ActivatedDate { get; protected set; }
        public VocabularyKey BillingCity { get; protected set; }
        public VocabularyKey BillingCountry { get; protected set; }
        public VocabularyKey BillingCountryCode { get; protected set; }
        public VocabularyKey BillingLatitude { get; protected set; }
        public VocabularyKey BillingLongitude { get; protected set; }
        public VocabularyKey BillingPostalCode { get; protected set; }
        public VocabularyKey BillingState { get; protected set; }
        public VocabularyKey BillingStateCode { get; protected set; }
        public VocabularyKey BillingStreet { get; protected set; }
        public VocabularyKey CompanyAuthorizedDate { get; protected set; }
        public VocabularyKey CustomerAuthorizedDate { get; protected set; }
        public VocabularyKey EffectiveDate { get; protected set; }
        public VocabularyKey EndDate { get; protected set; }
        public VocabularyKey IsReductionOrder { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey OrderNumber { get; protected set; }
        public VocabularyKey OrderReferenceNumber { get; protected set; }
        public VocabularyKey PoDate { get; protected set; }
        public VocabularyKey PoNumber { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey ShippingCity { get; protected set; }
        public VocabularyKey ShippingCountry { get; protected set; }
        public VocabularyKey ShippingCountryCode { get; protected set; }
        public VocabularyKey ShippingLatitude { get; protected set; }
        public VocabularyKey ShippingLongitude { get; protected set; }
        public VocabularyKey ShippingPostalCode { get; protected set; }
        public VocabularyKey ShippingState { get; protected set; }
        public VocabularyKey ShippingStateCode { get; protected set; }
        public VocabularyKey ShippingStreet { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey StatusCode { get; protected set; }
        public VocabularyKey TotalAmount { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        
    }
}