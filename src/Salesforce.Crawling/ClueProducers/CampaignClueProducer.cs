// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the CampaignObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Vocabularies;
using CluedIn.Core.Utilities;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class CampaignClueProducer : BaseClueProducer<Campaign>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;

        public CampaignClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Campaign value, Guid id)
        {
            var clue = _factory.Create(EntityType.Marketing.Campaign, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Campaign.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.Status != null)
            {
                data.Properties[SalesforceVocabulary.Campaign.Status] = value.Status;
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Status);
                data.Tags.Add(new Tag(value.Status));
            }

            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Campaign.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);

            // TODO: This might cause a lot of noise.
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Campaign.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.ParentId != null)
            {
                // TODO: This is wrong. ParentId is not a person
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.Parent,
                 value, value.ParentId);
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
                data.Properties[SalesforceVocabulary.Campaign.SystemModstamp] = value.SystemModstamp;
            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Campaign.RecordTypeId] = value.RecordTypeId;
            if (!string.IsNullOrEmpty(value.Type))
            {
                data.Tags.Add(new Tag(value.Type));
                data.Properties[SalesforceVocabulary.Campaign.Type] = value.Type;
            }

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
