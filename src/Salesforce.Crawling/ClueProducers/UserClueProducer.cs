// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the UserObserver type.
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
    public class UserClueProducer : BaseClueProducer<User>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;

        

        public UserClueProducer([NotNull] IClueFactory factory)
            
        {
            _factory    = factory ?? throw new ArgumentNullException(nameof(factory));
            
        }

        protected override Clue MakeClueImpl(User value, Guid id)
        {
                        var clue = _factory.Create(EntityType.Person, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
              
            }
            
            if (value.AboutMe != null)
            {
                data.Description = value.AboutMe;
            }

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, value, value.AccountId);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.User.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            data.Properties[SalesforceVocabulary.User.Address] = value.Address;

            if (value.Alias != null)
            {
                data.Aliases.Add(value.Alias);
            }

            data.Properties[SalesforceVocabulary.User.BadgeText] = value.BadgeText;

            if (value.CallCenterId != null)
            {
                // TODO:Edge?
                data.Properties[SalesforceVocabulary.User.CallCenterId] = value.CallCenterId;
            }

            data.Properties[SalesforceVocabulary.User.City] = value.City;

            if (value.CommunityNickname != null)
            {
                data.Properties[SalesforceVocabulary.User.CommunityNickname] = value.CommunityNickname;
                data.Codes.Add(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CommunityNickname));
                data.Aliases.Add(value.CommunityNickname);
            }

            data.Properties[SalesforceVocabulary.User.CompanyName] = value.CompanyName;

            if (value.ContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.For, value, value.ContactId);
            }

            data.Properties[SalesforceVocabulary.User.Country]                           = value.Country;
            data.Properties[SalesforceVocabulary.User.CountryCode]                       = value.CountryCode;
            data.Properties[SalesforceVocabulary.User.CurrentStatus]                     = value.CurrentStatus;
            data.Properties[SalesforceVocabulary.User.DefaultCurrencyIsoCode]            = value.DefaultCurrencyIsoCode;
            data.Properties[SalesforceVocabulary.User.DefaultDivision]                   = value.DefaultDivision;
            data.Properties[SalesforceVocabulary.User.DefaultGroupNotificationFrequency] = value.DefaultGroupNotificationFrequency;

            if (value.DelegatedApproverId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.WorkedOnBy, value, value.DelegatedApproverId);
            }

            data.Properties[SalesforceVocabulary.User.Department]      = value.Department;
            data.Properties[SalesforceVocabulary.User.DigestFrequency] = value.DigestFrequency;
            data.Properties[SalesforceVocabulary.User.Division]        = value.Division;

            if (value.Email != null)
            {
                data.Codes.Add(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.Email));
                data.Properties[SalesforceVocabulary.User.Email] = value.Email;
            }

            data.Properties[SalesforceVocabulary.User.EmailEncodingKey]                    = value.EmailEncodingKey;
            data.Properties[SalesforceVocabulary.User.EmailPreferencesAutoBcc]             = value.EmailPreferencesAutoBcc;
            data.Properties[SalesforceVocabulary.User.EmailPreferencesAutoBccStayInTouch]  = value.EmailPreferencesAutoBccStayInTouch;
            data.Properties[SalesforceVocabulary.User.EmailPreferencesStayInTouchReminder] = value.EmailPreferencesStayInTouchReminder;
            data.Properties[SalesforceVocabulary.User.EmployeeNumber]                      = value.EmployeeNumber;
            data.Properties[SalesforceVocabulary.User.Extension]                           = value.Extension;
            data.Properties[SalesforceVocabulary.User.Fax]                                 = value.Fax;
            data.Properties[SalesforceVocabulary.User.FederationIdentifier]                = value.FederationIdentifier;
            data.Properties[SalesforceVocabulary.User.FirstName]                           = value.FirstName;
            data.Properties[SalesforceVocabulary.User.ForecastEnabled]                     = value.ForecastEnabled;

            //if (value.FullPhotoUrl != null)
            //{
            //    if (value.FullPhotoUrl != null)
            //    {
            //        try
            //        {
            //            using (var webClient = new WebClient())
            //            {
            //                webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
            //                using (var stream = webClient.OpenRead(value.FullPhotoUrl))
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
            //            state.Log.Warn(() => "Could not download FullPhotoUrl for Salesforce User", exception);
            //        }
            //    }
            //}

            data.Properties[SalesforceVocabulary.User.IsActive]                  = value.IsActive;
            data.Properties[SalesforceVocabulary.User.IsPartner]                 = value.IsPartner;
            data.Properties[SalesforceVocabulary.User.IsPortalEnabled]           = value.IsPortalEnabled;
            data.Properties[SalesforceVocabulary.User.IsPortalSelfRegistered]    = value.IsPortalSelfRegistered;
            data.Properties[SalesforceVocabulary.User.IsPrmSuperUser]            = value.IsPrmSuperUser;
            data.Properties[SalesforceVocabulary.User.JigsawImportLimitOverride] = value.JigsawImportLimitOverride;
            data.Properties[SalesforceVocabulary.User.LanguageLocaleKey]         = value.LanguageLocaleKey;
            data.Properties[SalesforceVocabulary.User.LastName]                  = value.LastName;
            data.Properties[SalesforceVocabulary.User.LastReferencedDate]        = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            data.Properties[SalesforceVocabulary.User.LastViewedDate]            = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            data.Properties[SalesforceVocabulary.User.Latitude]                  = value.Latitude;
            data.Properties[SalesforceVocabulary.User.LocaleSidKey]              = value.LocaleSidKey;
            data.Properties[SalesforceVocabulary.User.Longitude]                 = value.Longitude;
            data.Properties[SalesforceVocabulary.User.Manager]                   = value.Manager;


            if (value.ManagerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ManagedBy, value, value.ManagerId);
            }

            data.Properties[SalesforceVocabulary.User.MiddleName]                       = value.MiddleName;
            data.Properties[SalesforceVocabulary.User.MobilePhone]                      = value.MobilePhone;
            data.Properties[SalesforceVocabulary.User.OfflineTrialExpirationDate]       = DateUtilities.GetFormattedDateString(value.OfflineTrialExpirationDate);
            data.Properties[SalesforceVocabulary.User.Phone]                            = value.Phone;
            data.Properties[SalesforceVocabulary.User.PortalRole]                       = value.PortalRole;
            data.Properties[SalesforceVocabulary.User.PostalCode]                       = value.PostalCode;

            if (value.ProfileId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.Has, value, value.ProfileId);
            }

            data.Properties[SalesforceVocabulary.User.ReceivesAdminInfoEmails] = value.ReceivesAdminInfoEmails;
            data.Properties[SalesforceVocabulary.User.ReceivesInfoEmails]      = value.ReceivesInfoEmails;
            data.Properties[SalesforceVocabulary.User.SenderEmail]             = value.SenderEmail;
            data.Properties[SalesforceVocabulary.User.SenderName]              = value.SenderName;
            data.Properties[SalesforceVocabulary.User.Signature]               = value.Signature;

            if (value.SmallPhotoUrl != null)
            {
                data.Properties[SalesforceVocabulary.User.SmallPhotoUrl] = value.SmallPhotoUrl;
            }

            data.Properties[SalesforceVocabulary.User.State]                = value.State;
            data.Properties[SalesforceVocabulary.User.StateCode]            = value.StateCode;
            data.Properties[SalesforceVocabulary.User.StayInTouchNote]      = value.StayInTouchNote;
            data.Properties[SalesforceVocabulary.User.StayInTouchSignature] = value.StayInTouchSignature;
            data.Properties[SalesforceVocabulary.User.StayInTouchSubject]   = value.StayInTouchSubject;
            data.Properties[SalesforceVocabulary.User.Street]               = value.Street;
            data.Properties[SalesforceVocabulary.User.Suffix]               = value.Suffix;
            data.Properties[SalesforceVocabulary.User.TimeZoneSidKey]       = value.TimeZoneSidKey;
            data.Properties[SalesforceVocabulary.User.Title]                = value.Title;

            if (value.UserRoleId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Has, value, value.UserRoleId);
            }

            if (value.CreatedDate != null) data.CreatedDate = DateTime.Parse(value.CreatedDate);
            if (value.CreatedById != null)
            {
                if (value.CreatedById != value.ID)
                {
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);
                    var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
                    data.Authors.Add(createdBy);
                }
            }

            if (value.LastModifiedById != null)
            {
                if (value.LastModifiedById != value.ID)
                {
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                    var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                    data.Authors.Add(createdBy);
                }
            }

            if (value.LastModifiedDate != null) data.ModifiedDate = DateTime.Parse(value.LastModifiedDate);
            
            data.Properties[SalesforceVocabulary.User.SystemModstamp] = value.SystemModstamp;
            data.Properties[SalesforceVocabulary.User.UserType]       = value.UserType;
            data.Properties[SalesforceVocabulary.User.UserName]       = value.Username;

            if (value.WirelessEmail != null)
            {
                data.Aliases.Add(value.WirelessEmail);
                data.Properties[SalesforceVocabulary.User.WirelessEmail] = value.WirelessEmail;
            }

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
