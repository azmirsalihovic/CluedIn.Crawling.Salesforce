// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the ProductObserver type.
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
    public class ProductClueProducer : BaseClueProducer<Product>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;



        public ProductClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(Product value, Guid id)
        {
            var clue = _factory.Create(EntityType.Product, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
                data.Aliases.Add(value.Name);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Product.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.CanUseQuantitySchedule != null)
                data.Properties[SalesforceVocabulary.Product.CanUseQuantitySchedule] = value.CanUseQuantitySchedule;
            if (value.CanUseRevenueSchedule != null)
                data.Properties[SalesforceVocabulary.Product.CanUseRevenueSchedule] = value.CanUseRevenueSchedule;
            if (value.ConnectionReceivedId != null)
                data.Properties[SalesforceVocabulary.Product.ConnectionReceivedId] = value.ConnectionReceivedId;
            if (value.ConnectionSentId != null)
                data.Properties[SalesforceVocabulary.Product.ConnectionSentId] = value.ConnectionSentId;
            if (value.CurrencyIsoCode != null)
                data.Properties[SalesforceVocabulary.Product.CurrencyIsoCode] = value.CurrencyIsoCode;
            if (value.DefaultPrice != null)
                data.Properties[SalesforceVocabulary.Product.DefaultPrice] = value.DefaultPrice;
            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.Family != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Family);
                data.Properties[SalesforceVocabulary.Product.Family] = value.Family;
            }

            if (value.IsActive != null)
                data.Properties[SalesforceVocabulary.Product.IsActive] = value.IsActive;
            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Product.IsDeleted] = value.IsDeleted;
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Product.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Product.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.NumberOfQuantityInstallments != null)
                data.Properties[SalesforceVocabulary.Product.NumberOfQuantityInstallments] = value.NumberOfQuantityInstallments;
            if (value.NumberOfRevenueInstallments != null)
                data.Properties[SalesforceVocabulary.Product.NumberOfRevenueInstallments] = value.NumberOfRevenueInstallments;
            if (value.ProductCode != null)
            {
                data.Properties[SalesforceVocabulary.Product.ProductCode] = value.ProductCode;
                data.Aliases.Add(value.ProductCode);
                data.Codes.Add(new EntityCode(EntityType.Product, SalesforceConstants.CodeOrigin, value.ProductCode));
            }
            if (value.QuantityInstallmentPeriod != null)
                data.Properties[SalesforceVocabulary.Product.QuantityInstallmentPeriod] = value.QuantityInstallmentPeriod;
            if (value.QuantityScheduleType != null)
                data.Properties[SalesforceVocabulary.Product.QuantityScheduleType] = value.QuantityScheduleType;
            if (value.RecalculateTotalPrice != null)
                data.Properties[SalesforceVocabulary.Product.RecalculateTotalPrice] = value.RecalculateTotalPrice;
            if (value.RevenueInstallmentPeriod != null)
                data.Properties[SalesforceVocabulary.Product.RevenueInstallmentPeriod] = value.RevenueInstallmentPeriod;
            if (value.RevenueScheduleType != null)
                data.Properties[SalesforceVocabulary.Product.RevenueScheduleType] = value.RevenueScheduleType;

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
