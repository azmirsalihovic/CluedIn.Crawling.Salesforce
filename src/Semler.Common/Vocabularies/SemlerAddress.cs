using CluedIn.Core.Data.Vocabularies;

namespace Semler.Common.Vocabularies
{
    public class SemlerAddress : SimpleVocabulary
    {
        public SemlerAddress()
        {
            VocabularyName = "Semler Address";
            KeyPrefix = "semler.address";
            KeySeparator = ".";
            Grouping = "/Customer";

            AddGroup("Semler Address", group =>
            {
                COName = group.Add(new VocabularyKey("CONAME", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                Address1 = group.Add(new VocabularyKey("ADRESS1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                Address2 = group.Add(new VocabularyKey("ADRESS2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey("ZIPCODE", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Town = group.Add(new VocabularyKey("TOWN", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("COUNTRY", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey COName { get; private set; }
        public VocabularyKey Address1 { get; private set; }
        public VocabularyKey Address2 { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey Town { get; private set; }
        public VocabularyKey Country { get; private set; }
    }
}
