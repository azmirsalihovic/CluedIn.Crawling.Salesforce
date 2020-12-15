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
                //SalesForce
                AccountSource = group.Add(new VocabularyKey("AccountSource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Source"));
                Address = group.Add(new VocabularyKey("Address", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address"));
                BillingAddress = group.Add(new VocabularyKey("BillingAddress", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Address"));
                BillingCity = group.Add(new VocabularyKey("BillingCity", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("Billing City"));
                BillingCountry = group.Add(new VocabularyKey("BillingCountry", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country"));
                BillingCountryCode = group.Add(new VocabularyKey("BillingCountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Country Code"));
                BillingPostalCode = group.Add(new VocabularyKey("BillingPostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Postal Code"));
                BillingState = group.Add(new VocabularyKey("BillingState", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("Billing State"));
                BillingStateCode = group.Add(new VocabularyKey("BillingStateCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing State Code"));
                BillingStreet = group.Add(new VocabularyKey("BillingStreet", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Billing Street"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                CustomerName = group.Add(new VocabularyKey("CustomerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Name"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                CustomerType = group.Add(new VocabularyKey("CustomerType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Type"));
                CVRNumber = group.Add(new VocabularyKey("CVRNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("CVR Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumber", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                Website = group.Add(new VocabularyKey("Website", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Website"));
                COName = group.Add(new VocabularyKey("COName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.Visible).WithDisplayName("LastName"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                Eannumber = group.Add(new VocabularyKey("eannumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Eannumer").WithDescription("International Article Number"));
                Taxcode = group.Add(new VocabularyKey("taxcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Taxcode").WithDescription("Tax Code"));
            });

            AddMapping(BillingAddress, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(BillingCity, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(BillingCountry, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName);
            AddMapping(BillingCountryCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            AddMapping(BillingPostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            AddMapping(CVRNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);

            AddMapping(Name, SemlerVocabularies.Customer.CustomerName);
            AddMapping(FirstName, SemlerVocabularies.Customer.FirstName);
            AddMapping(LastName, SemlerVocabularies.Customer.LastName);
            AddMapping(COName, SemlerVocabularies.Customer.COName);
            AddMapping(Address, SemlerVocabularies.Customer.Address1);
            AddMapping(Address, SemlerVocabularies.Customer.Address2);
            AddMapping(City, SemlerVocabularies.Customer.Address2);
            AddMapping(PostalCode, SemlerVocabularies.Customer.Address2);
            AddMapping(CountryCode, SemlerVocabularies.Customer.CountryCode);
            AddMapping(Email, SemlerVocabularies.Customer.Email);
            AddMapping(PhoneNumber, SemlerVocabularies.Customer.PhoneNumber);
            AddMapping(CVRNumber, SemlerVocabularies.Customer.CvrNumber);
            AddMapping(Eannumber, SemlerVocabularies.Customer.EanNumber);
            AddMapping(Taxcode, SemlerVocabularies.Customer.TaxCode);
        }

        public VocabularyKey AccountSource { get; private set; }
        public VocabularyKey Address { get; private set; }
        public VocabularyKey BillingAddress { get; private set; }
        public VocabularyKey BillingCity { get; private set; }
        public VocabularyKey BillingCountry { get; private set; }
        public VocabularyKey BillingCountryCode { get; private set; }
        public VocabularyKey BillingPostalCode { get; private set; }
        public VocabularyKey BillingState { get; private set; }
        public VocabularyKey BillingStateCode { get; private set; }
        public VocabularyKey BillingStreet { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey CustomerName { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey CVRNumber { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Website { get; private set; }
        public VocabularyKey Eannumber { get; private set; }
        public VocabularyKey Taxcode { get; private set; }
    }
}
