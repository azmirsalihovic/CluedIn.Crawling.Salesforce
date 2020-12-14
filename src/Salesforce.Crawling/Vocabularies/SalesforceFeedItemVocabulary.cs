// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceFeedItemVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceFeedItemVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce feed item vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceFeedItemVocabulary : SimpleVocabulary
    {
        public SalesforceFeedItemVocabulary()
        {
            VocabularyName = "Salesforce Feed Item";
            KeyPrefix      = "salesforce.feedItem";
            KeySeparator   = ".";
            Grouping       = EntityType.News;

            AddGroup("Salesforce Group Detail Details", group =>
            {
                Attachment                = group.Add(new VocabularyKey("Attachment", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                Body                      = group.Add(new VocabularyKey("Body", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                CanShare                  = group.Add(new VocabularyKey("CanShare", VocabularyKeyDataType.Boolean));
                ClientInfo                = group.Add(new VocabularyKey("ClientInfo", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden).MarkObsoleteSince(CluedIn.Core.Constants.AppVersion_1_4_2_0));
                Comments                  = group.Add(new VocabularyKey("Comments", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden).MarkObsoleteSince(CluedIn.Core.Constants.AppVersion_1_4_2_0));
                Event                     = group.Add(new VocabularyKey("Event"));
                IsBookmarkedByCurrentUser = group.Add(new VocabularyKey("IsBookmarkedByCurrentUser", VocabularyKeyDataType.Boolean));
                IsDeleteRestricted        = group.Add(new VocabularyKey("IsDeleteRestricted", VocabularyKeyDataType.Boolean));
                IsLikedByCurrentUser      = group.Add(new VocabularyKey("IsLikedByCurrentUser", VocabularyKeyDataType.Boolean));
                Likes                     = group.Add(new VocabularyKey("Likes", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                LikesMessage              = group.Add(new VocabularyKey("LikesMessage", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                ModerationFlags           = group.Add(new VocabularyKey("ModerationFlags", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                MyLike                    = group.Add(new VocabularyKey("MyLike", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                OriginalFeedItem          = group.Add(new VocabularyKey("OriginalFeedItem", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                OriginalFeedItemActor     = group.Add(new VocabularyKey("OriginalFeedItemActor", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                Parent                    = group.Add(new VocabularyKey("Parent", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                PhotoUrl                  = group.Add(new VocabularyKey("PhotoUrl", VocabularyKeyDataType.Uri));
                Preamble                  = group.Add(new VocabularyKey("Preamble", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                RelativeCreatedDate       = group.Add(new VocabularyKey("RelativeCreatedDate", VocabularyKeyDataType.DateTime));
                Type                      = group.Add(new VocabularyKey("Type"));
                Url                       = group.Add(new VocabularyKey("Url", VocabularyKeyDataType.Uri));
                Visibility                = group.Add(new VocabularyKey("Visibility"));
                ClientInfoApplicationName = group.Add(new VocabularyKey("ClientInfoApplicationName"));
                ClientInfoApplicationUrl = group.Add(new VocabularyKey("ClientInfoApplicationUrl"));
                LikesMessageText = group.Add(new VocabularyKey("LikesMessageText"));
                LikesMessageMessageSegments = group.Add(new VocabularyKey("LikesMessageMessageSegments"));
                FlagCount = group.Add(new VocabularyKey("FlagCount"));
                FlaggedByMe = group.Add(new VocabularyKey("FlaggedByMe"));
                MyLikeId = group.Add(new VocabularyKey("MyLikeId"));
                MyLikeUrl = group.Add(new VocabularyKey("MyLikeUrl"));
                OriginalFeedItemId = group.Add(new VocabularyKey("OriginalFeedItemId"));
                OriginalFeedItemUrl = group.Add(new VocabularyKey("OriginalFeedItemUrl"));
                PreambleMessageSegments = group.Add(new VocabularyKey("PreambleMessageSegments"));
                PreambleText = group.Add(new VocabularyKey("PreambleText"));
            });

            EditUrl = Add(new VocabularyKey("editUrl"));

            AddMapping(EditUrl, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey Attachment                 { get; protected set; }
        public VocabularyKey Body                       { get; protected set; }
        public VocabularyKey CanShare                   { get; protected set; }
        public VocabularyKey ClientInfo                 { get; protected set; }
        public VocabularyKey Comments                   { get; protected set; }
        public VocabularyKey Event                      { get; protected set; }
        public VocabularyKey IsBookmarkedByCurrentUser  { get; protected set; }
        public VocabularyKey IsDeleteRestricted         { get; protected set; }
        public VocabularyKey IsLikedByCurrentUser       { get; protected set; }
        public VocabularyKey Likes                      { get; protected set; }
        public VocabularyKey LikesMessage               { get; protected set; }
        public VocabularyKey ModerationFlags            { get; protected set; }
        public VocabularyKey MyLike                     { get; protected set; }
        public VocabularyKey OriginalFeedItem           { get; protected set; }
        public VocabularyKey OriginalFeedItemActor      { get; protected set; }
        public VocabularyKey Parent                     { get; protected set; }
        public VocabularyKey PhotoUrl                   { get; protected set; }
        public VocabularyKey Preamble                   { get; protected set; }
        public VocabularyKey RelativeCreatedDate        { get; protected set; }
        public VocabularyKey Type                       { get; protected set; }
        public VocabularyKey Url                        { get; protected set; }
        public VocabularyKey Visibility                 { get; protected set; }
        public VocabularyKey ClientInfoApplicationName { get; set; }
        public VocabularyKey ClientInfoApplicationUrl { get; set; }
        public VocabularyKey LikesMessageText { get; set; }
        public VocabularyKey LikesMessageMessageSegments { get; set; }
        public VocabularyKey FlagCount { get; set; }
        public VocabularyKey FlaggedByMe { get; set; }
        public VocabularyKey MyLikeId { get; set; }
        public VocabularyKey MyLikeUrl { get; set; }
        public VocabularyKey OriginalFeedItemId { get; set; }
        public VocabularyKey OriginalFeedItemUrl { get; set; }
        public VocabularyKey PreambleMessageSegments { get; set; }
        public VocabularyKey PreambleText { get; set; }
    }
}