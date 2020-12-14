// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceContractVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceContractVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce contract vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceContractVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceContractVocabulary" /> class.
        /// </summary>
        public SalesforceContractVocabulary()
        {
            VocabularyName = "Salesforce Contract";
            KeyPrefix      = "salesforce.contract";
            KeySeparator   = ".";
            Grouping       = EntityType.Sales.Contract;

            AddGroup("Salesforce Contract Details", group =>
            {
                ActivatedDate         = group.Add(new VocabularyKey("activatedDate", VocabularyKeyDataType.DateTime));
                BillingAddress        = group.Add(new VocabularyKey("billingAddress", VocabularyKeyDataType.GeographyLocation));
                BillingCity           = group.Add(new VocabularyKey("billingCity", VocabularyKeyDataType.GeographyCity));
                BillingCountry        = group.Add(new VocabularyKey("billingCountry", VocabularyKeyDataType.GeographyCountry));
                BillingCountryCode    = group.Add(new VocabularyKey("billingCountryCode"));
                BillingLatitude       = group.Add(new VocabularyKey("billingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                BillingLongitude      = group.Add(new VocabularyKey("billingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                BillingPostalCode     = group.Add(new VocabularyKey("billingPostalCode"));
                BillingState          = group.Add(new VocabularyKey("billingState", VocabularyKeyDataType.GeographyLocation));
                BillingStateCode      = group.Add(new VocabularyKey("billingStateCode", VocabularyKeyDataType.Html));
                BillingStreet         = group.Add(new VocabularyKey("billingStreet", VocabularyKeyDataType.GeographyLocation));
                CompanySignedDate     = group.Add(new VocabularyKey("companySignedDate", VocabularyKeyDataType.DateTime));
                CustomerSignedDate    = group.Add(new VocabularyKey("customerSignedDate", VocabularyKeyDataType.DateTime));
                CustomerSignedTitle   = group.Add(new VocabularyKey("customerSignedTitle"));
                EndDate               = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.DateTime));
                IsDeleted             = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                LastApprovedDate      = group.Add(new VocabularyKey("lastApprovedDate", VocabularyKeyDataType.DateTime));
                LastReferencedDate    = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate        = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                RecordTypeId          = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                SystemModstamp        = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                OwnerExpirationNotice = group.Add(new VocabularyKey("ownerExpirationNotice"));
                Pricebook2Id          = group.Add(new VocabularyKey("pricebook2Id", VocabularyKeyVisibility.Hidden));
                ShippingAddress       = group.Add(new VocabularyKey("shippingAddress", VocabularyKeyDataType.GeographyLocation));
                ShippingCity          = group.Add(new VocabularyKey("shippingCity", VocabularyKeyDataType.GeographyCity));
                ShippingCountry       = group.Add(new VocabularyKey("shippingCountry", VocabularyKeyDataType.GeographyCountry));
                ShippingCountryCode   = group.Add(new VocabularyKey("shippingCountryCode"));
                ShippingLatitude      = group.Add(new VocabularyKey("shippingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                ShippingLongitude     = group.Add(new VocabularyKey("shippingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                ShippingPostalCode    = group.Add(new VocabularyKey("shippingPostalCode"));
                ShippingState         = group.Add(new VocabularyKey("shippingState", VocabularyKeyDataType.GeographyLocation));
                ShippingStateCode     = group.Add(new VocabularyKey("shippingStateCode"));
                ShippingStreet        = group.Add(new VocabularyKey("shippingStreet", VocabularyKeyDataType.GeographyLocation));
                SpecialTerms          = group.Add(new VocabularyKey("specialTerms"));
                StartDate             = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.DateTime));
                Status                = group.Add(new VocabularyKey("status"));
                StatusCode            = group.Add(new VocabularyKey("statusCode"));
                Type                  = group.Add(new VocabularyKey("type"));
                TotalAmount           = group.Add(new VocabularyKey("totalAmount", VocabularyKeyDataType.Number));
                ContractNumber        = group.Add(new VocabularyKey("contractNumber", VocabularyKeyDataType.Number));
                ContractTerm          = group.Add(new VocabularyKey("contractTerm"));
                EditUrl               = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey ActivatedDate { get; protected set; }
        public VocabularyKey BillingAddress { get; protected set; }
        public VocabularyKey BillingCity { get; protected set; }
        public VocabularyKey BillingCountry { get; protected set; }
        public VocabularyKey BillingCountryCode { get; protected set; }
        public VocabularyKey BillingLatitude { get; protected set; }
        public VocabularyKey BillingLongitude { get; protected set; }
        public VocabularyKey BillingPostalCode { get; protected set; }
        public VocabularyKey BillingState { get; protected set; }
        public VocabularyKey BillingStateCode { get; protected set; }
        public VocabularyKey BillingStreet { get; protected set; }
        public VocabularyKey CompanySignedDate { get; protected set; }
        public VocabularyKey ContractNumber { get; protected set; }
        public VocabularyKey ContractTerm { get; protected set; }
        public VocabularyKey CustomerSignedDate { get; protected set; }
        public VocabularyKey CustomerSignedTitle { get; protected set; }
        public VocabularyKey EndDate { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey LastApprovedDate { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey OwnerExpirationNotice { get; protected set; }
        public VocabularyKey Pricebook2Id { get; protected set; }
        public VocabularyKey ShippingAddress { get; protected set; }
        public VocabularyKey ShippingCity { get; protected set; }
        public VocabularyKey ShippingCountry { get; protected set; }
        public VocabularyKey ShippingCountryCode { get; protected set; }
        public VocabularyKey ShippingLatitude { get; protected set; }
        public VocabularyKey ShippingLongitude { get; protected set; }
        public VocabularyKey ShippingPostalCode { get; protected set; }
        public VocabularyKey ShippingState { get; protected set; }
        public VocabularyKey ShippingStateCode { get; protected set; }
        public VocabularyKey ShippingStreet { get; protected set; }
        public VocabularyKey SpecialTerms { get; protected set; }
        public VocabularyKey StartDate { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey StatusCode { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey TotalAmount { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
      
    }
}
