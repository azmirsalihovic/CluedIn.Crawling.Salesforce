using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
	public class CustomerVocabulary : SimpleVocabulary
    {
        public CustomerVocabulary()
        {
            VocabularyName = "Semler Customer";
            KeyPrefix = "semler.customer";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.User;

            AddGroup("Semler Customer Details", group =>
            {
                Address1 = group.Add(new VocabularyKey("Address1", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("Address 1"));
                Address2 = group.Add(new VocabularyKey("Address2", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("Address 2"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                CustomerType = group.Add(new VocabularyKey("CustomerType", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Type"));
                CvrNumber = group.Add(new VocabularyKey("CvrNumber", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("CVR Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                CustomerName = group.Add(new VocabularyKey("CustomerName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Name"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("LastName"));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumber", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                PhoneNumberType = group.Add(new VocabularyKey("PhoneNumberType", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number Type"));
                EmailType = group.Add(new VocabularyKey("EmailType", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Email Type"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                COName = group.Add(new VocabularyKey("COName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                TaxCode = group.Add(new VocabularyKey("TaxCode", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Code"));
                EanNumber = group.Add(new VocabularyKey("EanNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("International Article Number"));
            });

            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(CustomerName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(PhoneNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(CvrNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            AddMapping(TaxCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.TaxId);
        }

        public VocabularyKey Address1 { get; private set; }
        public VocabularyKey Address2 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey EmailType { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey PhoneNumberType { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey EanNumber { get; private set; }
        public VocabularyKey CvrNumber { get; private set; }
        public VocabularyKey CustomerName { get; private set; }
    }
}
