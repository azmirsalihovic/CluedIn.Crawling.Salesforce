using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
	public class PrivateCustomerVocabulary : SimpleVocabulary
    {
        public PrivateCustomerVocabulary()
        {
            VocabularyName = "Semler User";
            KeyPrefix = "semler.user";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.User;

            AddGroup("Semler User Details", group =>
            {
                //SalesForce
                AccountSource = group.Add(new VocabularyKey("AccountSource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Source"));
                AccPhone = group.Add(new VocabularyKey("AccPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone"));
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                AdrLine1Other = group.Add(new VocabularyKey("AdrLine1Other", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Other"));
                AdrLine2 = group.Add(new VocabularyKey("AdrLine2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2"));
                AdrLine2Other = group.Add(new VocabularyKey("AdrLine2Other", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2 Other"));
                Birthdate = group.Add(new VocabularyKey("Birthdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Birthdate"));
               //BussinessPhone = group.Add(new VocabularyKey("BussinessPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Business Phone"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                CityCustomer = group.Add(new VocabularyKey("CityCustomer", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Customer"));
                CityOther = group.Add(new VocabularyKey("CityOther", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Other"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                CountryCodeOther = group.Add(new VocabularyKey("CountryCodeOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Other"));
                CountryOther = group.Add(new VocabularyKey("CountryOther", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Other"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                HomePhoneNr = group.Add(new VocabularyKey("HomePhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Home Phone"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                MobPhoneNr = group.Add(new VocabularyKey("MobPhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone"));
                PhoneNumbOther = group.Add(new VocabularyKey("PhoneNumbOther", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number Other"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                PostalCodeOther = group.Add(new VocabularyKey("PostalCodeOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Other"));
                State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                StateCodeOther = group.Add(new VocabularyKey("StateCodeOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code Other"));
                StateOther = group.Add(new VocabularyKey("StateOther", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State Other"));
                Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Title"));

                //Geomatic
                AdrFloor = group.Add(new VocabularyKey("AdrFloor", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Floor"));
                AdrHouseChar = group.Add(new VocabularyKey("AdrHouseChar", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address House Character"));
                //AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                AdrLine1Per1 = group.Add(new VocabularyKey("AdrLine1Per1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Person 1"));
                AdrLine1Per2 = group.Add(new VocabularyKey("AdrLine1Per2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Person 2"));
                AdrLoc = group.Add(new VocabularyKey("AdrLoc", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Location"));
                AdrLocPer1 = group.Add(new VocabularyKey("AdrLocPer1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Location Person 1"));
                AdrLocPer2 = group.Add(new VocabularyKey("AdrLocPer2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Location Person 2"));
                AdrPlace = group.Add(new VocabularyKey("AdrPlace", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Place"));
                AdrPlacePer1 = group.Add(new VocabularyKey("AdrPlacePer1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Place Person 1"));
                AdrPlacePer2 = group.Add(new VocabularyKey("AdrPlacePer2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Place Person 2"));
                AdrStreet = group.Add(new VocabularyKey("AdrStreet", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Street"));
                AdrStrNum = group.Add(new VocabularyKey("AdrStrNum", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Street Number"));
                AdrSuite = group.Add(new VocabularyKey("AdrSuite", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Suite"));
                //City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                CityPer1 = group.Add(new VocabularyKey("CityPer1", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Person 1"));
                CityPer2 = group.Add(new VocabularyKey("CityPer2", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Person 2"));
                COName = group.Add(new VocabularyKey("COName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name"));
                CONamePer1 = group.Add(new VocabularyKey("CONamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name Person 1"));
                CONamePer2 = group.Add(new VocabularyKey("CONamePer2", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name Person 2"));
                //FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                FirstNamePer1 = group.Add(new VocabularyKey("FirstNamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name Person 1"));
                FirstNamePer2 = group.Add(new VocabularyKey("FirstNamePer2", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name Person 2"));
                ForeignAdr1Per1 = group.Add(new VocabularyKey("ForeignAdr1Per1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 1 Person 1"));
                ForeignAdr1Per2 = group.Add(new VocabularyKey("ForeignAdr1Per2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 1 Person 2"));
                ForeignAdr2Per1 = group.Add(new VocabularyKey("ForeignAdr2Per1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 2 Person 1"));
                ForeignAdr2Per2 = group.Add(new VocabularyKey("ForeignAdr2Per2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 2 Person 2"));
                ForeignAdr3Per1 = group.Add(new VocabularyKey("ForeignAdr3Per1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 3 Person 1"));
                ForeignAdr3Per2 = group.Add(new VocabularyKey("ForeignAdr3Per2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 3 Person 2"));
                ForeignAdr4Per1 = group.Add(new VocabularyKey("ForeignAdr4Per1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 4 Person 1"));
                ForeignAdr4Per2 = group.Add(new VocabularyKey("ForeignAdr4Per2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 4 Person 2"));
                ForeignAdr5Per1 = group.Add(new VocabularyKey("ForeignAdr5Per1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 5 Person 1"));
                ForeignAdr5Per2 = group.Add(new VocabularyKey("ForeignAdr5Per2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Foreign Address 5 Person 2"));
                FullNamePer1 = group.Add(new VocabularyKey("FullNamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Full Name Person 1"));
                FullNamePer2 = group.Add(new VocabularyKey("FullNamePer2", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Full Name Person 2"));
                LandPhoneNum = group.Add(new VocabularyKey("LandPhoneNum", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Landline Phone Number"));
                //LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                LastNamePer1 = group.Add(new VocabularyKey("LastNamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name Person 1"));
                LastNamePer2 = group.Add(new VocabularyKey("LastNamePer2", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name Person 2"));
                MobPhoneNum = group.Add(new VocabularyKey("MobPhoneNum", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone Number"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                NamePer1 = group.Add(new VocabularyKey("NamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name Person 1"));
                NamePer2 = group.Add(new VocabularyKey("NamePer2", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name Person 2"));
                //PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                PostalCodePer1 = group.Add(new VocabularyKey("PostalCodePer1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Person 1"));
                PostalCodePer2 = group.Add(new VocabularyKey("PostalCodePer2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Person 2"));
            });

            //CluedIn (need review)
            AddMapping(AdrLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(CountryOther, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName); //This should be CoutryCode
            AddMapping(CountryCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            AddMapping(PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(AccPhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(Birthdate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday);
            AddMapping(Title, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Title);

            //Geomatic (need review)
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);

            //SalesForce Common Customer
            AddMapping(AccountSource, SemlerVocabularies.Customer.AccountSource);
            AddMapping(AccPhone, SemlerVocabularies.Customer.AccPhone);
            AddMapping(AdrLine1, SemlerVocabularies.Customer.AdrLine1);
            AddMapping(AdrLine1Other, SemlerVocabularies.Customer.AdrLine1Other);
            AddMapping(AdrLine2, SemlerVocabularies.Customer.AdrLine2);
            AddMapping(AdrLine2Other, SemlerVocabularies.Customer.AdrLine2Other);
            AddMapping(Birthdate, SemlerVocabularies.Customer.Birthdate);
            //AddMapping(BussinessPhone, SemlerVocabularies.Customer.BussinessPhone); //This is missing in CustomerVocabulary (this is from Account)
            AddMapping(City, SemlerVocabularies.Customer.City);
            AddMapping(CityCustomer, SemlerVocabularies.Customer.CityCustomer);
            AddMapping(CityOther, SemlerVocabularies.Customer.CityOther);
            AddMapping(CountryCode, SemlerVocabularies.Customer.CountryCode);
            AddMapping(CountryCodeOther, SemlerVocabularies.Customer.CountryCodeOther);
            AddMapping(CountryOther, SemlerVocabularies.Customer.CountryOther);
            AddMapping(CustomerNumber, SemlerVocabularies.Customer.CustomerNumber);
            AddMapping(Email, SemlerVocabularies.Customer.Email);
            AddMapping(FirstName, SemlerVocabularies.Customer.FirstName);
            AddMapping(HomePhoneNr, SemlerVocabularies.Customer.HomePhoneNr);
            AddMapping(LastName, SemlerVocabularies.Customer.LastName);
            AddMapping(MobPhoneNr, SemlerVocabularies.Customer.MobPhoneNr);
            AddMapping(PhoneNumbOther, SemlerVocabularies.Customer.PhoneNumbOther);
            AddMapping(PostalCode, SemlerVocabularies.Customer.PostalCode);
            AddMapping(PostalCodeOther, SemlerVocabularies.Customer.PostalCodeOther);
            AddMapping(State, SemlerVocabularies.Customer.State);
            AddMapping(StateCode, SemlerVocabularies.Customer.StateCode);
            AddMapping(StateCodeOther, SemlerVocabularies.Customer.StateCodeOther);
            AddMapping(StateOther, SemlerVocabularies.Customer.StateOther);
            AddMapping(Title, SemlerVocabularies.Customer.Title);

            //Geomatic Common Customer
            AddMapping(AdrFloor, SemlerVocabularies.Customer.AdrFloor);
            AddMapping(AdrHouseChar, SemlerVocabularies.Customer.AdrHouseChar);
            //AddMapping(AdrLine1, SemlerVocabularies.Customer.AdrLine1);
            AddMapping(AdrLine1Per1, SemlerVocabularies.Customer.AdrLine1Per1);
            AddMapping(AdrLine1Per2, SemlerVocabularies.Customer.AdrLine1Per2);
            AddMapping(AdrLoc, SemlerVocabularies.Customer.AdrLoc);
            AddMapping(AdrLocPer1, SemlerVocabularies.Customer.AdrLocPer1);
            AddMapping(AdrLocPer2, SemlerVocabularies.Customer.AdrLocPer2);
            AddMapping(AdrPlace, SemlerVocabularies.Customer.AdrPlace);
            AddMapping(AdrPlacePer1, SemlerVocabularies.Customer.AdrPlacePer1);
            AddMapping(AdrPlacePer2, SemlerVocabularies.Customer.AdrPlacePer2);
            AddMapping(AdrStreet, SemlerVocabularies.Customer.AdrStreet);
            AddMapping(AdrStrNum, SemlerVocabularies.Customer.AdrStrNum);
            AddMapping(AdrSuite, SemlerVocabularies.Customer.AdrSuite);
            //AddMapping(City, SemlerVocabularies.Customer.City);
            AddMapping(CityPer1, SemlerVocabularies.Customer.CityPer1);
            AddMapping(CityPer2, SemlerVocabularies.Customer.CityPer2);
            AddMapping(COName, SemlerVocabularies.Customer.COName);
            AddMapping(CONamePer1, SemlerVocabularies.Customer.CONamePer1);
            AddMapping(CONamePer2, SemlerVocabularies.Customer.CONamePer2);
            //AddMapping(FirstName, SemlerVocabularies.Customer.FirstName);
            AddMapping(FirstNamePer1, SemlerVocabularies.Customer.FirstNamePer1);
            AddMapping(FirstNamePer2, SemlerVocabularies.Customer.FirstNamePer2);
            AddMapping(ForeignAdr1Per1, SemlerVocabularies.Customer.ForeignAdr1Per1);
            AddMapping(ForeignAdr1Per2, SemlerVocabularies.Customer.ForeignAdr1Per2);
            AddMapping(ForeignAdr2Per1, SemlerVocabularies.Customer.ForeignAdr2Per1);
            AddMapping(ForeignAdr2Per2, SemlerVocabularies.Customer.ForeignAdr2Per2);
            AddMapping(ForeignAdr3Per1, SemlerVocabularies.Customer.ForeignAdr3Per1);
            AddMapping(ForeignAdr3Per2, SemlerVocabularies.Customer.ForeignAdr3Per2);
            AddMapping(ForeignAdr4Per1, SemlerVocabularies.Customer.ForeignAdr4Per1);
            AddMapping(ForeignAdr4Per2, SemlerVocabularies.Customer.ForeignAdr4Per2);
            AddMapping(ForeignAdr5Per1, SemlerVocabularies.Customer.ForeignAdr5Per1);
            AddMapping(ForeignAdr5Per2, SemlerVocabularies.Customer.ForeignAdr5Per2);
            AddMapping(FullNamePer1, SemlerVocabularies.Customer.FullNamePer1);
            AddMapping(FullNamePer2, SemlerVocabularies.Customer.FullNamePer2);
            AddMapping(LandPhoneNum, SemlerVocabularies.Customer.LandPhoneNum);
            //AddMapping(LastName, SemlerVocabularies.Customer.LastName);
            AddMapping(LastNamePer1, SemlerVocabularies.Customer.LastNamePer1);
            AddMapping(LastNamePer2, SemlerVocabularies.Customer.LastNamePer2);
            AddMapping(MobPhoneNum, SemlerVocabularies.Customer.MobPhoneNum);
            AddMapping(Name, SemlerVocabularies.Customer.Name);
            AddMapping(NamePer1, SemlerVocabularies.Customer.NamePer1);
            AddMapping(NamePer2, SemlerVocabularies.Customer.NamePer2);
            //AddMapping(PostalCode, SemlerVocabularies.Customer.PostalCode);
            AddMapping(PostalCodePer1, SemlerVocabularies.Customer.PostalCodePer1);
            AddMapping(PostalCodePer2, SemlerVocabularies.Customer.PostalCodePer2);
        }
        public VocabularyKey AccountSource { get; private set; }
        public VocabularyKey AccPhone { get; private set; }
        public VocabularyKey Birthdate { get; private set; }
        //public VocabularyKey BussinessPhone { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CityCustomer { get; private set; }
        public VocabularyKey CityOther { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey HomePhoneNr { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MobPhoneNr { get; private set; }
        public VocabularyKey PhoneNumbOther { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NamePer1 { get; private set; }
        public VocabularyKey NamePer2 { get; private set; }
        public VocabularyKey PostalCodePer1 { get; private set; }
        public VocabularyKey PostalCodePer2 { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey CountryCodeOther { get; private set; }
        public VocabularyKey CountryOther { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PostalCodeOther { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateCodeOther { get; private set; }
        public VocabularyKey StateOther { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey AdrFloor { get; private set; }
        public VocabularyKey AdrHouseChar { get; private set; }
        public VocabularyKey AdrLine1 { get; private set; }
        public VocabularyKey AdrLine1Other { get; private set; }
        public VocabularyKey AdrLine2 { get; private set; }
        public VocabularyKey AdrLine2Other { get; private set; }
        public VocabularyKey AdrLine1Per1 { get; private set; }
        public VocabularyKey AdrLine1Per2 { get; private set; }
        public VocabularyKey AdrLoc { get; private set; }
        public VocabularyKey AdrLocPer1 { get; private set; }
        public VocabularyKey AdrLocPer2 { get; private set; }
        public VocabularyKey AdrPlace { get; private set; }
        public VocabularyKey AdrPlacePer1 { get; private set; }
        public VocabularyKey AdrPlacePer2 { get; private set; }
        public VocabularyKey AdrStreet { get; private set; }
        public VocabularyKey AdrStrNum { get; private set; }
        public VocabularyKey AdrSuite { get; private set; }
        public VocabularyKey CityPer1 { get; private set; }
        public VocabularyKey CityPer2 { get; private set; }
        public VocabularyKey CONamePer1 { get; private set; }
        public VocabularyKey CONamePer2 { get; private set; }
        public VocabularyKey FirstNamePer1 { get; private set; }
        public VocabularyKey FirstNamePer2 { get; private set; }
        public VocabularyKey ForeignAdr1Per1 { get; private set; }
        public VocabularyKey ForeignAdr1Per2 { get; private set; }
        public VocabularyKey ForeignAdr2Per1 { get; private set; }
        public VocabularyKey ForeignAdr2Per2 { get; private set; }
        public VocabularyKey ForeignAdr3Per1 { get; private set; }
        public VocabularyKey ForeignAdr3Per2 { get; private set; }
        public VocabularyKey ForeignAdr4Per1 { get; private set; }
        public VocabularyKey ForeignAdr4Per2 { get; private set; }
        public VocabularyKey ForeignAdr5Per1 { get; private set; }
        public VocabularyKey ForeignAdr5Per2 { get; private set; }
        public VocabularyKey FullNamePer1 { get; private set; }
        public VocabularyKey FullNamePer2 { get; private set; }
        public VocabularyKey LandPhoneNum { get; private set; }
        public VocabularyKey LastNamePer1 { get; private set; }
        public VocabularyKey LastNamePer2 { get; private set; }
        public VocabularyKey MobPhoneNum { get; private set; }
    }
}
