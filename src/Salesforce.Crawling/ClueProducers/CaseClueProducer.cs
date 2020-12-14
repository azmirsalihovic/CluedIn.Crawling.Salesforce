// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaseObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the CaseObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Utilities;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class CaseClueProducer : BaseClueProducer<Case>
    {
        private readonly IClueFactory _factory;

        public CaseClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(Case value, Guid id)
        {
            var clue = _factory.Create(EntityType.Issue, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Subject != null)
            {
                data.Name = value.Subject;
                data.DisplayName = value.Subject;
            }
            else
            {
                data.Name = $"New Case with ID of {value.ID}";
                data.DisplayName = $"New Case with ID of {value.ID}";
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Case.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.Status != null)
            {
                data.Properties[SalesforceVocabulary.Case.Status] = value.Status;
                data.Tags.Add(new Tag(value.Status));
            }

            if (value.CreatedDate != null)
            {
                DateTimeOffset createdDate;
                if (DateTimeOffset.TryParse(value.CreatedDate, out createdDate))
                {
                    data.CreatedDate = createdDate;
                }
            }

            if (value.LastModifiedDate != null)
            {
                DateTimeOffset modifiedDate;
                if (DateTimeOffset.TryParse(value.LastModifiedDate, out modifiedDate))
                {
                    data.ModifiedDate = modifiedDate;
                }
            }

            if (value.CreatedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
                data.Authors.Add(createdBy);
            }

            if (value.LastModifiedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);
            }

            if (value.SystemModstamp != null)
                data.Properties[SalesforceVocabulary.Case.SystemModstamp] = value.SystemModstamp;
            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, value, value.AccountId);
            }

            if (value.CaseNumber != null)
                data.Properties[SalesforceVocabulary.Case.CaseNumber] = value.CaseNumber;
            if (value.ClosedDate != null)
                data.Properties[SalesforceVocabulary.Case.ClosedDate] = DateUtilities.GetFormattedDateString(value.ClosedDate);
            if (value.CommunityId != null)
            {
                // TODO: Should this reference an org?
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.PartOf, value, value.CommunityId);
            }

            if (value.ConnectionReceivedId != null)
                data.Properties[SalesforceVocabulary.Case.ConnectionReceivedId] = value.ConnectionReceivedId;
            if (value.ConnectionSentId != null)
                data.Properties[SalesforceVocabulary.Case.ConnectionSentId] = value.ConnectionSentId;
            if (value.ContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.For,
               value, value.ContactId);
            }

            //if (value.CreatorFullPhotoUrl != null)
            //{
            //    if (value.CreatorFullPhotoUrl != null)
            //    {
            //        try
            //        {
            //            using (var webClient = new WebClient())
            //            {
            //                webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
            //                using (var stream = webClient.OpenRead(value.CreatorFullPhotoUrl))
            //                {
            //                    var inArray = StreamUtilies.ReadFully(stream);
            //                    if (inArray != null)
            //                    {
            //                        var rawDataPart = new RawDataPart()
            //                        {
            //                            Type = "/RawData/PreviewImage",
            //                            MimeType = CluedIn.Core.FileTypes.MimeType.Jpeg.Code,
            //                            FileName = "preview_{0}".FormatWith(clue.OriginEntityCode.Key),
            //                            RawDataMD5 = FileHashUtility.GetMD5Base64String(inArray),
            //                            RawData = Convert.ToBase64String(inArray)
            //                        };

            //                        clue.Details.RawData.Add(rawDataPart);

            //                        clue.Data.EntityData.PreviewImage = new ImageReferencePart(rawDataPart);
            //                    }
            //                }
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            state.Log.Warn(() => "Could not download Full Photo Url for Creator of Case in Salesforce", ex);
            //        }
            //    }
            //}

            if (value.CreatorName != null)
                data.Properties[SalesforceVocabulary.Case.CreatorName] = value.CreatorName;
            if (value.CreatorSmallPhotoUrl != null)
                data.Properties[SalesforceVocabulary.Case.CreatorSmallPhotoUrl] = value.CreatorSmallPhotoUrl;
            if (value.FeedItemId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.News, EntityEdgeType.For,
               value, value.FeedItemId);
            }

            if (value.HasCommentsUnreadByOwner != null)
                data.Properties[SalesforceVocabulary.Case.HasCommentsUnreadByOwner] = value.HasCommentsUnreadByOwner;
            if (value.HasSelfServiceComments != null)
                data.Properties[SalesforceVocabulary.Case.HasSelfServiceComments] = value.HasSelfServiceComments;
            if (value.IsClosed != null)
                data.Properties[SalesforceVocabulary.Case.IsClosed] = value.IsClosed;
            if (value.IsClosedOnCreate != null)
                data.Properties[SalesforceVocabulary.Case.IsClosedOnCreate] = value.IsClosedOnCreate;
            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Case.IsDeleted] = value.IsDeleted;
            if (value.IsEscalated != null)
                data.Properties[SalesforceVocabulary.Case.IsEscalated] = value.IsEscalated;
            if (value.IsSelfServiceClosed != null)
                data.Properties[SalesforceVocabulary.Case.IsSelfServiceClosed] = value.IsSelfServiceClosed;
            if (value.IsStopped != null)
                data.Properties[SalesforceVocabulary.Case.IsStopped] = value.IsStopped;
            if (value.IsVisibleInSelfService != null)
                data.Properties[SalesforceVocabulary.Case.IsVisibleInSelfService] = value.IsVisibleInSelfService;
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Case.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Case.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.Origin != null)
            {
                data.Tags.Add(new Tag(value.Origin));
                data.Properties[SalesforceVocabulary.Case.Origin] = value.Origin;
            }
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.ParentId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Issue, EntityEdgeType.Parent,
                 value, value.ParentId);
            }

            if (value.Priority != null)
            {
                data.Tags.Add(new Tag(value.Priority));
                data.Properties[SalesforceVocabulary.Case.Priority] = value.Priority;
            }

            if (value.QuestionId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Question, EntityEdgeType.For,
             value, value.QuestionId);
            }

            if (value.Reason != null)
            {
                if (value.Description == null)
                {
                    data.Description = value.Reason;
                }

                data.Properties[SalesforceVocabulary.Case.Reason] = value.Reason;
            }
            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Case.RecordTypeId] = value.RecordTypeId;
            if (value.SlaStartDate != null)
                data.Properties[SalesforceVocabulary.Case.SlaStartDate] = DateUtilities.GetFormattedDateString(value.SlaStartDate);
            if (value.StopStartDate != null)
                data.Properties[SalesforceVocabulary.Case.StopStartDate] = DateUtilities.GetFormattedDateString(value.StopStartDate);
            if (value.Subject != null)
            {
                if (value.Description == null)
                {
                    data.Description = value.Subject;
                }

                data.Properties[SalesforceVocabulary.Case.Subject] = value.Subject;
            }

            if (value.SuppliedCompany != null)
                data.Properties[SalesforceVocabulary.Case.SuppliedCompany] = value.SuppliedCompany;
            if (value.SuppliedEmail != null)
                data.Properties[SalesforceVocabulary.Case.SuppliedEmail] = value.SuppliedEmail;
            if (value.SuppliedName != null)
                data.Properties[SalesforceVocabulary.Case.SuppliedName] = value.SuppliedName;
            if (value.SuppliedPhone != null)
                data.Properties[SalesforceVocabulary.Case.SuppliedPhone] = value.SuppliedPhone;
            if (value.Type != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
                data.Properties[SalesforceVocabulary.Case.Type] = value.Type;
                data.Tags.Add(new Tag(value.Type));
            }

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
