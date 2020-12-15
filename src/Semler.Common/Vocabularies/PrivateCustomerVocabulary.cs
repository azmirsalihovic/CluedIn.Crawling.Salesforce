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
                //SalesForce
                AccountNumber = group.Add(new VocabularyKey("AccountNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                AccountSource = group.Add(new VocabularyKey("AccountSource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Source"));
                Address = group.Add(new VocabularyKey("Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                BillingAddress = group.Add(new VocabularyKey("BillingAddress", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Address"));
                BillingCity = group.Add(new VocabularyKey("BillingCity", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("Billing City"));
                BillingCountry = group.Add(new VocabularyKey("BillingCountry", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country"));
                BillingCountryCode = group.Add(new VocabularyKey("BillingCountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country Code"));
                BillingPostalCode = group.Add(new VocabularyKey("BillingPostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Postal Code"));
                Birthdate = group.Add(new VocabularyKey("Birthdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Birthdate"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                CustomerType = group.Add(new VocabularyKey("CustomerType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Type"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("LastName"));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumber", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Title"));

                //Geomatic
                COName = group.Add(new VocabularyKey("COName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
            });

            AddMapping(BillingAddress, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(BillingCity, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(BillingCountry, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName);
            AddMapping(BillingCountryCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            AddMapping(BillingPostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(PhoneNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(Birthdate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday);
            AddMapping(Title, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Title);

            //Geomatic
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
        }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey AccountSource { get; private set; }
        public VocabularyKey BillingAddress { get; private set; }
        public VocabularyKey BillingCity { get; private set; }
        public VocabularyKey BillingCountry { get; private set; }
        public VocabularyKey BillingCountryCode { get; private set; }
        public VocabularyKey BillingPostalCode { get; private set; }
        public VocabularyKey Birthdate { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Address { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Title { get; private set; }
    }
}
