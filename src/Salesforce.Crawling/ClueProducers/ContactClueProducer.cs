// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the ContactObserver type.
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
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class ContactClueProducer : BaseClueProducer<Contact>
    {
        private readonly IClueFactory _factory;

        public ContactClueProducer([NotNull] IClueFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Contact value, Guid id)
        {
            var clue = _factory.Create(EntityType.Infrastructure.Contact, value.ID, id);
            var data = clue.Data.EntityData;

            if (!string.IsNullOrEmpty(value.Name))
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
                //data.Aliases.Add(value.Name);
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
            if (!string.IsNullOrEmpty(value.AccountId) && value.AccountId != value.ID)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, value, value.AccountId);
            }

            if (!string.IsNullOrEmpty(value.CreatedById))
            {
                if (value.CreatedById != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);

                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
                data.Authors.Add(createdBy);
            }

            if (!string.IsNullOrEmpty(value.LastModifiedById))
            {
                if (value.LastModifiedById != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);

                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);
            }

            data.Properties[SalesforceVocabulary.Contact.AccountId] = value.AccountId.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.CreatedById] = value.CreatedById.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.LastModifiedById] = value.LastModifiedById.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.ID] = value.ID.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.Description] = value.Description.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.SystemModstamp] = value.SystemModstamp.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.AgeC] = value.AgeC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.BouncedC] = value.BouncedC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.BrandC] = value.BrandC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.Brand2C] = value.Brand2C.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.BuyingTimeframeC] = value.BuyingTimeframeC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.CompanySizeC] = value.CompanySizeC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.ContactRoleC] = value.ContactRoleC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.CurrentCarBrandC] = value.CurrentCarBrandC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.HashedEmailC] = value.HashedEmailC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IdEmailC] = value.IdEmailC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IdentityKitIdC] = value.IdentityKitIdC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IdNgC] = value.IdNgC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IndustryC] = value.IndustryC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.InteractionScoreC] = value.InteractionScoreC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.InteractionScoreCalculatedC] = value.InteractionScoreCalculatedC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.InteractionScoreLastUpdatedC] = value.InteractionScoreLastUpdatedC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IsActiveUserC] = value.IsActiveUserC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IsMarketingContactC] = value.IsMarketingContactC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IsPartnerC] = value.IsPartnerC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.McApiErrorC] = value.McApiErrorC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.McApiStatusC] = value.McApiStatusC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.NumberOfCarsC] = value.NumberOfCarsC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.PreferedOwnershipC] = value.PreferedOwnershipC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.ResidenseRegionC] = value.ResidenseRegionC.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IsDeleted] = value.IsDeleted.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.RecordTypeId] = value.RecordTypeId.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.AssistantName] = value.AssistantName.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.FirstName] = value.FirstName.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.Birthdate))
            {
                data.Properties[SalesforceVocabulary.Contact.Birthdate] = value.Birthdate.PrintIfAvailable();
                //data.Aliases.Add(value.Birthdate);
            }

            data.Properties[SalesforceVocabulary.Contact.Department] = value.Department.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.DoNotCall] = value.DoNotCall.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IsEmailBounced] = value.IsEmailBounced.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.IsPersonAccount] = value.IsPersonAccount.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.AssistantPhone))
            {
                data.Properties[SalesforceVocabulary.Contact.AssistantPhone] = value.AssistantPhone;
                //data.Aliases.Add(value.AssistantPhone);
            }

            if (!string.IsNullOrEmpty(value.Email))
            {
                data.Properties[SalesforceVocabulary.Contact.Email] = value.Email;
                data.Aliases.Add(value.Email);
            }

            if (!string.IsNullOrEmpty(value.Fax))
            {
                data.Properties[SalesforceVocabulary.Contact.Fax] = value.Fax;
                //data.Aliases.Add(value.Fax);
            }

            if (!string.IsNullOrEmpty(value.HomePhone))
            {
                data.Properties[SalesforceVocabulary.Contact.HomePhone] = value.HomePhone;
                data.Aliases.Add(value.HomePhone);
            }

            if (!string.IsNullOrEmpty(value.LastActivityDate))
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }

            data.Properties[SalesforceVocabulary.Contact.LastCURequestDate] = DateUtilities.GetFormattedDateString(value.LastCURequestDate).PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.LastCUUpdateDate] = DateUtilities.GetFormattedDateString(value.LastCUUpdateDate).PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.LastName] = value.LastName.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate).PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate).PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.LeadSource))
            {
                //_factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.LeadSource);
                data.Properties[SalesforceVocabulary.Contact.LeadSource] = value.LeadSource.PrintIfAvailable();
            }

            data.Properties[SalesforceVocabulary.Contact.MailingAddress] = value.MailingAddress.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingCity] = value.MailingCity.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingCountry] = value.MailingCountry.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingCountryCode] = value.MailingCountryCode.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingGeocodeAccuracy] = value.MailingGeocodeAccuracy.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingLatitude] = value.MailingLatitude.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingLongitude] = value.MailingLongitude.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingPostalCode] = value.MailingPostalCode.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingState] = value.MailingState.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingStateCode] = value.MailingStateCode.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MailingStreet] = value.MailingStreet.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.MasterRecordId] = value.MasterRecordId.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.MobilePhone))
            {
                data.Properties[SalesforceVocabulary.Contact.MobilePhone] = value.MobilePhone;
                data.Aliases.Add(value.MobilePhone);
            }

            data.Properties[SalesforceVocabulary.Contact.OtherAddress] = value.OtherAddress.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.OtherCity] = value.OtherCity.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.OtherCountry] = value.OtherCountry.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.OtherCountryCode] = value.OtherCountryCode.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.OtherPhone))
            {
                data.Properties[SalesforceVocabulary.Contact.OtherPhone] = value.OtherPhone;
                //data.Aliases.Add(value.OtherPhone);
            }

            data.Properties[SalesforceVocabulary.Contact.OtherPostalCode] = value.OtherPostalCode.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.OtherState] = value.OtherState.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.OtherStateCode] = value.OtherStateCode.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.OtherStreet] = value.OtherStreet.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.OwnerId))
            {
                if (value.OwnerId != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);

                data.Properties[SalesforceVocabulary.Contact.OwnerId] = value.OwnerId.PrintIfAvailable();
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (!string.IsNullOrEmpty(value.Phone))
            {
                data.Properties[SalesforceVocabulary.Contact.Phone] = value.Phone;
                //data.Aliases.Add(value.Phone);
            }

            data.Properties[SalesforceVocabulary.Contact.PhotoUrl] = value.PhotoUrl.PrintIfAvailable();

            if (!string.IsNullOrEmpty(value.ReportsToId))
            {
                if (value.ReportsToId != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ManagedBy,value, value.ReportsToId);

                data.Properties[SalesforceVocabulary.Contact.ReportsToId] = value.ReportsToId.PrintIfAvailable();
            }

            data.Properties[SalesforceVocabulary.Contact.Salutation] = value.Salutation.PrintIfAvailable();
            data.Properties[SalesforceVocabulary.Contact.Title] = value.Title.PrintIfAvailable();

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
