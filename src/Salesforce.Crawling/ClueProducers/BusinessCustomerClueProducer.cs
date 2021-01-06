//// --------------------------------------------------------------------------------------------------------------------
//// <copyright file="AccountObserver.cs" company="Clued In">
////   Copyright Clued In
//// </copyright>
//// <summary>
////   Defines the AccountObserver type.
//// </summary>
//// --------------------------------------------------------------------------------------------------------------------

//using System;
//using CluedIn.Core;
//using CluedIn.Core.Data;
//using CluedIn.Crawling.Salesforce.Core;
//using CluedIn.Crawling.Factories;
//using CluedIn.Crawling.Salesforce.Core.Models;
//using CluedIn.Crawling.Salesforce.Vocabularies;
//using CluedIn.Core.Utilities;

//namespace CluedIn.Crawling.Salesforce.Subjects
//{
//    public class BusinessCustomerClueProducer : BaseClueProducer<BusinessCustomer>
//    {
//        private readonly IClueFactory _factory;

//        public BusinessCustomerClueProducer([NotNull] IClueFactory factory)
            
//        {
//            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
//        }

//        protected override Clue MakeClueImpl(BusinessCustomer value, Guid id)
//        {
//            Clue clue;
//            clue = _factory.Create(EntityType.Organization, value.ID, id);

//            var data = clue.Data.EntityData;

//            if (value.Name != null)
//            {
//                data.Name = value.Name;
//                data.DisplayName = value.Name;
//                data.Aliases.Add(value.Name);
//            }

//            // TODO: Could this fail? Is this the right name of the JobData?
//            //data.Uri = new Uri($"{_jobData.Token.Data}/{value.ID}");
//            //data.Properties[SalesforceVocabulary.Account.EditUrl] = $"{_jobData.Token.Data}/{value.ID}";
//            if (value.CreatedDate != null)
//            {
//                DateTimeOffset createdDate;
//                if (DateTimeOffset.TryParse(value.CreatedDate, out createdDate))
//                {
//                    data.CreatedDate = createdDate;
//                }
//            }
//            if (value.LastModifiedDate != null)
//            {
//                DateTimeOffset modifiedDate;
//                if (DateTimeOffset.TryParse(value.LastModifiedDate, out modifiedDate))
//                {
//                    data.ModifiedDate = modifiedDate;
//                }
//            }
//            if (value.CreatedById != null)
//            {
//                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);
//                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
//                data.Authors.Add(createdBy);

//                data.LastChangedBy = createdBy;
//            }
//            if (value.LastModifiedById != null)
//            {
//                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
//                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
//                data.Authors.Add(createdBy);

