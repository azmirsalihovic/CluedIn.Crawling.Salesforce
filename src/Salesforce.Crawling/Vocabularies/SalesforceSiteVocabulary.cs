using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    public class SalesforceSiteVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceSiteVocabulary"/> class.
        /// </summary>
        public SalesforceSiteVocabulary()
        {
            VocabularyName = "Salesforce Site";
            KeyPrefix      = "salesforce.site";
            KeySeparator   = ".";
            Grouping       = EntityType.Infrastructure.Site;
           
            AddGroup("Salesforce Site Details", group =>
            {
                Status         = group.Add(new VocabularyKey("status"));
                SystemModstamp = group.Add(new VocabularyKey("systemModstamp"));
                EditUrl        = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
    }
}