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
                AccPhone = group.Add(new VocabularyKey("AccPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone"));
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                CVRNumber = group.Add(new VocabularyKey("CVRNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("CVR Number"));
                MainDealerID = group.Add(new VocabularyKey("MainDealerID", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Main Dealer ID"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumber", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                Website = group.Add(new VocabularyKey("Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible).WithDisplayName("Website"));

                COName = group.Add(new VocabularyKey("COName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name"));

                AdrLine2 = group.Add(new VocabularyKey("AdrLine2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2"));
                EANNumber = group.Add(new VocabularyKey("EANNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("EAN Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                EmailType = group.Add(new VocabularyKey("EmailType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail Type"));
                PhoneType = group.Add(new VocabularyKey("PhoneType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Type"));
                TaxCode = group.Add(new VocabularyKey("TaxCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Code"));
            });

            AddMapping(AccPhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(AdrLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Address);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            AddMapping(Country, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCountryName);
            AddMapping(CVRNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.CodesCVR);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.ContactEmail);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.OrganizationName);
            AddMapping(PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressZipCode);
            AddMapping(State, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressState);
            AddMapping(Website, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Website);

            AddMapping(AccPhone, SemlerVocabularies.Customer.AccPhone);
            AddMapping(AdrLine1, SemlerVocabularies.Customer.AdrLine1);
            AddMapping(City, SemlerVocabularies.Customer.City);
            AddMapping(Country, SemlerVocabularies.Customer.Country);
            AddMapping(CustomerNumber, SemlerVocabularies.Customer.CustomerNumber);
            AddMapping(CVRNumber, SemlerVocabularies.Customer.CVRNumber);
            AddMapping(MainDealerID, SemlerVocabularies.Customer.MainDealerID);
            AddMapping(Name, SemlerVocabularies.Customer.Name);
            AddMapping(PhoneNumber, SemlerVocabularies.Customer.PhoneNumber);
            AddMapping(PostalCode, SemlerVocabularies.Customer.PostalCode);
            AddMapping(State, SemlerVocabularies.Customer.State);
            AddMapping(Website, SemlerVocabularies.Customer.Website);

            AddMapping(COName, SemlerVocabularies.Customer.COName);

            AddMapping(AdrLine2, SemlerVocabularies.Customer.AdrLine2);
            AddMapping(EANNumber, SemlerVocabularies.Customer.EANNumber);
            AddMapping(Email, SemlerVocabularies.Customer.Email);
            AddMapping(EmailType, SemlerVocabularies.Customer.EmailType);
            AddMapping(PhoneType, SemlerVocabularies.Customer.PhoneType);
            AddMapping(TaxCode, SemlerVocabularies.Customer.TaxCode);
        }

        public VocabularyKey AccPhone { get; private set; }
        public VocabularyKey AdrLine1 { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey AdrLine2 { get; private set; }
        public VocabularyKey CVRNumber { get; private set; }
        public VocabularyKey MainDealerID { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey EANNumber { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey EmailType { get; private set; }
        public VocabularyKey PhoneType { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Website { get; private set; }
    }
}
