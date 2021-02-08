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
                AccPhone = group.Add(new VocabularyKey("AccPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone"));
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                Dealer = group.Add(new VocabularyKey("Dealer", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Dealer"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                HomePhoneNr = group.Add(new VocabularyKey("HomePhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Home Phone"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                MobPhoneNr = group.Add(new VocabularyKey("MobPhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                
                //Geomatic
                AdrFloor = group.Add(new VocabularyKey("AdrFloor", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Floor"));
                AdrHouseChar = group.Add(new VocabularyKey("AdrHouseChar", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address House Character"));
                AdrLine1Per1 = group.Add(new VocabularyKey("AdrLine1Per1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Person 1"));
                AdrPlace = group.Add(new VocabularyKey("AdrPlace", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Place"));
                AdrPlacePer1 = group.Add(new VocabularyKey("AdrPlacePer1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Place Person 1"));
                AdrStreet = group.Add(new VocabularyKey("AdrStreet", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Street"));
                AdrStrNum = group.Add(new VocabularyKey("AdrStrNum", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Street Number"));
                AdrSuite = group.Add(new VocabularyKey("AdrSuite", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Suite"));
                CityPer1 = group.Add(new VocabularyKey("CityPer1", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Person 1"));
                COName = group.Add(new VocabularyKey("COName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name"));
                CONamePer1 = group.Add(new VocabularyKey("CONamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name Person 1"));
                FirstNamePer1 = group.Add(new VocabularyKey("FirstNamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name Person 1"));
                LandPhoneNum = group.Add(new VocabularyKey("LandPhoneNum", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Landline Phone Number"));
                LastNamePer1 = group.Add(new VocabularyKey("LastNamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name Person 1"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                NamePer1 = group.Add(new VocabularyKey("NamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name Person 1"));
                PostalCodePer1 = group.Add(new VocabularyKey("PostalCodePer1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Person 1"));

                //KUK
                AdrLine2 = group.Add(new VocabularyKey("AdrLine2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2"));
                EmailType = group.Add(new VocabularyKey("EmailType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail Type"));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumber", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                PhoneType = group.Add(new VocabularyKey("PhoneType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Type"));
            });

            //CluedIn mapping (need review)
            AddMapping(AccPhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(AdrLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressStreetName);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(HomePhoneNr, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomePhoneNumber);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(MobPhoneNr, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeMobileNumber);
            AddMapping(PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);

            //SalesForce Common Customer
            AddMapping(AccPhone, SemlerVocabularies.Customer.AccPhone);
            AddMapping(AdrLine1, SemlerVocabularies.Customer.AdrLine1);
            AddMapping(City, SemlerVocabularies.Customer.City);
            AddMapping(CustomerNumber, SemlerVocabularies.Customer.CustomerNumber);
            AddMapping(Dealer, SemlerVocabularies.Customer.Dealer);
            AddMapping(Email, SemlerVocabularies.Customer.Email);
            AddMapping(FirstName, SemlerVocabularies.Customer.FirstName);
            AddMapping(HomePhoneNr, SemlerVocabularies.Customer.HomePhoneNr);
            AddMapping(LastName, SemlerVocabularies.Customer.LastName);
            AddMapping(MobPhoneNr, SemlerVocabularies.Customer.MobPhoneNr);
            AddMapping(PostalCode, SemlerVocabularies.Customer.PostalCode);

            //Geomatic Common Customer
            AddMapping(AdrFloor, SemlerVocabularies.Customer.AdrFloor);
            AddMapping(AdrHouseChar, SemlerVocabularies.Customer.AdrHouseChar);
            AddMapping(AdrLine1Per1, SemlerVocabularies.Customer.AdrLine1Per1);
            AddMapping(AdrPlace, SemlerVocabularies.Customer.AdrPlace);
            AddMapping(AdrPlacePer1, SemlerVocabularies.Customer.AdrPlacePer1);
            AddMapping(AdrStreet, SemlerVocabularies.Customer.AdrStreet);
            AddMapping(AdrStrNum, SemlerVocabularies.Customer.AdrStrNum);
            AddMapping(AdrSuite, SemlerVocabularies.Customer.AdrSuite);
            AddMapping(COName, SemlerVocabularies.Customer.COName);
            AddMapping(CONamePer1, SemlerVocabularies.Customer.CONamePer1);
            AddMapping(CityPer1, SemlerVocabularies.Customer.CityPer1);
            AddMapping(FirstNamePer1, SemlerVocabularies.Customer.FirstNamePer1);
            AddMapping(LandPhoneNum, SemlerVocabularies.Customer.LandPhoneNum);
            AddMapping(LastNamePer1, SemlerVocabularies.Customer.LastNamePer1);
            AddMapping(Name, SemlerVocabularies.Customer.Name);
            AddMapping(NamePer1, SemlerVocabularies.Customer.NamePer1);
            AddMapping(PostalCodePer1, SemlerVocabularies.Customer.PostalCodePer1);

            //Geomatic Common Customer
            AddMapping(EmailType, SemlerVocabularies.Customer.EmailType);
            AddMapping(PhoneNumber, SemlerVocabularies.Customer.PhoneNumber);
            AddMapping(PhoneType, SemlerVocabularies.Customer.PhoneType);
        }

        public VocabularyKey AccPhone { get; private set; }
        public VocabularyKey AdrFloor { get; private set; }
        public VocabularyKey AdrHouseChar { get; private set; }
        public VocabularyKey AdrLine1 { get; private set; }
        public VocabularyKey AdrLine1Per1 { get; private set; }
        public VocabularyKey AdrPlace { get; private set; }
        public VocabularyKey AdrPlacePer1 { get; private set; }
        public VocabularyKey AdrStrNum { get; private set; }
        public VocabularyKey AdrStreet { get; private set; }
        public VocabularyKey AdrSuite { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey CONamePer1 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CityPer1 { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey FirstNamePer1 { get; private set; }
        public VocabularyKey HomePhoneNr { get; private set; }
        public VocabularyKey LandPhoneNum { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LastNamePer1 { get; private set; }
        public VocabularyKey MobPhoneNr { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NamePer1 { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PostalCodePer1 { get; private set; }
        public VocabularyKey AdrLine2 { get; private set; }
        public VocabularyKey EmailType { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey PhoneType { get; private set; }
        public VocabularyKey Dealer { get; private set; }
    }
}
