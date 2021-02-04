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
                //SalesForce Common Customer
                AccPhone = group.Add(new VocabularyKey("AccPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone"));
                AdrLine1Bill = group.Add(new VocabularyKey("AdrLine1Bill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Billing"));
                AdrLine2Bill = group.Add(new VocabularyKey("AdrLine2Bill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2 Billing"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                CityBill = group.Add(new VocabularyKey("CityBill", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Billing"));
                CountryBill = group.Add(new VocabularyKey("CountryBill", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Billing"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                CountryCodeBill = group.Add(new VocabularyKey("CountryCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Billing"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                CVRNumber = group.Add(new VocabularyKey("CVRNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("CVR Number"));
                Dealer = group.Add(new VocabularyKey("Dealer", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Dealer"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumber", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                PostalCodeBill = group.Add(new VocabularyKey("PostalCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Billing"));
                StateBill = group.Add(new VocabularyKey("StateBill", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State Billing"));
                Website = group.Add(new VocabularyKey("Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible).WithDisplayName("Website"));

                //Geomatic Common Customer
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                COName = group.Add(new VocabularyKey("COName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name"));

                //KUK Common Customer
                AdrLine2 = group.Add(new VocabularyKey("AdrLine2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2"));
                EANNumber = group.Add(new VocabularyKey("EANNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("EAN Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                EmailType = group.Add(new VocabularyKey("EmailType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail Type"));
                PhoneType = group.Add(new VocabularyKey("PhoneType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Type"));
                TaxCode = group.Add(new VocabularyKey("TaxCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Code"));
            });

            //CluedIn mapping (need review)
            AddMapping(AdrLine1Bill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Address);
            //AddMapping(AdrStrNum, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressStreetNumber);
            //AddMapping(AdrStreet, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressStreetName);
            //AddMapping(BillingCity, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            //AddMapping(BillingCountry, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCountryName);
            //AddMapping(BillingCountryCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCountryCode);
            //AddMapping(BillingPostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressZipCode);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            AddMapping(CVRNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.ContactEmail);
            AddMapping(PhoneNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);

            //SalesForce
            AddMapping(AccPhone, SemlerVocabularies.Customer.AccPhone);
            AddMapping(AdrLine1Bill, SemlerVocabularies.Customer.AdrLine1Bill);
            AddMapping(AdrLine2Bill, SemlerVocabularies.Customer.AdrLine2Bill);
            AddMapping(CVRNumber, SemlerVocabularies.Customer.CVRNumber);
            AddMapping(City, SemlerVocabularies.Customer.City);
            AddMapping(CityBill, SemlerVocabularies.Customer.CityBill);
            AddMapping(CountryBill, SemlerVocabularies.Customer.CountryBill);
            AddMapping(CountryCode, SemlerVocabularies.Customer.CountryCode);
            AddMapping(CountryCodeBill, SemlerVocabularies.Customer.CountryCodeBill);
            AddMapping(CustomerNumber, SemlerVocabularies.Customer.CustomerNumber);
            AddMapping(Name, SemlerVocabularies.Customer.Name);
            AddMapping(PhoneNumber, SemlerVocabularies.Customer.PhoneNumber);
            AddMapping(PostalCode, SemlerVocabularies.Customer.PostalCode);
            AddMapping(PostalCodeBill, SemlerVocabularies.Customer.PostalCodeBill);
            AddMapping(StateBill, SemlerVocabularies.Customer.StateBill);
            AddMapping(Website, SemlerVocabularies.Customer.Website);

            //Geomatic
            AddMapping(AdrLine1, SemlerVocabularies.Customer.AdrLine1);
            AddMapping(COName, SemlerVocabularies.Customer.COName);

            //KUK
            AddMapping(AdrLine2, SemlerVocabularies.Customer.AdrLine2);
            AddMapping(EANNumber, SemlerVocabularies.Customer.EANNumber);
            AddMapping(Email, SemlerVocabularies.Customer.Email);
            AddMapping(EmailType, SemlerVocabularies.Customer.EmailType);
            AddMapping(PhoneType, SemlerVocabularies.Customer.PhoneType);
            AddMapping(AdrLine2, SemlerVocabularies.Customer.AdrLine2);
            AddMapping(TaxCode, SemlerVocabularies.Customer.TaxCode);
        }

        public VocabularyKey AccPhone { get; private set; }
        public VocabularyKey AdrLine1 { get; private set; }
        public VocabularyKey AdrLine1Bill { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey AdrLine2 { get; private set; }
        public VocabularyKey CVRNumber { get; private set; }
        public VocabularyKey Dealer { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CityBill { get; private set; }
        public VocabularyKey CountryBill { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey CountryCodeBill { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey EANNumber { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey EmailType { get; private set; }
        public VocabularyKey PhoneType { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PostalCodeBill { get; private set; }
        public VocabularyKey StateBill { get; private set; }
        public VocabularyKey AdrLine2Bill { get; private set; }
        public VocabularyKey Website { get; private set; }
    }
}
