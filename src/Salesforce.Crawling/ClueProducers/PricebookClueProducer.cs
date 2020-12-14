// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PricebookObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the PricebookObserver type.
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
    public class PricebookClueProducer : BaseClueProducer<PriceBook2>
    {
        private readonly IClueFactory _factory;



        public PricebookClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(PriceBook2 value, Guid id)
        {
            var clue = _factory.Create(EntityType.Note, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
                data.Aliases.Add(value.Name);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.IsActive != null)
                data.Properties[SalesforceVocabulary.Product.IsActive] = value.IsActive;
            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Product.IsDeleted] = value.IsDeleted;

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
                data.Properties[SalesforceVocabulary.Product.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
