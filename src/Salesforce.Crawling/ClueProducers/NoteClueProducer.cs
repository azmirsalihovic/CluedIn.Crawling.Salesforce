// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoteObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the NoteObserver type.
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
    public class NoteClueProducer : BaseClueProducer<Note>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;



        public NoteClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(Note value, Guid id)
        {
            var clue = _factory.Create(EntityType.Note, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Title != null)
            {
                data.Name = value.Title;
                data.DisplayName = value.Title;
                data.Aliases.Add(value.Title);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Note.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.Body != null)
            {
                data.Description = value.Body;
            }

            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Note.IsDeleted] = value.IsDeleted;
            if (value.IsPrivate != null)
                data.Properties[SalesforceVocabulary.Note.IsPrivate] = value.IsPrivate;
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }
            if (value.ParentId != null)
            {
                // TODO: This is wrong; We are missing the context of what the note was for
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
                data.Properties[SalesforceVocabulary.Note.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
