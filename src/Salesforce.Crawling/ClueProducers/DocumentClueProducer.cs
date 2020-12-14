// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DocumentObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the DocumentObserver type.
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
    public class DocumentClueProducer : BaseClueProducer<Document>
    {
        private readonly IClueFactory _factory;

        public DocumentClueProducer([NotNull] IClueFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Document value, Guid id)
        {
            var clue = _factory.Create(EntityType.Document, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.AuthorId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.Action.CreatedBy, value, value.AuthorId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.AuthorId));
                data.Authors.Add(createdBy);
            }

            //Index this?
            //if (value.Body != null)
            //{
            //    try
            //    {
            //        using (var tempFile = new TemporaryFile(value.Name))
            //        {
            //            using (var webClient = new WebClient())
            //            {
            //                webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
            //                using (var stream = webClient.OpenRead($"{this.state.JobData.Token.Data}{value.Body}"))
            //                {
            //                    using (var fs = new FileStream(tempFile.FileInfo.FullName, FileMode.OpenOrCreate, FileAccess.Write))
            //                    {
            //                        stream.CopyTo(fs);
            //                    }
            //                }
            //            }

            //            FileCrawlingUtility.IndexFile(tempFile, clue.Data, clue, state, this.context);
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        state.Log.Warn(() => "Could not download Salesforce Document", ex);
            //    }

            //    data.Properties[SalesforceVocabulary.Document.Body] = value.Body;
            //}

            if (value.BodyLength != null)
                data.Properties[SalesforceVocabulary.Document.BodyLength] = value.BodyLength;
            if (value.ContentType != null)
                data.Properties[SalesforceVocabulary.Document.ContentType] = value.ContentType;
            if (value.DeveloperName != null)
                data.Properties[SalesforceVocabulary.Document.DeveloperName] = value.DeveloperName;
            if (value.FolderId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Files.Directory, EntityEdgeType.Parent, value, value.FolderId);
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

            if (value.SystemModstamp != null)
                data.Properties[SalesforceVocabulary.Document.SystemModstamp] = value.SystemModstamp;

            //https://eu5.salesforce.com/
            //https://c.eu5.content.force.com/servlet/servlet.FileDownload?file=015240000018dcd

            //var embedUrl = $"{this.state.JobData.Token.Data.Replace("//", "//c.").Replace("salesforce", "content").Replace(".com", ".force.com")}/servlet/servlet.FileDownload?file={value.ID}";
            //data.Properties[SalesforceVocabulary.Document.EmbedUrl] = embedUrl;

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Document.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.IsBodySearchable != null)
                data.Properties[SalesforceVocabulary.Document.IsBodySearchable] = value.IsBodySearchable;
            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Document.IsDeleted] = value.IsDeleted;
            if (value.IsInternalUseOnly != null)
                data.Properties[SalesforceVocabulary.Document.IsInternalUseOnly] = value.IsInternalUseOnly;
            if (value.IsPublic != null)
                data.Properties[SalesforceVocabulary.Document.IsPublic] = value.IsPublic;
            if (value.Keywords != null)
                data.Properties[SalesforceVocabulary.Document.Keywords] = value.Keywords;
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Document.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Document.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.NamespacePrefix != null)
                data.Properties[SalesforceVocabulary.Document.NamespacePrefix] = value.NamespacePrefix;
            if (value.Type != null)
                data.Properties[SalesforceVocabulary.Document.Type] = value.Type;
            if (value.Url != null)
            {
                Uri uri;

                if (Uri.TryCreate(value.Url, UriKind.Absolute, out uri))
                {
                    data.Uri = uri;
                }
            }

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
