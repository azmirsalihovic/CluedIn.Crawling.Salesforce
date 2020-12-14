// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProfileObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the ProfileObserver type.
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
    public class ProfileClueProducer : BaseClueProducer<Profile>
    {
        private readonly IClueFactory _factory;



        public ProfileClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Profile value, Guid id)
        {
            var clue = _factory.Create(EntityType.Person, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
                data.Aliases.Add(value.Name);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Profile.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.IsSsoEnabled != null)
                data.Properties[SalesforceVocabulary.Profile.IsSsoEnabled] = value.IsSsoEnabled;
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Profile.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Profile.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.PermissionsPermissionName != null)
                data.Properties[SalesforceVocabulary.Profile.PermissionsPermissionName] = value.PermissionsPermissionName;
            if (value.UserLicenseId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Note, EntityEdgeType.For, value, value.UserLicenseId);
            }

            if (value.UserType != null)
                data.Properties[SalesforceVocabulary.Profile.UserType] = value.UserType;
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

            if (value.LastModifiedDate != null)
                data.ModifiedDate = DateTime.Parse(value.LastModifiedDate);
            if (value.SystemModstamp != null)
                data.Properties[SalesforceVocabulary.Profile.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
