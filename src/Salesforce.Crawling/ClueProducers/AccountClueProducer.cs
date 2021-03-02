// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the AccountObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Vocabularies;
using CluedIn.Core.Utilities;
using CluedIn.Crawling.Salesforce.Infrastructure;
using Microsoft.Extensions.Logging;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class AccountClueProducer : BaseClueProducer<Account>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<SalesforceClient> _log;

        public AccountClueProducer([NotNull] IClueFactory factory, ILogger<SalesforceClient> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Account value, Guid id)
        {
            bool isPerson = value.RecordTypeId == "0122o0000007pMrAAI";
            bool isOrganization = value.RecordTypeId == "0121t000000Dy89AAC";

            Clue clue = null;

            if (isPerson)
                clue = _factory.Create(EntityType.Infrastructure.User, value.ID, id);
            else if (isOrganization)
                clue = _factory.Create(EntityType.Organization, value.ID, id);

            if (clue == null)
            {
                //If not person nor organization then log.
                _log.LogWarning($"Tried to parse {nameof(Account)} but was not person nor organization. Could not process {value.RecordTypeId}", value.Name);
                return null;
            }

            var data = clue.Data.EntityData;

            //Create identifiers
            //if (!string.IsNullOrWhiteSpace(value.CVR__c) && !isPerson)
            //{
            //    data.Codes.Add(new EntityCode(EntityType.Organization, Semler.Common.Origins.Cvr, value.CVR__c));
            //}

            if (!string.IsNullOrWhiteSpace(value.KUKCustomerID__c))
            {
                if (!isPerson)
                    data.Codes.Add(new EntityCode(EntityType.Organization, Semler.Common.Origins.CustId, value.KUKCustomerID__c));
                if (isPerson)
                    data.Codes.Add(new EntityCode(EntityType.Infrastructure.User, Semler.Common.Origins.CustId, value.KUKCustomerID__c));
            } // Check if we want to filter on isPerson or create it for all clues

            if (!string.IsNullOrEmpty(value.Name))
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            if (!string.IsNullOrEmpty(value.CreatedDate))
            {
                DateTimeOffset createdDate;
                if (DateTimeOffset.TryParse(value.CreatedDate, out createdDate))
                {
                    data.CreatedDate = createdDate;
                }
            }
            if (!string.IsNullOrEmpty(value.LastModifiedDate))
            {
                DateTimeOffset modifiedDate;
                if (DateTimeOffset.TryParse(value.LastModifiedDate, out modifiedDate))
                {
                    data.ModifiedDate = modifiedDate;
                }
            }

            //Create Edges
            if (!string.IsNullOrEmpty(value.PersonContactId))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Contact, EntityEdgeType.At, value, value.PersonContactId);
            }

            if (!string.IsNullOrEmpty(value.CreatedById))
            {
                if(value.CreatedById != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);

                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
                data.Authors.Add(createdBy);
            }

            if (!string.IsNullOrEmpty(value.KUKCode__c) && isOrganization)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.KUKCode__c);
            }

            if (!string.IsNullOrEmpty(value.LastModifiedById))
            {
                if (value.LastModifiedById != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);

                data.LastChangedBy = createdBy;
            }

            if (!string.IsNullOrEmpty(value.OwnerId))
            {
                if (value.OwnerId != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (!string.IsNullOrEmpty(value.ParentId) && isOrganization && value.ParentId != value.ID)
            {
                // TODO: This is wrong! ParentId refers to the parent account
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, value, value.ParentId);
            }

            //if (!string.IsNullOrEmpty(value.Ownership) && value.Ownership != value.ID)
            //{
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Ownership);
            //}
            dynamic vocab;
            if (isPerson)
            {
                vocab = new SalesforcePrivateAccountVocabulary();
            }
            else
            {
                vocab = new SalesforceBusinessAccountVocabulary();
            }

            data.Properties[vocab.CreatedById] = value.CreatedById.PrintIfAvailable();
            data.Properties[vocab.LastModifiedById] = value.ParentId.PrintIfAvailable();
            data.Properties[vocab.ParentId] = value.LastModifiedById.PrintIfAvailable();
            data.Properties[vocab.SystemModstamp] = value.SystemModstamp.PrintIfAvailable();
            data.Properties[vocab.AccountNumber] = value.AccountNumber.PrintIfAvailable();
            data.Properties[vocab.AccountSource] = value.AccountSource.PrintIfAvailable();
            data.Properties[vocab.AgePc] = value.Age__pc.PrintIfAvailable();
            data.Properties[vocab.AnnualRevenue] = value.AnnualRevenue.PrintIfAvailable();
            data.Properties[vocab.AudiIdC] = value.AudiIdC.PrintIfAvailable();
            data.Properties[vocab.BillingCity] = value.BillingCity.PrintIfAvailable();
            data.Properties[vocab.BillingCountry] = value.BillingCountry.PrintIfAvailable();
            data.Properties[vocab.BillingCountryCode] = value.BillingCountryCode.PrintIfAvailable();
            data.Properties[vocab.BillingPostalCode] = value.BillingPostalCode.PrintIfAvailable();
            data.Properties[vocab.BillingAddress] = value.BillingAddress.PrintIfAvailable();
            data.Properties[vocab.BillingState] = value.BillingState.PrintIfAvailable();
            data.Properties[vocab.BillingStateCode] = value.BillingStateCode.PrintIfAvailable();
            data.Properties[vocab.BillingStreet] = value.BillingStreet.PrintIfAvailable();
            data.Properties[vocab.BouncedPc] = value.Bounced__pc.PrintIfAvailable();
            data.Properties[vocab.BrandPc] = value.Brand__pc.PrintIfAvailable();
            data.Properties[vocab.Brand2Pc] = value.Brand2__pc.PrintIfAvailable();
            data.Properties[vocab.BuyingTimeframePc] = value.Buying_timeframe__pc.PrintIfAvailable();
            data.Properties[vocab.CompanySizePc] = value.Company_Size__pc.PrintIfAvailable();
            data.Properties[vocab.ContactRolePc] = value.Contact_Role__pc.PrintIfAvailable();
            data.Properties[vocab.CurrentCarBrandPc] = value.Current_Car_Brand__pc.PrintIfAvailable();
            data.Properties[vocab.CustomerCityC] = value.CustomerCity__c.PrintIfAvailable();
            data.Properties[vocab.CvrC] = value.CVR__c.PrintIfAvailable();
            data.Properties[vocab.DeadC] = value.Dead__c.PrintIfAvailable();
            data.Properties[vocab.DealershipidC] = value.DealershipID__c.PrintIfAvailable();
            data.Properties[vocab.Description] = value.Description.PrintIfAvailable();
            data.Properties[vocab.FirstName] = value.FirstName.PrintIfAvailable();
            data.Properties[vocab.HashedEmailPc] = value.HashedEmail__pc.PrintIfAvailable();
            data.Properties[vocab.ID] = value.ID.PrintIfAvailable();
            data.Properties[vocab.IdEmailC] = value.ID_Email__c.PrintIfAvailable();
            data.Properties[vocab.IdEmailPc] = value.ID_Email__pc.PrintIfAvailable();
            data.Properties[vocab.IdentityKitIdPc] = value.Identity_Kit_Id__pc.PrintIfAvailable();
            data.Properties[vocab.IdentityKitIdC] = value.IdentityKitId__c.PrintIfAvailable();
            data.Properties[vocab.IdNgC] = value.ID_NG__c.PrintIfAvailable();
            data.Properties[vocab.IdNgPc] = value.ID_NG__pc.PrintIfAvailable();
            data.Properties[vocab.Industry] = value.Industry.PrintIfAvailable();
            data.Properties[vocab.IndustryPc] = value.Industry__pc.PrintIfAvailable();
            data.Properties[vocab.InteractionScoreCalculatedPc] = value.InteractionScoreCalculated__pc.PrintIfAvailable();
            data.Properties[vocab.InteractionScoreLastUpdatedPc] = value.InteractionScoreLastUpdated__pc.PrintIfAvailable();
            data.Properties[vocab.InteractionScorePc] = value.InteractionScore__pc.PrintIfAvailable();
            data.Properties[vocab.IsActiveUserPc] = value.IsActiveUser__pc.PrintIfAvailable();
            data.Properties[vocab.IsDeleted] = value.IsDeleted.PrintIfAvailable();
            data.Properties[vocab.IsKukCustomerC] = value.IsKUKCustomer__c.PrintIfAvailable();
            data.Properties[vocab.IsMarketingContactPc] = value.IsMarketingContact__pc.PrintIfAvailable();
            data.Properties[vocab.IsPartner] = value.IsPartner.PrintIfAvailable();
            data.Properties[vocab.IsPartnerPc] = value.Is_Partner__pc.PrintIfAvailable();
            data.Properties[vocab.IsPersonAccount] = value.IsPersonAccount.PrintIfAvailable();
            data.Properties[vocab.KukCodeC] = value.KUKCode__c.PrintIfAvailable();
            data.Properties[vocab.KukCustomerIdC] = value.KUKCustomerID__c.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.LastActivityDate))
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }

            data.Properties[vocab.LastName] = value.LastName.PrintIfAvailable();
            data.Properties[vocab.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate).PrintIfAvailable();
            data.Properties[vocab.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate).PrintIfAvailable();
            data.Properties[vocab.LeadReassignmentC] = value.LeadReassignment__c.PrintIfAvailable();
            data.Properties[vocab.MarketingContactHemKeyC] = value.MarketingContactHEMKey__c.PrintIfAvailable();
            data.Properties[vocab.MarketingContactKeyC] = value.MarketingContactKey__c.PrintIfAvailable();
            data.Properties[vocab.McApiErrorPc] = value.MC_API_Error__pc.PrintIfAvailable();
            data.Properties[vocab.McApiStatusPc] = value.MC_API_Status__pc.PrintIfAvailable();
            data.Properties[vocab.NumberOfCarsPc] = value.Number_of_Cars__pc.PrintIfAvailable();
            data.Properties[vocab.NumberOfEmployees] = value.NumberOfEmployees.PrintIfAvailable();
            data.Properties[vocab.OrderedLicensesC] = value.OrderedLicenses__c.PrintIfAvailable();
            data.Properties[vocab.OwnerId] = value.OwnerId.PrintIfAvailable();
            data.Properties[vocab.PartnerExtidC] = value.Partner_ExtId__c.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.Phone))
            {
                data.Properties[vocab.Phone] = value.Phone;
                data.Aliases.Add(value.Phone);
            }

            data.Properties[vocab.PhoneFormulaC] = value.PhoneFormula__c.PrintIfAvailable();
            data.Properties[vocab.PhotoUrl] = value.PhotoUrl.PrintIfAvailable();
            data.Properties[vocab.PostBoxNameC] = value.PostboxName__c.PrintIfAvailable();
            data.Properties[vocab.PreferedOwnershipPc] = value.Prefered_Ownership__pc.PrintIfAvailable();
            data.Properties[vocab.OwnerShip] = value.Ownership.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.PersonAssistantPhone))
            {
                data.Properties[vocab.PersonAssistantPhone] = value.PersonAssistantPhone;
                data.Aliases.Add(value.PersonAssistantPhone);
            }

            if (!string.IsNullOrEmpty(value.PersonBirthDate))
            {
                data.Properties[vocab.PersonBirthDate] = value.PersonBirthDate.PrintIfAvailable();
                data.Aliases.Add(value.PersonBirthDate);
            }

            data.Properties[vocab.PersonContactId] = value.PersonContactId.PrintIfAvailable();
            data.Properties[vocab.PersonContactIdC] = value.PersonContactId__c.PrintIfAvailable();
            data.Properties[vocab.PersonDepartment] = value.PersonDepartment.PrintIfAvailable();
            data.Properties[vocab.PersonDonotCall] = value.PersonDonotCall.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.PersonEmail))
            {
                data.Properties[vocab.PersonEmail] = value.PersonEmail;
                data.Aliases.Add(value.PersonEmail);
            }

            data.Properties[vocab.PersonEmailBouncedDate] = value.PersonEmailBouncedDate.PrintIfAvailable();
            data.Properties[vocab.PersonEmailBouncedReason] = value.PersonEmailBouncedReason.PrintIfAvailable();
            data.Properties[vocab.PersonHasOptedOutOfEmail] = value.PersonHasOptedOutOfEmail.PrintIfAvailable();
            data.Properties[vocab.PersonHasOptedOutOfFax] = value.PersonHasOptedOutOfFax.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.PersonHomePhone))
            {
                data.Properties[vocab.PersonHomePhone] = value.PersonHomePhone;
                data.Aliases.Add(value.PersonHomePhone);
            }

            data.Properties[vocab.PersonLeadSource] = value.PersonLeadSource.PrintIfAvailable();
            data.Properties[vocab.PersonMailingAddress] = value.PersonMailingAddress.PrintIfAvailable();
            data.Properties[vocab.PersonMailingCity] = value.PersonMailingCity.PrintIfAvailable();
            data.Properties[vocab.PersonMailingCountry] = value.PersonMailingCountry.PrintIfAvailable();
            data.Properties[vocab.PersonMailingCountryCode] = value.PersonMailingCountryCode.PrintIfAvailable();
            data.Properties[vocab.PersonMailingPostalCode] = value.PersonMailingPostalCode.PrintIfAvailable();
            data.Properties[vocab.PersonMailingState] = value.PersonMailingState.PrintIfAvailable();
            data.Properties[vocab.PersonMailingStateCode] = value.PersonMailingStateCode.PrintIfAvailable();
            data.Properties[vocab.PersonMailingStreet] = value.PersonMailingStreet.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.PersonMobilePhone))
            {
                data.Properties[vocab.PersonMobilePhone] = value.PersonMobilePhone;
                data.Aliases.Add(value.PersonMobilePhone);
            }

            data.Properties[vocab.PersonOtherAddress] = value.PersonOtherAddress.PrintIfAvailable();
            data.Properties[vocab.PersonOtherCity] = value.PersonOtherCity.PrintIfAvailable();
            data.Properties[vocab.PersonOtherCountry] = value.PersonOtherCountry.PrintIfAvailable();
            data.Properties[vocab.PersonOtherCountryCode] = value.PersonOtherCountryCode.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.PersonOtherPhone))
            {
                data.Properties[vocab.PersonOtherPhone] = value.PersonOtherPhone;
                data.Aliases.Add(value.PersonOtherPhone);
            }

            data.Properties[vocab.PersonOtherPostalCode] = value.PersonOtherPostalCode.PrintIfAvailable();
            data.Properties[vocab.PersonOtherState] = value.PersonOtherState.PrintIfAvailable();
            data.Properties[vocab.PersonOtherStateCode] = value.PersonOtherStateCode.PrintIfAvailable();
            data.Properties[vocab.PersonOtherStreet] = value.PersonOtherStreet.PrintIfAvailable();
            data.Properties[vocab.PersonTitle] = value.PersonTitle.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.Rating))
            {
                //_factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Rating);
                data.Properties[vocab.Rating] = value.Rating;
                data.Tags.Add(new Tag(value.Rating));
            }

            data.Properties[vocab.RecordTypeId] = value.RecordTypeId.PrintIfAvailable();
            data.Properties[vocab.ResidenseRegionPc] = value.Residense_region__pc.PrintIfAvailable();
            data.Properties[vocab.RobinsonC] = value.Robinson__c.PrintIfAvailable();
            data.Properties[vocab.Salutation] = value.Salutation.PrintIfAvailable();
            data.Properties[vocab.SeatIdC] = value.Seat_Id__c.PrintIfAvailable();
            data.Properties[vocab.ShippingAddress] = value.ShippingAddress.PrintIfAvailable();
            data.Properties[vocab.ShippingCity] = value.ShippingCity.PrintIfAvailable();
            data.Properties[vocab.ShippingCountry] = value.ShippingCountry.PrintIfAvailable();
            data.Properties[vocab.ShippingCountryCode] = value.ShippingCountryCode.PrintIfAvailable();
            data.Properties[vocab.ShippingPostalCode] = value.ShippingPostalCode.PrintIfAvailable();
            data.Properties[vocab.ShippingState] = value.ShippingState.PrintIfAvailable();
            data.Properties[vocab.ShippingStateCode] = value.ShippingStateCode.PrintIfAvailable();
            data.Properties[vocab.ShippingStreet] = value.ShippingStreet.PrintIfAvailable();
            data.Properties[vocab.Site] = value.Site.PrintIfAvailable();
            data.Properties[vocab.SkodaIdC] = value.Skoda_Id__c.PrintIfAvailable();
            data.Properties[vocab.StartedUsingSfC] = value.Started_using_SF__c.PrintIfAvailable();
            data.Properties[vocab.TickerSymbol] = value.TickerSymbol.PrintIfAvailable();
            data.Properties[vocab.VwEIdCC] = value.VW_E_Id_c__c.PrintIfAvailable();
            data.Properties[vocab.VwIdC] = value.VW_Id__c.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.Type))
            {
                //_factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
                data.Properties[vocab.Type] = value.Type;
                data.Tags.Add(new Tag(value.Type));
            }

            if (!string.IsNullOrEmpty(value.Website))
            {
                data.Properties[vocab.Website] = value.Website;

                Uri website;

                if (Uri.TryCreate(value.Website, UriKind.Absolute, out website))
                {
                    data.ExternalReferences.Add(new Uri(value.Website));
                }
            }

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
