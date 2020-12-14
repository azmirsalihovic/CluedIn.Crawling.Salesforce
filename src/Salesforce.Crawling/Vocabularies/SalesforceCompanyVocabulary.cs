// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceCompanyVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceCompanyVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce company vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceCompanyVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceCompanyVocabulary"/> class.
        /// </summary>
        public SalesforceCompanyVocabulary()
        {
            VocabularyName = "Salesforce Company";
            KeyPrefix      = "salesforce.company";
            KeySeparator   = ".";
            Grouping       = EntityType.Organization;

            AddGroup("Salesforce Company Details", group =>
            {
                SystemModstamp               = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                Fax                          = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.PhoneNumber));
                MailingAddress               = group.Add(new VocabularyKey("mailingAddress", VocabularyKeyDataType.GeographyLocation));
                MailingCity                  = group.Add(new VocabularyKey("mailingCity", VocabularyKeyDataType.GeographyCity));
                MailingCountry               = group.Add(new VocabularyKey("mailingCountry", VocabularyKeyDataType.GeographyCountry));
                MailingPostalCode            = group.Add(new VocabularyKey("mailingPostalCode", VocabularyKeyDataType.GeographyLocation));
                MailingState                 = group.Add(new VocabularyKey("mailingState", VocabularyKeyDataType.GeographyLocation));
                MailingStreet                = group.Add(new VocabularyKey("mailingStreet", VocabularyKeyDataType.GeographyLocation));
                Phone                        = group.Add(new VocabularyKey("phone", VocabularyKeyDataType.PhoneNumber));
                Address                      = group.Add(new VocabularyKey("address", VocabularyKeyDataType.GeographyLocation));
                City                         = group.Add(new VocabularyKey("city", VocabularyKeyDataType.GeographyCity));
                CompanyCurrencyIsoCode       = group.Add(new VocabularyKey("companyCurrencyIsoCode"));
                Country                      = group.Add(new VocabularyKey("country", VocabularyKeyDataType.GeographyCountry));
                CountryAccessCode            = group.Add(new VocabularyKey("countryAccessCode"));
                CurrencyCode                 = group.Add(new VocabularyKey("currencyCode"));
                DomesticUltimateBusinessName = group.Add(new VocabularyKey("domesticUltimateBusinessName"));
                DomesticUltimateDunsNumber   = group.Add(new VocabularyKey("domesticUltimateDunsNumber"));
                DunsNumber                   = group.Add(new VocabularyKey("dunsNumber"));
                EmployeeQuantityGrowthRate   = group.Add(new VocabularyKey("employeeQuantityGrowthRate"));
                EmployeesHere                = group.Add(new VocabularyKey("employeesHere"));
                EmployeesHereReliability     = group.Add(new VocabularyKey("employeesHereReliability"));
                EmployeesTotal               = group.Add(new VocabularyKey("employeesTotal"));
                EmployeesTotalReliability    = group.Add(new VocabularyKey("employeesTotalReliability"));
                FamilyMembers                = group.Add(new VocabularyKey("familyMembers"));
                FifthNaics                   = group.Add(new VocabularyKey("fifthNaics"));
                FifthNaicsDesc               = group.Add(new VocabularyKey("fifthNaicsDesc"));
                FifthSic                     = group.Add(new VocabularyKey("fifthSic"));
                FifthSic8                    = group.Add(new VocabularyKey("fifthSic8"));
                FifthSic8Desc                = group.Add(new VocabularyKey("fifthSic8Desc"));
                FifthSicDesc                 = group.Add(new VocabularyKey("fifthSicDesc"));
                FipsMsaCode                  = group.Add(new VocabularyKey("fipsMsaCode"));
                FipsMsaDesc                  = group.Add(new VocabularyKey("fipsMsaDesc"));
                FortuneRank                  = group.Add(new VocabularyKey("fortuneRank"));
                FourthNaics                  = group.Add(new VocabularyKey("fourthNaics"));
                FourthNaicsDesc              = group.Add(new VocabularyKey("fourthNaicsDesc"));
                FourthSic                    = group.Add(new VocabularyKey("fourthSic"));
                FourthSic8                   = group.Add(new VocabularyKey("fourthSic8"));
                FourthSic8Desc               = group.Add(new VocabularyKey("fourthSic8Desc"));
                FourthSicDesc                = group.Add(new VocabularyKey("fourthSicDesc"));
                GeoCodeAccuracy              = group.Add(new VocabularyKey("geoCodeAccuracy"));
                GlobalUltimateBusinessName   = group.Add(new VocabularyKey("globalUltimateBusinessName"));
                GlobalUltimateDunsNumber     = group.Add(new VocabularyKey("globalUltimateDunsNumber"));
                GlobalUltimateTotalEmployees = group.Add(new VocabularyKey("globalUltimateTotalEmployees", VocabularyKeyDataType.Number));
                ImportExportAgent            = group.Add(new VocabularyKey("importExportAgent"));
                IncludedInSnP500             = group.Add(new VocabularyKey("includedInSnP500", VocabularyKeyDataType.Boolean));
                Latitude                     = group.Add(new VocabularyKey("latitude", VocabularyKeyDataType.Number));
                LegalStatus                  = group.Add(new VocabularyKey("legalStatus"));
                LocationStatus               = group.Add(new VocabularyKey("locationStatus"));
                Longitude                    = group.Add(new VocabularyKey("longitude", VocabularyKeyDataType.Number));
                MarketingPreScreen           = group.Add(new VocabularyKey("marketingPreScreen"));
                MarketingSegmentationCluster = group.Add(new VocabularyKey("marketingSegmentationCluster"));
                MinorityOwned                = group.Add(new VocabularyKey("minorityOwned", VocabularyKeyDataType.Boolean));
                NationalId                   = group.Add(new VocabularyKey("nationalId", VocabularyKeyVisibility.Hidden));
                NationalIdType               = group.Add(new VocabularyKey("nationalIdType"));
                OutOfBusiness                = group.Add(new VocabularyKey("outOfBusiness", VocabularyKeyDataType.Boolean));
                OwnOrRent                    = group.Add(new VocabularyKey("ownOrRent"));
                ParentOrHqBusinessName       = group.Add(new VocabularyKey("parentOrHqBusinessName"));
                ParentOrHqDunsNumber         = group.Add(new VocabularyKey("parentOrHqDunsNumber", VocabularyKeyDataType.Number));
                PostalCode                   = group.Add(new VocabularyKey("postalCode", VocabularyKeyDataType.GeographyLocation));
                PremisesMeasure              = group.Add(new VocabularyKey("premisesMeasure"));
                PremisesMeasureReliability   = group.Add(new VocabularyKey("premisesMeasureReliability"));
                PremisesMeasureUnit          = group.Add(new VocabularyKey("premisesMeasureUnit"));
                PrimaryNaics                 = group.Add(new VocabularyKey("primaryNaics"));
                PrimaryNaicsDesc             = group.Add(new VocabularyKey("primaryNaicsDesc"));
                PrimarySic                   = group.Add(new VocabularyKey("primarySic"));
                PrimarySic8                  = group.Add(new VocabularyKey("primarySic8"));
                PrimarySic8Desc              = group.Add(new VocabularyKey("primarySic8Desc"));
                PrimarySicDesc               = group.Add(new VocabularyKey("primarySicDesc"));
                PriorYearEmployees           = group.Add(new VocabularyKey("priorYearEmployees"));
                PriorYearRevenue             = group.Add(new VocabularyKey("priorYearRevenue", VocabularyKeyDataType.Money));
                PublicIndicator              = group.Add(new VocabularyKey("publicIndicator"));
                SalesTurnoverGrowthRate      = group.Add(new VocabularyKey("salesTurnoverGrowthRate"));
                SalesVolume                  = group.Add(new VocabularyKey("salesVolume"));
                SalesVolumeReliability       = group.Add(new VocabularyKey("salesVolumeReliability"));
                SecondNaics                  = group.Add(new VocabularyKey("secondNaics"));
                SecondNaicsDesc              = group.Add(new VocabularyKey("secondNaicsDesc"));
                SecondSic                    = group.Add(new VocabularyKey("secondSic"));
                SecondSic8                   = group.Add(new VocabularyKey("secondSic8"));
                SecondSic8Desc               = group.Add(new VocabularyKey("secondSic8Desc"));
                SecondSicDesc                = group.Add(new VocabularyKey("secondSicDesc"));
                SixthNaics                   = group.Add(new VocabularyKey("sixthNaics"));
                SixthNaicsDesc               = group.Add(new VocabularyKey("sixthNaicsDesc"));
                SixthSic                     = group.Add(new VocabularyKey("sixthSic"));
                SixthSic8                    = group.Add(new VocabularyKey("sixthSic8"));
                SixthSic8Desc                = group.Add(new VocabularyKey("sixthSic8Desc"));
                SixthSicDesc                 = group.Add(new VocabularyKey("sixthSicDesc"));
                SmallBusiness                = group.Add(new VocabularyKey("smallBusiness", VocabularyKeyDataType.Boolean));
                State                        = group.Add(new VocabularyKey("state"));
                StockExchange                = group.Add(new VocabularyKey("stockExchange"));
                StockSymbol                  = group.Add(new VocabularyKey("stockSymbol"));
                Street                       = group.Add(new VocabularyKey("street", VocabularyKeyDataType.GeographyLocation));
                Subsidiary                   = group.Add(new VocabularyKey("subsidiary"));
                ThirdNaics                   = group.Add(new VocabularyKey("thirdNaics"));
                ThirdNaicsDesc               = group.Add(new VocabularyKey("thirdNaicsDesc"));
                ThirdSic                     = group.Add(new VocabularyKey("thirdSic"));
                ThirdSic8                    = group.Add(new VocabularyKey("thirdSic8"));
                ThirdSic8Desc                = group.Add(new VocabularyKey("thirdSic8Desc"));
                ThirdSicDesc                 = group.Add(new VocabularyKey("thirdSicDesc"));
                TradeStyle1                  = group.Add(new VocabularyKey("tradeStyle1"));
                TradeStyle2                  = group.Add(new VocabularyKey("tradeStyle2"));
                TradeStyle3                  = group.Add(new VocabularyKey("tradeStyle3"));
                TradeStyle4                  = group.Add(new VocabularyKey("tradeStyle4"));
                TradeStyle5                  = group.Add(new VocabularyKey("tradeStyle5"));
                URL                          = group.Add(new VocabularyKey("url", VocabularyKeyDataType.Uri));
                UsTaxId                      = group.Add(new VocabularyKey("usTaxId"));
                WomenOwned                   = group.Add(new VocabularyKey("womenOwned"));
                YearStarted                  = group.Add(new VocabularyKey("yearStarted", VocabularyKeyDataType.Number));
                EditUrl                      = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(Phone,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(Fax,               CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Fax);
            AddMapping(StockSymbol,       CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.TickerSymbol);
            AddMapping(EmployeesTotal,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.EmployeeCount);
            AddMapping(URL,               CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Website);
            AddMapping(Address,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Address);
            AddMapping(City,              CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            AddMapping(Country,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCountryCode);
            AddMapping(PostalCode,        CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressZipCode);
            AddMapping(Street,            CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressStreetName);
            AddMapping(State,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressState);
            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey SystemModstamp                     { get; protected set; }
        public VocabularyKey Fax                                { get; protected set; }
        public VocabularyKey MailingAddress                     { get; protected set; }
        public VocabularyKey MailingCity                        { get; protected set; }
        public VocabularyKey MailingCountry                     { get; protected set; }
        public VocabularyKey MailingPostalCode                  { get; protected set; }
        public VocabularyKey MailingState                       { get; protected set; }
        public VocabularyKey MailingStreet                      { get; protected set; }
        public VocabularyKey Phone                              { get; protected set; }
        public VocabularyKey Address                            { get; protected set; }
        public VocabularyKey City                               { get; protected set; }
        public VocabularyKey CompanyCurrencyIsoCode             { get; protected set; }
        public VocabularyKey Country                            { get; protected set; }
        public VocabularyKey CountryAccessCode                  { get; protected set; }
        public VocabularyKey CurrencyCode                       { get; protected set; }
        public VocabularyKey DomesticUltimateBusinessName       { get; protected set; }
        public VocabularyKey DomesticUltimateDunsNumber         { get; protected set; }
        public VocabularyKey DunsNumber                         { get; protected set; }
        public VocabularyKey EmployeeQuantityGrowthRate         { get; protected set; }
        public VocabularyKey EmployeesHere                      { get; protected set; }
        public VocabularyKey EmployeesHereReliability           { get; protected set; }
        public VocabularyKey EmployeesTotal                     { get; protected set; }
        public VocabularyKey EmployeesTotalReliability          { get; protected set; }
        public VocabularyKey FamilyMembers                      { get; protected set; }
        public VocabularyKey FifthNaics                         { get; protected set; }
        public VocabularyKey FifthNaicsDesc                     { get; protected set; }
        public VocabularyKey FifthSic                           { get; protected set; }
        public VocabularyKey FifthSic8                          { get; protected set; }
        public VocabularyKey FifthSic8Desc                      { get; protected set; }
        public VocabularyKey FifthSicDesc                       { get; protected set; }
        public VocabularyKey FipsMsaCode                        { get; protected set; }
        public VocabularyKey FipsMsaDesc                        { get; protected set; }
        public VocabularyKey FortuneRank                        { get; protected set; }
        public VocabularyKey FourthNaics                        { get; protected set; }
        public VocabularyKey FourthNaicsDesc                    { get; protected set; }
        public VocabularyKey FourthSic                          { get; protected set; }
        public VocabularyKey FourthSic8                         { get; protected set; }
        public VocabularyKey FourthSic8Desc                     { get; protected set; }
        public VocabularyKey FourthSicDesc                      { get; protected set; }
        public VocabularyKey GeoCodeAccuracy                    { get; protected set; }
        public VocabularyKey GlobalUltimateBusinessName         { get; protected set; }
        public VocabularyKey GlobalUltimateDunsNumber           { get; protected set; }
        public VocabularyKey GlobalUltimateTotalEmployees       { get; protected set; }
        public VocabularyKey ImportExportAgent                  { get; protected set; }
        public VocabularyKey IncludedInSnP500                   { get; protected set; }
        public VocabularyKey Latitude                           { get; protected set; }
        public VocabularyKey LegalStatus                        { get; protected set; }
        public VocabularyKey LocationStatus                     { get; protected set; }
        public VocabularyKey Longitude                          { get; protected set; }
        public VocabularyKey MarketingPreScreen                 { get; protected set; }
        public VocabularyKey MarketingSegmentationCluster       { get; protected set; }
        public VocabularyKey MinorityOwned                      { get; protected set; }
        public VocabularyKey NationalId                         { get; protected set; }
        public VocabularyKey NationalIdType                     { get; protected set; }
        public VocabularyKey OutOfBusiness                      { get; protected set; }
        public VocabularyKey OwnOrRent                          { get; protected set; }
        public VocabularyKey ParentOrHqBusinessName             { get; protected set; }
        public VocabularyKey ParentOrHqDunsNumber               { get; protected set; }
        public VocabularyKey PostalCode                         { get; protected set; }
        public VocabularyKey PremisesMeasure                    { get; protected set; }
        public VocabularyKey PremisesMeasureReliability         { get; protected set; }
        public VocabularyKey PremisesMeasureUnit                { get; protected set; }
        public VocabularyKey PrimaryNaics                       { get; protected set; }
        public VocabularyKey PrimaryNaicsDesc                   { get; protected set; }
        public VocabularyKey PrimarySic                         { get; protected set; }
        public VocabularyKey PrimarySic8                        { get; protected set; }
        public VocabularyKey PrimarySic8Desc                    { get; protected set; }
        public VocabularyKey PrimarySicDesc                     { get; protected set; }
        public VocabularyKey PriorYearEmployees                 { get; protected set; }
        public VocabularyKey PriorYearRevenue                   { get; protected set; }
        public VocabularyKey PublicIndicator                    { get; protected set; }
        public VocabularyKey SalesTurnoverGrowthRate            { get; protected set; }
        public VocabularyKey SalesVolume                        { get; protected set; }
        public VocabularyKey SalesVolumeReliability             { get; protected set; }
        public VocabularyKey SecondNaics                        { get; protected set; }
        public VocabularyKey SecondNaicsDesc                    { get; protected set; }
        public VocabularyKey SecondSic                          { get; protected set; }
        public VocabularyKey SecondSic8                         { get; protected set; }
        public VocabularyKey SecondSic8Desc                     { get; protected set; }
        public VocabularyKey SecondSicDesc                      { get; protected set; }
        public VocabularyKey SixthNaics                         { get; protected set; }
        public VocabularyKey SixthNaicsDesc                     { get; protected set; }
        public VocabularyKey SixthSic                           { get; protected set; }
        public VocabularyKey SixthSic8                          { get; protected set; }
        public VocabularyKey SixthSic8Desc                      { get; protected set; }
        public VocabularyKey SixthSicDesc                       { get; protected set; }
        public VocabularyKey SmallBusiness                      { get; protected set; }
        public VocabularyKey State                              { get; protected set; }
        public VocabularyKey StockExchange                      { get; protected set; }
        public VocabularyKey StockSymbol                        { get; protected set; }
        public VocabularyKey Street                             { get; protected set; }
        public VocabularyKey Subsidiary                         { get; protected set; }
        public VocabularyKey ThirdNaics                         { get; protected set; }
        public VocabularyKey ThirdNaicsDesc                     { get; protected set; }
        public VocabularyKey ThirdSic                           { get; protected set; }
        public VocabularyKey ThirdSic8                          { get; protected set; }
        public VocabularyKey ThirdSic8Desc                      { get; protected set; }
        public VocabularyKey ThirdSicDesc                       { get; protected set; }
        public VocabularyKey TradeStyle1                        { get; protected set; }
        public VocabularyKey TradeStyle2                        { get; protected set; }
        public VocabularyKey TradeStyle3                        { get; protected set; }
        public VocabularyKey TradeStyle4                        { get; protected set; }
        public VocabularyKey TradeStyle5                        { get; protected set; }
        public VocabularyKey URL                                { get; protected set; }
        public VocabularyKey UsTaxId                            { get; protected set; }
        public VocabularyKey WomenOwned                         { get; protected set; }
        public VocabularyKey YearStarted                        { get; protected set; }
    }
}