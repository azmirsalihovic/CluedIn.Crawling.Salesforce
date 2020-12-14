// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PartnerObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the PartnerObserver type.
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
    public class PartnerClueProducer : BaseClueProducer<Partner>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;



        public PartnerClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(Partner value, Guid id)
        {
            var clue = _factory.Create(EntityType.Partner, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Role != null)
            {
                data.Name = value.Role;
                data.DisplayName = value.Role;
                data.Aliases.Add(value.Role);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Partner.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.Role != null)
                data.Properties[SalesforceVocabulary.Partner.Role] = value.Role;
            if (value.AccountFromId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.AccountFromId);
            }
            if (value.AccountToId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.AccountToId);
            }

            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Partner.IsDeleted] = value.IsDeleted;
            if (value.IsPrimary != null)
                data.Properties[SalesforceVocabulary.Partner.IsPrimary] = value.IsPrimary;
            if (value.OpportunityId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Deal, EntityEdgeType.For, value, value.OpportunityId);
            }

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
                data.Properties[SalesforceVocabulary.Partner.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
