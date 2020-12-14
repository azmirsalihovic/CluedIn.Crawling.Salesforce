// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the DomainObserver type.
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
    public class DomainClueProducer : BaseClueProducer<DomainObject>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;



        public DomainClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(DomainObject value, Guid id)
        {
            var clue = _factory.Create(EntityType.Infrastructure.Site, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Domain != null)
            {
                data.Name = value.Domain;
                data.DisplayName = value.Domain;
            }

            // TODO: Could this fail? Is this the right name of the JobData?
            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");

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

            //if (value.SystemModstamp != null)
            //    data.Properties[SalesforceVocabulary.Account.SystemModstamp] = value.SystemModstamp;
            //if (value.DomainType != null)
            //    data.Properties[SalesforceVocabulary.Account.DomainType] = value.DomainType;

            if (value.LastModifiedDate != null)
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastModifiedDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
