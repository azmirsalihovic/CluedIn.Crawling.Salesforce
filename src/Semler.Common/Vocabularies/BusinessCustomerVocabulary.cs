using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
	public class BusinessCustomerVocabulary : SimpleVocabulary
    {
        public BusinessCustomerVocabulary()
        {
            VocabularyName = "Semler Business Customer";
            KeyPrefix = "semler.businesscustomer";
            KeySeparator = ".";
            Grouping = EntityType.Organization;

            AddGroup("Semler Business Customer Details", group =>
            {
                AccountNumber = group.Add(new VocabularyKey("AccountNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                AccountSource = group.Add(new VocabularyKey("AccountSource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Source"));
                BillingAddress = group.Add(new VocabularyKey("BillingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Address"));
                BillingCity = group.Add(new VocabularyKey("BillingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing City"));
                BillingCountry = group.Add(new VocabularyKey("BillingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country"));
                BillingCountryCode = group.Add(new VocabularyKey("BillingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country Code"));
                BillingPostalCode = group.Add(new VocabularyKey("BillingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Postal Code"));
                    BillingState = group.Add(new VocabularyKey("BillingState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing State"));
                    BillingStateCode = group.Add(new VocabularyKey("BillingStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing State Code"));
                    BillingStreet = group.Add(new VocabularyKey("BillingStreet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Street"));
                CustomerCity__c = group.Add(new VocabularyKey("CustomerCity__c", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                CVR__c = group.Add(new VocabularyKey("CVR__c", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("CVR Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                MailingAddress = group.Add(new VocabularyKey("MailingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                MailingCity = group.Add(new VocabularyKey("MailingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                MailingCountry = group.Add(new VocabularyKey("MailingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                MailingCountryCode = group.Add(new VocabularyKey("MailingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                MailingPostalCode = group.Add(new VocabularyKey("MailingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    MailingState = group.Add(new VocabularyKey("MailingState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                    MailingStateCode = group.Add(new VocabularyKey("MailingStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                    MailingStreet = group.Add(new VocabularyKey("MailingStreet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Name"));
                OtherAddress = group.Add(new VocabularyKey("OtherAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                OtherCity = group.Add(new VocabularyKey("OtherCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                OtherCountry = group.Add(new VocabularyKey("OtherCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                OtherCountryCode = group.Add(new VocabularyKey("OtherCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                OtherPhone = group.Add(new VocabularyKey("OtherPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                OtherPostalCode = group.Add(new VocabularyKey("OtherPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    OtherState = group.Add(new VocabularyKey("OtherState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                    OtherStateCode = group.Add(new VocabularyKey("OtherStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                    OtherStreet = group.Add(new VocabularyKey("OtherStreet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                Phone = group.Add(new VocabularyKey("Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                ShippingAddress = group.Add(new VocabularyKey("ShippingAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                ShippingCity = group.Add(new VocabularyKey("ShippingCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                ShippingCountry = group.Add(new VocabularyKey("ShippingCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                ShippingCountryCode = group.Add(new VocabularyKey("ShippingCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                ShippingPostalCode = group.Add(new VocabularyKey("ShippingPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                    ShippingState = group.Add(new VocabularyKey("ShippingState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                    ShippingStateCode = group.Add(new VocabularyKey("ShippingStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                    ShippingStreet = group.Add(new VocabularyKey("ShippingStreet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                Type = group.Add(new VocabularyKey("Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Type"));
                    Website = group.Add(new VocabularyKey("Website", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Website"));
            });
            AddMapping(BillingAddress, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(BillingCity, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(BillingCountry, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName);
            AddMapping(BillingCountryCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            AddMapping(BillingPostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            AddMapping(CVR__c, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
        }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey AccountSource { get; private set; }
        public VocabularyKey BillingAddress { get; private set; }
        public VocabularyKey BillingCity { get; private set; }
        public VocabularyKey BillingCountry { get; private set; }
        public VocabularyKey BillingCountryCode { get; private set; }
        public VocabularyKey BillingPostalCode { get; private set; }
        public VocabularyKey BillingState { get; private set; }
        public VocabularyKey BillingStateCode { get; private set; }
        public VocabularyKey BillingStreet { get; private set; }
        public VocabularyKey CustomerCity__c { get; private set; }
        public VocabularyKey CVR__c { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey MailingAddress { get; private set; }
        public VocabularyKey MailingCity { get; private set; }
        public VocabularyKey MailingCountry { get; private set; }
        public VocabularyKey MailingCountryCode { get; private set; }
        public VocabularyKey MailingPostalCode { get; private set; }
        public VocabularyKey MailingState { get; private set; }
        public VocabularyKey MailingStateCode { get; private set; }
        public VocabularyKey MailingStreet { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OtherAddress { get; private set; }
        public VocabularyKey OtherCity { get; private set; }
        public VocabularyKey OtherCountry { get; private set; }
        public VocabularyKey OtherCountryCode { get; private set; }
        public VocabularyKey OtherPhone { get; private set; }
        public VocabularyKey OtherPostalCode { get; private set; }
        public VocabularyKey OtherState { get; private set; }
        public VocabularyKey OtherStateCode { get; private set; }
        public VocabularyKey OtherStreet { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey ShippingAddress { get; private set; }
        public VocabularyKey ShippingCity { get; private set; }
        public VocabularyKey ShippingCountry { get; private set; }
        public VocabularyKey ShippingCountryCode { get; private set; }
        public VocabularyKey ShippingPostalCode { get; private set; }
        public VocabularyKey ShippingState { get; private set; }
        public VocabularyKey ShippingStateCode { get; private set; }
        public VocabularyKey ShippingStreet { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Website { get; private set; }
    }
}
