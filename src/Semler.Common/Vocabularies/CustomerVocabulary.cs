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
                AccPhone = group.Add(new VocabularyKey("AccPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Account Phone"));
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                AdrLine1Bill = group.Add(new VocabularyKey("AdrLine1Bill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Billing"));
                AdrLine2 = group.Add(new VocabularyKey("AdrLine2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2"));
                AdrLine2Bill = group.Add(new VocabularyKey("AdrLine2Bill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2 Billing"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                CityBill = group.Add(new VocabularyKey("CityBill", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Billing"));
                CityCustomer = group.Add(new VocabularyKey("CityCustomer", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Customer"));
                CountryBill = group.Add(new VocabularyKey("CountryBill", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Billing"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                CountryCodeBill = group.Add(new VocabularyKey("CountryCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Billing"));
                CustomerNumber = group.Add(new VocabularyKey("CustomerNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Customer Number"));
                CVRNumber = group.Add(new VocabularyKey("CVRNumber", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("CVR Number"));
                Dealer = group.Add(new VocabularyKey("Dealer", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible).WithDisplayName("Dealer"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                HomePhoneNr = group.Add(new VocabularyKey("HomePhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Home Phone"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                MobPhoneNr = group.Add(new VocabularyKey("MobPhoneNr", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumbOther", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number Other"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                PostalCodeBill = group.Add(new VocabularyKey("PostalCodeBill", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Billing"));
                StateBill = group.Add(new VocabularyKey("StateBill", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("State Billing"));
                Website = group.Add(new VocabularyKey("Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible).WithDisplayName("Website"));

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
                MobPhoneNum = group.Add(new VocabularyKey("MobPhoneNum", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone Number"));
                NamePer1 = group.Add(new VocabularyKey("NamePer1", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name Person 1"));
                PostalCodePer1 = group.Add(new VocabularyKey("PostalCodePer1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Person 1"));
                
                //KUK
                EANNumber = group.Add(new VocabularyKey("EANNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("EAN Number"));
                EmailType = group.Add(new VocabularyKey("EmailType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail Type"));
                PhoneType = group.Add(new VocabularyKey("PhoneType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Type"));
                TaxCode = group.Add(new VocabularyKey("TaxCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Code"));
            });

            //CluedIn mapping (need review)
            AddMapping(AdrLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(CVRNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.VatNumber);
            AddMapping(CityBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(CountryBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName);
            AddMapping(CountryCodeBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(MobPhoneNr, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeMobileNumber);
            AddMapping(HomePhoneNr, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomePhoneNumber);
            AddMapping(PhoneNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
            AddMapping(PostalCodeBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            AddMapping(StateBill, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressState);
        }

        public VocabularyKey AccPhone { get; private set; }
        public VocabularyKey AdrFloor { get; private set; }
        public VocabularyKey AdrHouseChar { get; private set; }
        public VocabularyKey AdrLine1 { get; private set; }
        public VocabularyKey AdrLine1Bill { get; private set; }
        public VocabularyKey AdrLine1Per1 { get; private set; }
        public VocabularyKey AdrLine2 { get; private set; }
        public VocabularyKey AdrPlace { get; private set; }
        public VocabularyKey AdrPlacePer1 { get; private set; }
        public VocabularyKey AdrStrNum { get; private set; }
        public VocabularyKey AdrStreet { get; private set; }
        public VocabularyKey AdrSuite { get; private set; }
        public VocabularyKey COName { get; private set; }
        public VocabularyKey CONamePer1 { get; private set; }
        public VocabularyKey CVRNumber { get; private set; }
        public VocabularyKey Dealer { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CityBill { get; private set; }
        public VocabularyKey CityCustomer { get; private set; }
        public VocabularyKey CityPer1 { get; private set; }
        public VocabularyKey CountryBill { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey CountryCodeBill { get; private set; }
        public VocabularyKey CustomerNumber { get; private set; }
        public VocabularyKey EANNumber { get; private set; }
        public VocabularyKey EmailType { get; private set; }
        public VocabularyKey PhoneType { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey FirstNamePer1 { get; private set; }
        public VocabularyKey HomePhoneNr { get; private set; }
        public VocabularyKey LandPhoneNum { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LastNamePer1 { get; private set; }
        public VocabularyKey MobPhoneNr { get; private set; }
        public VocabularyKey MobPhoneNum { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NamePer1 { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PostalCodeBill { get; private set; }
        public VocabularyKey PostalCodePer1 { get; private set; }
        public VocabularyKey StateBill { get; private set; }
        public VocabularyKey AdrLine2Bill { get; private set; }
        public VocabularyKey Website { get; private set; }
    }
}
