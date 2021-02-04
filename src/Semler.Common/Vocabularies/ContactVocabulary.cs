using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
	public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Semler Contact";
            KeyPrefix = "semler.contact";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.Contact;

            AddGroup("Semler Contact Details", group =>
            {
                //SalesForce
                //AdrGeocode = group.Add(new VocabularyKey("AdrGeocode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Geocode"));
                //AdrLatitude = group.Add(new VocabularyKey("AdrLatitude", VocabularyKeyDataType.GeographyCoordinates, VocabularyKeyVisibility.Visible).WithDisplayName("Address Latitute"));
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                AdrLine2 = group.Add(new VocabularyKey("AdrLine2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 2"));
                //AdrLine2Other = group.Add(new VocabularyKey("AdrLine2Other", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Adress Line 2 Other"));
                //AdrLineOther = group.Add(new VocabularyKey("AdrLineOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1 Other"));
                //AdrLongitude = group.Add(new VocabularyKey("AdrLongitude", VocabularyKeyDataType.GeographyCoordinates, VocabularyKeyVisibility.Visible).WithDisplayName("Address Longitude"));
                //AdrState = group.Add(new VocabularyKey("AdrState", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("Address State"));
                AdrStateCode = group.Add(new VocabularyKey("AdrStateCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address State Code"));
                //Birthdate = group.Add(new VocabularyKey("Birthdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Birthdate"));
                //BusinessPhone = group.Add(new VocabularyKey("BusinessPhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Business Phone"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                //CityOther = group.Add(new VocabularyKey("CityOther", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City Other"));
                ContactRole = group.Add(new VocabularyKey("ContactRole", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Contact Role"));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                CountryCode = group.Add(new VocabularyKey("CountryCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code"));
                //CountryCodeOther = group.Add(new VocabularyKey("CountryCodeOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Country Code Other"));
                //CountryOther = group.Add(new VocabularyKey("CountryOther", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country Other"));
                Department = group.Add(new VocabularyKey("Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Department"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                MobPhoneNum = group.Add(new VocabularyKey("MobPhoneNum", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                //OtherState = group.Add(new VocabularyKey("OtherState", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible).WithDisplayName("Other State"));
                //OtherStateCode = group.Add(new VocabularyKey("OtherStateCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Other State Code"));
                //PhoneNumOther = group.Add(new VocabularyKey("PhoneNumOther", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Phone Number Other"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
                //PostalCodeOther = group.Add(new VocabularyKey("PostalCodeOther", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code Other"));

            });

            //(need review)
            AddMapping(AdrLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            //AddMapping(Birthdate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday);
            //AddMapping(BusinessPhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(Country, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Country);
            AddMapping(CountryCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            AddMapping(Department, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Department);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
            AddMapping(PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
        }

        //public VocabularyKey AdrGeocode { get; private set; }
        //public VocabularyKey AdrLatitude { get; private set; }
        public VocabularyKey AdrLine1 { get; private set; }
        public VocabularyKey AdrLine2 { get; private set; }
        //public VocabularyKey AdrLine2Other { get; private set; }
        //public VocabularyKey AdrLineOther { get; private set; }
        //public VocabularyKey AdrLongitude { get; private set; }
        //public VocabularyKey AdrState { get; private set; }
        public VocabularyKey AdrStateCode { get; private set; }
        //public VocabularyKey Birthdate { get; private set; }
        //public VocabularyKey BusinessPhone { get; private set; }
        public VocabularyKey City { get; private set; }
        //public VocabularyKey CityOther { get; private set; }
        public VocabularyKey ContactRole { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        //public VocabularyKey CountryCodeOther { get; private set; }
        //public VocabularyKey CountryOther { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MobPhoneNum { get; private set; }
        public VocabularyKey Name { get; private set; }
        //public VocabularyKey OtherState { get; private set; }
        //public VocabularyKey OtherStateCode { get; private set; }
        //public VocabularyKey PhoneNumOther { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        //public VocabularyKey PostalCodeOther { get; private set; }
    }
}
