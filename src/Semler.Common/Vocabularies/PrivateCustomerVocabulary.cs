using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
	public class PrivateCustomerVocabulary : SimpleVocabulary
    {
        public PrivateCustomerVocabulary()
        {
            VocabularyName = "Semler Private Customer";
            KeyPrefix = "semler.privatecustomer";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.User;

            AddGroup("Semler Private Customer Details", group =>
            {
                //AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("ID"));
                AccountNumber = group.Add(new VocabularyKey("AccountNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                AccountSource = group.Add(new VocabularyKey("AccountSource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Source"));
                BillingAddress = group.Add(new VocabularyKey("BillingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Address"));
                BillingCity = group.Add(new VocabularyKey("BillingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing City"));
                BillingCountry = group.Add(new VocabularyKey("BillingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country"));
                BillingCountryCode = group.Add(new VocabularyKey("BillingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country Code"));
                BillingPostalCode = group.Add(new VocabularyKey("BillingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Postal Code"));
                    Birthdate = group.Add(new VocabularyKey("Birthdate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Birthdate"));
                CustomerCity__c = group.Add(new VocabularyKey("CustomerCity__c", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                //CVR__c = group.Add(new VocabularyKey("CVR__c", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("VAT Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                //Id = group.Add(new VocabularyKey("Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("ID"));
                    HomePhone = group.Add(new VocabularyKey("HomePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("LastName"));
                MailingAddress = group.Add(new VocabularyKey("MailingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                MailingCity = group.Add(new VocabularyKey("MailingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                MailingCountry = group.Add(new VocabularyKey("MailingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                MailingCountryCode = group.Add(new VocabularyKey("MailingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                MailingPostalCode = group.Add(new VocabularyKey("MailingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    MobilePhone = group.Add(new VocabularyKey("MobilePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                //Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Name"));

                OtherAddress = group.Add(new VocabularyKey("OtherAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                OtherCity = group.Add(new VocabularyKey("OtherCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                OtherCountry = group.Add(new VocabularyKey("OtherCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                OtherCountryCode = group.Add(new VocabularyKey("OtherCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                OtherPhone = group.Add(new VocabularyKey("OtherPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                OtherPostalCode = group.Add(new VocabularyKey("OtherPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));

                    PersonBirthdate = group.Add(new VocabularyKey("PersonBirthdate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Birthdate"));
                    PersonEmail = group.Add(new VocabularyKey("PersonEmail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                    PersonHomePhone = group.Add(new VocabularyKey("PersonHomePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                    PersonMailingAddress = group.Add(new VocabularyKey("PersonMailingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                    PersonMailingCity = group.Add(new VocabularyKey("PersonMailingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                    PersonMailingCountryCode = group.Add(new VocabularyKey("PersonMailingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                    PersonMailingPostalCode = group.Add(new VocabularyKey("PersonMailingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    PersonMailingState = group.Add(new VocabularyKey("PersonMailingState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                    PersonMailingStateCode = group.Add(new VocabularyKey("PersonMailingStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                    PersonMailingStreet = group.Add(new VocabularyKey("PersonMailingStreet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                    PersonMobilePhone = group.Add(new VocabularyKey("PersonMobilePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                    PersonOtherAddress = group.Add(new VocabularyKey("PersonOtherAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                    PersonOtherCity = group.Add(new VocabularyKey("PersonOtherCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                    PersonOtherCountry = group.Add(new VocabularyKey("PersonOtherCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                    PersonOtherCountryCode = group.Add(new VocabularyKey("PersonOtherCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                    PersonOtherPhone = group.Add(new VocabularyKey("PersonOtherPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                    PersonOtherPostalCode = group.Add(new VocabularyKey("PersonOtherPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    PersonOtherState = group.Add(new VocabularyKey("PersonOtherState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                    PersonOtherStateCode = group.Add(new VocabularyKey("PersonOtherStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                    PersonOtherStreet = group.Add(new VocabularyKey("PersonOtherStreet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                    PersonTitle = group.Add(new VocabularyKey("PersonTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Title"));

                Phone = group.Add(new VocabularyKey("Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                ShippingAddress = group.Add(new VocabularyKey("ShippingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                ShippingCity = group.Add(new VocabularyKey("ShippingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                ShippingCountry = group.Add(new VocabularyKey("ShippingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                ShippingCountryCode = group.Add(new VocabularyKey("ShippingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                ShippingPostalCode = group.Add(new VocabularyKey("ShippingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                Type = group.Add(new VocabularyKey("Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Type"));
            });

            AddMapping(BillingAddress, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(BillingCity, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(BillingCountry, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName);
            AddMapping(BillingCountryCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            AddMapping(BillingPostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            //AddMapping(CVR__c, Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
        }
        //public VocabularyKey AccountId { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey AccountSource { get; private set; }
        public VocabularyKey BillingAddress { get; private set; }
        public VocabularyKey BillingCity { get; private set; }
        public VocabularyKey BillingCountry { get; private set; }
        public VocabularyKey BillingCountryCode { get; private set; }
        public VocabularyKey BillingPostalCode { get; private set; }
        public VocabularyKey Birthdate { get; private set; }
        public VocabularyKey CustomerCity__c { get; private set; }
        //public VocabularyKey CVR__c { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey HomePhone { get; private set; }

        //public VocabularyKey Id { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MailingAddress { get; private set; }
        public VocabularyKey MailingCity { get; private set; }
        public VocabularyKey MailingCountry { get; private set; }
        public VocabularyKey MailingCountryCode { get; private set; }
        public VocabularyKey MailingPostalCode { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }

        //public VocabularyKey Name { get; private set; }
        public VocabularyKey OtherAddress { get; private set; }
        public VocabularyKey OtherCity { get; private set; }
        public VocabularyKey OtherCountry { get; private set; }
        public VocabularyKey OtherCountryCode { get; private set; }
        public VocabularyKey OtherPhone { get; private set; }
        public VocabularyKey OtherPostalCode { get; private set; }
        public VocabularyKey PersonBirthdate { get; private set; }
        public VocabularyKey PersonEmail { get; private set; }
        public VocabularyKey PersonHomePhone { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey ShippingAddress { get; private set; }
        public VocabularyKey ShippingCity { get; private set; }
        public VocabularyKey ShippingCountry { get; private set; }
        public VocabularyKey ShippingCountryCode { get; private set; }
        public VocabularyKey ShippingPostalCode { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey PersonMailingAddress { get; private set; }
        public VocabularyKey PersonMailingCity { get; private set; }
        public VocabularyKey PersonMailingCountryCode { get; private set; }
        public VocabularyKey PersonMailingPostalCode { get; private set; }
        public VocabularyKey PersonMailingState { get; private set; }
        public VocabularyKey PersonMailingStateCode { get; private set; }
        public VocabularyKey PersonMailingStreet { get; private set; }
        public VocabularyKey PersonMobilePhone { get; private set; }
        public VocabularyKey PersonOtherAddress { get; private set; }
        public VocabularyKey PersonOtherCity { get; private set; }
        public VocabularyKey PersonOtherCountry { get; private set; }
        public VocabularyKey PersonOtherCountryCode { get; private set; }
        public VocabularyKey PersonOtherPhone { get; private set; }
        public VocabularyKey PersonOtherPostalCode { get; private set; }
        public VocabularyKey PersonOtherState { get; private set; }
        public VocabularyKey PersonOtherStateCode { get; private set; }
        public VocabularyKey PersonOtherStreet { get; private set; }
        public VocabularyKey PersonTitle { get; private set; }
    }
}
