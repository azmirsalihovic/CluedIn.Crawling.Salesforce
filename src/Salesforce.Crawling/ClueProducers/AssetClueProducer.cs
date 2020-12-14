// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssetObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the AssetObserver type.
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
    public class AssetClueProducer : BaseClueProducer<Asset>
    {
        private readonly IClueFactory _factory;


        public AssetClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Asset value, Guid id)
        {
            var clue = _factory.Create(EntityType.Note, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            // TODO: Could this fail? Is this the right name of the JobData?
            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Asset.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

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

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.AccountId);
            }

            if (value.ContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.For, value, value.ContactId);
            }

            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.Owns, value, value.OwnerId);
            }

            if (value.ParentId != null)
            {
                // TODO: This is wrong. ParentId refers to the parent asset
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.Parent, value, value.ParentId);
            }

            if (value.Product2Id != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.For, value, value.Product2Id);
            }

            //if (value.SystemModstamp != null)
            //    data.Properties[SalesforceVocabulary.Account.SystemModstamp] = value.SystemModstamp;
            if (value.InstallDate != null)
                data.Properties[SalesforceVocabulary.Asset.InstallDate] = DateUtilities.GetFormattedDateString(value.InstallDate);
            if (value.IsCompetitorProduct != null)
                data.Properties[SalesforceVocabulary.Asset.IsCompetitorProduct] = value.IsCompetitorProduct;
            if (value.Price != null)
                data.Properties[SalesforceVocabulary.Asset.Price] = value.Price;
            if (value.PurchaseDate != null)
                data.Properties[SalesforceVocabulary.Asset.PurchaseDate] = DateUtilities.GetFormattedDateString(value.PurchaseDate);
            if (value.Quantity != null)
                data.Properties[SalesforceVocabulary.Asset.Quantity] = value.Quantity;
            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Asset.RecordTypeId] = value.RecordTypeId;
            if (value.SerialNumber != null)
                data.Properties[SalesforceVocabulary.Asset.SerialNumber] = value.SerialNumber;
            if (value.Status != null)
                data.Properties[SalesforceVocabulary.Asset.Status] = value.Status;
            if (value.UsageEndDate != null)
                data.Properties[SalesforceVocabulary.Asset.UsageEndDate] = value.UsageEndDate;
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
