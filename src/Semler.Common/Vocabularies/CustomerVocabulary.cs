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
            Grouping = "/Customer";

            AddGroup("Semler Customer Details", group =>
            {
                //SalesForce
                AccountSource = group.Add(new VocabularyKey("AccountSource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Source"));
                AccPhone = group.Add(new VocabularyKey("AccPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone"));
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                AdrLine1Bill = group.Add(new VocabularyKey("AdrLine1Bill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Billing"));
                AdrLine1Other = group.Add(new VocabularyKey("AdrLine1Other", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Other"));
                AdrLine1Ship = group.Add(new VocabularyKey("AdrLine1Ship", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Shipping"));
                AdrLine2 = group.Add(new VocabularyKey("AdrLine2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2"));
                AdrLine2Other = group.Add(new VocabularyKey("AdrLine2Other", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2 Other"));
                AdrLine2Ship = group.Add(new VocabularyKey("AdrLine2Ship", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2 Shipping"));
                Birthdate = group.Add(new VocabularyKey("Birthdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Birthdate"));
                CityCustomer = group.Add(new VocabularyKey("CityCustomer", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Customer"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                CityShip = group.Add(new VocabularyKey("CityShip", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Shipping"));
                CityBill = group.Add(new VocabularyKey("CityBill", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Billing"));
                CityOther = group.Add(new VocabularyKey("CityOther", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Other"));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Shipping"));
                CountryBill = group.Add(new VocabularyKey("CountryBill", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Billing"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                CountryCodeShip = group.Add(new VocabularyKey("CountryCodeShip", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Shipping"));
                CountryCodeBill = group.Add(new VocabularyKey("CountryCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Billing"));
                CountryCodeOther = group.Add(new VocabularyKey("CountryCodeOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Other"));
                CountryOther = group.Add(new VocabularyKey("CountryOther", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Other"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                CustomerType = group.Add(new VocabularyKey("CustomerType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Type"));
                CVRNumber = group.Add(new VocabularyKey("CVRNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("CVR Number"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                HomePhoneNr = group.Add(new VocabularyKey("HomePhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Home Phone"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                MobPhoneNr = group.Add(new VocabularyKey("MobPhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                PhoneNumbOther = group.Add(new VocabularyKey("PhoneNumbOther", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number Other"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                PostalCodeBill = group.Add(new VocabularyKey("PostalCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Billing"));
                PostalCodeOther = group.Add(new VocabularyKey("PostalCodeOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Other"));
                PostalCodeShip = group.Add(new VocabularyKey("PostalCodeShip", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Shipping"));
                State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State"));
                StateBill = group.Add(new VocabularyKey("StateBill", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State Billing"));
                StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code"));
                StateCodeBill = group.Add(new VocabularyKey("StateCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code Billing"));
                StateCodeOther = group.Add(new VocabularyKey("StateCodeOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code Other"));
                StateCodeShip = group.Add(new VocabularyKey("StateCodeShip", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code Shipping"));
                StateOther = group.Add(new VocabularyKey("StateOther", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State Other"));
                StateShip = group.Add(new VocabularyKey("StateShip", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State Shipping"));
                StreetBill = group.Add(new VocabularyKey("StreetBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2 Billing"));
                Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Title"));
                Website = group.Add(new VocabularyKey("Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible).WithDisplayName("Website"));

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
                //COName = group.Add(new VocabularyKey("COName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("C/O Name"));
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

            //
            //SalesForce (need review)
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
            AddMapping(HomePhoneNr, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(Birthdate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday);
            AddMapping(AdrLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(CityBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(CountryCodeBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            AddMapping(CountryBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName);
            AddMapping(PostalCodeBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            AddMapping(StateBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressState);
            AddMapping(CVRNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            //AddMapping(TaxCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.TaxId);
        }

        public VocabularyKey City { get; private set; }
        public VocabularyKey CityBill { get; private set; }
        public VocabularyKey CityOther { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey CountryBill { get; private set; }
        public VocabularyKey CityShip { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey CountryCodeShip { get; private set; }
        public VocabularyKey CountryCodeBill { get; private set; }
        public VocabularyKey CountryCodeOther { get; private set; }
        public VocabularyKey CountryOther { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey HomePhoneNr { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MobPhoneNr { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PostalCodeBill { get; private set; }
        public VocabularyKey PostalCodeOther { get; private set; }
        public VocabularyKey PostalCodeShip { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StateBill { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateCodeBill { get; private set; }
        public VocabularyKey StateCodeOther { get; private set; }
        public VocabularyKey StateCodeShip { get; private set; }
        public VocabularyKey StateOther { get; private set; }
        public VocabularyKey StateShip { get; private set; }
        public VocabularyKey StreetBill { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Website { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey CVRNumber { get; private set; }
        //public VocabularyKey TaxCode { get; private set; }
        //public VocabularyKey EanNumber { get; private set; }
        public VocabularyKey AdrFloor { get; private set; }
        public VocabularyKey AdrHouseChar { get; private set; }
        public VocabularyKey AdrLine1 { get; private set; }
        public VocabularyKey AdrLine1Bill { get; private set; }
        public VocabularyKey AdrLine1Other { get; private set; }
        public VocabularyKey AdrLine1Ship { get; private set; }
        public VocabularyKey AdrLine2 { get; private set; }
        public VocabularyKey AdrLine2Other { get; private set; }
        public VocabularyKey AdrLine2Ship { get; private set; }
        public VocabularyKey Birthdate { get; private set; }
        public VocabularyKey CityCustomer { get; private set; }
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
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PhoneNumbOther { get; private set; }
        public VocabularyKey NamePer1 { get; private set; }
        public VocabularyKey NamePer2 { get; private set; }
        public VocabularyKey PostalCodePer1 { get; private set; }
        public VocabularyKey PostalCodePer2 { get; private set; }
        public VocabularyKey AccountSource { get; private set; }
        public VocabularyKey AccPhone { get; private set; }
    }
}
