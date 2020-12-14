// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeadObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the LeadObserver type.
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
    public class LeadClueProducer : BaseClueProducer<Lead>
    {
        private readonly IClueFactory _factory;



        public LeadClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Lead value, Guid id)
        {
            var clue = _factory.Create(EntityType.Sales.Lead, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
                data.Aliases.Add(value.Name);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Lead.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            data.Properties[SalesforceVocabulary.Lead.Address] = value.Address;
            data.Properties[SalesforceVocabulary.Lead.AnnualRevenue] = value.AnnualRevenue;
            data.Properties[SalesforceVocabulary.Lead.City] = value.City;

            if (value.CleanStatus != null)
            {
                data.Properties[SalesforceVocabulary.Lead.CleanStatus] = value.CleanStatus;
                data.Tags.Add(new Tag(value.CleanStatus));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.CleanStatus);
            }

            data.Properties[SalesforceVocabulary.Lead.Company] = value.Company;
            data.Properties[SalesforceVocabulary.Lead.CompanyDunsNumber] = value.CompanyDunsNumber;
            data.Properties[SalesforceVocabulary.Lead.ConnectionReceivedId] = value.ConnectionReceivedId;
            data.Properties[SalesforceVocabulary.Lead.ConnectionSentId] = value.ConnectionSentId;

            if (value.ConvertedAccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.ConvertedAccountId);
            }
            if (value.ConvertedContactId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.ConvertedContactId);
            }

            if (value.ConvertedDate != null)
                data.Properties[SalesforceVocabulary.Lead.ConvertedDate] = DateUtilities.GetFormattedDateString(value.ConvertedDate);
            if (value.ConvertedOpportunityId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Deal, EntityEdgeType.For, value, value.ConvertedOpportunityId);
            }

            data.Properties[SalesforceVocabulary.Lead.Country] = value.Country;
            data.Properties[SalesforceVocabulary.Lead.CountryCode] = value.CountryCode;
            data.Properties[SalesforceVocabulary.Lead.CurrencyIsoCode] = value.CurrencyIsoCode;
            data.Properties[SalesforceVocabulary.Lead.Division] = value.Division;
            data.Properties[SalesforceVocabulary.Lead.Email] = value.Email;
            data.Properties[SalesforceVocabulary.Lead.EmailBouncedDate] = DateUtilities.GetFormattedDateString(value.EmailBouncedDate);
            data.Properties[SalesforceVocabulary.Lead.EmailBouncedReason] = value.EmailBouncedReason;
            data.Properties[SalesforceVocabulary.Lead.Fax] = value.Fax;
            data.Properties[SalesforceVocabulary.Lead.FirstName] = value.FirstName;
            data.Properties[SalesforceVocabulary.Lead.GeocodeAccuracy] = value.GeocodeAccuracy;
            data.Properties[SalesforceVocabulary.Lead.HasOptedOutOfEmail] = value.HasOptedOutOfEmail;
            data.Properties[SalesforceVocabulary.Lead.Industry] = value.Industry;
            data.Properties[SalesforceVocabulary.Lead.IsConverted] = value.IsConverted;
            data.Properties[SalesforceVocabulary.Lead.IsDeleted] = value.IsDeleted;
            data.Properties[SalesforceVocabulary.Lead.IsUnreadByOwner] = value.IsUnreadByOwner;
            data.Properties[SalesforceVocabulary.Lead.Jigsaw] = value.Jigsaw;

            if (value.LastActivityDate != null)
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }

            data.Properties[SalesforceVocabulary.Lead.LastName] = value.LastName;
            data.Properties[SalesforceVocabulary.Lead.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            data.Properties[SalesforceVocabulary.Lead.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            data.Properties[SalesforceVocabulary.Lead.Latitude] = value.Latitude;

            if (value.LeadSource != null)
            {
                data.Properties[SalesforceVocabulary.Lead.LeadSource] = value.LeadSource;
                data.Tags.Add(new Tag(value.LeadSource));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.LeadSource);
            }

            data.Properties[SalesforceVocabulary.Lead.Longitude] = value.Longitude;
            data.Properties[SalesforceVocabulary.Lead.MasterRecordId] = value.MasterRecordId;
            data.Properties[SalesforceVocabulary.Lead.MiddleName] = value.MiddleName;
            data.Properties[SalesforceVocabulary.Lead.MobileNumber] = value.MobilePhone;
            data.Properties[SalesforceVocabulary.Lead.NumberOfEmployees] = value.NumberOfEmployees;

            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.PartnerAccountId != null)
            {
                // TODO: The edge type might need to be different https://help.salesforce.com/apex/HTViewHelpDoc?id=leads_fields.htm
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, value, value.PartnerAccountId);
            }

            data.Properties[SalesforceVocabulary.Lead.Phone] = value.Phone;

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
            //        catch (Exception ex)
            //        {
            //            this.state.Log.Warn(() => "Could not download lead image", ex);
            //        }
            //    }
            //}

            data.Properties[SalesforceVocabulary.Lead.PostalCode] = value.PostalCode;
            data.Properties[SalesforceVocabulary.Lead.Rating] = value.Rating;
            data.Properties[SalesforceVocabulary.Lead.RecordTypeId] = value.RecordTypeId;
            data.Properties[SalesforceVocabulary.Lead.Salutation] = value.Salutation;
            data.Properties[SalesforceVocabulary.Lead.State] = value.State;
            data.Properties[SalesforceVocabulary.Lead.StateCode] = value.StateCode;

            if (value.Status != null)
            {
                data.Properties[SalesforceVocabulary.Lead.Status] = value.Status;
                data.Tags.Add(new Tag(value.Status));
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Status);
            }

            data.Properties[SalesforceVocabulary.Lead.Street] = value.Street;
            data.Properties[SalesforceVocabulary.Lead.Suffix] = value.Suffix;
            data.Properties[SalesforceVocabulary.Lead.Title] = value.Title;
            data.Properties[SalesforceVocabulary.Lead.Website] = value.Website;

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

            data.Properties[SalesforceVocabulary.Lead.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