//                data.LastChangedBy = createdBy;
//            }
//            if (value.SystemModstamp != null) data.Properties[SalesforceVocabulary.BusinessCustomer.SystemModstamp] = value.SystemModstamp;
//            if (value.AccountNumber != null) data.Properties[SalesforceVocabulary.BusinessCustomer.AccountNumber] = value.AccountNumber;
//            if (value.AccountSource != null) data.Properties[SalesforceVocabulary.BusinessCustomer.AccountSource] = value.AccountSource;
//            if (value.AgePc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.AgePc] = value.AgePc;
//            if (value.AnnualRevenue != null) data.Properties[SalesforceVocabulary.BusinessCustomer.AnnualRevenue] = value.AnnualRevenue;
//            if (value.AudiIdC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.AudiIdC] = value.AudiIdC;
//            if (value.BillingCity != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BillingCity] = value.BillingCity;
//            if (value.BillingCountry != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BillingCountry] = value.BillingCountry;
//            if (value.BillingCountryCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BillingCountryCode] = value.BillingCountryCode;
//            if (value.BillingPostalCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BillingPostalCode] = value.BillingPostalCode;
//            if (value.BillingAddress != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BillingAddress] = value.BillingAddress;
//            if (value.BillingState != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BillingState] = value.BillingState;
//            if (value.BillingStateCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BillingStateCode] = value.BillingStateCode;
//            if (value.BillingStreet != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BillingStreet] = value.BillingStreet;
//            if (value.BouncedPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BouncedPc] = value.BouncedPc;
//            if (value.BrandPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BrandPc] = value.BrandPc;
//            if (value.Brand2Pc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.Brand2Pc] = value.Brand2Pc;
//            if (value.BuyingTimeframePc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.BuyingTimeframePc] = value.BuyingTimeframePc;
//            if (value.CompanySizePc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.CompanySizePc] = value.CompanySizePc;
//            if (value.ContactRolePc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ContactRolePc] = value.ContactRolePc;
//            if (value.CurrentCarBrandPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.CurrentCarBrandPc] = value.CurrentCarBrandPc;
//            if (value.CustomerCityC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.CustomerCityC] = value.CustomerCityC;
//            if (value.CvrC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.CvrC] = value.CvrC;
//            if (value.DeadC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.DeadC] = value.DeadC;
//            if (value.DealershipidC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.DealershipidC] = value.DealershipidC;
//            if (value.Description != null) data.Properties[SalesforceVocabulary.BusinessCustomer.Description] = value.Description;
//            if (value.FirstName != null) data.Properties[SalesforceVocabulary.BusinessCustomer.FirstName] = value.FirstName;
//            if (value.HashedEmailPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.HashedEmailPc] = value.HashedEmailPc;
//            if (value.ID != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ID] = value.ID;
//            if (value.IdEmailC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IdEmailC] = value.IdEmailC;
//            if (value.IdEmailPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IdEmailPc] = value.IdEmailPc;
//            if (value.IdentityKitIdPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IdentityKitIdPc] = value.IdentityKitIdPc;
//            if (value.IdentityKitIdC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IdentityKitIdC] = value.IdentityKitIdC;
//            if (value.IdNgC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IdNgC] = value.IdNgC;
//            if (value.IdNgPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IdNgPc] = value.IdNgPc;
//            if (value.Industry != null) data.Properties[SalesforceVocabulary.BusinessCustomer.Industry] = value.Industry;
//            if (value.IndustryPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IndustryPc] = value.IndustryPc;
//            if (value.InteractionScoreCalculatedPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.InteractionScoreCalculatedPc] = value.InteractionScoreCalculatedPc;
//            if (value.InteractionScoreLastUpdatedPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.InteractionScoreLastUpdatedPc] = value.InteractionScoreLastUpdatedPc;
//            if (value.InteractionScorePc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.InteractionScorePc] = value.InteractionScorePc;
//            if (value.IsActiveUserPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IsActiveUserPc] = value.IsActiveUserPc;
//            if (value.IsDeleted != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IsDeleted] = value.IsDeleted;
//            if (value.IsKukCustomerC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IsKukCustomerC] = value.IsKukCustomerC;
//            if (value.IsMarketingContactPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IsMarketingContactPc] = value.IsMarketingContactPc;
//            if (value.IsPartner != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IsPartner] = value.IsPartner;
//            if (value.IsPartnerPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IsPartnerPc] = value.IsPartnerPc;
//            if (value.IsPersonAccount != null) data.Properties[SalesforceVocabulary.BusinessCustomer.IsPersonAccount] = value.IsPersonAccount;
//            if (value.KukCodeC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.KukCodeC] = value.KukCodeC;
//            if (value.KukCustomerIdC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.KukCustomerIdC] = value.KukCustomerIdC;
//            if (value.LastActivityDate != null)
//            {
//                DateTime modifiedDateTime;
//                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
//                {
//                    data.ModifiedDate = modifiedDateTime;
//                }
//            }
//            if (value.LastName != null) data.Properties[SalesforceVocabulary.BusinessCustomer.LastName] = value.LastName;
//            if (value.LastReferencedDate != null) data.Properties[SalesforceVocabulary.BusinessCustomer.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
//            if (value.LastViewedDate != null) data.Properties[SalesforceVocabulary.BusinessCustomer.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
//            if (value.LeadReassignmentC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.LeadReassignmentC] = DateUtilities.GetFormattedDateString(value.LeadReassignmentC);
//            if (value.MarketingContactHemKeyC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.MarketingContactHemKeyC] = DateUtilities.GetFormattedDateString(value.MarketingContactHemKeyC);
//            if (value.MarketingContactKeyC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.MarketingContactKeyC] = DateUtilities.GetFormattedDateString(value.MarketingContactKeyC);
//            if (value.McApiErrorPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.McApiErrorPc] = DateUtilities.GetFormattedDateString(value.McApiErrorPc);
//            if (value.McApiStatusPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.McApiStatusPc] = DateUtilities.GetFormattedDateString(value.McApiStatusPc);
//            if (value.NumberOfCarsPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.NumberOfCarsPc] = value.NumberOfCarsPc;
//            if (value.NumberOfEmployees != null) data.Properties[SalesforceVocabulary.BusinessCustomer.NumberOfEmployees] = value.NumberOfEmployees;
//            if (value.OrderedLicensesC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.OrderedLicensesC] = value.OrderedLicensesC;
//            if (value.OwnerId != null)
//            {
//                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
//                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
//                data.Authors.Add(createdBy);
//            }
//            if (value.Ownership != null)
//            {
//                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Ownership);
//                data.Properties[SalesforceVocabulary.BusinessCustomer.OwnerShip] = value.Ownership;
//            }
//            if (value.ParentId != null)
//            {
//                // TODO: This is wrong! ParentId refers to the parent account
//                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, value, value.ParentId);
//            }
//            if (value.PartnerExtidC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PartnerExtidC] = value.PartnerExtidC;
//            if (value.Phone != null)
//            {
//                data.Properties[SalesforceVocabulary.BusinessCustomer.Phone] = value.Phone;
//                data.Aliases.Add(value.Phone);
//            }
//            if (value.PhoneFormulaC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PhoneFormulaC] = value.PhoneFormulaC;
//            if (value.PhotoUrl != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PhotoUrl] = value.PhotoUrl;
//            //if (value.PhotoUrl != null)
//            //{
//            //    if (value.PhotoUrl != null)
//            //    {
//            //        try
//            //        {
//            //            using (var webClient = new WebClient())
//            //            {
//            //                webClient.Headers.Add("Authorization", "Bearer " + _jobData.Token.AccessToken);
//            //                using (var stream = webClient.OpenRead(value.PhotoUrl))
//            //                {
//            //                    var inArray = StreamUtilies.ReadFully(stream);
//            //                    if (inArray != null)
//            //                    {
//            //                        var rawDataPart = new RawDataPart()
//            //                        {
//            //                            Type = "/RawData/PreviewImage",
//            //                            MimeType = CluedIn.Core.FileTypes.MimeType.Jpeg.Code,
//            //                            FileName = "preview_{0}".FormatWith(clue.OriginEntityCode.Key),
//            //                            RawDataMD5 = FileHashUtility.GetMD5Base64String(inArray),
//            //                            RawData = Convert.ToBase64String(inArray)
//            //                        };

