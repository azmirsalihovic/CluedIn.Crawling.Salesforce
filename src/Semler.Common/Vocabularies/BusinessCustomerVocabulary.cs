using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
	public class BusinessCustomerVocabulary : SimpleVocabulary
    {
        public BusinessCustomerVocabulary()
        {
            VocabularyName = "Semler Organization";
            KeyPrefix = "semler.organization";
            KeySeparator = ".";
            Grouping = EntityType.Organization;

            AddGroup("Semler Organization Details", group =>
            {
                //SalesForce
                AdrLine1Ship = group.Add(new VocabularyKey("AdrLine1Ship", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Shipping"));
                AdrLine2Ship = group.Add(new VocabularyKey("AdrLine2Ship", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2 Shipping"));
                AdrLine1Bill = group.Add(new VocabularyKey("AdrLine1Bill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Billing"));
                CityBill = group.Add(new VocabularyKey("CityBill", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Billing"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                CountryBill = group.Add(new VocabularyKey("CountryBill", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Billing"));
                CountryCodeBill = group.Add(new VocabularyKey("CountryCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Billing"));
                PostalCodeBill = group.Add(new VocabularyKey("PostalCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Billing"));
                StateBill = group.Add(new VocabularyKey("StateBill", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State Billing"));
                StateCodeBill = group.Add(new VocabularyKey("StateCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code Billing"));
                StreetBill = group.Add(new VocabularyKey("StreetBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2 Billing"));
                CityShip = group.Add(new VocabularyKey("CityShip", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Shipping"));
                CountryShip = group.Add(new VocabularyKey("CountryShip", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Shipping"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Shipping"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                CustomerType = group.Add(new VocabularyKey("CustomerType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Type"));
                CVRNumber = group.Add(new VocabularyKey("CVRNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("CVR Number"));
                AccPhone = group.Add(new VocabularyKey("AccPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone"));
                PostalCodeShip = group.Add(new VocabularyKey("PostalCodeShip", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Shipping"));
                StateShip = group.Add(new VocabularyKey("StateShip", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State Shipping"));
                StateCodeShip = group.Add(new VocabularyKey("StateCodeShip", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("State Code Shipping"));
                Website = group.Add(new VocabularyKey("Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible).WithDisplayName("Website"));

                //Geomatic
                AdrFloor = group.Add(new VocabularyKey("AdrFloor", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Floor"));
                AdrHouseChar = group.Add(new VocabularyKey("AdrHouseChar", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address House Character"));
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
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
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
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
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                LastNamePer1 = group.Add(new VocabularyKey("LastNamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name Person 1"));
                LastNamePer2 = group.Add(new VocabularyKey("LastNamePer2", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name Person 2"));
                MobPhoneNum = group.Add(new VocabularyKey("MobPhoneNum", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone Number"));
                //Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                NamePer1 = group.Add(new VocabularyKey("NamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name Person 1"));
                NamePer2 = group.Add(new VocabularyKey("NamePer2", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name Person 2"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                PostalCodePer1 = group.Add(new VocabularyKey("PostalCodePer1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Person 1"));
                PostalCodePer2 = group.Add(new VocabularyKey("PostalCodePer2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Person 2"));

                //KUK
                TaxCode = group.Add(new VocabularyKey("TaxCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Code"));
                EANNumber = group.Add(new VocabularyKey("EANNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("EAN Number"));
            });

            //SalesForce (need review)
            AddMapping(AdrLine1Bill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Address);
            AddMapping(AdrStreet, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressStreetName);
            AddMapping(AdrStrNum, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressStreetNumber);
            AddMapping(BillingCity, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            AddMapping(BillingCountry, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCountryName);
            AddMapping(BillingCountryCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCountryCode);
            AddMapping(BillingPostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressZipCode);
            AddMapping(CVRNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.ContactEmail);

            // SalesForce
            AddMapping(AdrLine1Ship, SemlerVocabularies.Customer.AdrLine1Ship);
            AddMapping(AdrLine2Ship, SemlerVocabularies.Customer.AdrLine2Ship);
            AddMapping(AdrLine1Bill, SemlerVocabularies.Customer.AdrLine1Bill);
            AddMapping(CityBill, SemlerVocabularies.Customer.CityBill);
            AddMapping(City, SemlerVocabularies.Customer.City);
            AddMapping(CountryBill, SemlerVocabularies.Customer.CountryBill);
            AddMapping(CountryCodeBill, SemlerVocabularies.Customer.CountryCodeBill);
            AddMapping(PostalCodeBill, SemlerVocabularies.Customer.PostalCodeBill);
            AddMapping(StateBill, SemlerVocabularies.Customer.StateBill);
            AddMapping(StateCodeBill, SemlerVocabularies.Customer.StateCodeBill);
            AddMapping(StreetBill, SemlerVocabularies.Customer.StreetBill);
            AddMapping(CityShip, SemlerVocabularies.Customer.CityShip);
            AddMapping(CountryShip, SemlerVocabularies.Customer.Country);
            AddMapping(CountryCode, SemlerVocabularies.Customer.CountryCode);
            AddMapping(Name, SemlerVocabularies.Customer.Name);
            AddMapping(CustomerNumber, SemlerVocabularies.Customer.CustomerNumber);
            AddMapping(CustomerType, SemlerVocabularies.Customer.CustomerType);
            AddMapping(CVRNumber, SemlerVocabularies.Customer.CVRNumber);
            AddMapping(AccPhone, SemlerVocabularies.Customer.AccPhone);
            AddMapping(PostalCodeShip, SemlerVocabularies.Customer.PostalCodeShip);
            AddMapping(StateShip, SemlerVocabularies.Customer.StateShip);
            AddMapping(StateCodeShip, SemlerVocabularies.Customer.StateCodeShip);
            AddMapping(Website, SemlerVocabularies.Customer.Website);

            //Geomatic mapping to Semler.Common.Customer
            AddMapping(AdrFloor, SemlerVocabularies.Customer.AdrFloor);
            AddMapping(AdrHouseChar, SemlerVocabularies.Customer.AdrHouseChar);
            AddMapping(AdrLine1, SemlerVocabularies.Customer.AdrLine1);
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
            AddMapping(FirstName, SemlerVocabularies.Customer.FirstName);
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
            AddMapping(LastName, SemlerVocabularies.Customer.LastName);
            AddMapping(LastNamePer1, SemlerVocabularies.Customer.LastNamePer1);
            AddMapping(LastNamePer2, SemlerVocabularies.Customer.LastNamePer2);
            AddMapping(MobPhoneNum, SemlerVocabularies.Customer.MobPhoneNum);
            AddMapping(Name, SemlerVocabularies.Customer.Name);
            AddMapping(NamePer1, SemlerVocabularies.Customer.NamePer1);
            AddMapping(NamePer2, SemlerVocabularies.Customer.NamePer2);
            AddMapping(PostalCode, SemlerVocabularies.Customer.PostalCode);
            AddMapping(PostalCodePer1, SemlerVocabularies.Customer.PostalCodePer1);
            AddMapping(PostalCodePer2, SemlerVocabularies.Customer.PostalCodePer2);
        }

        public VocabularyKey BillingCity { get; private set; }
        public VocabularyKey BillingCountry { get; private set; }
        public VocabularyKey BillingCountryCode { get; private set; }
        public VocabularyKey BillingPostalCode { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryBill { get; private set; }
        public VocabularyKey CountryCodeBill { get; private set; }
        public VocabularyKey PostalCodeBill { get; private set; }
        public VocabularyKey StateBill { get; private set; }
        public VocabularyKey StateCodeBill { get; private set; }
        public VocabularyKey StreetBill { get; private set; }
        public VocabularyKey CityShip { get; private set; }
        public VocabularyKey CountryShip { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey CONamePer1 { get; private set; }
        public VocabularyKey CONamePer2 { get; private set; }
        public VocabularyKey FirstName { get; private set; }
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
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey CVRNumber { get; private set; }
        public VocabularyKey AccPhone { get; private set; }
        public VocabularyKey PostalCodeShip { get; private set; }
        public VocabularyKey StateShip { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LastNamePer1 { get; private set; }
        public VocabularyKey LastNamePer2 { get; private set; }
        public VocabularyKey MobPhoneNum { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NamePer1 { get; private set; }
        public VocabularyKey NamePer2 { get; private set; }
        public VocabularyKey PostalCodePer1 { get; private set; }
        public VocabularyKey PostalCodePer2 { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey EANNumber { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey AdrLine1Ship { get; private set; }
        public VocabularyKey AdrLine2Ship { get; private set; }
        public VocabularyKey AdrLine1Bill { get; private set; }
        public VocabularyKey CityBill { get; private set; }
        public VocabularyKey StateCodeShip { get; private set; }
        public VocabularyKey Website { get; private set; }
        public VocabularyKey AdrFloor { get; private set; }
        public VocabularyKey AdrHouseChar { get; private set; }
        public VocabularyKey AdrLine1 { get; private set; }
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
    }
}
