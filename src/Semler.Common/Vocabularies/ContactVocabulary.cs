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
                AdrLine1 = group.Add(new VocabularyKey("AdrLine1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line 1"));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible).WithDisplayName("City"));
                ContactRole = group.Add(new VocabularyKey("ContactRole", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Contact Role"));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible).WithDisplayName("Country"));
                Department = group.Add(new VocabularyKey("Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Department"));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible).WithDisplayName("E-mail"));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name"));
                HomePhoneNr = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Home Phone"));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name"));
                MobPhoneNum = group.Add(new VocabularyKey("MobPhoneNum", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible).WithDisplayName("Mobile Phone"));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code"));
            });

            //(need review)
            AddMapping(AdrLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            AddMapping(Country, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryName);
            AddMapping(Department, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Department);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(HomePhoneNr, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomePhoneNumber);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(MobPhoneNum, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MobileNumber);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
            AddMapping(PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
        }

        public VocabularyKey AdrLine1 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey ContactRole { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey HomePhoneNr { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MobPhoneNum { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
    }
}
