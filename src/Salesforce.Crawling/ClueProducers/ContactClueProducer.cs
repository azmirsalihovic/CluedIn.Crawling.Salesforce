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
using System.Globalization;

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

            // Creates a TextInfo based on the "da-DK" culture.
            TextInfo myTI = new CultureInfo("da-DK", false).TextInfo;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = myTI.ToTitleCase(myTI.ToLower(value.Name));
                data.Aliases.Add(value.Name);
            }

            if (value.ID != null) data.Properties[SalesforceVocabulary.Contact.ID] = value.ID;

            if (value.Description != null) data.Description = value.Description;

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, value, value.AccountId);
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

            if (value.SystemModstamp != null) data.Properties[SalesforceVocabulary.Contact.SystemModstamp] = value.SystemModstamp;
            if (value.AgeC != null) data.Properties[SalesforceVocabulary.Contact.AgeC] = value.AgeC;
            if (value.BouncedC != null) data.Properties[SalesforceVocabulary.Contact.BouncedC] = value.BouncedC;
            if (value.BrandC != null) data.Properties[SalesforceVocabulary.Contact.BrandC] = value.BrandC;
            if (value.Brand2C != null) data.Properties[SalesforceVocabulary.Contact.Brand2C] = value.Brand2C;
            if (value.BuyingTimeframeC != null) data.Properties[SalesforceVocabulary.Contact.BuyingTimeframeC] = value.BuyingTimeframeC;
            if (value.CompanySizeC != null) data.Properties[SalesforceVocabulary.Contact.CompanySizeC] = value.CompanySizeC;
            if (value.ContactRoleC != null) data.Properties[SalesforceVocabulary.Contact.ContactRoleC] = value.ContactRoleC;
            if (value.CurrentCarBrandC != null) data.Properties[SalesforceVocabulary.Contact.CurrentCarBrandC] = value.CurrentCarBrandC;
            if (value.HashedEmailC != null) data.Properties[SalesforceVocabulary.Contact.HashedEmailC] = value.HashedEmailC;
            if (value.IdEmailC != null) data.Properties[SalesforceVocabulary.Contact.IdEmailC] = value.IdEmailC;
            if (value.IdentityKitIdC != null) data.Properties[SalesforceVocabulary.Contact.IdentityKitIdC] = value.IdentityKitIdC;
            if (value.IdNgC != null) data.Properties[SalesforceVocabulary.Contact.IdNgC] = value.IdNgC;
            if (value.IndustryC != null) data.Properties[SalesforceVocabulary.Contact.IndustryC] = value.IndustryC;
            if (value.InteractionScoreC != null) data.Properties[SalesforceVocabulary.Contact.InteractionScoreC] = value.InteractionScoreC;
            if (value.InteractionScoreCalculatedC != null) data.Properties[SalesforceVocabulary.Contact.InteractionScoreCalculatedC] = value.InteractionScoreCalculatedC;
            if (value.InteractionScoreLastUpdatedC != null) data.Properties[SalesforceVocabulary.Contact.InteractionScoreLastUpdatedC] = value.InteractionScoreLastUpdatedC;
            if (value.IsActiveUserC != null) data.Properties[SalesforceVocabulary.Contact.IsActiveUserC] = value.IsActiveUserC;
            if (value.IsMarketingContactC != null) data.Properties[SalesforceVocabulary.Contact.IsMarketingContactC] = value.IsMarketingContactC;
            if (value.IsPartnerC != null) data.Properties[SalesforceVocabulary.Contact.IsPartnerC] = value.IsPartnerC;
            if (value.McApiErrorC != null) data.Properties[SalesforceVocabulary.Contact.McApiErrorC] = value.McApiErrorC;
            if (value.McApiStatusC != null) data.Properties[SalesforceVocabulary.Contact.McApiStatusC] = value.McApiStatusC;
            if (value.NumberOfCarsC != null) data.Properties[SalesforceVocabulary.Contact.NumberOfCarsC] = value.NumberOfCarsC;
            if (value.PreferedOwnershipC != null) data.Properties[SalesforceVocabulary.Contact.PreferedOwnershipC] = value.PreferedOwnershipC;
            if (value.ResidenseRegionC != null) data.Properties[SalesforceVocabulary.Contact.ResidenseRegionC] = value.ResidenseRegionC;
            if (value.IsDeleted != null) data.Properties[SalesforceVocabulary.Contact.IsDeleted] = value.IsDeleted;
            if (value.RecordTypeId != null) data.Properties[SalesforceVocabulary.Contact.RecordTypeId] = value.RecordTypeId;
            if (value.AssistantName != null) data.Properties[SalesforceVocabulary.Contact.AssistantName] = value.AssistantName;
            if (value.AssistantPhone != null)
            {
                data.Properties[SalesforceVocabulary.Contact.AssistantPhone] = value.AssistantPhone;
                data.Aliases.Add(value.AssistantPhone);
            }
            if (value.Birthdate != null) data.Properties[SalesforceVocabulary.Contact.Birthdate] = value.Birthdate;
            if (value.Department != null) data.Properties[SalesforceVocabulary.Contact.Department] = value.Department;
            if (value.DoNotCall != null) data.Properties[SalesforceVocabulary.Contact.DoNotCall] = value.DoNotCall;
            if (value.Email != null)
            {
                data.Properties[SalesforceVocabulary.Contact.Email] = value.Email;
                data.Aliases.Add(value.Email);
            }
            if (value.Fax != null)
            {
                data.Properties[SalesforceVocabulary.Contact.Fax] = value.Fax;
                data.Aliases.Add(value.Fax);
            }
            if (value.FirstName != null) data.Properties[SalesforceVocabulary.Contact.FirstName] = value.FirstName;
            if (value.HomePhone != null)
            {
                data.Properties[SalesforceVocabulary.Contact.HomePhone] = value.HomePhone;
                data.Aliases.Add(value.HomePhone);
            }
            if (value.IsEmailBounced != null) data.Properties[SalesforceVocabulary.Contact.IsEmailBounced] = value.IsEmailBounced;
            if (value.IsPersonAccount != null) data.Properties[SalesforceVocabulary.Contact.IsPersonAccount] = value.IsPersonAccount;
            if (value.LastActivityDate != null)
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }

            if (value.LastCURequestDate != null) data.Properties[SalesforceVocabulary.Contact.LastCURequestDate] = DateUtilities.GetFormattedDateString(value.LastCURequestDate);
            if (value.LastCUUpdateDate != null) data.Properties[SalesforceVocabulary.Contact.LastCUUpdateDate] = DateUtilities.GetFormattedDateString(value.LastCUUpdateDate);
            if (value.LastName != null) data.Properties[SalesforceVocabulary.Contact.LastName] = value.LastName;
            if (value.LastReferencedDate != null) data.Properties[SalesforceVocabulary.Contact.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null) data.Properties[SalesforceVocabulary.Contact.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.LeadSource != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.LeadSource);
                data.Properties[SalesforceVocabulary.Contact.LeadSource] = value.LeadSource;
            }

            if (value.MailingAddress != null) data.Properties[SalesforceVocabulary.Contact.MailingAddress] = value.MailingAddress;
            if (value.MailingCity != null) data.Properties[SalesforceVocabulary.Contact.MailingCity] = value.MailingCity;
            if (value.MailingCountry != null) data.Properties[SalesforceVocabulary.Contact.MailingCountry] = value.MailingCountry;
            if (value.MailingCountryCode != null) data.Properties[SalesforceVocabulary.Contact.MailingCountryCode] = value.MailingCountryCode;
            if (value.MailingGeocodeAccuracy != null) data.Properties[SalesforceVocabulary.Contact.MailingGeocodeAccuracy] = value.MailingGeocodeAccuracy;
            if (value.MailingLatitude != null) data.Properties[SalesforceVocabulary.Contact.MailingLatitude] = value.MailingLatitude;
            if (value.MailingLongitude != null) data.Properties[SalesforceVocabulary.Contact.MailingLongitude] = value.MailingLongitude;
            if (value.MailingPostalCode != null) data.Properties[SalesforceVocabulary.Contact.MailingPostalCode] = value.MailingPostalCode;
            if (value.MailingState != null) data.Properties[SalesforceVocabulary.Contact.MailingState] = value.MailingState;
            if (value.MailingStateCode != null) data.Properties[SalesforceVocabulary.Contact.MailingStateCode] = value.MailingStateCode;
            if (value.MailingStreet != null) data.Properties[SalesforceVocabulary.Contact.MailingStreet] = value.MailingStreet;
            if (value.MasterRecordId != null) data.Properties[SalesforceVocabulary.Contact.MasterRecordId] = value.MasterRecordId;
            if (value.MobilePhone != null)
            {
                data.Properties[SalesforceVocabulary.Contact.MobilePhone] = value.MobilePhone;
                data.Aliases.Add(value.MobilePhone);
            }
            if (value.OtherAddress != null) data.Properties[SalesforceVocabulary.Contact.OtherAddress] = value.OtherAddress;
            if (value.OtherCity != null) data.Properties[SalesforceVocabulary.Contact.OtherCity] = value.OtherCity;
            if (value.OtherCountry != null) data.Properties[SalesforceVocabulary.Contact.OtherCountry] = value.OtherCountry;
            if (value.OtherCountryCode != null) data.Properties[SalesforceVocabulary.Contact.OtherCountryCode] = value.OtherCountryCode;
            if (value.OtherPhone != null)
            {
                data.Properties[SalesforceVocabulary.Contact.OtherPhone] = value.OtherPhone;
                data.Aliases.Add(value.OtherPhone);
            }
            if (value.OtherPostalCode != null) data.Properties[SalesforceVocabulary.Contact.OtherPostalCode] = value.OtherPostalCode;
            if (value.OtherState != null) data.Properties[SalesforceVocabulary.Contact.OtherState] = value.OtherState;
            if (value.OtherStateCode != null) data.Properties[SalesforceVocabulary.Contact.OtherStateCode] = value.OtherStateCode;
            if (value.OtherStreet != null) data.Properties[SalesforceVocabulary.Contact.OtherStreet] = value.OtherStreet;
            if (value.OwnerId != null)
            {
                if (value.OwnerId != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.OwnerId);

                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }
            if (value.Phone != null)
            {
                data.Properties[SalesforceVocabulary.Contact.Phone] = value.Phone;
                data.Aliases.Add(value.Phone);
            }
            if (value.PhotoUrl != null) data.Properties[SalesforceVocabulary.Contact.PhotoUrl] = value.PhotoUrl;
            //if (value.PhotoUrl != null)
            //{
            //    if (value.PhotoUrl != null)
            //    {
            //        try
            //        {
            //            using (var webClient = new WebClient())
            //            {
            //                webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
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
            //            state.Log.Warn(() => "Could not download Contact Thumbnail Preview from SalesForce.", exception);
            //        }
            //    }
            //}

            if (value.ReportsToId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ManagedBy,
                value, value.ReportsToId);
            }

            if (value.Salutation != null) data.Properties[SalesforceVocabulary.Contact.Salutation] = value.Salutation;
            if (value.Title != null) data.Properties[SalesforceVocabulary.Contact.Title] = value.Title;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
