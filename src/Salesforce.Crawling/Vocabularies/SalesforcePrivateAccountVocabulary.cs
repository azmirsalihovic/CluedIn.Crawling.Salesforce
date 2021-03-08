// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceAccountVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   The salesforce account vocabulary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce account vocabulary.</summary>
    public class SalesforcePrivateAccountVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforcePrivateAccountVocabulary"/> class.
        /// </summary>
        public SalesforcePrivateAccountVocabulary()
        {
            VocabularyName = "Salesforce Account";
            KeyPrefix = "salesforce.privateaccount";
            KeySeparator = ".";
            //Grouping       = EntityType.Infrastructure.User;
            Grouping = EntityType.Infrastructure.User;


            AddGroup("Salesforce Account Details", group =>
            {
                Description = group.Add(new VocabularyKey("description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Account Description").WithDescription("A text description of the account "));
                ID = group.Add(new VocabularyKey("id", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Account ID").WithDescription("Account ID"));
                Name = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Account Name").WithDescription("\"Required. Label is Account Name. Name of the account. Maximum size is 255 characters. If the account has a record type of Person Account:This value is the concatenation of the FirstName, MiddleName, LastName, and Suffix of the associated person contact.You can't modify this value.\""));
                AccountNumber = group.Add(new VocabularyKey("accountnumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Account Number").WithDescription("\"Account number assigned to this account (not the unique, system-generated ID assigned during creation). Maximum size is 40 characters. This is used on dealerships to map to the main dealer number\""));
                Phone = group.Add(new VocabularyKey("phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone").WithDescription("Account Phone"));
                Rating = group.Add(new VocabularyKey("rating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Account Rating"));
                Site = group.Add(new VocabularyKey("site", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Account Site"));
                AccountSource = group.Add(new VocabularyKey("accountsource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Account Source").WithDescription("\"The source of the account record. For example, Advertisement, Data.com, or Trade Show. The source is selected from a picklist of available values, which are set by an administrator. Each picklist value can have up to 40 characters.\""));
                Type = group.Add(new VocabularyKey("type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Account Type").WithDescription("Classification of the Customer "));
                AgePc = group.Add(new VocabularyKey("agePc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Age").WithDescription("Segmentation for Marketing customers "));
                AnnualRevenue = group.Add(new VocabularyKey("annualrevenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Annual Revenue").WithDescription("\"Estimated annual revenue of the account.\""));
                PersonAssistantPhone = group.Add(new VocabularyKey("personassistantphone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Asst. Phone"));
                AudiIdC = group.Add(new VocabularyKey("audiIdC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Audi Id").WithDescription("The Dealerships Audi Dealership ID if they have it"));
                BillingAddress = group.Add(new VocabularyKey("billingaddress", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Address").WithDescription("The compound form of the billing address"));
                BillingCity = group.Add(new VocabularyKey("billingcity", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("Billing City").WithDescription("The billing City"));
                BillingCountry = group.Add(new VocabularyKey("billingcountry", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country").WithDescription("Billing Country"));
                BillingCountryCode = group.Add(new VocabularyKey("billingcountrycode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country Code").WithDescription("ISO Picklist"));
                BillingState = group.Add(new VocabularyKey("billingstate", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("Billing State/Province").WithDescription("Billing State/Province"));
                BillingStateCode = group.Add(new VocabularyKey("billingstatecode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Billing State/Province Code"));
                BillingStreet = group.Add(new VocabularyKey("billingstreet", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Street").WithDescription("Billing Street"));
                BillingPostalCode = group.Add(new VocabularyKey("billingpostalcode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Zip/Postal Code").WithDescription("Billing Zip/Postal Code"));
                PersonBirthDate = group.Add(new VocabularyKey("personbirthdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Birthdate").WithDescription("The birthday of a person - NOT CPR"));
                BouncedPc = group.Add(new VocabularyKey("bouncedPc", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Bounced").WithDescription("Has the e-mail bounced from Marketing Cloud which means it is not correct"));
                BrandPc = group.Add(new VocabularyKey("brandPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Brand").WithDescription("The brand of the account - legacy field on the way to be depricated"));
                Brand2Pc = group.Add(new VocabularyKey("brand2Pc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Brand").WithDescription("The brand of the account"));
                BuyingTimeframePc = group.Add(new VocabularyKey("buyingTimeframePc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Buying timeframe").WithDescription("Survey Segmentation response"));
                CompanySizePc = group.Add(new VocabularyKey("companySizePc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Company Size").WithDescription("Survey Segmentation response"));
                PersonContactId = group.Add(new VocabularyKey("personcontactid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Contact ID").WithDescription("The Contact ID of the related contact to the Person Account"));
                ContactRolePc = group.Add(new VocabularyKey("contactRolePc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Contact Role").WithDescription("Survey Segmentation response"));
                CreatedById = group.Add(new VocabularyKey("createdbyid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Created By ID").WithDescription("Audit field"));
                CreatedDate = group.Add(new VocabularyKey("createddate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Created Date").WithDescription("Audit field"));
                CurrentCarBrandPc = group.Add(new VocabularyKey("currentCarBrandPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Current Car Brand").WithDescription("Survey Segmentation response"));
                CustomerCityC = group.Add(new VocabularyKey("customercityC", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("Customer City").WithDescription("Survey Segmentation response"));
                CvrC = group.Add(new VocabularyKey("cvrC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CVR").WithDescription("The Danish CVR field for Dealerships and B2B customers"));
                DeadC = group.Add(new VocabularyKey("deadC", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Dead").WithDescription("Is the customer dead"));
                DealershipidC = group.Add(new VocabularyKey("dealershipidC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("DealershipID").WithDescription("The id of the dealership - in the format of 00000"));
                IsDeleted = group.Add(new VocabularyKey("isdeleted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Deleted").WithDescription("Is the record deleted as we are not hard deleting any records by default"));
                PersonDepartment = group.Add(new VocabularyKey("persondepartment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Department"));
                PersonDonotCall = group.Add(new VocabularyKey("persondonotcall", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Do Not Call"));
                PersonEmail = group.Add(new VocabularyKey("personemail", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("Email").WithDescription("Email"));
                PersonEmailBouncedDate = group.Add(new VocabularyKey("personemailbounceddate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Email Bounced Date").WithDescription("Email Bounced Date"));
                PersonEmailBouncedReason = group.Add(new VocabularyKey("personemailbouncedreason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Email Bounced Reason").WithDescription("Email Bounced Reason"));
                PersonHasOptedOutOfEmail = group.Add(new VocabularyKey("personhasoptedoutofemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Email Opt Out"));
                NumberOfEmployees = group.Add(new VocabularyKey("numberofemployees", VocabularyKeyDataType.Number, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Employees"));
                PersonHasOptedOutOfFax = group.Add(new VocabularyKey("personhasoptedoutoffax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fax Opt Out"));
                FirstName = group.Add(new VocabularyKey("firstname", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name").WithDescription("\"First name of the person for a person account. Maximum size is 40 characters.\""));
                HashedEmailPc = group.Add(new VocabularyKey("hashedemailPc", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Hashed Email").WithDescription("The hashed e-mail of the account as a link to Interaction studio"));
                PersonHomePhone = group.Add(new VocabularyKey("personhomephone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Home Phone").WithDescription("Home Phone"));
                IdEmailPc = group.Add(new VocabularyKey("idEmailPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("ID Email").WithDescription("Internat key to avoid dublicated for marketing contacts "));
                IdEmailC = group.Add(new VocabularyKey("idEmailC", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("ID Email").WithDescription("Internat key to avoid dublicated for marketing contacts "));
                IdentityKitIdPc = group.Add(new VocabularyKey("identitykitidPc", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Identity Kit Id").WithDescription("The link to the identitity Kit ID of the customer "));
                IdentityKitIdC = group.Add(new VocabularyKey("identitykitidC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Identity Kit Id (Account)").WithDescription("The link to the identitity Kit ID of the customer "));
                IdNgPc = group.Add(new VocabularyKey("idNgPc", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("ID NG").WithDescription("Link to AutoCore for Marketing Contacts (NOT KUK)"));
                IdNgC = group.Add(new VocabularyKey("idNgC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("ID NG").WithDescription("Link to AutoCore for Marketing Contacts (NOT KUK)"));
                IndustryPc = group.Add(new VocabularyKey("industryPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Industry").WithDescription("Survey Segmentation response"));
                Industry = group.Add(new VocabularyKey("industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Industry").WithDescription("Segmentation of Customers "));
                InteractionScorePc = group.Add(new VocabularyKey("interactionscorePc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Interaction Score").WithDescription("The score of the account in the context of a lead or an opportunity based on updates from Interaction Studio"));
                InteractionScoreCalculatedPc = group.Add(new VocabularyKey("interactionscorecalculatedPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Interaction Score Calculated").WithDescription("The recalculation of the score "));
                InteractionScoreLastUpdatedPc = group.Add(new VocabularyKey("interactionscorelastupdatedPc", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Interaction Score Last Updated").WithDescription("The time the score was updated"));
                IsActiveUserPc = group.Add(new VocabularyKey("isactiveuserPc", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Is Active User").WithDescription("Is the active or terminated "));
                IsKukCustomerC = group.Add(new VocabularyKey("iskukcustomerC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Is KUK Customer").WithDescription("Is the customer a Kuk Customer "));
                IsMarketingContactPc = group.Add(new VocabularyKey("ismarketingcontactPc", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Is Marketing Contact").WithDescription("is t he customer a marketing contact"));
                IsPartnerPc = group.Add(new VocabularyKey("isPartnerPc", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Is Partner").WithDescription("Is the account a partner account"));
                IsPersonAccount = group.Add(new VocabularyKey("ispersonaccount", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Is Person Account").WithDescription("Read only. Label is Is Person Account. Indicates whether this account has a record type of Person Account (true) or not (false)."));
                KukCodeC = group.Add(new VocabularyKey("kukcodeC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("KUK Code").WithDescription("what customer db in Kuk is the customer connected to "));
                KukCustomerIdC = group.Add(new VocabularyKey("kukcustomeridC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("KUK Customer ID").WithDescription("What is the KuK ID of the customer "));
                LastActivityDate = group.Add(new VocabularyKey("lastactivitydate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Activity").WithDescription("Audit field"));
                LastModifiedById = group.Add(new VocabularyKey("lastmodifiedbyid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Last Modified By ID").WithDescription("Audit field"));
                LastModifiedDate = group.Add(new VocabularyKey("lastmodifieddate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Last Modified Date").WithDescription("Audit field"));
                LastName = group.Add(new VocabularyKey("lastname", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name").WithDescription("Last name of the person for a person account. Required if the record type is a person account record type. Maximum size is 80 characters."));
                LastReferencedDate = group.Add(new VocabularyKey("lastreferenceddate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Last Referenced Date").WithDescription("Audit field"));
                LastViewedDate = group.Add(new VocabularyKey("lastvieweddate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Last Viewed Date").WithDescription("Audit field"));
                LeadReassignmentC = group.Add(new VocabularyKey("leadreassignmentC", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Lead Reassignment").WithDescription("does the dealership use lead reassignment rules"));
                PersonLeadSource = group.Add(new VocabularyKey("personleadsource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lead Source").WithDescription("Where did the customer get generated from "));
                PersonMailingAddress = group.Add(new VocabularyKey("personmailingaddress", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Address").WithDescription("compound address field "));
                PersonMailingCity = group.Add(new VocabularyKey("personmailingcity", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing City").WithDescription("Mailing City"));
                PersonMailingCountry = group.Add(new VocabularyKey("personmailingcountry", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Country").WithDescription("Mailing Country"));
                PersonMailingCountryCode = group.Add(new VocabularyKey("personmailingcountrycode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Country Code").WithDescription("Mailing Country Code"));
                PersonMailingState = group.Add(new VocabularyKey("personmailingstate", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailing State/Province"));
                PersonMailingStateCode = group.Add(new VocabularyKey("personmailingstatecode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailing State/Province Code"));
                PersonMailingStreet = group.Add(new VocabularyKey("personmailingstreet", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Street").WithDescription("Mailing Street"));
                PersonMailingPostalCode = group.Add(new VocabularyKey("personmailingpostalcode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Zip/Postal Code").WithDescription("Mailing Zip/Postal Code"));
                MarketingContactHemKeyC = group.Add(new VocabularyKey("marketingcontacthemkeyC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Marketing Contact HEM Key").WithDescription("Marketing Contact HEM Key"));
                MarketingContactKeyC = group.Add(new VocabularyKey("marketingcontactkeyC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Marketing Contact Key").WithDescription("A combination of e-mail address # Brand "));
                McApiErrorPc = group.Add(new VocabularyKey("mcApiErrorPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("MC API Error").WithDescription("Error Code if error in the sync to MC"));
                McApiStatusPc = group.Add(new VocabularyKey("mcApiStatusPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("MC API Status").WithDescription("Status of marketing contact sync to MC"));
                PersonMobilePhone = group.Add(new VocabularyKey("personmobilephone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile").WithDescription("Phone number "));
                NumberOfCarsPc = group.Add(new VocabularyKey("numberOfCarsPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Number of Cars").WithDescription("Survey Segmentation response"));
                OrderedLicensesC = group.Add(new VocabularyKey("orderedlicensesC", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Ordered Licenses").WithDescription("how many salesforce licenses did the dealership order "));
                PersonOtherAddress = group.Add(new VocabularyKey("personotheraddress", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Address").WithDescription("compound address field "));
                PersonOtherCity = group.Add(new VocabularyKey("personothercity", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other City"));
                PersonOtherCountry = group.Add(new VocabularyKey("personothercountry", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Country"));
                PersonOtherCountryCode = group.Add(new VocabularyKey("personothercountrycode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Country Code"));
                PersonOtherPhone = group.Add(new VocabularyKey("personotherphone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Phone"));
                PersonOtherState = group.Add(new VocabularyKey("personotherstate", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other State/Province"));
                PersonOtherStateCode = group.Add(new VocabularyKey("personotherstatecode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other State/Province Code"));
                PersonOtherStreet = group.Add(new VocabularyKey("personotherstreet", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Other Street"));
                PersonOtherPostalCode = group.Add(new VocabularyKey("personotherpostalcode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Zip/Postal Code"));
                OwnerId = group.Add(new VocabularyKey("ownerid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Owner ID").WithDescription("Audit field"));
                OwnerShip = group.Add(new VocabularyKey("ownership", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Ownership").WithDescription("Audit Field"));
                ParentId = group.Add(new VocabularyKey("parentid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Parent Account ID").WithDescription("Link to a parent account record for creating Account hierachies "));
                IsPartner = group.Add(new VocabularyKey("ispartner", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Partner Account").WithDescription("Is the account a Partner Account"));
                PartnerExtidC = group.Add(new VocabularyKey("partnerExtidC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Partner ExtId").WithDescription("Not Used "));
                PersonContactIdC = group.Add(new VocabularyKey("personcontactidC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Person Contact Id").WithDescription("Showing the related contact Id for a person account"));
                PhoneFormulaC = group.Add(new VocabularyKey("phoneformulaC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("PhoneFormula").WithDescription("PhoneFormula"));
                PhotoUrl = group.Add(new VocabularyKey("photourl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Photo URL").WithDescription("Photo URL"));
                PostBoxNameC = group.Add(new VocabularyKey("postboxnameC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postbox Name").WithDescription("Address field for b2b customers "));
                PreferedOwnershipPc = group.Add(new VocabularyKey("preferedOwnershipPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Prefered Ownership").WithDescription("Survey segmentations resonse"));
                RecordTypeId = group.Add(new VocabularyKey("recordtypeid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Record Type ID").WithDescription("This indicated what type of Account we are talking about "));
                ResidenseRegionPc = group.Add(new VocabularyKey("residenseRegionPc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Residense region").WithDescription("Survey segmentations resonse"));
                RobinsonC = group.Add(new VocabularyKey("robinsonC", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Robinson").WithDescription("Is the customer on a robinson list"));
                Salutation = group.Add(new VocabularyKey("salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Salutation"));
                SeatIdC = group.Add(new VocabularyKey("seatIdC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Seat Id").WithDescription("Seat Brand Dealer ID "));
                ShippingAddress = group.Add(new VocabularyKey("shippingaddress", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shipping Address"));
                ShippingCity = group.Add(new VocabularyKey("shippingcity", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shipping City"));
                ShippingCountry = group.Add(new VocabularyKey("shippingcountry", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shipping Country"));
                ShippingCountryCode = group.Add(new VocabularyKey("shippingcountrycode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shipping Country Code"));
                ShippingState = group.Add(new VocabularyKey("shippingstate", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shipping State/Province"));
                ShippingStateCode = group.Add(new VocabularyKey("shippingstatecode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shipping State/Province Code"));
                ShippingStreet = group.Add(new VocabularyKey("shippingstreet", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shipping Street"));
                ShippingPostalCode = group.Add(new VocabularyKey("shippingpostalcode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shipping Zip/Postal Code"));
                SkodaIdC = group.Add(new VocabularyKey("skodaIdC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Skoda Id").WithDescription("Skoda Brand Dealer ID"));
                StartedUsingSfC = group.Add(new VocabularyKey("startedUsingSfC", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Started using SF").WithDescription("Is the dealership using Salesforce "));
                SystemModstamp = group.Add(new VocabularyKey("systemmodstamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("System Modstamp").WithDescription("Audit Field"));
                TickerSymbol = group.Add(new VocabularyKey("tickersymbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ticker Symbol").WithDescription("Stock Tickerr - not used"));
                PersonTitle = group.Add(new VocabularyKey("persontitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Title"));
                VwEIdCC = group.Add(new VocabularyKey("vwEIdCC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("VW_Erhverv_Id (TBD)").WithDescription("VWE Brand dealer "));
                VwIdC = group.Add(new VocabularyKey("vwIdC", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("VW Id").WithDescription("VW Brand Dealer id "));
                Website = group.Add(new VocabularyKey("website", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Website").WithDescription("Website"));

            });

            //Semler vocabs Private
            AddMapping(Phone, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.AccPhone);
            AddMapping(PersonMailingStreet, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.AdrLine1);
            AddMapping(PersonMailingCity, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.City);
            AddMapping(PersonMailingCountry, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.Country);
            AddMapping(AccountNumber, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.CustomerNumber);
            AddMapping(PersonEmail, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.Email);
            AddMapping(FirstName, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.FirstName);
            AddMapping(PersonHomePhone, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.HomePhoneNr);
            AddMapping(LastName, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.LastName);
            AddMapping(DealershipidC, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.MainDealerID);
            AddMapping(PersonMobilePhone, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.MobPhoneNr);
            AddMapping(PersonMailingPostalCode, Semler.Common.Vocabularies.SemlerVocabularies.PrivateCustomer.PostalCode);

            //Common mapping
            AddMapping(SystemModstamp, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey Description { get; protected set; }
        public VocabularyKey ID { get; protected set; }
        public VocabularyKey Name { get; protected set; }
        public VocabularyKey AccountNumber { get; protected set; }
        public VocabularyKey Phone { get; protected set; }
        public VocabularyKey Rating { get; protected set; }
        public VocabularyKey Site { get; protected set; }
        public VocabularyKey AccountSource { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey AgePc { get; protected set; }
        public VocabularyKey AnnualRevenue { get; protected set; }
        public VocabularyKey PersonAssistantPhone { get; protected set; }
        public VocabularyKey AudiIdC { get; protected set; }
        public VocabularyKey BillingAddress { get; protected set; }
        public VocabularyKey BillingCity { get; protected set; }
        public VocabularyKey BillingCountry { get; protected set; }
        public VocabularyKey BillingCountryCode { get; protected set; }
        public VocabularyKey BillingState { get; protected set; }
        public VocabularyKey BillingStateCode { get; protected set; }
        public VocabularyKey BillingStreet { get; protected set; }
        public VocabularyKey BillingPostalCode { get; protected set; }
        public VocabularyKey PersonBirthDate { get; protected set; }
        public VocabularyKey BouncedPc { get; protected set; }
        public VocabularyKey BrandPc { get; protected set; }
        public VocabularyKey Brand2Pc { get; protected set; }
        public VocabularyKey BuyingTimeframePc { get; protected set; }
        public VocabularyKey CompanySizePc { get; protected set; }
        public VocabularyKey PersonContactId { get; protected set; }
        public VocabularyKey ContactRolePc { get; protected set; }
        public VocabularyKey CreatedById { get; protected set; }
        public VocabularyKey CreatedDate { get; protected set; }
        public VocabularyKey CurrentCarBrandPc { get; protected set; }
        public VocabularyKey CustomerCityC { get; protected set; }
        public VocabularyKey CvrC { get; protected set; }
        public VocabularyKey DeadC { get; protected set; }
        public VocabularyKey DealershipidC { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey PersonDepartment { get; protected set; }
        public VocabularyKey PersonDonotCall { get; protected set; }
        public VocabularyKey PersonEmail { get; protected set; }
        public VocabularyKey PersonEmailBouncedDate { get; protected set; }
        public VocabularyKey PersonEmailBouncedReason { get; protected set; }
        public VocabularyKey PersonHasOptedOutOfEmail { get; protected set; }
        public VocabularyKey NumberOfEmployees { get; protected set; }
        public VocabularyKey PersonHasOptedOutOfFax { get; protected set; }
        public VocabularyKey FirstName { get; protected set; }
        public VocabularyKey HashedEmailPc { get; protected set; }
        public VocabularyKey PersonHomePhone { get; protected set; }
        public VocabularyKey IdEmailPc { get; protected set; }
        public VocabularyKey IdEmailC { get; protected set; }
        public VocabularyKey IdentityKitIdPc { get; protected set; }
        public VocabularyKey IdentityKitIdC { get; protected set; }
        public VocabularyKey IdNgPc { get; protected set; }
        public VocabularyKey IdNgC { get; protected set; }
        public VocabularyKey IndustryPc { get; protected set; }
        public VocabularyKey Industry { get; protected set; }
        public VocabularyKey InteractionScorePc { get; protected set; }
        public VocabularyKey InteractionScoreCalculatedPc { get; protected set; }
        public VocabularyKey InteractionScoreLastUpdatedPc { get; protected set; }
        public VocabularyKey IsActiveUserPc { get; protected set; }
        public VocabularyKey IsKukCustomerC { get; protected set; }
        public VocabularyKey IsMarketingContactPc { get; protected set; }
        public VocabularyKey IsPartnerPc { get; protected set; }
        public VocabularyKey IsPersonAccount { get; protected set; }
        public VocabularyKey KukCodeC { get; protected set; }
        public VocabularyKey KukCustomerIdC { get; protected set; }
        public VocabularyKey LastActivityDate { get; protected set; }
        public VocabularyKey LastModifiedById { get; protected set; }
        public VocabularyKey LastModifiedDate { get; protected set; }
        public VocabularyKey LastName { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey LeadReassignmentC { get; protected set; }
        public VocabularyKey PersonLeadSource { get; protected set; }
        public VocabularyKey PersonMailingAddress { get; protected set; }
        public VocabularyKey PersonMailingCity { get; protected set; }
        public VocabularyKey PersonMailingCountry { get; protected set; }
        public VocabularyKey PersonMailingCountryCode { get; protected set; }
        public VocabularyKey PersonMailingState { get; protected set; }
        public VocabularyKey PersonMailingStateCode { get; protected set; }
        public VocabularyKey PersonMailingStreet { get; protected set; }
        public VocabularyKey PersonMailingPostalCode { get; protected set; }
        public VocabularyKey MarketingContactHemKeyC { get; protected set; }
        public VocabularyKey MarketingContactKeyC { get; protected set; }
        public VocabularyKey McApiErrorPc { get; protected set; }
        public VocabularyKey McApiStatusPc { get; protected set; }
        public VocabularyKey PersonMobilePhone { get; protected set; }
        public VocabularyKey NumberOfCarsPc { get; protected set; }
        public VocabularyKey OrderedLicensesC { get; protected set; }
        public VocabularyKey PersonOtherAddress { get; protected set; }
        public VocabularyKey PersonOtherCity { get; protected set; }
        public VocabularyKey PersonOtherCountry { get; protected set; }
        public VocabularyKey PersonOtherCountryCode { get; protected set; }
        public VocabularyKey PersonOtherPhone { get; protected set; }
        public VocabularyKey PersonOtherState { get; protected set; }
        public VocabularyKey PersonOtherStateCode { get; protected set; }
        public VocabularyKey PersonOtherStreet { get; protected set; }
        public VocabularyKey PersonOtherPostalCode { get; protected set; }
        public VocabularyKey OwnerId { get; protected set; }
        public VocabularyKey OwnerShip { get; protected set; }
        public VocabularyKey ParentId { get; protected set; }
        public VocabularyKey IsPartner { get; protected set; }
        public VocabularyKey PartnerExtidC { get; protected set; }
        public VocabularyKey PersonContactIdC { get; protected set; }
        public VocabularyKey PhoneFormulaC { get; protected set; }
        public VocabularyKey PhotoUrl { get; protected set; }
        public VocabularyKey PostBoxNameC { get; protected set; }
        public VocabularyKey PreferedOwnershipPc { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey ResidenseRegionPc { get; protected set; }
        public VocabularyKey RobinsonC { get; protected set; }
        public VocabularyKey Salutation { get; protected set; }
        public VocabularyKey SeatIdC { get; protected set; }
        public VocabularyKey ShippingAddress { get; protected set; }
        public VocabularyKey ShippingCity { get; protected set; }
        public VocabularyKey ShippingCountry { get; protected set; }
        public VocabularyKey ShippingCountryCode { get; protected set; }
        public VocabularyKey ShippingState { get; protected set; }
        public VocabularyKey ShippingStateCode { get; protected set; }
        public VocabularyKey ShippingStreet { get; protected set; }
        public VocabularyKey ShippingPostalCode { get; protected set; }
        public VocabularyKey SkodaIdC { get; protected set; }
        public VocabularyKey StartedUsingSfC { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey TickerSymbol { get; protected set; }
        public VocabularyKey PersonTitle { get; protected set; }
        public VocabularyKey VwEIdCC { get; protected set; }
        public VocabularyKey VwIdC { get; protected set; }
        public VocabularyKey Website { get; protected set; }
    }
}
