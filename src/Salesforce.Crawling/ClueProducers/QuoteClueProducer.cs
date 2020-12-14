// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuoteObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the QuoteObserver type.
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
    public class QuoteClueProducer : BaseClueProducer<Quote>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;



        public QuoteClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(Quote value, Guid id)
        {
            var clue = _factory.Create(EntityType.Sales.Quote, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
                data.Aliases.Add(value.Name);
            }

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, value, value.AccountId);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Quote.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            data.Properties[SalesforceVocabulary.Quote.AdditionalAddress] = value.AdditionalAddress;
            data.Properties[SalesforceVocabulary.Quote.AdditionalCity] = value.AdditionalCity;
            data.Properties[SalesforceVocabulary.Quote.AdditionalCountry] = value.AdditionalCountry;
            data.Properties[SalesforceVocabulary.Quote.AdditionalCountryCode] = value.AdditionalCountryCode;
            data.Properties[SalesforceVocabulary.Quote.AdditionalLatitude] = value.AdditionalLatitude;
            data.Properties[SalesforceVocabulary.Quote.AdditionalLongitude] = value.AdditionalLongitude;
            data.Properties[SalesforceVocabulary.Quote.AdditionalName] = value.AdditionalName;
            data.Properties[SalesforceVocabulary.Quote.AdditionalPostalCode] = value.AdditionalPostalCode;
            data.Properties[SalesforceVocabulary.Quote.AdditionalState] = value.AdditionalState;
            data.Properties[SalesforceVocabulary.Quote.AdditionalStateCode] = value.AdditionalStateCode;
            data.Properties[SalesforceVocabulary.Quote.AdditionalStreet] = value.AdditionalStreet;
            data.Properties[SalesforceVocabulary.Quote.BillingAddress] = value.BillingAddress;
            data.Properties[SalesforceVocabulary.Quote.BillingCity] = value.BillingCity;
            data.Properties[SalesforceVocabulary.Quote.BillingCountry] = value.BillingCountry;
            data.Properties[SalesforceVocabulary.Quote.BillingCountryCode] = value.BillingCountryCode;
            data.Properties[SalesforceVocabulary.Quote.BillingLatitude] = value.BillingLatitude;
            data.Properties[SalesforceVocabulary.Quote.BillingLongitude] = value.BillingLongitude;
            data.Properties[SalesforceVocabulary.Quote.BillingName] = value.BillingName;
            data.Properties[SalesforceVocabulary.Quote.BillingPostalCode] = value.BillingPostalCode;
            data.Properties[SalesforceVocabulary.Quote.BillingState] = value.BillingState;
            data.Properties[SalesforceVocabulary.Quote.BillingStateCode] = value.BillingStateCode;
            data.Properties[SalesforceVocabulary.Quote.BillingStreet] = value.BillingStreet;

            if (value.ContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.For, value, value.ContactId);
            }

            if (value.ContractId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Contract, EntityEdgeType.For, value, value.ContractId);
            }

            data.Properties[SalesforceVocabulary.Quote.CurrencyIsoCode] = value.CurrencyIsoCode;

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            data.Properties[SalesforceVocabulary.Quote.Discount] = value.Discount;
            data.Properties[SalesforceVocabulary.Quote.Email] = value.Email;
            data.Properties[SalesforceVocabulary.Quote.ExpirationDate] = DateUtilities.GetFormattedDateString(value.ExpirationDate);
            data.Properties[SalesforceVocabulary.Quote.Fax] = value.Fax;
            data.Properties[SalesforceVocabulary.Quote.GrandTotal] = value.GrandTotal;
            data.Properties[SalesforceVocabulary.Quote.IsSyncing] = value.IsSyncing;
            data.Properties[SalesforceVocabulary.Quote.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            data.Properties[SalesforceVocabulary.Quote.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            data.Properties[SalesforceVocabulary.Quote.LineItemCount] = value.LineItemCount;

            if (value.OpportunityId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Deal, EntityEdgeType.For, value, value.OpportunityId);
            }

            data.Properties[SalesforceVocabulary.Quote.Phone] = value.Phone;

            if (value.Pricebook2Id != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Quote, EntityEdgeType.For, value, value.Pricebook2Id);
            }

            data.Properties[SalesforceVocabulary.Quote.QuoteNumber] = value.QuoteNumber;
            data.Properties[SalesforceVocabulary.Quote.QuoteToAddress] = value.QuoteToAddress;
            data.Properties[SalesforceVocabulary.Quote.QuoteToCity] = value.QuoteToCity;
            data.Properties[SalesforceVocabulary.Quote.QuoteToCountry] = value.QuoteToCountry;
            data.Properties[SalesforceVocabulary.Quote.QuoteToLatitude] = value.QuoteToLatitude;
            data.Properties[SalesforceVocabulary.Quote.QuoteToLongitude] = value.QuoteToLongitude;
            data.Properties[SalesforceVocabulary.Quote.QuoteToName] = value.QuoteToName;
            data.Properties[SalesforceVocabulary.Quote.QuoteToPostalCode] = value.QuoteToPostalCode;
            data.Properties[SalesforceVocabulary.Quote.QuoteToState] = value.QuoteToState;
            data.Properties[SalesforceVocabulary.Quote.QuoteToStreet] = value.QuoteToStreet;
            data.Properties[SalesforceVocabulary.Quote.RecordTypeID] = value.RecordTypeID;
            data.Properties[SalesforceVocabulary.Quote.ShippingAddress] = value.ShippingAddress;
            data.Properties[SalesforceVocabulary.Quote.ShippingCity] = value.ShippingCity;
            data.Properties[SalesforceVocabulary.Quote.ShippingCountry] = value.ShippingCountry;
            data.Properties[SalesforceVocabulary.Quote.ShippingCountryCode] = value.ShippingCountryCode;
            data.Properties[SalesforceVocabulary.Quote.ShippingHandling] = value.ShippingHandling;
            data.Properties[SalesforceVocabulary.Quote.ShippingLatitude] = value.ShippingLatitude;
            data.Properties[SalesforceVocabulary.Quote.ShippingLongitude] = value.ShippingLongitude;
            data.Properties[SalesforceVocabulary.Quote.ShippingName] = value.ShippingName;
            data.Properties[SalesforceVocabulary.Quote.ShippingPostalCode] = value.ShippingPostalCode;
            data.Properties[SalesforceVocabulary.Quote.ShippingState] = value.ShippingState;
            data.Properties[SalesforceVocabulary.Quote.ShippingStateCode] = value.ShippingStateCode;
            data.Properties[SalesforceVocabulary.Quote.ShippingStreet] = value.ShippingStreet;
            data.Properties[SalesforceVocabulary.Quote.Status] = value.Status;
            data.Properties[SalesforceVocabulary.Quote.Subtotal] = value.Subtotal;
            data.Properties[SalesforceVocabulary.Quote.Tax] = value.Tax;
            data.Properties[SalesforceVocabulary.Quote.TotalPrice] = value.TotalPrice;

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
                data.Properties[SalesforceVocabulary.Quote.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
