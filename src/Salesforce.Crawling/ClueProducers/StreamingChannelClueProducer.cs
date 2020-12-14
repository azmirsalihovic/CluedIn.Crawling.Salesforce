// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StreamingChannelObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the StreamingChannelObserver type.
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
    public class StreamingChannelClueProducer : BaseClueProducer<StreamingChannel>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;



        public StreamingChannelClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(StreamingChannel value, Guid id)
        {
            var clue = _factory.Create(EntityType.Channel, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
            }

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");

            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Solution.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Solution.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.CreatedDate != null)
                data.CreatedDate = DateTime.Parse(value.CreatedDate);
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

            if (value.LastModifiedDate != null)
                data.ModifiedDate = DateTime.Parse(value.LastModifiedDate);
            if (value.SystemModstamp != null)
                data.Properties[SalesforceVocabulary.Solution.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
