// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TaskObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the TaskObserver type.
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
    public class TaskClueProducer : BaseClueProducer<SalesForceTask>
    {
        private readonly IClueFactory _factory;



        public TaskClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(SalesForceTask value, Guid id)
        {
            var clue = _factory.Create(EntityType.Task, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Subject != null)
            {
                data.Name = value.Subject;
                data.DisplayName = value.Subject;
            }

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.For, value, value.AccountId);
            }

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Task.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.ActivityDate != null)
                data.Properties[SalesforceVocabulary.Task.ActivityDate] = DateUtilities.GetFormattedDateString(value.ActivityDate);
            if (value.CallDisposition != null)
                data.Properties[SalesforceVocabulary.Task.CallDisposition] = value.CallDisposition;
            if (value.CallDurationInSeconds != null)
                data.Properties[SalesforceVocabulary.Task.CallDurationInSeconds] = value.CallDurationInSeconds;
            if (value.CallObject != null)
                data.Properties[SalesforceVocabulary.Task.CallObject] = value.CallObject;
            if (value.CallType != null)
                data.Properties[SalesforceVocabulary.Task.CallType] = value.CallType;
            if (value.ConnectionReceivedId != null)
                data.Properties[SalesforceVocabulary.Task.ConnectionReceivedId] = value.ConnectionReceivedId;
            if (value.ConnectionSentId != null)
                data.Properties[SalesforceVocabulary.Task.ConnectionSentId] = value.ConnectionSentId;
            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.IsArchived != null)
                data.Properties[SalesforceVocabulary.Task.IsArchived] = value.IsArchived;
            if (value.IsClosed != null)
                data.Properties[SalesforceVocabulary.Task.IsClosed] = value.IsClosed;
            if (value.IsHighPriority != null)
                data.Properties[SalesforceVocabulary.Task.IsHighPriority] = value.IsHighPriority;
            if (value.IsRecurrence != null)
                data.Properties[SalesforceVocabulary.Task.IsRecurrence] = value.IsRecurrence;
            if (value.IsReminderSet != null)
                data.Properties[SalesforceVocabulary.Task.IsReminderSet] = value.IsReminderSet;
            if (value.IsVisibleInSelfService != null)
                data.Properties[SalesforceVocabulary.Task.IsVisibleInSelfService] = value.IsVisibleInSelfService;
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);

                data.Properties[SalesforceVocabulary.Task.OwnerName] = value.OwnerId;
            }

            if (value.CreatedDate != null)
                data.CreatedDate = DateTime.Parse(value.CreatedDate);
            if (value.CreatedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
                data.Authors.Add(createdBy);

                data.Properties[SalesforceVocabulary.Task.CreatedByName] = value.CreatedById;
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
                data.Properties[SalesforceVocabulary.Task.SystemModstamp] = value.SystemModstamp;
            if (value.Priority != null)
                data.Properties[SalesforceVocabulary.Task.Priority] = value.Priority;
            if (value.RecurrenceActivityId != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceActivityId] = value.RecurrenceActivityId;
            if (value.RecurrenceDayOfMonth != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceDayOfMonth] = value.RecurrenceDayOfMonth;
            if (value.RecurrenceDayOfWeekMask != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceDayOfWeekMask] = value.RecurrenceDayOfWeekMask;
            if (value.RecurrenceEndDateOnly != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceEndDateOnly] = value.RecurrenceEndDateOnly;
            if (value.RecurrenceInstance != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceInstance] = value.RecurrenceInstance;
            if (value.RecurrenceInterval != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceInterval] = value.RecurrenceInterval;
            if (value.RecurrenceMonthOfYear != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceMonthOfYear] = value.RecurrenceMonthOfYear;
            if (value.RecurrenceRegeneratedType != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceRegeneratedType] = value.RecurrenceRegeneratedType;
            if (value.RecurrenceStartDateOnly != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceStartDateOnly] = value.RecurrenceStartDateOnly;
            if (value.RecurrenceTimeZoneSidKey != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceTimeZoneSidKey] = value.RecurrenceTimeZoneSidKey;
            if (value.RecurrenceType != null)
                data.Properties[SalesforceVocabulary.Task.RecurrenceType] = value.RecurrenceType;
            if (value.ReminderDateTime != null)
                data.Properties[SalesforceVocabulary.Task.ReminderDateTime] = DateUtilities.GetFormattedDateString(value.ReminderDateTime);
            if (value.Status != null)
                data.Properties[SalesforceVocabulary.Task.Status] = value.Status;
            if (value.TaskSubtype != null)
                data.Properties[SalesforceVocabulary.Task.TaskSubtype] = value.TaskSubtype;
            if (value.TaskWhoIds != null)
                data.Properties[SalesforceVocabulary.Task.TaskWhoIds] = value.TaskWhoIds;
            if (value.Type != null)
                data.Properties[SalesforceVocabulary.Task.Type] = value.Type;
            if (value.WhatCount != null)
                data.Properties[SalesforceVocabulary.Task.WhatCount] = value.WhatCount;
            if (value.WhatId != null)
                data.Properties[SalesforceVocabulary.Task.WhatId] = value.WhatId;
            if (value.WhoCount != null)
                data.Properties[SalesforceVocabulary.Task.WhoCount] = value.WhoCount;
            if (value.WhoId != null)
                data.Properties[SalesforceVocabulary.Task.WhoId] = value.WhoId;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
