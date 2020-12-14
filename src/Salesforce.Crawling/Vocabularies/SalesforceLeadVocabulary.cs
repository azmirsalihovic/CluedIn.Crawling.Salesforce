// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceLeadVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceLeadVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce lead vocabulary.</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceLeadVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceLeadVocabulary"/> class.
        /// </summary>
        public SalesforceLeadVocabulary()
        {
            VocabularyName = "Salesforce Lead";
            KeyPrefix      = "salesforce.lead";
            KeySeparator   = ".";
            Grouping       = EntityType.Sales.Lead;

            AddGroup("Salesforce Lead Details", group =>
            {
                AnnualRevenue        = group.Add(new VocabularyKey("annualRevenue", VocabularyKeyDataType.Money));
                CleanStatus          = group.Add(new VocabularyKey("cleanStatus"));
                CompanyDunsNumber    = group.Add(new VocabularyKey("companyDunsNumber", VocabularyKeyDataType.Number));
                ConnectionReceivedId = group.Add(new VocabularyKey("connectionReceivedId", VocabularyKeyVisibility.Hidden));
                ConnectionSentId     = group.Add(new VocabularyKey("connectionSentId", VocabularyKeyVisibility.Hidden));
                ConvertedDate        = group.Add(new VocabularyKey("convertedDate", VocabularyKeyDataType.DateTime));
                Country              = group.Add(new VocabularyKey("country"));
                CurrencyIsoCode      = group.Add(new VocabularyKey("currencyIsoCode"));
                Division             = group.Add(new VocabularyKey("division"));
                EmailBouncedDate     = group.Add(new VocabularyKey("emailBouncedDate", VocabularyKeyDataType.DateTime));
                EmailBouncedReason   = group.Add(new VocabularyKey("emailBouncedReason"));
                GeocodeAccuracy      = group.Add(new VocabularyKey("geocodeAccuracy"));
                HasOptedOutOfEmail   = group.Add(new VocabularyKey("hasOptedOutOfEmail", VocabularyKeyDataType.Boolean));
                IsConverted          = group.Add(new VocabularyKey("isConverted", VocabularyKeyDataType.Boolean));
                IsDeleted            = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                IsUnreadByOwner      = group.Add(new VocabularyKey("isUnreadByOwner", VocabularyKeyDataType.Boolean));
                Jigsaw               = group.Add(new VocabularyKey("jigsaw"));
                LastReferencedDate   = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate       = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                Latitude             = group.Add(new VocabularyKey("latitude", VocabularyKeyDataType.GeographyCoordinates));
                LeadSource           = group.Add(new VocabularyKey("leadSource"));
                Longitude            = group.Add(new VocabularyKey("longitude", VocabularyKeyDataType.GeographyCoordinates));
                MasterRecordId       = group.Add(new VocabularyKey("masterRecordId", VocabularyKeyVisibility.Hidden));
                Rating               = group.Add(new VocabularyKey("rating"));
                RecordTypeId         = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                StateCode            = group.Add(new VocabularyKey("stateCode"));
                Status               = group.Add(new VocabularyKey("status"));
                Suffix               = group.Add(new VocabularyKey("suffix"));
                SystemModstamp       = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));

                Address              = group.Add(new VocabularyKey("address", VocabularyKeyDataType.GeographyLocation));
                City                 = group.Add(new VocabularyKey("city", VocabularyKeyDataType.GeographyCity));
                Company              = group.Add(new VocabularyKey("company"));
                CountryCode          = group.Add(new VocabularyKey("countryCode", VocabularyKeyDataType.GeographyLocation));
                Email                = group.Add(new VocabularyKey("email", VocabularyKeyDataType.Email));
                Fax                  = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.PhoneNumber));
                FirstName            = group.Add(new VocabularyKey("firstName"));
                Industry             = group.Add(new VocabularyKey("industry"));
                LastName             = group.Add(new VocabularyKey("lastName"));
                MiddleName           = group.Add(new VocabularyKey("middleName"));
                MobileNumber         = group.Add(new VocabularyKey("mobileNumber", VocabularyKeyDataType.PhoneNumber));
                NumberOfEmployees    = group.Add(new VocabularyKey("numberOfEmployees", VocabularyKeyDataType.Number));
                Phone                = group.Add(new VocabularyKey("phone", VocabularyKeyDataType.PhoneNumber));
                PostalCode           = group.Add(new VocabularyKey("postalCode", VocabularyKeyDataType.GeographyLocation));
                Salutation           = group.Add(new VocabularyKey("salutation"));
                State                = group.Add(new VocabularyKey("state", VocabularyKeyDataType.GeographyLocation));
                Street               = group.Add(new VocabularyKey("street", VocabularyKeyDataType.GeographyLocation));
                Title                = group.Add(new VocabularyKey("title"));
                Website              = group.Add(new VocabularyKey("website", VocabularyKeyDataType.Uri));
                EditUrl              = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(Email,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName,         CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(MiddleName,        CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MiddleName);
            AddMapping(Salutation,        CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Title);
            AddMapping(Title,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.JobTitle);
            AddMapping(MobileNumber,      CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MobileNumber);
            AddMapping(Phone,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);

            AddMapping(Industry,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Industry);
            AddMapping(NumberOfEmployees, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.EmployeeCount);
            AddMapping(Website,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Website);
            AddMapping(AnnualRevenue,     CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AnnualRevenue);
            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey AnnualRevenue { get; protected set; }
        public VocabularyKey CleanStatus { get; protected set; }
        public VocabularyKey CompanyDunsNumber { get; protected set; }
        public VocabularyKey ConnectionReceivedId { get; protected set; }
        public VocabularyKey ConnectionSentId { get; protected set; }
        public VocabularyKey ConvertedDate { get; protected set; }
        public VocabularyKey Country { get; protected set; }
        public VocabularyKey CurrencyIsoCode { get; protected set; }
        public VocabularyKey Division { get; protected set; }
        public VocabularyKey EmailBouncedDate { get; protected set; }
        public VocabularyKey EmailBouncedReason { get; protected set; }
        public VocabularyKey GeocodeAccuracy { get; protected set; }
        public VocabularyKey HasOptedOutOfEmail { get; protected set; }
        public VocabularyKey IsConverted { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey IsUnreadByOwner { get; protected set; }
        public VocabularyKey Jigsaw { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey Latitude { get; protected set; }
        public VocabularyKey LeadSource { get; protected set; }
        public VocabularyKey Longitude { get; protected set; }
        public VocabularyKey MasterRecordId { get; protected set; }
        public VocabularyKey Rating { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey StateCode { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey Suffix { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey Address              { get; protected set; }
        public VocabularyKey City                 { get; protected set; }
        public VocabularyKey Company              { get; protected set; }
        public VocabularyKey CountryCode          { get; protected set; }
        public VocabularyKey Email                { get; protected set; }
        public VocabularyKey Fax                  { get; protected set; }
        public VocabularyKey FirstName            { get; protected set; }
        public VocabularyKey Industry             { get; protected set; }
        public VocabularyKey LastName             { get; protected set; }
        public VocabularyKey MiddleName           { get; protected set; }
        public VocabularyKey MobileNumber         { get; protected set; }
        public VocabularyKey NumberOfEmployees    { get; protected set; }
        public VocabularyKey Phone                { get; protected set; }
        public VocabularyKey PostalCode           { get; protected set; }
        public VocabularyKey Salutation           { get; protected set; }
        public VocabularyKey State                { get; protected set; }
        public VocabularyKey Street               { get; protected set; }
        public VocabularyKey Title                { get; protected set; }
        public VocabularyKey Website              { get; protected set; }
    }
}
