// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AttachmentObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the AttachmentObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    /// <summary>The attachment observer</summary>
    /// <seealso cref="System.IObserver{CluedIn.Crawling.Salesforce.Types.Attachment}" />
    public class AttachmentClueProducer : BaseClueProducer<Attachment>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;

       
        public AttachmentClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));   
        }

        protected override Clue MakeClueImpl(Attachment value, Guid id)
        {
            var clue = _factory.Create(EntityType.Files.File, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Attachment.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

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
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, "Salesforce", value.CreatedById));
                data.Authors.Add(createdBy);
            }

            if (value.LastModifiedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, "Salesforce", value.LastModifiedById));
                data.Authors.Add(createdBy);
            }

            if (value.LastModifiedDate != null)
                data.ModifiedDate = DateTime.Parse(value.LastModifiedDate);
            if (value.CreatedDate != null)
                data.CreatedDate = DateTime.Parse(value.CreatedDate);
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
                data.Properties[SalesforceVocabulary.Attachment.SystemModstamp] = value.SystemModstamp;
            if (value.Description != null)
                data.Description = value.Description;
            //if (value.Body != null)
            //{
            //    data.Properties[SalesforceVocabulary.Attachment.Body] = value.Body;
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

            //            // TODO: Files is indexed twice, with different contents, this should not be indexed and produce hash codes.
            //            FileCrawlingUtility.IndexFile(tempFile, clue.Data, clue, state, this.context);
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        state.Log.Warn(() => "Could not download Salesforce Attachment", ex);
            //    }
            //}


            if (value.BodyLength != null)
                data.Properties[SalesforceVocabulary.Attachment.BodyLength] = value.BodyLength;
            if (value.ConnectionReceivedId != null)
                data.Properties[SalesforceVocabulary.Attachment.ConnectionReceivedId] = value.ConnectionReceivedId;
            if (value.ConnectionSentId != null)
                data.Properties[SalesforceVocabulary.Attachment.ConnectionSentId] = value.ConnectionSentId;
            if (value.ContentType != null)
            {
                data.DocumentMimeType = value.ContentType;
                data.Properties[SalesforceVocabulary.Attachment.ContentType] = value.ContentType;
            }
            if (value.IsEncrypted != null)
                data.Properties[SalesforceVocabulary.Attachment.IsEncrypted] = value.IsEncrypted;
            if (value.IsPartnerShared != null)
                data.Properties[SalesforceVocabulary.Attachment.IsPartnerShared] = value.IsPartnerShared;
            if (value.IsPrivate != null)
                data.Properties[SalesforceVocabulary.Attachment.IsPrivate] = value.IsPrivate;

            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.ParentId != null)
            {
                // TODO: This is wrong. ParentId is not a person
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.Parent,
                 value, value.ParentId);
            }

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            //try
            //{
            //    using (var tempFile = new TemporaryFile(value.Name))
            //    {
            //        using (var webClient = new WebClient())
            //        {
            //            webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
            //            using (var stream = webClient.OpenRead(string.Format("{1}/servlet/servlet.FileDownload?file={0}", value.ID, state.JobData.Token.Data.Replace("https://", "https://a.").Replace("salesforce", "content.force"))))
            //            {
            //                using (var fs = new FileStream(tempFile.FileInfo.FullName, FileMode.OpenOrCreate, FileAccess.Write))
            //                {
            //                    stream.CopyTo(fs);
            //                }
            //            }
            //        }

            //        // TODO: Files is indexed twice, with different contents
            //        FileCrawlingUtility.IndexFile(tempFile, clue.Data, clue, state, this.context);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    state.Log.Warn(() => "Could not download Salesforce Attachment", ex);
            //}

            return clue;
        }
    }
}