//            //                        clue.Details.RawData.Add(rawDataPart);

//            //                        clue.Data.EntityData.PreviewImage = new ImageReferencePart(rawDataPart);
//            //                    }
//            //                }
//            //            }

//            //        }
//            //        catch (Exception exception)
//            //        {
//            //        }
//            //    }
//            //}
//            if (value.PostBoxNameC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PostBoxNameC] = value.PostBoxNameC;
//            if (value.PreferedOwnershipPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PreferedOwnershipPc] = value.PreferedOwnershipPc;
//            if (value.PersonAssistantPhone != null)
//            {
//                data.Properties[SalesforceVocabulary.BusinessCustomer.PersonAssistantPhone] = value.PersonAssistantPhone;
//                data.Aliases.Add(value.PersonAssistantPhone);
//            }
//            if (value.PersonBirthDate != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonBirthDate] = value.PersonBirthDate;
//            //if (value.PersonContactId != null) data.Properties[SalesforceVocabulary.OrganizationAccount.PersonContactId] = value.PersonContactId;

//            if (value.PersonContactId != null)
//            {
//                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Contact, EntityEdgeType.At, value, value.PersonContactId);
//                var createdBy = new PersonReference(new EntityCode(EntityType.Infrastructure.Contact, SalesforceConstants.CodeOrigin, value.PersonContactId));
//                data.Authors.Add(createdBy);
//            }

