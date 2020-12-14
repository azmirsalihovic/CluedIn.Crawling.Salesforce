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

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class PrivateCustomerClueProducer : BaseClueProducer<PrivateCustomer>
    {
        private readonly IClueFactory _factory;

        public PrivateCustomerClueProducer([NotNull] IClueFactory factory)
            
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(PrivateCustomer value, Guid id)
        {
            Clue clue;
            clue = _factory.Create(EntityType.Infrastructure.User, value.ID, id);

            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
                data.Aliases.Add(value.Name);
            }

            // TODO: Could this fail? Is this the right name of the JobData?
            //data.Uri = new Uri($"{_jobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Account.EditUrl] = $"{_jobData.Token.Data}/{value.ID}";
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

                data.LastChangedBy = createdBy;
            }
            if (value.LastModifiedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);

                data.LastChangedBy = createdBy;
            }
            if (value.SystemModstamp != null) data.Properties[SalesforceVocabulary.PrivateCustomer.SystemModstamp] = value.SystemModstamp;
            if (value.AccountNumber != null) data.Properties[SalesforceVocabulary.PrivateCustomer.AccountNumber] = value.AccountNumber;
            if (value.AccountSource != null) data.Properties[SalesforceVocabulary.PrivateCustomer.AccountSource] = value.AccountSource;
            if (value.AgePc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.AgePc] = value.AgePc;
            if (value.AnnualRevenue != null) data.Properties[SalesforceVocabulary.PrivateCustomer.AnnualRevenue] = value.AnnualRevenue;
            if (value.AudiIdC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.AudiIdC] = value.AudiIdC;
            if (value.BillingCity != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BillingCity] = value.BillingCity;
            if (value.BillingCountry != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BillingCountry] = value.BillingCountry;
            if (value.BillingCountryCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BillingCountryCode] = value.BillingCountryCode;
            if (value.BillingPostalCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BillingPostalCode] = value.BillingPostalCode;
            if (value.BillingAddress != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BillingAddress] = value.BillingAddress;
            if (value.BillingState != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BillingState] = value.BillingState;
            if (value.BillingStateCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BillingStateCode] = value.BillingStateCode;
            if (value.BillingStreet != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BillingStreet] = value.BillingStreet;
            if (value.BouncedPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BouncedPc] = value.BouncedPc;
            if (value.BrandPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BrandPc] = value.BrandPc;
            if (value.Brand2Pc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.Brand2Pc] = value.Brand2Pc;
            if (value.BuyingTimeframePc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.BuyingTimeframePc] = value.BuyingTimeframePc;
            if (value.CompanySizePc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.CompanySizePc] = value.CompanySizePc;
            if (value.ContactRolePc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ContactRolePc] = value.ContactRolePc;
            if (value.CurrentCarBrandPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.CurrentCarBrandPc] = value.CurrentCarBrandPc;
            if (value.CustomerCityC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.CustomerCityC] = value.CustomerCityC;
            if (value.CvrC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.CvrC] = value.CvrC;
            if (value.DeadC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.DeadC] = value.DeadC;
            if (value.DealershipidC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.DealershipidC] = value.DealershipidC;
            if (value.Description != null) data.Properties[SalesforceVocabulary.PrivateCustomer.Description] = value.Description;
            if (value.FirstName != null) data.Properties[SalesforceVocabulary.PrivateCustomer.FirstName] = value.FirstName;
            if (value.HashedEmailPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.HashedEmailPc] = value.HashedEmailPc;
            if (value.ID != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ID] = value.ID;
            if (value.IdEmailC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IdEmailC] = value.IdEmailC;
            if (value.IdEmailPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IdEmailPc] = value.IdEmailPc;
            if (value.IdentityKitIdPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IdentityKitIdPc] = value.IdentityKitIdPc;
            if (value.IdentityKitIdC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IdentityKitIdC] = value.IdentityKitIdC;
            if (value.IdNgC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IdNgC] = value.IdNgC;
            if (value.IdNgPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IdNgPc] = value.IdNgPc;
            if (value.Industry != null) data.Properties[SalesforceVocabulary.PrivateCustomer.Industry] = value.Industry;
            if (value.IndustryPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IndustryPc] = value.IndustryPc;
            if (value.InteractionScoreCalculatedPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.InteractionScoreCalculatedPc] = value.InteractionScoreCalculatedPc;
            if (value.InteractionScoreLastUpdatedPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.InteractionScoreLastUpdatedPc] = value.InteractionScoreLastUpdatedPc;
            if (value.InteractionScorePc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.InteractionScorePc] = value.InteractionScorePc;
            if (value.IsActiveUserPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IsActiveUserPc] = value.IsActiveUserPc;
            if (value.IsDeleted != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IsDeleted] = value.IsDeleted;
            if (value.IsKukCustomerC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IsKukCustomerC] = value.IsKukCustomerC;
            if (value.IsMarketingContactPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IsMarketingContactPc] = value.IsMarketingContactPc;
            if (value.IsPartner != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IsPartner] = value.IsPartner;
            if (value.IsPartnerPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IsPartnerPc] = value.IsPartnerPc;
            if (value.IsPersonAccount != null) data.Properties[SalesforceVocabulary.PrivateCustomer.IsPersonAccount] = value.IsPersonAccount;
            if (value.KukCodeC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.KukCodeC] = value.KukCodeC;
            if (value.KukCustomerIdC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.KukCustomerIdC] = value.KukCustomerIdC;
            if (value.LastActivityDate != null)
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }
            if (value.LastName != null) data.Properties[SalesforceVocabulary.PrivateCustomer.LastName] = value.LastName;
            if (value.LastReferencedDate != null) data.Properties[SalesforceVocabulary.PrivateCustomer.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null) data.Properties[SalesforceVocabulary.PrivateCustomer.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.LeadReassignmentC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.LeadReassignmentC] = DateUtilities.GetFormattedDateString(value.LeadReassignmentC);
            if (value.MarketingContactHemKeyC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.MarketingContactHemKeyC] = DateUtilities.GetFormattedDateString(value.MarketingContactHemKeyC);
            if (value.MarketingContactKeyC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.MarketingContactKeyC] = DateUtilities.GetFormattedDateString(value.MarketingContactKeyC);
            if (value.McApiErrorPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.McApiErrorPc] = DateUtilities.GetFormattedDateString(value.McApiErrorPc);
            if (value.McApiStatusPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.McApiStatusPc] = DateUtilities.GetFormattedDateString(value.McApiStatusPc);
            if (value.NumberOfCarsPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.NumberOfCarsPc] = value.NumberOfCarsPc;
            if (value.NumberOfEmployees != null) data.Properties[SalesforceVocabulary.PrivateCustomer.NumberOfEmployees] = value.NumberOfEmployees;
            if (value.OrderedLicensesC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.OrderedLicensesC] = value.OrderedLicensesC;
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }
            if (value.Ownership != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Ownership);
                data.Properties[SalesforceVocabulary.PrivateCustomer.OwnerShip] = value.Ownership;
            }
            if (value.ParentId != null)
            {
                // TODO: This is wrong! ParentId refers to the parent account
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, value, value.ParentId);
            }
            if (value.PartnerExtidC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PartnerExtidC] = value.PartnerExtidC;
            if (value.Phone != null)
            {
                data.Properties[SalesforceVocabulary.PrivateCustomer.Phone] = value.Phone;
                data.Aliases.Add(value.Phone);
            }
            if (value.PhoneFormulaC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PhoneFormulaC] = value.PhoneFormulaC;
            if (value.PhotoUrl != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PhotoUrl] = value.PhotoUrl;
            //if (value.PhotoUrl != null)
            //{
            //    if (value.PhotoUrl != null)
            //    {
            //        try
            //        {
            //            using (var webClient = new WebClient())
            //            {
            //                webClient.Headers.Add("Authorization", "Bearer " + _jobData.Token.AccessToken);
            //                using (var stream = webClient.OpenRead(value.PhotoUrl))
            //                {
            //                    var inArray = StreamUtilies.ReadFully(stream);
            //                    if (inArray != null)
            //                    {
            //                        var rawDataPart = new RawDataPart()
            //                        {
            //                            Type = "/RawData/PreviewImage",
            //                            MimeType = CluedIn.Core.FileTypes.MimeType.Jpeg.Code,
            //                            FileName = "preview_{0}".FormatWith(clue.OriginEntityCode.Key),
            //                            RawDataMD5 = FileHashUtility.GetMD5Base64String(inArray),
            //                            RawData = Convert.ToBase64String(inArray)
            //                        };

            //                        clue.Details.RawData.Add(rawDataPart);

            //                        clue.Data.EntityData.PreviewImage = new ImageReferencePart(rawDataPart);
            //                    }
            //                }
            //            }

            //        }
            //        catch (Exception exception)
            //        {
            //        }
            //    }
            //}
            if (value.PostBoxNameC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PostBoxNameC] = value.PostBoxNameC;
            if (value.PreferedOwnershipPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PreferedOwnershipPc] = value.PreferedOwnershipPc;
            if (value.PersonAssistantPhone != null)
            {
                data.Properties[SalesforceVocabulary.PrivateCustomer.PersonAssistantPhone] = value.PersonAssistantPhone;
                data.Aliases.Add(value.PersonAssistantPhone);
            }
            if (value.PersonBirthDate != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonBirthDate] = value.PersonBirthDate;
            //if (value.PersonContactId != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonContactId] = value.PersonContactId;

            if (value.PersonContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Contact, EntityEdgeType.At, value, value.PersonContactId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Infrastructure.Contact, SalesforceConstants.CodeOrigin, value.PersonContactId));
                data.Authors.Add(createdBy);
            }

            if (value.PersonContactIdC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonContactIdC] = value.PersonContactIdC;
            if (value.PersonDepartment != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonDepartment] = value.PersonDepartment;
            if (value.PersonDonotCall != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonDonotCall] = value.PersonDonotCall;
            if (value.PersonEmail != null)
            {
                data.Properties[SalesforceVocabulary.PrivateCustomer.PersonEmail] = value.PersonEmail;
                data.Aliases.Add(value.PersonEmail);
            }
            if (value.PersonEmailBouncedDate != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonEmailBouncedDate] = value.PersonEmailBouncedDate;
            if (value.PersonEmailBouncedReason != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonEmailBouncedReason] = value.PersonEmailBouncedReason;
            if (value.PersonHasOptedOutOfEmail != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonHasOptedOutOfEmail] = value.PersonHasOptedOutOfEmail;
            if (value.PersonHasOptedOutOfFax != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonHasOptedOutOfFax] = value.PersonHasOptedOutOfFax;
            if (value.PersonHomePhone != null)
            {
                data.Properties[SalesforceVocabulary.PrivateCustomer.PersonHomePhone] = value.PersonHomePhone;
                data.Aliases.Add(value.PersonHomePhone);
            }
            if (value.PersonLeadSource != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonLeadSource] = value.PersonLeadSource;
            if (value.PersonMailingAddress != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMailingAddress] = value.PersonMailingAddress;
            if (value.PersonMailingCity != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMailingCity] = value.PersonMailingCity;
            if (value.PersonMailingCountry != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMailingCountry] = value.PersonMailingCountry;
            if (value.PersonMailingCountryCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMailingCountryCode] = value.PersonMailingCountryCode;
            if (value.PersonMailingPostalCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMailingPostalCode] = value.PersonMailingPostalCode;
            if (value.PersonMailingState != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMailingState] = value.PersonMailingState;
            if (value.PersonMailingStateCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMailingStateCode] = value.PersonMailingStateCode;
            if (value.PersonMailingStreet != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMailingStreet] = value.PersonMailingStreet;
            if (value.PersonMobilePhone != null)
            {
                data.Properties[SalesforceVocabulary.PrivateCustomer.PersonMobilePhone] = value.PersonMobilePhone;
                data.Aliases.Add(value.PersonMobilePhone);
            }
            if (value.PersonOtherAddress != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherAddress] = value.PersonOtherAddress;
            if (value.PersonOtherCity != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherCity] = value.PersonOtherCity;
            if (value.PersonOtherCountry != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherCountry] = value.PersonOtherCountry;
            if (value.PersonOtherCountryCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherCountryCode] = value.PersonOtherCountryCode;
            if (value.PersonOtherPhone != null)
            {
                data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherPhone] = value.PersonOtherPhone;
                data.Aliases.Add(value.PersonOtherPhone);
            }
            if (value.PersonOtherPostalCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherPostalCode] = value.PersonOtherPostalCode;
            if (value.PersonOtherState != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherState] = value.PersonOtherState;
            if (value.PersonOtherStateCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherStateCode] = value.PersonOtherStateCode;
            if (value.PersonOtherStreet != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonOtherStreet] = value.PersonOtherStreet;
            if (value.PersonTitle != null) data.Properties[SalesforceVocabulary.PrivateCustomer.PersonTitle] = value.PersonTitle;
            if (value.Rating != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Rating);
                data.Properties[SalesforceVocabulary.PrivateCustomer.Rating] = value.Rating;
                data.Tags.Add(new Tag(value.Rating));
            }
            if (value.RecordTypeId != null) data.Properties[SalesforceVocabulary.PrivateCustomer.RecordTypeId] = value.RecordTypeId;
            if (value.ResidenseRegionPc != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ResidenseRegionPc] = value.ResidenseRegionPc;
            if (value.RobinsonC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.RobinsonC] = value.RobinsonC;
            if (value.Salutation != null) data.Properties[SalesforceVocabulary.PrivateCustomer.Salutation] = value.Salutation;
            if (value.SeatIdC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.SeatIdC] = value.SeatIdC;
            if (value.ShippingAddress != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ShippingAddress] = value.ShippingAddress;
            if (value.ShippingCity != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ShippingCity] = value.ShippingCity;
            if (value.ShippingCountry != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ShippingCountry] = value.ShippingCountry;
            if (value.ShippingCountryCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ShippingCountryCode] = value.ShippingCountryCode;
            if (value.ShippingPostalCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ShippingPostalCode] = value.ShippingPostalCode;
            if (value.ShippingState != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ShippingState] = value.ShippingState;
            if (value.ShippingStateCode != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ShippingStateCode] = value.ShippingStateCode;
            if (value.ShippingStreet != null) data.Properties[SalesforceVocabulary.PrivateCustomer.ShippingStreet] = value.ShippingStreet;
            if (value.Site != null) data.Properties[SalesforceVocabulary.PrivateCustomer.Site] = value.Site;
            if (value.SkodaIdC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.SkodaIdC] = value.SkodaIdC;
            if (value.StartedUsingSfC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.StartedUsingSfC] = value.StartedUsingSfC;
            if (value.TickerSymbol != null) data.Properties[SalesforceVocabulary.PrivateCustomer.TickerSymbol] = value.TickerSymbol;
            if (value.Type != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
                data.Properties[SalesforceVocabulary.PrivateCustomer.Type] = value.Type;
                data.Tags.Add(new Tag(value.Type));
            }
            if (value.VwEIdCC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.VwEIdCC] = value.VwEIdCC;
            if (value.VwIdC != null) data.Properties[SalesforceVocabulary.PrivateCustomer.VwIdC] = value.VwIdC;
            if (value.Website != null)
            {
                data.Properties[SalesforceVocabulary.PrivateCustomer.Website] = value.Website;

                Uri website;

                if (Uri.TryCreate(value.Website, UriKind.Absolute, out website))
                {
                    data.ExternalReferences.Add(new Uri(value.Website));
                }
            }
            //if (value.YearStarted != null) data.Properties[SalesforceVocabulary.Account.YearStarted] = value.YearStarted;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
