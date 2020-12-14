// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpportunityObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the OpportunityObserver type.
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
    public class OpportunityClueProducer : BaseClueProducer<Opportunity>
    {
        private readonly IClueFactory _factory;



        public OpportunityClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Opportunity value, Guid id)
        {
            var clue = _factory.Create(EntityType.Sales.Opportunity, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Opportunity.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.AccountId);
            }

            if (value.Amount != null)
                data.Properties[SalesforceVocabulary.Opportunity.Amount] = value.Amount;
            if (value.CampaignId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Marketing.Campaign, EntityEdgeType.For, value, value.CampaignId);
            }

            if (value.CloseDate != null)
                data.Properties[SalesforceVocabulary.Opportunity.CloseDate] = DateUtilities.GetFormattedDateString(value.CloseDate);
            if (value.ConnectionReceivedId != null)
                data.Properties[SalesforceVocabulary.Opportunity.ConnectionReceivedId] = value.ConnectionReceivedId;
            if (value.ConnectionSentId != null)
                data.Properties[SalesforceVocabulary.Opportunity.ConnectionSentId] = value.ConnectionSentId;
            if (value.ContractId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Contract, EntityEdgeType.For, value, value.ContractId);
            }

            if (value.CurrencyIsoCode != null)
                data.Properties[SalesforceVocabulary.Opportunity.CurrencyIsoCode] = value.CurrencyIsoCode;
            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.ExpectedRevenue != null)
                data.Properties[SalesforceVocabulary.Opportunity.ExpectedRevenue] = value.ExpectedRevenue;
            if (value.Fiscal != null)
                data.Properties[SalesforceVocabulary.Opportunity.Fiscal] = value.Fiscal;
            if (value.FiscalQuarter != null)
                data.Properties[SalesforceVocabulary.Opportunity.FiscalQuarter] = value.FiscalQuarter;
            if (value.FiscalYear != null)
                data.Properties[SalesforceVocabulary.Opportunity.FiscalYear] = value.FiscalYear;
            if (value.ForecastCategory != null)
            {
                data.Properties[SalesforceVocabulary.Opportunity.ForecastCategory] = value.ForecastCategory;
                data.Tags.Add(new Tag(value.ForecastCategory));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.ForecastCategory);
            }
            if (value.ForecastCategoryName != null)
            {
                data.Properties[SalesforceVocabulary.Opportunity.ForecastCategoryName] = value.ForecastCategoryName;
                data.Tags.Add(new Tag(value.ForecastCategoryName));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.ForecastCategoryName);
            }

            if (value.HasOpenActivity != null)
                data.Properties[SalesforceVocabulary.Opportunity.HasOpenActivity] = value.HasOpenActivity;
            if (value.HasOpportunityLineItem != null)
                data.Properties[SalesforceVocabulary.Opportunity.HasOpportunityLineItem] = value.HasOpportunityLineItem;
            if (value.HasOverdueTask != null)
                data.Properties[SalesforceVocabulary.Opportunity.HasOverdueTask] = value.HasOverdueTask;
            if (value.IsClosed != null)
                data.Properties[SalesforceVocabulary.Opportunity.IsClosed] = value.IsClosed;
            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Opportunity.IsDeleted] = value.IsDeleted;
            if (value.IsExcludedFromTerritory2Filter != null)
                data.Properties[SalesforceVocabulary.Opportunity.IsExcludedFromTerritory2Filter] = value.IsExcludedFromTerritory2Filter;
            if (value.IsSplit != null)
                data.Properties[SalesforceVocabulary.Opportunity.IsSplit] = value.IsSplit;
            if (value.IsWon != null)
                data.Properties[SalesforceVocabulary.Opportunity.IsWon] = value.IsWon;
            if (value.LastActivityDate != null)
            {
                data.Properties[SalesforceVocabulary.Opportunity.LastActivityDate] = DateUtilities.GetFormattedDateString(value.LastActivityDate);
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Opportunity.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Opportunity.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.LeadSource != null)
            {
                data.Properties[SalesforceVocabulary.Opportunity.LeadSource] = value.LeadSource;
                data.Tags.Add(new Tag(value.LeadSource));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.LeadSource);
            }

            if (value.NextStep != null)
                data.Properties[SalesforceVocabulary.Opportunity.NextStep] = value.NextStep;
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.Pricebook2Id != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Quote, EntityEdgeType.For, value, value.Pricebook2Id);
            }
            if (value.PricebookId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Quote, EntityEdgeType.For, value, value.PricebookId);
            }
            if (value.Probability != null)
                data.Properties[SalesforceVocabulary.Opportunity.Probability] = value.Probability;
            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Opportunity.RecordTypeId] = value.RecordTypeId;
            if (value.SpecialTerms != null)
                data.Properties[SalesforceVocabulary.Opportunity.SpecialTerms] = value.SpecialTerms;
            if (value.StageName != null)
            {
                data.Properties[SalesforceVocabulary.Opportunity.StageName] = value.StageName;
                data.Tags.Add(new Tag(value.StageName));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.StageName);
            }
            if (value.StartDate != null)
                data.Properties[SalesforceVocabulary.Opportunity.StartDate] = DateUtilities.GetFormattedDateString(value.StartDate);
            if (value.Status != null)
            {
                data.Properties[SalesforceVocabulary.Opportunity.Status] = value.Status;
                data.Tags.Add(new Tag(value.Status));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Status);
            }

            if (value.StatusCode != null)
                data.Properties[SalesforceVocabulary.Opportunity.StatusCode] = value.StatusCode;
            if (value.SyncedQuoteID != null)
            {
                data.Properties[SalesforceVocabulary.Opportunity.SyncedQuoteID] = value.SyncedQuoteID;
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Quote, EntityEdgeType.For, value, value.SyncedQuoteID);
            }
            if (value.Territory2Id != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Location, EntityEdgeType.For, value, value.Territory2Id);
            }
            if (value.TotalAmount != null)
                data.Properties[SalesforceVocabulary.Opportunity.TotalAmount] = value.TotalAmount;
            if (value.TotalOpportunityQuantity != null)
                data.Properties[SalesforceVocabulary.Opportunity.TotalOpportunityQuantity] = value.TotalOpportunityQuantity;
            if (value.Type != null)
            {
                data.Properties[SalesforceVocabulary.Opportunity.Type] = value.Type;
                data.Tags.Add(new Tag(value.Type));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
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
                data.Properties[SalesforceVocabulary.Opportunity.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
