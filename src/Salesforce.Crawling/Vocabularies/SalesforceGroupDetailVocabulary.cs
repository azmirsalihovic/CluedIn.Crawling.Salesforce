// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceGroupDetailVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceGroupDetailVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce group detail vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceGroupDetailVocabulary : SimpleVocabulary
    {
        public SalesforceGroupDetailVocabulary()
        {
            VocabularyName = "Salesforce Group Detail";
            KeyPrefix      = "salesforce.groupDetail";
            KeySeparator   = ".";
            Grouping       = EntityType.Infrastructure.Group;

            AddGroup("Salesforce Group Detail Details", group =>
            {
                CanHaveChatterGuests  = group.Add(new VocabularyKey("CanHaveChatterGuests", VocabularyKeyDataType.Boolean));
                Community             = group.Add(new VocabularyKey("Community", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                EmailToChatterAddress = group.Add(new VocabularyKey("EmailToChatterAddress", VocabularyKeyDataType.Email));
                FileCount             = group.Add(new VocabularyKey("FileCount", VocabularyKeyDataType.Number));
                Information           = group.Add(new VocabularyKey("Information", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                LastFeedItemPostDate  = group.Add(new VocabularyKey("LastFeedItemPostDate", VocabularyKeyDataType.DateTime));
                MemberCount           = group.Add(new VocabularyKey("MemberCount", VocabularyKeyDataType.Number));
                MyRole                = group.Add(new VocabularyKey("MyRole"));
                Motif                 = group.Add(new VocabularyKey("Motif", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                MySubscription        = group.Add(new VocabularyKey("MySubscription", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                Owner                 = group.Add(new VocabularyKey("Owner", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                Photo                 = group.Add(new VocabularyKey("Photo", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                Type                  = group.Add(new VocabularyKey("Type"));
                Visibility            = group.Add(new VocabularyKey("Visibility"));
                Url                   = group.Add(new VocabularyKey("Url", VocabularyKeyDataType.Uri));
                InformationText = group.Add(new VocabularyKey("InformationText"));
                InformationTitle = group.Add(new VocabularyKey("InformationTitle"));
                MotifColor = group.Add(new VocabularyKey("MotifColor"));
                MotifLargeIconUrl = group.Add(new VocabularyKey("MotifLargeIconUrl"));
                MotifMediumIconUrl = group.Add(new VocabularyKey("MotifMediumIconUrl"));
                MotifSmallIconUrl = group.Add(new VocabularyKey("MotifSmallIconUrl"));
                MySubscriptionId = group.Add(new VocabularyKey("MySubscriptionId"));
                MySubscriptionUrl = group.Add(new VocabularyKey("MySubscriptionUrl"));
            });

            EditUrl = Add(new VocabularyKey("editUrl"));

            AddMapping(EditUrl, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey CanHaveChatterGuests   { get; protected set; }
        public VocabularyKey Community              { get; protected set; }
        public VocabularyKey EmailToChatterAddress  { get; protected set; }
        public VocabularyKey FileCount              { get; protected set; }
        public VocabularyKey Information            { get; protected set; }
        public VocabularyKey LastFeedItemPostDate   { get; protected set; }
        public VocabularyKey MemberCount            { get; protected set; }
        public VocabularyKey MyRole                 { get; protected set; }
        public VocabularyKey Motif                  { get; protected set; }
        public VocabularyKey MySubscription         { get; protected set; }
        public VocabularyKey Owner                  { get; protected set; }
        public VocabularyKey Photo                  { get; protected set; }
        public VocabularyKey Type                   { get; protected set; }
        public VocabularyKey Visibility             { get; protected set; }
        public VocabularyKey Url                    { get; protected set; }
        public VocabularyKey InformationText { get; set; }
        public VocabularyKey InformationTitle { get; set; }
        public VocabularyKey MotifColor { get; set; }
        public VocabularyKey MotifLargeIconUrl { get; set; }
        public VocabularyKey MotifMediumIconUrl { get; set; }
        public VocabularyKey MotifSmallIconUrl { get; set; }
        public VocabularyKey MySubscriptionId { get; set; }
        public VocabularyKey MySubscriptionUrl { get; set; }
    }
}