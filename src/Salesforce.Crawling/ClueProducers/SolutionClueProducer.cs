// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolutionObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SolutionObserver type.
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
    public class SolutionClueProducer : BaseClueProducer<Solution>
    {
        private readonly IClueFactory _factory;



        public SolutionClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Solution value, Guid id)
        {
            var clue = _factory.Create(EntityType.Note, value.ID, id);
            var data = clue.Data.EntityData;

            data.Name = value.SolutionName;
            data.Description = value.SolutionNote;
            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Solution.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.CreatedDate != null)
                data.CreatedDate = DateTime.Parse(value.CreatedDate);
            if (value.LastModifiedDate != null)
                data.ModifiedDate = DateTime.Parse(value.LastModifiedDate);

            data.Properties[SalesforceVocabulary.Solution.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            data.Properties[SalesforceVocabulary.Solution.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            data.Properties[SalesforceVocabulary.Solution.Status] = value.Status;
            data.Properties[SalesforceVocabulary.Solution.SystemModstamp] = value.SystemModstamp;
            data.Properties[SalesforceVocabulary.Solution.ID] = value.ID;
            data.Properties[SalesforceVocabulary.Solution.IsDeleted] = value.IsDeleted;
            data.Properties[SalesforceVocabulary.Solution.IsHtml] = value.IsHtml;
            data.Properties[SalesforceVocabulary.Solution.IsOutOfDate] = value.IsOutOfDate;
            data.Properties[SalesforceVocabulary.Solution.IsPublished] = value.IsPublished;
            data.Properties[SalesforceVocabulary.Solution.IsPublishedInPublicKb] = value.IsPublishedInPublicKb;
            data.Properties[SalesforceVocabulary.Solution.IsReviewed] = value.IsReviewed;
            data.Properties[SalesforceVocabulary.Solution.ParentId] = value.ParentId;
            data.Properties[SalesforceVocabulary.Solution.RecordTypeId] = value.RecordTypeId;
            data.Properties[SalesforceVocabulary.Solution.SolutionLanguage] = value.SolutionLanguage;
            data.Properties[SalesforceVocabulary.Solution.SolutionNumber] = value.SolutionNumber;
            data.Properties[SalesforceVocabulary.Solution.TimesUsed] = value.TimesUsed;

            if (value.CreatedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
                data.Authors.Add(createdBy);

                data.Properties[SalesforceVocabulary.Solution.CreatedByName] = value.CreatedById;
            }

            if (value.LastModifiedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);
            }

            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var ownedBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(ownedBy);

                data.Properties[SalesforceVocabulary.Solution.OwnedByName] = value.OwnerId;
            }

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
