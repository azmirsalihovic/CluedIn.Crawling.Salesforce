// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the EventObserver type.
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
    public class EventClueProducer : BaseClueProducer<Event>
    {
        /// <summary>The factory</summary>
        private readonly IClueFactory _factory;



        public EventClueProducer([NotNull] IClueFactory factory)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        }

        protected override Clue MakeClueImpl(Event value, Guid id)
        {
            var clue = _factory.Create(EntityType.Calendar.Event, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Subject != null)
            {
                data.Name = value.Subject;
                data.DisplayName = value.Subject;
            }

            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.AcceptedEventInviteeIds != null)
            {
                var acceptedEventIds = value.AcceptedEventInviteeIds.Split(',');
                foreach (var acceptedId in acceptedEventIds)
                {
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.InvitedTo, value, acceptedId);
                }

                data.Properties[SalesforceVocabulary.Event.AcceptedEventInviteeIds] = value.AcceptedEventInviteeIds;
            }

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, value, value.AccountId);
            }

            if (value.ActivityDate != null)
            {
                data.Properties[SalesforceVocabulary.Event.ActivityDate] = DateUtilities.GetFormattedDateString(value.ActivityDate);
            }

            if (value.ActivityDateTime != null)
                data.Properties[SalesforceVocabulary.Event.ActivityDateTime] = DateUtilities.GetFormattedDateString(value.ActivityDateTime);
            if (value.ClientGuid != null)
                data.Properties[SalesforceVocabulary.Event.ClientGuid] = value.ClientGuid;
            if (value.CurrencyIsoCode != null)
                data.Properties[SalesforceVocabulary.Event.CurrencyIsoCode] = value.CurrencyIsoCode;
            if (value.DeclinedEventInviteeIds != null)
                data.Properties[SalesforceVocabulary.Event.DeclinedEventInviteeIds] = value.DeclinedEventInviteeIds;

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Event.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            if (value.Division != null)
                data.Properties[SalesforceVocabulary.Event.Division] = value.Division;
            if (value.DurationInMinutes != null)
                data.Properties[SalesforceVocabulary.Event.DurationInMinutes] = value.DurationInMinutes;
            if (value.EndDateTime != null)
            {
                data.Properties[SalesforceVocabulary.Event.EndDateTime] = DateUtilities.GetFormattedDateString(value.EndDateTime);
            }

            data.Properties[SalesforceVocabulary.Event.EventSubtype] = value.EventSubtype;
            data.Properties[SalesforceVocabulary.Event.EventWhoIds] = value.EventWhoIds;
            data.Properties[SalesforceVocabulary.Event.GroupEventType] = value.GroupEventType;
            data.Properties[SalesforceVocabulary.Event.IsAllDayEvent] = value.IsAllDayEvent;
            data.Properties[SalesforceVocabulary.Event.IsArchived] = value.IsArchived;
            data.Properties[SalesforceVocabulary.Event.IsChild] = value.IsChild;
            data.Properties[SalesforceVocabulary.Event.IsClientManaged] = value.IsClientManaged;
            data.Properties[SalesforceVocabulary.Event.IsGroupEvent] = value.IsGroupEvent;
            data.Properties[SalesforceVocabulary.Event.IsPrivate] = value.IsPrivate;
            data.Properties[SalesforceVocabulary.Event.IsRecurrence] = value.IsRecurrence;
            data.Properties[SalesforceVocabulary.Event.IsReminderSet] = value.IsReminderSet;
            data.Properties[SalesforceVocabulary.Event.IsVisibleInSelfService] = value.IsVisibleInSelfService;
            data.Properties[SalesforceVocabulary.Event.Location] = value.Location;
            data.Properties[SalesforceVocabulary.Event.RecurrenceActivityId] = value.RecurrenceActivityId;
            data.Properties[SalesforceVocabulary.Event.RecurrenceDayOfMonth] = value.RecurrenceDayOfMonth;
            data.Properties[SalesforceVocabulary.Event.RecurrenceDayOfWeekMask] = value.RecurrenceDayOfWeekMask;
            data.Properties[SalesforceVocabulary.Event.RecurrenceEndDateOnly] = value.RecurrenceEndDateOnly;
            data.Properties[SalesforceVocabulary.Event.RecurrenceInstance] = value.RecurrenceInstance;
            data.Properties[SalesforceVocabulary.Event.RecurrenceMonthOfYear] = value.RecurrenceMonthOfYear;
            data.Properties[SalesforceVocabulary.Event.RecurrenceStartDateTime] = DateUtilities.GetFormattedDateString(value.RecurrenceStartDateTime);
            data.Properties[SalesforceVocabulary.Event.RecurrenceTimeZoneSidKey] = value.RecurrenceTimeZoneSidKey;
            data.Properties[SalesforceVocabulary.Event.RecurrenceType] = value.RecurrenceType;
            data.Properties[SalesforceVocabulary.Event.ReminderDateTime] = DateUtilities.GetFormattedDateString(value.ReminderDateTime);
            data.Properties[SalesforceVocabulary.Event.ShowAs] = value.ShowAs;

            DateTime startDate;

            if (DateTime.TryParse(value.StartDateTime, out startDate))
            {
                data.Properties[SalesforceVocabulary.Event.DayOfWeek] = startDate.DayOfWeek.ToString();
            }

            data.Properties[SalesforceVocabulary.Event.StartDateTime] = DateUtilities.GetFormattedDateString(value.StartDateTime);
            data.Properties[SalesforceVocabulary.Event.Type] = value.Type;
            data.Properties[SalesforceVocabulary.Event.UndecidedEventInviteeIds] = value.UndecidedEventInviteeIds;
            data.Properties[SalesforceVocabulary.Event.WhatCount] = value.WhatCount;
            data.Properties[SalesforceVocabulary.Event.WhatId] = value.WhatId;
            data.Properties[SalesforceVocabulary.Event.WhoCount] = value.WhoCount;
            data.Properties[SalesforceVocabulary.Event.WhoId] = value.WhoId;

            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
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
                data.Properties[SalesforceVocabulary.Event.SystemModstamp] = value.SystemModstamp;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
