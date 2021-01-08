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
using System.Globalization;

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

            // Creates a TextInfo based on the "da-DK" culture.
            TextInfo myTI = new CultureInfo("da-DK", false).TextInfo;

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

            if (!string.IsNullOrWhiteSpace(value.KUKCustomerID__c) && !isPerson)
            {
                data.Codes.Add(new EntityCode(EntityType.Organization, Semler.Common.Origins.KUK, value.KUKCustomerID__c));
            }

            if (value.Name != null)
            {
                data.Name = value.Name;
                //This works fine except for words that are entirely in uppercase, which are considered to be acronyms. That's why we need to convert to lowerCase first.
                data.DisplayName = myTI.ToTitleCase(myTI.ToLower(value.Name));
                data.Aliases.Add(value.Name);
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

                data.LastChangedBy = createdBy;
            }
            if (value.LastModifiedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);

                data.LastChangedBy = createdBy;
            }
            var vocab = new SalesforceAccountVocabulary(isPerson);
            if (value.SystemModstamp != null)
                data.Properties[vocab.SystemModstamp] = value.SystemModstamp;//.PrintIfAvailable();//This is they way this shoul be done, and remove check for null above
            if (value.AccountNumber != null)
                data.Properties[vocab.AccountNumber] = value.AccountNumber;
            if (value.AccountSource != null)
                data.Properties[vocab.AccountSource] = value.AccountSource;
            if (value.Age__pc != null)
                data.Properties[vocab.AgePc] = value.Age__pc;
            if (value.AnnualRevenue != null)
                data.Properties[vocab.AnnualRevenue] = value.AnnualRevenue;
            if (value.AudiIdC != null)
                data.Properties[vocab.AudiIdC] = value.AudiIdC;
            if (value.BillingCity != null)
                data.Properties[vocab.BillingCity] = value.BillingCity;
            if (value.BillingCountry != null)
                data.Properties[vocab.BillingCountry] = value.BillingCountry;
            if (value.BillingCountryCode != null)
                data.Properties[vocab.BillingCountryCode] = value.BillingCountryCode;
            if (value.BillingPostalCode != null)
                data.Properties[vocab.BillingPostalCode] = value.BillingPostalCode;
            if (value.BillingAddress != null)
                data.Properties[vocab.BillingAddress] = value.BillingAddress;
            if (value.BillingState != null)
                data.Properties[vocab.BillingState] = value.BillingState;
            if (value.BillingStateCode != null)
                data.Properties[vocab.BillingStateCode] = value.BillingStateCode;
            if (value.BillingStreet != null)
                data.Properties[vocab.BillingStreet] = value.BillingStreet;
            if (value.Bounced__pc != null)
                data.Properties[vocab.BouncedPc] = value.Bounced__pc;
            if (value.Brand__pc != null)
                data.Properties[vocab.BrandPc] = value.Brand__pc;
            if (value.Brand2__pc != null)
                data.Properties[vocab.Brand2Pc] = value.Brand2__pc;
            if (value.Buying_timeframe__pc != null)
                data.Properties[vocab.BuyingTimeframePc] = value.Buying_timeframe__pc;
            if (value.Company_Size__pc != null)
                data.Properties[vocab.CompanySizePc] = value.Company_Size__pc;
            if (value.Contact_Role__pc != null)
                data.Properties[vocab.ContactRolePc] = value.Contact_Role__pc;
            if (value.Current_Car_Brand__pc != null)
                data.Properties[vocab.CurrentCarBrandPc] = value.Current_Car_Brand__pc;
            if (value.CustomerCity__c != null)
                data.Properties[vocab.CustomerCityC] = value.CustomerCity__c;
            //if (!string.IsNullOrWhiteSpace(value.CVR__c))
            if (value.CVR__c != null)
                data.Properties[vocab.CvrC] = value.CVR__c;
            if (value.Dead__c != null)
                data.Properties[vocab.DeadC] = value.Dead__c;
            if (value.DealershipID__c != null)
                data.Properties[vocab.DealershipidC] = value.DealershipID__c;
            if (value.Description != null)
                data.Properties[vocab.Description] = value.Description;
            if (value.FirstName != null)
                data.Properties[vocab.FirstName] = value.FirstName;
            if (value.HashedEmail__pc != null)
                data.Properties[vocab.HashedEmailPc] = value.HashedEmail__pc;
            if (value.ID != null)
                data.Properties[vocab.ID] = value.ID;
            if (value.ID_Email__c != null)
                data.Properties[vocab.IdEmailC] = value.ID_Email__c;
            if (value.ID_Email__pc != null)
                data.Properties[vocab.IdEmailPc] = value.ID_Email__pc;
            if (value.Identity_Kit_Id__pc != null)
                data.Properties[vocab.IdentityKitIdPc] = value.Identity_Kit_Id__pc;
            if (value.IdentityKitId__c != null)
                data.Properties[vocab.IdentityKitIdC] = value.IdentityKitId__c;
            if (value.ID_NG__c != null)
                data.Properties[vocab.IdNgC] = value.ID_NG__c;
            if (value.ID_NG__pc != null)
                data.Properties[vocab.IdNgPc] = value.ID_NG__pc;
            if (value.Industry != null)
                data.Properties[vocab.Industry] = value.Industry;
            if (value.Industry__pc != null)
                data.Properties[vocab.IndustryPc] = value.Industry__pc;
            if (value.InteractionScoreCalculated__pc != null)
                data.Properties[vocab.InteractionScoreCalculatedPc] = value.InteractionScoreCalculated__pc;
            if (value.InteractionScoreLastUpdated__pc != null)
                data.Properties[vocab.InteractionScoreLastUpdatedPc] = value.InteractionScoreLastUpdated__pc;
            if (value.InteractionScore__pc != null)
                data.Properties[vocab.InteractionScorePc] = value.InteractionScore__pc;
            if (value.IsActiveUser__pc != null)
                data.Properties[vocab.IsActiveUserPc] = value.IsActiveUser__pc;
            if (value.IsDeleted != null)
                data.Properties[vocab.IsDeleted] = value.IsDeleted;
            if (value.IsKUKCustomer__c != null)
                data.Properties[vocab.IsKukCustomerC] = value.IsKUKCustomer__c;
            if (value.IsMarketingContact__pc != null)
                data.Properties[vocab.IsMarketingContactPc] = value.IsMarketingContact__pc;
            if (value.IsPartner != null)
                data.Properties[vocab.IsPartner] = value.IsPartner;
            if (value.Is_Partner__pc != null)
                data.Properties[vocab.IsPartnerPc] = value.Is_Partner__pc;
            if (value.IsPersonAccount != null)
                data.Properties[vocab.IsPersonAccount] = value.IsPersonAccount;
            if (value.KUKCode__c != null)
                data.Properties[vocab.KukCodeC] = value.KUKCode__c;
            if (value.KUKCustomerID__c != null)
                data.Properties[vocab.KukCustomerIdC] = value.KUKCustomerID__c;
            if (value.LastActivityDate != null)
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }
            if (value.LastName != null)
                data.Properties[vocab.LastName] = value.LastName;
            if (value.LastReferencedDate != null)
                data.Properties[vocab.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[vocab.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.LeadReassignment__c != null)
                data.Properties[vocab.LeadReassignmentC] = DateUtilities.GetFormattedDateString(value.LeadReassignment__c);
            if (value.MarketingContactHEMKey__c != null)
                data.Properties[vocab.MarketingContactHemKeyC] = DateUtilities.GetFormattedDateString(value.MarketingContactHEMKey__c);
            if (value.MarketingContactKey__c != null)
                data.Properties[vocab.MarketingContactKeyC] = DateUtilities.GetFormattedDateString(value.MarketingContactKey__c);
            if (value.MC_API_Error__pc != null)
                data.Properties[vocab.McApiErrorPc] = DateUtilities.GetFormattedDateString(value.MC_API_Error__pc);
            if (value.MC_API_Status__pc != null)
                data.Properties[vocab.McApiStatusPc] = DateUtilities.GetFormattedDateString(value.MC_API_Status__pc);
            if (value.Number_of_Cars__pc != null)
                data.Properties[vocab.NumberOfCarsPc] = value.Number_of_Cars__pc;
            if (value.NumberOfEmployees != null)
                data.Properties[vocab.NumberOfEmployees] = value.NumberOfEmployees;
            if (value.OrderedLicenses__c != null)
                data.Properties[vocab.OrderedLicensesC] = value.OrderedLicenses__c;
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }
            if (value.Ownership != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Ownership);
                data.Properties[vocab.OwnerShip] = value.Ownership;
            }
            if (value.ParentId != null)
            {
                // TODO: This is wrong! ParentId refers to the parent account
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, value, value.ParentId);
            }
            if (value.Partner_ExtId__c != null)
                data.Properties[vocab.PartnerExtidC] = value.Partner_ExtId__c;
            if (value.Phone != null)
            {
                data.Properties[vocab.Phone] = value.Phone;
                data.Aliases.Add(value.Phone);
            }
            if (value.PhoneFormula__c != null)
                data.Properties[vocab.PhoneFormulaC] = value.PhoneFormula__c;
            if (value.PhotoUrl != null)
                data.Properties[vocab.PhotoUrl] = value.PhotoUrl;
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
            if (value.PostboxName__c != null)
                data.Properties[vocab.PostBoxNameC] = value.PostboxName__c;
            if (value.Prefered_Ownership__pc != null)
                data.Properties[vocab.PreferedOwnershipPc] = value.Prefered_Ownership__pc;
            if (value.PersonAssistantPhone != null)
            {
                data.Properties[vocab.PersonAssistantPhone] = value.PersonAssistantPhone;
                data.Aliases.Add(value.PersonAssistantPhone);
            }
            if (value.PersonBirthDate != null)
                data.Properties[vocab.PersonBirthDate] = value.PersonBirthDate;
            //if (value.PersonContactId != null) data.Properties[SalesforceVocabulary.OrganizationAccount.PersonContactId] = value.PersonContactId;

            if (value.PersonContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Contact, EntityEdgeType.At, value, value.PersonContactId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Infrastructure.Contact, SalesforceConstants.CodeOrigin, value.PersonContactId));
                data.Authors.Add(createdBy);
            }

            if (value.PersonContactId__c != null)
                data.Properties[vocab.PersonContactIdC] = value.PersonContactId__c;
            if (value.PersonDepartment != null)
                data.Properties[vocab.PersonDepartment] = value.PersonDepartment;
            if (value.PersonDonotCall != null)
                data.Properties[vocab.PersonDonotCall] = value.PersonDonotCall;
            if (value.PersonEmail != null)
            {
                data.Properties[vocab.PersonEmail] = value.PersonEmail;
                data.Aliases.Add(value.PersonEmail);
            }
            if (value.PersonEmailBouncedDate != null)
                data.Properties[vocab.PersonEmailBouncedDate] = value.PersonEmailBouncedDate;
            if (value.PersonEmailBouncedReason != null)
                data.Properties[vocab.PersonEmailBouncedReason] = value.PersonEmailBouncedReason;
            if (value.PersonHasOptedOutOfEmail != null)
                data.Properties[vocab.PersonHasOptedOutOfEmail] = value.PersonHasOptedOutOfEmail;
            if (value.PersonHasOptedOutOfFax != null)
                data.Properties[vocab.PersonHasOptedOutOfFax] = value.PersonHasOptedOutOfFax;
            if (value.PersonHomePhone != null)
            {
                data.Properties[vocab.PersonHomePhone] = value.PersonHomePhone;
                data.Aliases.Add(value.PersonHomePhone);
            }
            if (value.PersonLeadSource != null)
                data.Properties[vocab.PersonLeadSource] = value.PersonLeadSource;
            if (value.PersonMailingAddress != null)
                data.Properties[vocab.PersonMailingAddress] = value.PersonMailingAddress;
            if (value.PersonMailingCity != null)
                data.Properties[vocab.PersonMailingCity] = value.PersonMailingCity;
            if (value.PersonMailingCountry != null)
                data.Properties[vocab.PersonMailingCountry] = value.PersonMailingCountry;
            if (value.PersonMailingCountryCode != null)
                data.Properties[vocab.PersonMailingCountryCode] = value.PersonMailingCountryCode;
            if (value.PersonMailingPostalCode != null)
                data.Properties[vocab.PersonMailingPostalCode] = value.PersonMailingPostalCode;
            if (value.PersonMailingState != null)
                data.Properties[vocab.PersonMailingState] = value.PersonMailingState;
            if (value.PersonMailingStateCode != null)
                data.Properties[vocab.PersonMailingStateCode] = value.PersonMailingStateCode;
            if (value.PersonMailingStreet != null)
                data.Properties[vocab.PersonMailingStreet] = value.PersonMailingStreet;
            if (value.PersonMobilePhone != null)
            {
                data.Properties[vocab.PersonMobilePhone] = value.PersonMobilePhone;
                data.Aliases.Add(value.PersonMobilePhone);
            }
            if (value.PersonOtherAddress != null)
                data.Properties[vocab.PersonOtherAddress] = value.PersonOtherAddress;
            if (value.PersonOtherCity != null)
                data.Properties[vocab.PersonOtherCity] = value.PersonOtherCity;
            if (value.PersonOtherCountry != null)
                data.Properties[vocab.PersonOtherCountry] = value.PersonOtherCountry;
            if (value.PersonOtherCountryCode != null)
                data.Properties[vocab.PersonOtherCountryCode] = value.PersonOtherCountryCode;
            if (value.PersonOtherPhone != null)
            {
                data.Properties[vocab.PersonOtherPhone] = value.PersonOtherPhone;
                data.Aliases.Add(value.PersonOtherPhone);
            }
            if (value.PersonOtherPostalCode != null)
                data.Properties[vocab.PersonOtherPostalCode] = value.PersonOtherPostalCode;
            if (value.PersonOtherState != null)
                data.Properties[vocab.PersonOtherState] = value.PersonOtherState;
            if (value.PersonOtherStateCode != null)
                data.Properties[vocab.PersonOtherStateCode] = value.PersonOtherStateCode;
            if (value.PersonOtherStreet != null)
                data.Properties[vocab.PersonOtherStreet] = value.PersonOtherStreet;
            if (value.PersonTitle != null)
                data.Properties[vocab.PersonTitle] = value.PersonTitle;
            if (value.Rating != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Rating);
                data.Properties[vocab.Rating] = value.Rating;
                data.Tags.Add(new Tag(value.Rating));
            }
            if (value.RecordTypeId != null)
                data.Properties[vocab.RecordTypeId] = value.RecordTypeId;
            if (value.Residense_region__pc != null)
                data.Properties[vocab.ResidenseRegionPc] = value.Residense_region__pc;
            if (value.Robinson__c != null)
                data.Properties[vocab.RobinsonC] = value.Robinson__c;
            if (value.Salutation != null)
                data.Properties[vocab.Salutation] = value.Salutation;
            if (value.Seat_Id__c != null)
                data.Properties[vocab.SeatIdC] = value.Seat_Id__c;
            if (value.ShippingAddress != null)
                data.Properties[vocab.ShippingAddress] = value.ShippingAddress;
            if (value.ShippingCity != null)
                data.Properties[vocab.ShippingCity] = value.ShippingCity;
            if (value.ShippingCountry != null)
                data.Properties[vocab.ShippingCountry] = value.ShippingCountry;
            if (value.ShippingCountryCode != null)
                data.Properties[vocab.ShippingCountryCode] = value.ShippingCountryCode;
            if (value.ShippingPostalCode != null)
                data.Properties[vocab.ShippingPostalCode] = value.ShippingPostalCode;
            if (value.ShippingState != null)
                data.Properties[vocab.ShippingState] = value.ShippingState;
            if (value.ShippingStateCode != null)
                data.Properties[vocab.ShippingStateCode] = value.ShippingStateCode;
            if (value.ShippingStreet != null)
                data.Properties[vocab.ShippingStreet] = value.ShippingStreet;
            if (value.Site != null)
                data.Properties[vocab.Site] = value.Site;
            if (value.Skoda_Id__c != null)
                data.Properties[vocab.SkodaIdC] = value.Skoda_Id__c;
            if (value.Started_using_SF__c != null)
                data.Properties[vocab.StartedUsingSfC] = value.Started_using_SF__c;
            if (value.TickerSymbol != null)
                data.Properties[vocab.TickerSymbol] = value.TickerSymbol;
            if (value.Type != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
                data.Properties[vocab.Type] = value.Type;
                data.Tags.Add(new Tag(value.Type));
            }
            if (value.VW_E_Id_c__c != null)
                data.Properties[vocab.VwEIdCC] = value.VW_E_Id_c__c;
            if (value.VW_Id__c != null)
                data.Properties[vocab.VwIdC] = value.VW_Id__c;
            if (value.Website != null)
            {
                data.Properties[vocab.Website] = value.Website;

                Uri website;

                if (Uri.TryCreate(value.Website, UriKind.Absolute, out website))
                {
                    data.ExternalReferences.Add(new Uri(value.Website));
                }
            }
            //if (value.YearStarted != null) data.Properties[SalesforceVocabulary.OrganizationAccount.YearStarted] = value.YearStarted;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
