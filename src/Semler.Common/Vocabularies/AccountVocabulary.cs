using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
	public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Semler Account";
            KeyPrefix = "semler.account";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.User;
            AddGroup("Semler Account Details", group =>
            {
                AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Account ID"));
                AccountNumber = group.Add(new VocabularyKey("AccountNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Account Number"));
                AccountSource = group.Add(new VocabularyKey("AccountSource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Source"));
                BillingAddress = group.Add(new VocabularyKey("BillingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Account Billing Address"));
                BillingCity = group.Add(new VocabularyKey("BillingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing City"));
                BillingCountry = group.Add(new VocabularyKey("BillingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country"));
                BillingCountryCode = group.Add(new VocabularyKey("BillingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country Code"));
                BillingPostalCode = group.Add(new VocabularyKey("BillingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Postal Code"));
                CVR__c = group.Add(new VocabularyKey("CVR__c", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("VAT Number"));
                CustomerCity__c = group.Add(new VocabularyKey("CustomerCity__c", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail Address"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                Id = group.Add(new VocabularyKey("Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("ID"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Person Account Name"));
                MailingAddress = group.Add(new VocabularyKey("MailingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                MailingCity = group.Add(new VocabularyKey("MailingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                MailingCountry = group.Add(new VocabularyKey("MailingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                MailingCountryCode = group.Add(new VocabularyKey("MailingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                MailingPostalCode = group.Add(new VocabularyKey("MailingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Name"));
                OtherAddress = group.Add(new VocabularyKey("OtherAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                OtherCity = group.Add(new VocabularyKey("OtherCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                OtherCountry = group.Add(new VocabularyKey("OtherCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                OtherCountryCode = group.Add(new VocabularyKey("OtherCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                OtherPhone = group.Add(new VocabularyKey("OtherPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                OtherPostalCode = group.Add(new VocabularyKey("OtherPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
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
            AddMapping(CVR__c, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
        }

        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey AccountSource { get; private set; }
        public VocabularyKey BillingAddress { get; private set; }
        public VocabularyKey BillingCity { get; private set; }
        public VocabularyKey BillingCountry { get; private set; }
        public VocabularyKey BillingCountryCode { get; private set; }
        public VocabularyKey BillingPostalCode { get; private set; }
        public VocabularyKey CVR__c { get; private set; }
        public VocabularyKey CustomerCity__c { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey Id { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MailingAddress { get; private set; }
        public VocabularyKey MailingCity { get; private set; }
        public VocabularyKey MailingCountry { get; private set; }
        public VocabularyKey MailingCountryCode { get; private set; }
        public VocabularyKey MailingPostalCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OtherAddress { get; private set; }
        public VocabularyKey OtherCity { get; private set; }
        public VocabularyKey OtherCountry { get; private set; }
        public VocabularyKey OtherCountryCode { get; private set; }
        public VocabularyKey OtherPhone { get; private set; }
        public VocabularyKey OtherPostalCode { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey ShippingAddress { get; private set; }
        public VocabularyKey ShippingCity { get; private set; }
        public VocabularyKey ShippingCountry { get; private set; }
        public VocabularyKey ShippingCountryCode { get; private set; }
        public VocabularyKey ShippingPostalCode { get; private set; }
        public VocabularyKey Type { get; private set; }

    }
}
