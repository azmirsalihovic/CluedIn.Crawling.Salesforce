using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using CluedIn.Crawling.Salesforce.Core;

namespace CluedIn.Crawling.Salesforce.Factories
{
    public class SalesforceClueFactory : ClueFactory
    {
        public SalesforceClueFactory()
            : base(SalesforceConstants.CodeOrigin, SalesforceConstants.ProviderRootCodeValue)
        {
        }

        protected override Clue ConfigureProviderRoot([NotNull] Clue clue)
        {
            if (clue == null)
            {
                throw new ArgumentNullException(nameof(clue));
            }

            var data = clue.Data.EntityData;
            data.Name = SalesforceConstants.CrawlerName;
            data.Uri = new Uri(SalesforceConstants.Uri);
            data.Description = SalesforceConstants.CrawlerDescription;

            clue.ValidationRuleSuppressions.AddRange(new[] {RuleConstants.PROPERTIES_001_MustExist,});

            clue.ValidationRuleSuppressions.AddRange(new[]
            {
                RuleConstants.METADATA_002_Uri_MustBeSet, RuleConstants.PROPERTIES_002_Unknown_VocabularyKey_Used
            });

            return clue;
        }

    }
}
