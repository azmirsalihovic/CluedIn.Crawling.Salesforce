using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
	public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Semler Contact";
            KeyPrefix = "semler.contact";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.Contact;

            AddGroup("Semler Contact Details", group =>
            {
                Birthdate = group.Add(new VocabularyKey("Birthdate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Birthdate"));
                    Contact_Role__c = group.Add(new VocabularyKey("Contact_Role__c", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Contact Role"));
                    Contact_Role__pc = group.Add(new VocabularyKey("Contact_Role__pc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Contact Role"));
                Department = group.Add(new VocabularyKey("Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Department"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                MailingAddress = group.Add(new VocabularyKey("MailingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                MailingCity = group.Add(new VocabularyKey("MailingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                MailingCountry = group.Add(new VocabularyKey("MailingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                MailingCountryCode = group.Add(new VocabularyKey("MailingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                    MailingPostalCode = group.Add(new VocabularyKey("MailingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));

                MobilePhone = group.Add(new VocabularyKey("MobilePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Name"));
                OtherAddress = group.Add(new VocabularyKey("OtherAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                OtherCity = group.Add(new VocabularyKey("OtherCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                OtherCountry = group.Add(new VocabularyKey("OtherCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                OtherCountryCode = group.Add(new VocabularyKey("OtherCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                OtherPhone = group.Add(new VocabularyKey("OtherPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                OtherPostalCode = group.Add(new VocabularyKey("OtherPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    PersonEmail = group.Add(new VocabularyKey("PersonEmail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                    PersonHomePhone = group.Add(new VocabularyKey("PersonHomePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                    PersonMailingAddress = group.Add(new VocabularyKey("PersonMailingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                    PersonMailingCity = group.Add(new VocabularyKey("PersonMailingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                    PersonMailingCountryCode = group.Add(new VocabularyKey("PersonMailingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                    PersonMailingPostalCode = group.Add(new VocabularyKey("PersonMailingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    PersonMobilePhone = group.Add(new VocabularyKey("PersonMobilePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                    PersonOtherAddress = group.Add(new VocabularyKey("PersonOtherAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                    PersonOtherCity = group.Add(new VocabularyKey("PersonOtherCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                    PersonOtherCountry = group.Add(new VocabularyKey("PersonOtherCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                    PersonOtherCountryCode = group.Add(new VocabularyKey("PersonOtherCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                    PersonOtherPhone = group.Add(new VocabularyKey("PersonOtherPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                    PersonOtherPostalCode = group.Add(new VocabularyKey("PersonOtherPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    PersonTitle = group.Add(new VocabularyKey("PersonTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Title"));
                    Phone = group.Add(new VocabularyKey("Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
            });

            AddMapping(Birthdate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday);
            AddMapping(Department, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Department);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(PersonHomePhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomePhoneNumber);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(MobilePhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MobileNumber);
            AddMapping(Phone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(PersonTitle, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Title);
        }
        public VocabularyKey Birthdate { get; private set; }
        public VocabularyKey Contact_Role__c { get; private set; }
        public VocabularyKey Contact_Role__pc { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MailingAddress { get; private set; }
        public VocabularyKey MailingCity { get; private set; }
        public VocabularyKey MailingCountry { get; private set; }
        public VocabularyKey MailingCountryCode { get; private set; }
        public VocabularyKey MailingPostalCode { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }
        public VocabularyKey OtherAddress { get; private set; }
        public VocabularyKey OtherCity { get; private set; }
        public VocabularyKey OtherCountry { get; private set; }
        public VocabularyKey OtherCountryCode { get; private set; }
        public VocabularyKey OtherPhone { get; private set; }
        public VocabularyKey OtherPostalCode { get; private set; }
        public VocabularyKey PersonEmail { get; private set; }
        public VocabularyKey PersonHomePhone { get; private set; }
        public VocabularyKey PersonMailingAddress { get; private set; }
        public VocabularyKey PersonMailingCity { get; private set; }
        public VocabularyKey PersonMailingCountryCode { get; private set; }
        public VocabularyKey PersonMailingPostalCode { get; private set; }
        public VocabularyKey PersonMobilePhone { get; private set; }
        public VocabularyKey PersonOtherAddress { get; private set; }
        public VocabularyKey PersonOtherCity { get; private set; }
        public VocabularyKey PersonOtherCountry { get; private set; }
        public VocabularyKey PersonOtherCountryCode { get; private set; }
        public VocabularyKey PersonOtherPhone { get; private set; }
        public VocabularyKey PersonOtherPostalCode { get; private set; }
        public VocabularyKey PersonTitle { get; private set; }
        public VocabularyKey Phone { get; private set; }
    }
}
