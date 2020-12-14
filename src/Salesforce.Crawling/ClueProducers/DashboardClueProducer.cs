// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DashboardObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the DashboardObserver type.
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
    public class DashboardClueProducer : BaseClueProducer<Dashboard>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;

        public DashboardClueProducer([NotNull] IClueFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Dashboard value, Guid id)
        {
            var clue = _factory.Create(EntityType.Planning.Workspace, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Title != null)
            {
                data.Name = value.Title;
                data.DisplayName = value.Title;
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");

            if (value.Description != null)
            {
                data.Description = value.Description;
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

            if (value.SystemModstamp != null)
                data.Properties[SalesforceVocabulary.Case.SystemModstamp] = value.SystemModstamp;

            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Case.IsDeleted] = value.IsDeleted;
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Case.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Case.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);

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
