// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceContact.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceContact type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce contact vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceContactVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceContact"/> class.
        /// </summary>
        public SalesforceContactVocabulary()
        {
            VocabularyName = "Salesforce Contact";
            KeyPrefix = "salesforce.contact";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.Contact;

            AddGroup("Salesforce Contact Details", group =>
            {
                AccountId = group.Add(new VocabularyKey("accountid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Account ID").WithDescription("\"ID of the account that’s the parent of this contact.\""));
                AgeC = group.Add(new VocabularyKey("ageC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Age").WithDescription("We recommend that you update up to 50 contacts simultaneously when changing the accounts on contacts enabled for a Customer Portal or partner portal. We also recommend that you make this update after business hours."));
                AssistantName = group.Add(new VocabularyKey("assistantname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Assistant's Name"));
                AssistantPhone = group.Add(new VocabularyKey("assistantphone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Asst. Phone"));
                Birthdate = group.Add(new VocabularyKey("birthdate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Birthdate"));
                BouncedC = group.Add(new VocabularyKey("bouncedC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Bounced").WithDescription("has the e-mail addres bounced "));
                BrandC = group.Add(new VocabularyKey("brandC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Brand").WithDescription("Legacy Brand"));
                Brand2C = group.Add(new VocabularyKey("brand2C", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Brand").WithDescription("New Brand pick list "));
                Fax = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Fax"));
                Phone = group.Add(new VocabularyKey("phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Phone"));
                BuyingTimeframeC = group.Add(new VocabularyKey("buyingTimeframeC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Buying timeframe").WithDescription("Survey response segment "));
                CompanySizeC = group.Add(new VocabularyKey("companySizeC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Company Size").WithDescription("Survey response segment "));
                Description = group.Add(new VocabularyKey("description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Contact Description"));
                ID = group.Add(new VocabularyKey("id", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Contact ID").WithDescription("The System ID "));
                ContactRoleC = group.Add(new VocabularyKey("contactRoleC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Contact Role").WithDescription("Survey response segment "));
                CreatedById = group.Add(new VocabularyKey("createdbyid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Created By ID").WithDescription("audit"));
                CreatedDate = group.Add(new VocabularyKey("createddate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Created Date").WithDescription("audit"));
                CurrentCarBrandC = group.Add(new VocabularyKey("currentCarBrandC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Current Car Brand").WithDescription("Survey response segment "));
                IsDeleted = group.Add(new VocabularyKey("isdeleted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Deleted"));
                Department = group.Add(new VocabularyKey("department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Department"));
                DoNotCall = group.Add(new VocabularyKey("donotcall", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Do Not Call"));
                Email = group.Add(new VocabularyKey("email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Email"));
                FirstName = group.Add(new VocabularyKey("firstname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("First Name").WithDescription("\"The contact’s first name up to 40 characters.\""));
                Name = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Full Name").WithDescription("Concatenation of FirstName, MiddleName, LastName, and Suffix up to 203 characters, including whitespaces."));
                HashedEmailC = group.Add(new VocabularyKey("hashedemailC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Hashed Email"));
                HomePhone = group.Add(new VocabularyKey("homephone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Home Phone"));
                IdEmailC = group.Add(new VocabularyKey("idEmailC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("ID Email"));
                IdentityKitIdC = group.Add(new VocabularyKey("identitykitidC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Identity Kit Id"));
                IdNgC = group.Add(new VocabularyKey("idNgC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("ID NG"));
                IndustryC = group.Add(new VocabularyKey("industryC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Industry"));
                InteractionScoreC = group.Add(new VocabularyKey("interactionscoreC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Interaction Score"));
                InteractionScoreCalculatedC = group.Add(new VocabularyKey("interactionscorecalculatedC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Interaction Score Calculated"));
                InteractionScoreLastUpdatedC = group.Add(new VocabularyKey("interactionscorelastupdatedC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Interaction Score Last Updated"));
                IsActiveUserC = group.Add(new VocabularyKey("isactiveuserC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Is Active User"));
                IsEmailBounced = group.Add(new VocabularyKey("isemailbounced", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Is Email Bounced"));
                IsMarketingContactC = group.Add(new VocabularyKey("ismarketingcontactC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Is Marketing Contact"));
                IsPartnerC = group.Add(new VocabularyKey("isPartnerC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Is Partner"));
                IsPersonAccount = group.Add(new VocabularyKey("ispersonaccount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Is Person Account"));
                LastActivityDate = group.Add(new VocabularyKey("lastactivitydate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Activity"));
                LastModifiedById = group.Add(new VocabularyKey("lastmodifiedbyid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Modified By ID"));
                LastModifiedDate = group.Add(new VocabularyKey("lastmodifieddate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Modified Date"));
                LastName = group.Add(new VocabularyKey("lastname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name").WithDescription("\"Required. Last name of the contact up to 80 characters.\""));
                LastReferencedDate = group.Add(new VocabularyKey("lastreferenceddate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Referenced Date"));
                LastCURequestDate = group.Add(new VocabularyKey("lastcurequestdate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Stay-in-Touch Request Date"));
                LastCUUpdateDate = group.Add(new VocabularyKey("lastcuupdatedate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Stay-in-Touch Save Date"));
                LastViewedDate = group.Add(new VocabularyKey("lastvieweddate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Viewed Date"));
                LeadSource = group.Add(new VocabularyKey("leadsource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lead Source"));
                MailingAddress = group.Add(new VocabularyKey("mailingaddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Address"));
                MailingCity = group.Add(new VocabularyKey("mailingcity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing City"));
                MailingCountry = group.Add(new VocabularyKey("mailingcountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Country"));
                MailingCountryCode = group.Add(new VocabularyKey("mailingcountrycode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Country Code"));
                MailingGeocodeAccuracy = group.Add(new VocabularyKey("mailinggeocodeaccuracy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailing Geocode Accuracy"));
                MailingLatitude = group.Add(new VocabularyKey("mailinglatitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailing Latitude"));
                MailingLongitude = group.Add(new VocabularyKey("mailinglongitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailing Longitude"));
                MailingState = group.Add(new VocabularyKey("mailingstate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailing State/Province"));
                MailingStateCode = group.Add(new VocabularyKey("mailingstatecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailing State/Province Code"));
                MailingStreet = group.Add(new VocabularyKey("mailingstreet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Street"));
                MailingPostalCode = group.Add(new VocabularyKey("mailingpostalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Mailing Zip/Postal Code"));
                MasterRecordId = group.Add(new VocabularyKey("masterrecordid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Master Record ID"));
                McApiErrorC = group.Add(new VocabularyKey("mcApiErrorC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("MC API Error"));
                McApiStatusC = group.Add(new VocabularyKey("mcApiStatusC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("MC API Status"));
                MobilePhone = group.Add(new VocabularyKey("mobilephone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone"));
                NumberOfCarsC = group.Add(new VocabularyKey("numberOfCarsC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Number of Cars").WithDescription("Survey Segmentation Response"));
                OtherAddress = group.Add(new VocabularyKey("otheraddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Address"));
                OtherCity = group.Add(new VocabularyKey("othercity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other City"));
                OtherCountry = group.Add(new VocabularyKey("othercountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Country"));
                OtherCountryCode = group.Add(new VocabularyKey("othercountrycode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Country Code"));
                OtherPhone = group.Add(new VocabularyKey("otherphone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Phone"));
                OtherState = group.Add(new VocabularyKey("otherstate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other State/Province"));
                OtherStateCode = group.Add(new VocabularyKey("otherstatecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other State/Province Code"));
                OtherStreet = group.Add(new VocabularyKey("otherstreet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Street"));
                OtherPostalCode = group.Add(new VocabularyKey("otherpostalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Other Zip/Postal Code"));
                OwnerId = group.Add(new VocabularyKey("ownerid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Owner ID"));
                PhotoUrl = group.Add(new VocabularyKey("photourl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Photo URL"));
                PreferedOwnershipC = group.Add(new VocabularyKey("preferedOwnershipC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Prefered Ownership").WithDescription("Survey Segmentation Response"));
                RecordTypeId = group.Add(new VocabularyKey("recordtypeid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Record Type ID"));
                ReportsToId = group.Add(new VocabularyKey("reportstoid", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Reports To ID").WithDescription("ID to another contact who is the manager of this contact"));
                ResidenseRegionC = group.Add(new VocabularyKey("residenseRegionC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Residense region").WithDescription("Survey Segmentation Response"));
                Salutation = group.Add(new VocabularyKey("salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Salutation"));
                SystemModstamp = group.Add(new VocabularyKey("systemmodstamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("System Modstamp"));
                Title = group.Add(new VocabularyKey("title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Title"));
            });

            //CluedIn
            AddMapping(SystemModstamp, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);

            //Semler vocabs
            AddMapping(MailingAddress, Semler.Common.Vocabularies.SemlerVocabularies.Contact.AdrLine1);
            AddMapping(MailingCity, Semler.Common.Vocabularies.SemlerVocabularies.Contact.City);
            AddMapping(ContactRoleC, Semler.Common.Vocabularies.SemlerVocabularies.Contact.ContactRole);
            AddMapping(MailingCountry, Semler.Common.Vocabularies.SemlerVocabularies.Contact.Country);
            AddMapping(Department, Semler.Common.Vocabularies.SemlerVocabularies.Contact.Department);
            AddMapping(Email, Semler.Common.Vocabularies.SemlerVocabularies.Contact.Email);
            AddMapping(FirstName, Semler.Common.Vocabularies.SemlerVocabularies.Contact.FirstName);
            AddMapping(LastName, Semler.Common.Vocabularies.SemlerVocabularies.Contact.LastName);
            AddMapping(MobilePhone, Semler.Common.Vocabularies.SemlerVocabularies.Contact.MobPhoneNum);
            AddMapping(Name, Semler.Common.Vocabularies.SemlerVocabularies.Contact.Name);
            AddMapping(MailingPostalCode, Semler.Common.Vocabularies.SemlerVocabularies.Contact.PostalCode);
        }

        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey AgeC { get; private set; }
        public VocabularyKey AssistantName { get; private set; }
        public VocabularyKey AssistantPhone { get; private set; }
        public VocabularyKey Birthdate { get; private set; }
        public VocabularyKey BouncedC { get; private set; }
        public VocabularyKey BrandC { get; private set; }
        public VocabularyKey Brand2C { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey BuyingTimeframeC { get; private set; }
        public VocabularyKey CompanySizeC { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey ContactRoleC { get; private set; }
        public VocabularyKey CreatedById { get; private set; }
        public VocabularyKey CreatedDate { get; private set; }
        public VocabularyKey CurrentCarBrandC { get; private set; }
        public VocabularyKey IsDeleted { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey DoNotCall { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey HashedEmailC { get; private set; }
        public VocabularyKey HomePhone { get; private set; }
        public VocabularyKey IdEmailC { get; private set; }
        public VocabularyKey IdentityKitIdC { get; private set; }
        public VocabularyKey IdNgC { get; private set; }
        public VocabularyKey IndustryC { get; private set; }
        public VocabularyKey InteractionScoreC { get; private set; }
        public VocabularyKey InteractionScoreCalculatedC { get; private set; }
        public VocabularyKey InteractionScoreLastUpdatedC { get; private set; }
        public VocabularyKey IsActiveUserC { get; private set; }
        public VocabularyKey IsEmailBounced { get; private set; }
        public VocabularyKey IsMarketingContactC { get; private set; }
        public VocabularyKey IsPartnerC { get; private set; }
        public VocabularyKey IsPersonAccount { get; private set; }
        public VocabularyKey LastActivityDate { get; private set; }
        public VocabularyKey LastModifiedById { get; private set; }
        public VocabularyKey LastModifiedDate { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LastReferencedDate { get; private set; }
        public VocabularyKey LastCURequestDate { get; private set; }
        public VocabularyKey LastCUUpdateDate { get; private set; }
        public VocabularyKey LastViewedDate { get; private set; }
        public VocabularyKey LeadSource { get; private set; }
        public VocabularyKey MailingAddress { get; private set; }
        public VocabularyKey MailingCity { get; private set; }
        public VocabularyKey MailingCountry { get; private set; }
        public VocabularyKey MailingCountryCode { get; private set; }
        public VocabularyKey MailingGeocodeAccuracy { get; private set; }
        public VocabularyKey MailingLatitude { get; private set; }
        public VocabularyKey MailingLongitude { get; private set; }
        public VocabularyKey MailingState { get; private set; }
        public VocabularyKey MailingStateCode { get; private set; }
        public VocabularyKey MailingStreet { get; private set; }
        public VocabularyKey MailingPostalCode { get; private set; }
        public VocabularyKey MasterRecordId { get; private set; }
        public VocabularyKey McApiErrorC { get; private set; }
        public VocabularyKey McApiStatusC { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }
        public VocabularyKey NumberOfCarsC { get; private set; }
        public VocabularyKey OtherAddress { get; private set; }
        public VocabularyKey OtherCity { get; private set; }
        public VocabularyKey OtherCountry { get; private set; }
        public VocabularyKey OtherCountryCode { get; private set; }
        public VocabularyKey OtherPhone { get; private set; }
        public VocabularyKey OtherState { get; private set; }
        public VocabularyKey OtherStateCode { get; private set; }
        public VocabularyKey OtherStreet { get; private set; }
        public VocabularyKey OtherPostalCode { get; private set; }
        public VocabularyKey OwnerId { get; private set; }
        public VocabularyKey PhotoUrl { get; private set; }
        public VocabularyKey PreferedOwnershipC { get; private set; }
        public VocabularyKey RecordTypeId { get; private set; }
        public VocabularyKey ReportsToId { get; private set; }
        public VocabularyKey ResidenseRegionC { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey SystemModstamp { get; private set; }
        public VocabularyKey Title { get; private set; }
    }
}
