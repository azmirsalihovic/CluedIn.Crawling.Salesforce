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
                AccPhone = group.Add(new VocabularyKey("AccPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone"));
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                HomePhoneNr = group.Add(new VocabularyKey("HomePhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Home Phone"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                MainDealerID = group.Add(new VocabularyKey("MainDealerID", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Main Dealer ID"));
                MobPhoneNr = group.Add(new VocabularyKey("MobPhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                
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

                AdrLine2 = group.Add(new VocabularyKey("AdrLine2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2"));
                BelongDealerID = group.Add(new VocabularyKey("BelongDealerID", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Belong Dealer ID"));
                EmailType = group.Add(new VocabularyKey("EmailType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail Type"));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumber", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number"));
                PhoneType = group.Add(new VocabularyKey("PhoneType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Type"));
            });

            AddMapping(AccPhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);//PhoneNumber
            AddMapping(AdrFloor, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressFloorCode);
            AddMapping(AdrLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(AdrLine2, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressState);//HomeAddressState
            AddMapping(AdrPlace, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressState);//HomeAddressState
            AddMapping(AdrStreet, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressStreetName);
            AddMapping(AdrStrNum, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressStreetNumber);
            AddMapping(AdrSuite, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressApartmentCode);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(Country, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(HomePhoneNr, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomePhoneNumber);
            AddMapping(LandPhoneNum, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);//PhoneNumber
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(MobPhoneNr, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeMobileNumber);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
            AddMapping(PhoneNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);//PhoneNumber
            AddMapping(PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);

            AddMapping(AccPhone, SemlerVocabularies.Customer.AccPhone);
            AddMapping(AdrLine1, SemlerVocabularies.Customer.AdrLine1);
            AddMapping(City, SemlerVocabularies.Customer.City);
            AddMapping(Country, SemlerVocabularies.Customer.Country);
            AddMapping(CustomerNumber, SemlerVocabularies.Customer.CustomerNumber);
            AddMapping(Email, SemlerVocabularies.Customer.Email);
            AddMapping(FirstName, SemlerVocabularies.Customer.FirstName);
            AddMapping(HomePhoneNr, SemlerVocabularies.Customer.HomePhoneNr);
            AddMapping(LastName, SemlerVocabularies.Customer.LastName);
            AddMapping(MainDealerID, SemlerVocabularies.Customer.MainDealerID);
            AddMapping(MobPhoneNr, SemlerVocabularies.Customer.MobPhoneNr);
            AddMapping(PostalCode, SemlerVocabularies.Customer.PostalCode);

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

            AddMapping(AdrLine2, SemlerVocabularies.Customer.AdrLine2);
            AddMapping(BelongDealerID, SemlerVocabularies.Customer.BelongDealerID);
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
        public VocabularyKey Country { get; private set; }
        public VocabularyKey CityPer1 { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey MainDealerID { get; private set; }
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
        public VocabularyKey BelongDealerID { get; private set; }
    }
}