//            if (value.PersonContactIdC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonContactIdC] = value.PersonContactIdC;
//            if (value.PersonDepartment != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonDepartment] = value.PersonDepartment;
//            if (value.PersonDonotCall != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonDonotCall] = value.PersonDonotCall;
//            if (value.PersonEmail != null)
//            {
//                data.Properties[SalesforceVocabulary.BusinessCustomer.PersonEmail] = value.PersonEmail;
//                data.Aliases.Add(value.PersonEmail);
//            }
//            if (value.PersonEmailBouncedDate != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonEmailBouncedDate] = value.PersonEmailBouncedDate;
//            if (value.PersonEmailBouncedReason != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonEmailBouncedReason] = value.PersonEmailBouncedReason;
//            if (value.PersonHasOptedOutOfEmail != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonHasOptedOutOfEmail] = value.PersonHasOptedOutOfEmail;
//            if (value.PersonHasOptedOutOfFax != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonHasOptedOutOfFax] = value.PersonHasOptedOutOfFax;
//            if (value.PersonHomePhone != null)
//            {
//                data.Properties[SalesforceVocabulary.BusinessCustomer.PersonHomePhone] = value.PersonHomePhone;
//                data.Aliases.Add(value.PersonHomePhone);
//            }
//            if (value.PersonLeadSource != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonLeadSource] = value.PersonLeadSource;
//            if (value.PersonMailingAddress != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMailingAddress] = value.PersonMailingAddress;
//            if (value.PersonMailingCity != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMailingCity] = value.PersonMailingCity;
//            if (value.PersonMailingCountry != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMailingCountry] = value.PersonMailingCountry;
//            if (value.PersonMailingCountryCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMailingCountryCode] = value.PersonMailingCountryCode;
//            if (value.PersonMailingPostalCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMailingPostalCode] = value.PersonMailingPostalCode;
//            if (value.PersonMailingState != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMailingState] = value.PersonMailingState;
//            if (value.PersonMailingStateCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMailingStateCode] = value.PersonMailingStateCode;
//            if (value.PersonMailingStreet != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMailingStreet] = value.PersonMailingStreet;
//            if (value.PersonMobilePhone != null)
//            {
//                data.Properties[SalesforceVocabulary.BusinessCustomer.PersonMobilePhone] = value.PersonMobilePhone;
//                data.Aliases.Add(value.PersonMobilePhone);
//            }
//            if (value.PersonOtherAddress != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherAddress] = value.PersonOtherAddress;
//            if (value.PersonOtherCity != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherCity] = value.PersonOtherCity;
//            if (value.PersonOtherCountry != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherCountry] = value.PersonOtherCountry;
//            if (value.PersonOtherCountryCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherCountryCode] = value.PersonOtherCountryCode;
//            if (value.PersonOtherPhone != null)
//            {
//                data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherPhone] = value.PersonOtherPhone;
//                data.Aliases.Add(value.PersonOtherPhone);
//            }
//            if (value.PersonOtherPostalCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherPostalCode] = value.PersonOtherPostalCode;
//            if (value.PersonOtherState != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherState] = value.PersonOtherState;
//            if (value.PersonOtherStateCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherStateCode] = value.PersonOtherStateCode;
//            if (value.PersonOtherStreet != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonOtherStreet] = value.PersonOtherStreet;
//            if (value.PersonTitle != null) data.Properties[SalesforceVocabulary.BusinessCustomer.PersonTitle] = value.PersonTitle;
//            if (value.Rating != null)
//            {
//                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Rating);
//                data.Properties[SalesforceVocabulary.BusinessCustomer.Rating] = value.Rating;
//                data.Tags.Add(new Tag(value.Rating));
//            }
//            if (value.RecordTypeId != null) data.Properties[SalesforceVocabulary.BusinessCustomer.RecordTypeId] = value.RecordTypeId;
//            if (value.ResidenseRegionPc != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ResidenseRegionPc] = value.ResidenseRegionPc;
//            if (value.RobinsonC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.RobinsonC] = value.RobinsonC;
//            if (value.Salutation != null) data.Properties[SalesforceVocabulary.BusinessCustomer.Salutation] = value.Salutation;
//            if (value.SeatIdC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.SeatIdC] = value.SeatIdC;
//            if (value.ShippingAddress != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ShippingAddress] = value.ShippingAddress;
//            if (value.ShippingCity != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ShippingCity] = value.ShippingCity;
//            if (value.ShippingCountry != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ShippingCountry] = value.ShippingCountry;
//            if (value.ShippingCountryCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ShippingCountryCode] = value.ShippingCountryCode;
//            if (value.ShippingPostalCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ShippingPostalCode] = value.ShippingPostalCode;
//            if (value.ShippingState != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ShippingState] = value.ShippingState;
//            if (value.ShippingStateCode != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ShippingStateCode] = value.ShippingStateCode;
//            if (value.ShippingStreet != null) data.Properties[SalesforceVocabulary.BusinessCustomer.ShippingStreet] = value.ShippingStreet;
//            if (value.Site != null) data.Properties[SalesforceVocabulary.BusinessCustomer.Site] = value.Site;
//            if (value.SkodaIdC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.SkodaIdC] = value.SkodaIdC;
//            if (value.StartedUsingSfC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.StartedUsingSfC] = value.StartedUsingSfC;
//            if (value.TickerSymbol != null) data.Properties[SalesforceVocabulary.BusinessCustomer.TickerSymbol] = value.TickerSymbol;
//            if (value.Type != null)
//            {
//                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
//                data.Properties[SalesforceVocabulary.BusinessCustomer.Type] = value.Type;
//                data.Tags.Add(new Tag(value.Type));
//            }
//            if (value.VwEIdCC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.VwEIdCC] = value.VwEIdCC;
//            if (value.VwIdC != null) data.Properties[SalesforceVocabulary.BusinessCustomer.VwIdC] = value.VwIdC;
//            if (value.Website != null)
//            {
//                data.Properties[SalesforceVocabulary.BusinessCustomer.Website] = value.Website;

//                Uri website;

//                if (Uri.TryCreate(value.Website, UriKind.Absolute, out website))
//                {
//                    data.ExternalReferences.Add(new Uri(value.Website));
//                }
//            }
//            //if (value.YearStarted != null) data.Properties[SalesforceVocabulary.OrganizationAccount.YearStarted] = value.YearStarted;

//            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

//            return clue;
//        }
//    }
//}
