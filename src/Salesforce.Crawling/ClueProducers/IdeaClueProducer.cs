// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IdeaObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the IdeaObserver type.
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
    public class IdeaClueProducer : BaseClueProducer<Idea>
    {
        private readonly IClueFactory _factory;



        public IdeaClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(Idea value, Guid id)
        {
            var clue = _factory.Create(EntityType.Issue, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Title != null)
            {
                data.Name = value.Title;
                data.DisplayName = value.Title;
                data.Aliases.Add(value.Title);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Idea.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.AttachmentBody != null)
                data.Properties[SalesforceVocabulary.Idea.AttachmentBody] = value.AttachmentBody;
            if (value.AttachmentContentType != null)
                data.Properties[SalesforceVocabulary.Idea.AttachmentContentType] = value.AttachmentContentType;
            if (value.AttachmentLength != null)
                data.Properties[SalesforceVocabulary.Idea.AttachmentLength] = value.AttachmentLength;
            if (value.AttachmentName != null)
                data.Properties[SalesforceVocabulary.Idea.AttachmentName] = value.AttachmentName;
            if (value.Body != null)
            {
                data.Description = value.Body;
            }

            if (value.Categories != null)
                data.Properties[SalesforceVocabulary.Idea.Categories] = value.Categories;
            if (value.Category != null)
                data.Properties[SalesforceVocabulary.Idea.Category] = value.Category;
            if (value.CommunityId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.For, value, value.CommunityId);
            }

            if (value.CreatorFullPhotoUrl != null)
                data.Properties[SalesforceVocabulary.Idea.CreatorFullPhotoUrl] = value.CreatorFullPhotoUrl;
            if (value.CreatorName != null)
                data.Properties[SalesforceVocabulary.Idea.CreatorName] = value.CreatorName;
            if (value.CreatorSmallPhotoUrl != null)
                data.Properties[SalesforceVocabulary.Idea.CreatorSmallPhotoUrl] = value.CreatorSmallPhotoUrl;
            if (value.CurrencyIsoCode != null)
                data.Properties[SalesforceVocabulary.Idea.CurrencyIsoCode] = value.CurrencyIsoCode;
            if (value.IdeaThemeID != null)
                data.Properties[SalesforceVocabulary.Idea.IdeaThemeID] = value.IdeaThemeID;
            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Idea.IsDeleted] = value.IsDeleted;
            if (value.IsHtml != null)
                data.Properties[SalesforceVocabulary.Idea.IsHtml] = value.IsHtml;
            if (value.IsMerged != null)
                data.Properties[SalesforceVocabulary.Idea.IsMerged] = value.IsMerged;
            if (value.LastCommentDate != null)
                data.Properties[SalesforceVocabulary.Idea.LastCommentDate] = DateUtilities.GetFormattedDateString(value.LastCommentDate);
            if (value.LastCommentId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Comment, EntityEdgeType.For, value, value.LastCommentId);
            }

            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Idea.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Idea.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.NumComments != null)
                data.Properties[SalesforceVocabulary.Idea.NumComments] = value.NumComments;
            if (value.ParentIdeaId != null)
                data.Properties[SalesforceVocabulary.Idea.ParentIdeaId] = value.ParentIdeaId;
            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Idea.RecordTypeId] = value.RecordTypeId;
            if (value.Status != null)
                data.Properties[SalesforceVocabulary.Idea.Status] = value.Status;
            if (value.VoteScore != null)
                data.Properties[SalesforceVocabulary.Idea.VoteScore] = value.VoteScore;
            if (value.VoteTotal != null)
                data.Properties[SalesforceVocabulary.Idea.VoteTotal] = value.VoteTotal;

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
                data.Properties[SalesforceVocabulary.Idea.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
