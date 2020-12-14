// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedItemObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the FeedItemObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CluedIn.Crawling.Salesforce.Subjects
{
    //public class FeedItemClueProducer : MultiOutputSubjectObserver<FeedItem>
    //{
    //    /// <summary>The factory</summary>
    //    private readonly IClueFactory _factory;



    //    

    //    public FeedItemClueProducer([NotNull] IClueFactory factory, [NotNull] ApplicationContext context)

    //    {
    //        _factory    = factory ?? throw new ArgumentNullException(nameof(factory));

    //        this.context    = context;
    //    }

    //    protected override int GetExpectedCount(FeedItem value, Guid id)
    //    {
    //        return 1 + (value.Comments != null ? value.Comments.Comments.Count : 0);
    //    }

    //    protected override IEnumerable<Clue> MakeClueImpl(FeedItem value, Guid id)
    //    {
    //                    var clue = _factory.Create(EntityType., value.ID, id);
    //        var data = clue.Data.EntityData;

    //        if (value.Actor != null)
    //        {
    //            if (value.Actor.Id != null)
    //            {
    //                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.Actor.Id);
    //                var createdBy = new PersonReference(value.Actor.Name, new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.Actor.Id));
    //                data.Authors.Add(createdBy);
    //            }

    //            if (value.Actor.Id != null)
    //            {
    //                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.Actor.Id);
    //                var createdBy = new PersonReference(value.Actor.Name, new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.Actor.Id));
    //                data.Authors.Add(createdBy);
    //            }
    //        }

    //        if (value.Attachment != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.Attachment] = JsonUtility.Serialize(value.Attachment);
    //            try
    //            {
    //                var attachment = value.Attachment as dynamic;

    //                string checksum = attachment.checksum;
    //                string description = attachment.description;
    //                string downloadUrl = attachment.downloadUrl;
    //                string fileExtension = attachment.fileExtension;
    //                string fileSize = attachment.fileSize;
    //                string fileType = attachment.fileType;
    //                string hasImagePreview = attachment.hasImagePreview;
    //                string hasPdfPreview = attachment.hasPdfPreview;
    //                string id = attachment.id;
    //                string isInMyFileSync = attachment.isInMyFileSync;
    //                string mimeType = attachment.mimeType;
    //                string renditionUrl = attachment.renditionUrl;
    //                string title = attachment.title;
    //                string versionId = attachment.versionId;

    //                if (downloadUrl != null)
    //                {
    //                    downloadUrl = $"{this.state.JobData.Token.Data}/{downloadUrl}";

    //                    using (var webClient = new WebClient())
    //                    {
    //                        webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
    //                        using (var stream = webClient.OpenRead(downloadUrl))
    //                        {
    //                            var inArray = StreamUtilies.ReadFully(stream);
    //                            if (inArray != null)
    //                            {
    //                                var rawDataPart = new CluedIn.Core.Data.Parts.RawDataPart()
    //                                {
    //                                    Type = "/RawData/PreviewImage",
    //                                    MimeType = CluedIn.Core.FileTypes.MimeType.Jpeg.Code,
    //                                    FileName = "preview_{0}".FormatWith(clue.OriginEntityCode.Key),
    //                                    RawDataMD5 = FileHashUtility.GetMD5Base64String(inArray),
    //                                    RawData = Convert.ToBase64String(inArray)
    //                                };

    //                                clue.Details.RawData.Add(rawDataPart);

    //                                clue.Data.EntityData.PreviewImage = new CluedIn.Core.Data.Parts.ImageReferencePart(rawDataPart);
    //                            }
    //                        }
    //                    }

    //                    using (var tempFile = new TemporaryFile($"{value.Id}.{fileExtension}"))
    //                    {
    //                        using (var webClient = new WebClient())
    //                        {
    //                            webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
    //                            using (var stream = webClient.OpenRead(downloadUrl))
    //                            {
    //                                using (var fs = new FileStream(tempFile.FileInfo.FullName, FileMode.OpenOrCreate, FileAccess.Write))
    //                                {
    //                                    stream.CopyTo(fs);
    //                                }
    //                            }

    //                            FileCrawlingUtility.IndexFile(tempFile, clue.Data, clue, state, context);
    //                        }
    //                    }
    //                }
    //            }
    //            catch (Exception exception)
    //            {
    //                state.Log.Warn(() => "Could not download attachment from FeedItem in Salesforce", exception);
    //            }
    //        }
    //        if (value.Body != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.Body] = JsonUtility.Serialize(value.Body);
    //            if (value.Body.Text != null)
    //            {
    //                data.Name = value.Body.Text;
    //                data.DisplayName = value.Body.Text;
    //            }
    //        }

    //        data.Properties[SalesforceVocabulary.FeedItem.CanShare] = value.CanShare.ToString();

    //        if (value.ClientInfo != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.ClientInfo] = JsonUtility.Serialize(value.ClientInfo);

    //            if (value.ClientInfo.ApplicationName != null) data.Properties[SalesforceVocabulary.FeedItem.ClientInfoApplicationName] = value.ClientInfo.ApplicationName;
    //            if (value.ClientInfo.ApplicationUrl != null) data.Properties[SalesforceVocabulary.FeedItem.ClientInfoApplicationUrl] = value.ClientInfo.ApplicationUrl;
    //        }

    //        if (value.Comments != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.Comments] = JsonUtility.Serialize(value.Comments);

    //            foreach (var comment in value.Comments.Comments)
    //            {
    //                var clueComment = CreateComment(comment);
    //                _factory.CreateOutgoingEntityReference(clue, EntityType.Comment, EntityEdgeType.For, comment, v => v.Id);
    //                yield return clueComment;
    //            }
    //        }

    //        data.Properties[SalesforceVocabulary.FeedItem.Event] = value.Event.ToString();

    //        if (value.CreatedDate != null)
    //        {
    //            DateTimeOffset createdDate;
    //            if (DateTimeOffset.TryParse(value.CreatedDate, out createdDate))
    //            {
    //                data.CreatedDate = createdDate;
    //            }
    //        }

    //        if (value.ModifiedDate != null)
    //        {
    //            DateTimeOffset modifiedDate;
    //            if (DateTimeOffset.TryParse(value.ModifiedDate, out modifiedDate))
    //            {
    //                data.ModifiedDate = modifiedDate;
    //            }
    //        }

    //        data.Properties[SalesforceVocabulary.FeedItem.IsBookmarkedByCurrentUser] = value.IsBookmarkedByCurrentUser.ToString();
    //        data.Properties[SalesforceVocabulary.FeedItem.IsDeleteRestricted] = value.IsDeleteRestricted.ToString();
    //        data.Properties[SalesforceVocabulary.FeedItem.IsLikedByCurrentUser] = value.IsLikedByCurrentUser.ToString();

    //        if (value.Likes != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.Likes] = JsonUtility.Serialize(value.Likes);
    //            // TODO: Make request to get likes.
    //        }

    //        if (value.LikesMessage != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.LikesMessage] = JsonUtility.Serialize(value.LikesMessage);
    //            if (value.LikesMessage.Text != null) data.Properties[SalesforceVocabulary.FeedItem.LikesMessageText] = value.LikesMessage.Text;
    //            if (value.LikesMessage.MessageSegments != null) data.Properties[SalesforceVocabulary.FeedItem.LikesMessageMessageSegments] = JsonUtility.Serialize(value.LikesMessage.MessageSegments);
    //            // TODO: Evaludate Message Segments
    //        }

    //        if (value.ModerationFlags != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.ModerationFlags] = JsonUtility.Serialize(value.ModerationFlags);
    //            data.Properties[SalesforceVocabulary.FeedItem.FlagCount]       = value.ModerationFlags.FlagCount.ToString();
    //            data.Properties[SalesforceVocabulary.FeedItem.FlaggedByMe]     = value.ModerationFlags.FlaggedByMe.ToString();
    //            // TODO: Probably need to add the context of 'ME' as this could be added by anyone.
    //        }

    //        if (value.MyLike != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.MyLike]    = JsonUtility.Serialize(value.MyLike);
    //            data.Properties[SalesforceVocabulary.FeedItem.MyLikeId]  = value.MyLike.Id;
    //            data.Properties[SalesforceVocabulary.FeedItem.MyLikeUrl] = value.MyLike.Url;
    //        }

    //        if (value.OriginalFeedItem != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.OriginalFeedItem] = JsonUtility.Serialize(value.OriginalFeedItem);
    //            if (value.OriginalFeedItem.Id != null) data.Properties[SalesforceVocabulary.FeedItem.OriginalFeedItemId] = value.OriginalFeedItem.Id;
    //            if (value.OriginalFeedItem.Url != null) data.Properties[SalesforceVocabulary.FeedItem.OriginalFeedItemUrl] = value.OriginalFeedItem.Url;
    //        }

    //        if (value.OriginalFeedItemActor != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.OriginalFeedItemActor] = JsonUtility.Serialize(value.OriginalFeedItemActor);
    //            _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.For, value.OriginalFeedItemActor, v => v.Id);
    //        }

    //        if (value.Parent != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.Parent] = JsonUtility.Serialize(value.Parent);
    //            _factory.CreateOutgoingEntityReference(clue, EntityType.Activity, EntityEdgeType.Parent, value.Parent, v => v.Id);
    //        }

    //        try
    //        {
    //            if (value.PhotoUrl != null)
    //            {
    //                if (value.Attachment != null)
    //                {
    //                    var attachment = value.Attachment as dynamic;
    //                    string downloadUrl = attachment.downloadUrl;
    //                    if (downloadUrl == null)
    //                    {
    //                        data.Properties[SalesforceVocabulary.FeedItem.PhotoUrl] = value.PhotoUrl;
    //                        if (value.PhotoUrl != null)
    //                        {
    //                            using (var webClient = new WebClient())
    //                            {
    //                                webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
    //                                using (var stream = webClient.OpenRead(value.PhotoUrl))
    //                                {
    //                                    var inArray = StreamUtilies.ReadFully(stream);
    //                                    if (inArray != null)
    //                                    {
    //                                        var rawDataPart = new CluedIn.Core.Data.Parts.RawDataPart()
    //                                        {
    //                                            Type = "/RawData/PreviewImage",
    //                                            MimeType = CluedIn.Core.FileTypes.MimeType.Jpeg.Code,
    //                                            FileName = "preview_{0}".FormatWith(clue.OriginEntityCode.Key),
    //                                            RawDataMD5 = FileHashUtility.GetMD5Base64String(inArray),
    //                                            RawData = Convert.ToBase64String(inArray)
    //                                        };

    //                                        clue.Details.RawData.Add(rawDataPart);

    //                                        clue.Data.EntityData.PreviewImage = new CluedIn.Core.Data.Parts.ImageReferencePart(rawDataPart);
    //                                    }
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            state.Log.Warn(() => "Could not download Thumbnail for FeedItem in Salesforce", exception);
    //        }

    //        if (value.Preamble != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.Preamble] = JsonUtility.Serialize(value.Preamble);
    //            if (value.Preamble.Text != null) data.Properties[SalesforceVocabulary.FeedItem.PreambleText] = value.Preamble.Text;
    //            //if (value.Preamble.MessageSegments != null) data.Properties[SalesforceVocabulary.FeedItem.PreambleMessageSegments] = value.Preamble.MessageSegments;
    //        }
    //        if (value.RelativeCreatedDate != null) data.Properties[SalesforceVocabulary.FeedItem.RelativeCreatedDate] = DateUtilities.GetFormattedDateString(value.RelativeCreatedDate);
    //        if (value.Topics != null)
    //        {
    //            foreach (var topic in value.Topics.Topics)
    //            {
    //                data.Tags.Add(new Tag(topic.ToString()));
    //            }
    //        }

    //        data.Properties[SalesforceVocabulary.FeedItem.Type] = value.Type;

    //        if (value.Url != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.Url] = value.Url;

    //            try
    //            {
    //                data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.Url}");
    //                data.Properties[SalesforceVocabulary.FeedItem.EditUrl] =
    //                    $"{this.state.JobData.Token.Data}/{value.Url}";
    //            }
    //            catch (Exception exc)
    //            {
    //                state.Log.Warn(() => "Could not parse FeedItem Url in Salesforce", exc);
    //            }
    //        }

    //        data.Properties[SalesforceVocabulary.FeedItem.Visibility] = value.Visibility;

    //        _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

    //        yield return clue;
    //    }

    //    /// <summary>Creates the comment.</summary>
    //    /// <param name="value">The value.</param>
    //    /// <returns></returns>
    //    public Clue CreateComment(Comment value, Guid id)
    //    {
    //                    var clue = _factory.Create(EntityType., value.ID, id);
    //        var data = clue.Data.EntityData;

    //        if (value.Body != null)
    //        {
    //            if (value.Body.Text != null)
    //            {
    //                data.Name = value.Body.Text;
    //                data.DisplayName = value.Body.Text;
    //            }

    //            data.Properties[SalesforceVocabulary.FeedItem.PreambleMessageSegments] = value.Body.MessageSegments.PrintIfAvailable(s => string.Join(",", s));
    //        }

    //        if (value.ClientInfo != null)
    //        {
    //            data.Properties[SalesforceVocabulary.FeedItem.ClientInfoApplicationName] = value.ClientInfo.ApplicationName;
    //            data.Properties[SalesforceVocabulary.FeedItem.ClientInfoApplicationUrl]  = value.ClientInfo.ApplicationUrl;
    //        }

    //        data.Properties[SalesforceVocabulary.Comment.IsDeleteRestricted]    = value.IsDeleteRestricted.PrintIfAvailable();
    //        data.Properties[SalesforceVocabulary.Comment.RelativeCreatedDate]   = value.RelativeCreatedDate;

    //        if (value.CreatedDate != null)
    //        {
    //            DateTimeOffset createdDate;

    //            if (DateTimeOffset.TryParse(value.CreatedDate, out createdDate))
    //            {
    //                data.CreatedDate = createdDate;
    //            }
    //        }

    //        if (value.Type != null) data.Properties[SalesforceVocabulary.Comment.Type] = value.Type;

    //        if (value.User != null)
    //        {
    //            _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.User.Id);
    //            var createdBy = new PersonReference(value.User.Name, new EntityCode(EntityType.Person, "Salesforce", value.User.Id));
    //            data.Authors.Add(createdBy);
    //        }

    //        if (value.Parent != null)
    //        {
    //            // TODO: This is wrong. ParentId is not a comment https://developer.salesforce.com/docs/atlas.en-us.api.meta/api/sforce_api_objects_feedcomment.htm
    //            _factory.CreateOutgoingEntityReference(clue, EntityType.Comment, EntityEdgeType.Parent, value, value.Parent.Id);
    //        }

    //        if (value.Likes != null)
    //        {
    //            if (value.Likes.Likes != null)
    //            {
    //                foreach (var like in value.Likes.Likes)
    //                {
    //                    // TODO
    //                }
    //            }
    //        }

    //        try
    //        {
    //            var attachment = value.Attachment as dynamic;

    //            string checksum = attachment.checksum;
    //            string description = attachment.description;
    //            string downloadUrl = attachment.downloadUrl;
    //            string fileExtension = attachment.fileExtension;
    //            string fileSize = attachment.fileSize;
    //            string fileType = attachment.fileType;
    //            string hasImagePreview = attachment.hasImagePreview;
    //            string hasPdfPreview = attachment.hasPdfPreview;
    //            string id = attachment.id;
    //            string isInMyFileSync = attachment.isInMyFileSync;
    //            string mimeType = attachment.mimeType;
    //            string renditionUrl = attachment.renditionUrl;
    //            string title = attachment.title;
    //            string versionId = attachment.versionId;

    //            if (downloadUrl != null)
    //            {
    //                downloadUrl = $"{this.state.JobData.Token.Data}/{downloadUrl}";

    //                using (var webClient = new WebClient())
    //                {
    //                    webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
    //                    using (var stream = webClient.OpenRead(downloadUrl))
    //                    {
    //                        var inArray = StreamUtilies.ReadFully(stream);
    //                        if (inArray != null)
    //                        {
    //                            var rawDataPart = new CluedIn.Core.Data.Parts.RawDataPart()
    //                            {
    //                                Type = "/RawData/PreviewImage",
    //                                MimeType = CluedIn.Core.FileTypes.MimeType.Jpeg.Code,
    //                                FileName = "preview_{0}".FormatWith(clue.OriginEntityCode.Key),
    //                                RawDataMD5 = FileHashUtility.GetMD5Base64String(inArray),
    //                                RawData = Convert.ToBase64String(inArray)
    //                            };

    //                            clue.Details.RawData.Add(rawDataPart);

    //                            clue.Data.EntityData.PreviewImage = new CluedIn.Core.Data.Parts.ImageReferencePart(rawDataPart);
    //                        }
    //                    }
    //                }

    //                using (var tempFile = new TemporaryFile($"{value.Id}.{fileExtension}"))
    //                {
    //                    using (var webClient = new WebClient())
    //                    {
    //                        webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
    //                        using (var stream = webClient.OpenRead(downloadUrl))
    //                        {
    //                            using (var fs = new FileStream(tempFile.FileInfo.FullName, FileMode.OpenOrCreate, FileAccess.Write))
    //                            {
    //                                stream.CopyTo(fs);
    //                            }
    //                        }

    //                        FileCrawlingUtility.IndexFile(tempFile, clue.Data, clue, state, context);
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            state.Log.Warn(() => "Could not download image from comment in FeedItem Observer in Salesforce.", exception);
    //        }

    //        data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.Id}");

    //        _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

    //        return clue;
    //    }
    //}
}
