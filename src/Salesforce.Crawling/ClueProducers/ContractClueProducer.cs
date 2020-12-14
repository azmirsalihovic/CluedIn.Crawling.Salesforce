// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContractObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the ContractObserver type.
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
    public class ContractClueProducer : BaseClueProducer<Contract>
    {
        private readonly IClueFactory _factory;

        public ContractClueProducer([NotNull] IClueFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Contract value, Guid id)
        {
            var clue = _factory.Create(EntityType.Sales.Contract, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.ContractTerm != null)
            {
                data.Name = value.ContractTerm;
                data.DisplayName = value.ContractTerm;
                data.Aliases.Add(value.ContractTerm);
            }

            if (value.Description != null)
                data.Description = value.Description;
            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, value, value.AccountId);
            }

            if (value.ActivatedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.WorkedOn, value, value.ActivatedById);
            }

            if (value.ActivatedDate != null)
                data.Properties[SalesforceVocabulary.Contract.ActivatedDate] = DateUtilities.GetFormattedDateString(value.ActivatedDate);
            if (value.BillingAddress != null)
                data.Properties[SalesforceVocabulary.Contract.BillingAddress] = value.BillingAddress;
            if (value.BillingCity != null)
                data.Properties[SalesforceVocabulary.Contract.BillingCity] = value.BillingCity;
            if (value.BillingCountry != null)
                data.Properties[SalesforceVocabulary.Contract.BillingCountry] = value.BillingCountry;
            if (value.BillingCountryCode != null)
                data.Properties[SalesforceVocabulary.Contract.BillingCountryCode] = value.BillingCountryCode;
            if (value.BillingLatitude != null)
                data.Properties[SalesforceVocabulary.Contract.BillingLatitude] = value.BillingLatitude;
            if (value.BillingLongitude != null)
                data.Properties[SalesforceVocabulary.Contract.BillingLongitude] = value.BillingLongitude;
            if (value.BillingPostalCode != null)
                data.Properties[SalesforceVocabulary.Contract.BillingPostalCode] = value.BillingPostalCode;
            if (value.BillingState != null)
                data.Properties[SalesforceVocabulary.Contract.BillingState] = value.BillingState;
            if (value.BillingStateCode != null)
                data.Properties[SalesforceVocabulary.Contract.BillingStateCode] = value.BillingStateCode;
            if (value.BillingStreet != null)
                data.Properties[SalesforceVocabulary.Contract.BillingStreet] = value.BillingStreet;
            if (value.CompanySignedDate != null)
                data.Properties[SalesforceVocabulary.Contract.CompanySignedDate] = DateUtilities.GetFormattedDateString(value.CompanySignedDate);
            if (value.CompanySignedId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.CompanySignedId);
            }

            if (value.ContractNumber != null)
            {
                data.Properties[SalesforceVocabulary.Contract.ContractNumber] = value.ContractNumber;
                data.Codes.Add(new EntityCode(EntityType.Sales.Contract, SalesforceConstants.CodeOrigin, value.ContractNumber));
            }

            if (value.ContractTerm != null)
                data.Properties[SalesforceVocabulary.Contract.ContractTerm] = value.ContractTerm;
            if (value.CustomerSignedDate != null)
                data.Properties[SalesforceVocabulary.Contract.CustomerSignedDate] = DateUtilities.GetFormattedDateString(value.CustomerSignedDate);
            if (value.CustomerSignedId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.For, value, value.CustomerSignedId);
            }

            if (value.CustomerSignedTitle != null)
                data.Properties[SalesforceVocabulary.Contract.CustomerSignedTitle] = value.CustomerSignedTitle;
            if (value.EndDate != null)
                data.Properties[SalesforceVocabulary.Contract.EndDate] = DateUtilities.GetFormattedDateString(value.EndDate);

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Contract.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Contract.IsDeleted] = value.IsDeleted;
            if (value.LastApprovedDate != null)
                data.Properties[SalesforceVocabulary.Contract.LastApprovedDate] = DateUtilities.GetFormattedDateString(value.LastApprovedDate);
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Contract.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Contract.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Contract.RecordTypeId] = value.RecordTypeId;

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
                data.Properties[SalesforceVocabulary.Contract.SystemModstamp] = value.SystemModstamp;
            if (value.OwnerExpirationNotice != null)
                data.Properties[SalesforceVocabulary.Contract.OwnerExpirationNotice] = value.OwnerExpirationNotice;
            if (value.Pricebook2Id != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Quote, EntityEdgeType.For, value, value.Pricebook2Id);
                data.Properties[SalesforceVocabulary.Contract.Pricebook2Id] = value.Pricebook2Id;
            }

            if (value.ShippingAddress != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingAddress] = value.ShippingAddress;
            if (value.ShippingCity != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingCity] = value.ShippingCity;
            if (value.ShippingCountry != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingCountry] = value.ShippingCountry;
            if (value.ShippingCountryCode != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingCountryCode] = value.ShippingCountryCode;
            if (value.ShippingLatitude != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingLatitude] = value.ShippingLatitude;
            if (value.ShippingLongitude != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingLongitude] = value.ShippingLongitude;
            if (value.ShippingPostalCode != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingPostalCode] = value.ShippingPostalCode;
            if (value.ShippingState != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingState] = value.ShippingState;
            if (value.ShippingStateCode != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingStateCode] = value.ShippingStateCode;
            if (value.ShippingStreet != null)
                data.Properties[SalesforceVocabulary.Contract.ShippingStreet] = value.ShippingStreet;
            if (value.SpecialTerms != null)
                data.Properties[SalesforceVocabulary.Contract.SpecialTerms] = value.SpecialTerms;
            if (value.StartDate != null)
                data.Properties[SalesforceVocabulary.Contract.StartDate] = DateUtilities.GetFormattedDateString(value.StartDate);
            if (value.Status != null)
            {
                data.Properties[SalesforceVocabulary.Contract.Status] = value.Status;
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Status);
                data.Tags.Add(new Tag(value.Status));
            }

            if (value.StatusCode != null)
                data.Properties[SalesforceVocabulary.Contract.StatusCode] = value.StatusCode;
            if (value.Type != null)
            {
                data.Properties[SalesforceVocabulary.Contract.Type] = value.Type;
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
                data.Tags.Add(new Tag(value.Type));
            }

            if (value.TotalAmount != null)
                data.Properties[SalesforceVocabulary.Contract.TotalAmount] = value.TotalAmount;
            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Contract.RecordTypeId] = value.RecordTypeId;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
