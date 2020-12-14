// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the OrderObserver type.
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
    public class OrderClueProducer : BaseClueProducer<Order>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;



        public OrderClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(Order value, Guid id)
        {
            var clue = _factory.Create(EntityType.Sales.Order, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
                data.Aliases.Add(value.Name);
            }
            else
            {
                if (value.Description != null)
                {
                    data.Name = value.Description;
                    data.DisplayName = value.Description;
                    data.Aliases.Add(value.Description);
                }
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Order.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.AccountId);
            }

            if (value.ActivatedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.WorkedOn, value, value.ActivatedById);
            }
            if (value.ActivatedDate != null)
                data.Properties[SalesforceVocabulary.Order.ActivatedDate] = DateUtilities.GetFormattedDateString(value.ActivatedDate);
            if (value.BillToContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.For, value, value.BillToContactId);
            }

            if (value.BillingCity != null)
                data.Properties[SalesforceVocabulary.Order.BillingCity] = value.BillingCity;
            if (value.BillingCountry != null)
                data.Properties[SalesforceVocabulary.Order.BillingCountry] = value.BillingCountry;
            if (value.BillingCountryCode != null)
                data.Properties[SalesforceVocabulary.Order.BillingCountryCode] = value.BillingCountryCode;
            if (value.BillingLatitude != null)
                data.Properties[SalesforceVocabulary.Order.BillingLatitude] = value.BillingLatitude;
            if (value.BillingLongitude != null)
                data.Properties[SalesforceVocabulary.Order.BillingLongitude] = value.BillingLongitude;
            if (value.BillingPostalCode != null)
                data.Properties[SalesforceVocabulary.Order.BillingPostalCode] = value.BillingPostalCode;
            if (value.BillingState != null)
                data.Properties[SalesforceVocabulary.Order.BillingState] = value.BillingState;
            if (value.BillingStateCode != null)
                data.Properties[SalesforceVocabulary.Order.BillingStateCode] = value.BillingStateCode;
            if (value.BillingStreet != null)
                data.Properties[SalesforceVocabulary.Order.BillingStreet] = value.BillingStreet;
            if (value.CompanyAuthorizedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.WorkedOn, value, value.CompanyAuthorizedById);
            }
            if (value.CompanyAuthorizedDate != null)
                data.Properties[SalesforceVocabulary.Order.CompanyAuthorizedDate] = DateUtilities.GetFormattedDateString(value.CompanyAuthorizedDate);
            if (value.ContractId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Contract, EntityEdgeType.For, value, value.ContractId);
            }

            if (value.CustomerAuthorizedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.WorkedOn, value, value.CustomerAuthorizedById);
            }

            if (value.CustomerAuthorizedDate != null)
                data.Properties[SalesforceVocabulary.Order.CustomerAuthorizedDate] = DateUtilities.GetFormattedDateString(value.CustomerAuthorizedDate);
            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.EffectiveDate != null)
                data.Properties[SalesforceVocabulary.Order.EffectiveDate] = DateUtilities.GetFormattedDateString(value.EffectiveDate);
            if (value.EndDate != null)
                data.Properties[SalesforceVocabulary.Order.EndDate] = DateUtilities.GetFormattedDateString(value.EndDate);
            if (value.IsReductionOrder != null)
                data.Properties[SalesforceVocabulary.Order.IsReductionOrder] = value.IsReductionOrder;
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Order.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Order.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.OpportunityId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Deal, EntityEdgeType.For, value, value.OpportunityId);
            }

            if (value.OrderNumber != null)
            {
                data.Properties[SalesforceVocabulary.Order.OrderNumber] = value.OrderNumber;
                data.Codes.Add(new EntityCode(EntityType.Sales.Order, SalesforceConstants.CodeOrigin, value.OrderNumber));
            }

            if (value.OrderReferenceNumber != null)
                data.Properties[SalesforceVocabulary.Order.OrderReferenceNumber] = value.OrderReferenceNumber;
            if (value.OriginalOrderId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Order, EntityEdgeType.For, value, value.OriginalOrderId);
            }
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.PoDate != null)
                data.Properties[SalesforceVocabulary.Order.PoDate] = value.PoDate;
            if (value.PoNumber != null)
                data.Properties[SalesforceVocabulary.Order.PoNumber] = value.PoNumber;

            if (value.Pricebook2Id != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Quote, EntityEdgeType.For, value, value.Pricebook2Id);
            }
            if (value.QuoteId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Quote, EntityEdgeType.For, value, value.QuoteId);
            }
            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Order.RecordTypeId] = value.RecordTypeId;
            if (value.ShipToContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.WorkedOn, value, value.ShipToContactId);
            }

            if (value.ShippingCity != null)
                data.Properties[SalesforceVocabulary.Order.ShippingCity] = value.ShippingCity;
            if (value.ShippingCountry != null)
                data.Properties[SalesforceVocabulary.Order.ShippingCountry] = value.ShippingCountry;
            if (value.ShippingCountryCode != null)
                data.Properties[SalesforceVocabulary.Order.ShippingCountryCode] = value.ShippingCountryCode;
            if (value.ShippingLatitude != null)
                data.Properties[SalesforceVocabulary.Order.ShippingLatitude] = value.ShippingLatitude;
            if (value.ShippingLongitude != null)
                data.Properties[SalesforceVocabulary.Order.ShippingLongitude] = value.ShippingLongitude;
            if (value.ShippingPostalCode != null)
                data.Properties[SalesforceVocabulary.Order.ShippingPostalCode] = value.ShippingPostalCode;
            if (value.ShippingState != null)
                data.Properties[SalesforceVocabulary.Order.ShippingState] = value.ShippingState;
            if (value.ShippingStateCode != null)
                data.Properties[SalesforceVocabulary.Order.ShippingStateCode] = value.ShippingStateCode;
            if (value.ShippingStreet != null)
                data.Properties[SalesforceVocabulary.Order.ShippingStreet] = value.ShippingStreet;
            if (value.Status != null)
            {
                data.Properties[SalesforceVocabulary.Order.Status] = value.Status;
                data.Tags.Add(new Tag(value.Status));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Status);
            }

            if (value.StatusCode != null)
                data.Properties[SalesforceVocabulary.Order.StatusCode] = value.StatusCode;
            if (value.TotalAmount != null)
                data.Properties[SalesforceVocabulary.Order.TotalAmount] = value.TotalAmount;
            if (value.Type != null)
            {
                data.Properties[SalesforceVocabulary.Order.Type] = value.Type;
                data.Tags.Add(new Tag(value.Type));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
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
                data.Properties[SalesforceVocabulary.Order.SystemModstamp] = value.SystemModstamp;

            if (value.CreatedDate != null)
                data.CreatedDate = DateTime.Parse(value.CreatedDate);

            if (value.LastModifiedDate != null)
                data.ModifiedDate = DateTime.Parse(value.LastModifiedDate);

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
