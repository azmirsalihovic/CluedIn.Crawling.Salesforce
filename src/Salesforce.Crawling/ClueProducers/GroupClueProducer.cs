// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GroupObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the GroupObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class GroupClueProducer : BaseClueProducer<Group>
    {
        private readonly IClueFactory _factory;



        public GroupClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(Group value, Guid id)
        {
            var clue = _factory.Create(EntityType.Infrastructure.Group, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            if (value.DefaultDivision != null)
                data.Properties[SalesforceVocabulary.Group.DefaultDivision] = value.DefaultDivision;
            if (value.DeveloperName != null)
                data.Properties[SalesforceVocabulary.Group.DeveloperName] = value.DeveloperName;
            if (value.DoesIncludeBosses != null)
                data.Properties[SalesforceVocabulary.Group.DoesIncludeBosses] = value.DoesIncludeBosses;
            if (value.DoesSendEmailToMembers != null)
                data.Properties[SalesforceVocabulary.Group.DoesSendEmailToMembers] = value.DoesSendEmailToMembers;
            if (value.Email != null)
                data.Properties[SalesforceVocabulary.Group.Email] = value.Email;
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.RelatedId != null)
                data.Properties[SalesforceVocabulary.Group.RelatedId] = value.RelatedId;
            if (value.Type != null)
                data.Properties[SalesforceVocabulary.Group.Type] = value.Type;
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
                data.Properties[SalesforceVocabulary.Group.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
