// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceEventVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceEventVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce event vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceEventVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceEventVocabulary"/> class.
        /// </summary>
        public SalesforceEventVocabulary()
        {
            VocabularyName = "Salesforce Event";
            KeyPrefix      = "salesforce.event";
            KeySeparator   = ".";
            Grouping       = EntityType.Calendar.Event;

            AddGroup("Salesforce Event Details", group =>
            {              
                AcceptedEventInviteeIds  = group.Add(new VocabularyKey("acceptedEventInviteeIds", VocabularyKeyVisibility.Hidden));
                ActivityDate             = group.Add(new VocabularyKey("activityDate", VocabularyKeyDataType.DateTime));
                ActivityDateTime         = group.Add(new VocabularyKey("activityDateTime", VocabularyKeyDataType.DateTime));
                ClientGuid               = group.Add(new VocabularyKey("clientGuid", VocabularyKeyVisibility.Hidden));
                CurrencyIsoCode          = group.Add(new VocabularyKey("currencyIsoCode"));
                DeclinedEventInviteeIds  = group.Add(new VocabularyKey("declinedEventInviteeIds", VocabularyKeyVisibility.Hidden));
                Division                 = group.Add(new VocabularyKey("division"));
                DurationInMinutes        = group.Add(new VocabularyKey("durationInMinutes", VocabularyKeyDataType.Duration));
                EventSubtype             = group.Add(new VocabularyKey("eventSubtype"));
                EventWhoIds              = group.Add(new VocabularyKey("eventWhoIds", VocabularyKeyVisibility.Hidden));
                GroupEventType           = group.Add(new VocabularyKey("groupEventType"));
                IsAllDayEvent            = group.Add(new VocabularyKey("isAllDayEvent", VocabularyKeyDataType.Boolean));
                IsArchived               = group.Add(new VocabularyKey("isArchived", VocabularyKeyVisibility.Hidden));
                IsChild                  = group.Add(new VocabularyKey("isChild", VocabularyKeyVisibility.Hidden));
                IsClientManaged          = group.Add(new VocabularyKey("isClientManaged", VocabularyKeyVisibility.Hidden));
                IsGroupEvent             = group.Add(new VocabularyKey("isGroupEvent", VocabularyKeyDataType.Boolean));
                IsPrivate                = group.Add(new VocabularyKey("isPrivate", VocabularyKeyDataType.Boolean));
                IsRecurrence             = group.Add(new VocabularyKey("isRecurrence", VocabularyKeyDataType.Boolean));
                IsReminderSet            = group.Add(new VocabularyKey("isReminderSet", VocabularyKeyDataType.Boolean));
                IsVisibleInSelfService   = group.Add(new VocabularyKey("isVisibleInSelfService", VocabularyKeyVisibility.Hidden));
                RecurrenceActivityId     = group.Add(new VocabularyKey("recurrenceActivityId", VocabularyKeyVisibility.Hidden));
                RecurrenceDayOfMonth     = group.Add(new VocabularyKey("recurrenceDayOfMonth"));
                RecurrenceDayOfWeekMask  = group.Add(new VocabularyKey("recurrenceDayOfWeekMask"));
                RecurrenceEndDateOnly    = group.Add(new VocabularyKey("recurrenceEndDateOnly"));
                RecurrenceInstance       = group.Add(new VocabularyKey("recurrenceInstance"));
                RecurrenceMonthOfYear    = group.Add(new VocabularyKey("recurrenceMonthOfYear", VocabularyKeyDataType.Number));
                RecurrenceStartDateTime  = group.Add(new VocabularyKey("recurrenceStartDateTime", VocabularyKeyDataType.DateTime));
                RecurrenceTimeZoneSidKey = group.Add(new VocabularyKey("recurrenceTimeZoneSidKey"));
                RecurrenceType           = group.Add(new VocabularyKey("recurrenceType"));
                ReminderDateTime         = group.Add(new VocabularyKey("reminderDateTime", VocabularyKeyDataType.DateTime));
                ShowAs                   = group.Add(new VocabularyKey("showAs"));
                Type                     = group.Add(new VocabularyKey("type"));
                UndecidedEventInviteeIds = group.Add(new VocabularyKey("undecidedEventInviteeIds", VocabularyKeyVisibility.Hidden));
                WhatCount                = group.Add(new VocabularyKey("whatCount", VocabularyKeyDataType.Number));
                WhatId                   = group.Add(new VocabularyKey("whatId", VocabularyKeyVisibility.Hidden));
                WhoCount                 = group.Add(new VocabularyKey("whoCount", VocabularyKeyDataType.Number));
                WhoId                    = group.Add(new VocabularyKey("whoId", VocabularyKeyVisibility.Hidden));
                SystemModstamp           = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                Location                 = group.Add(new VocabularyKey("location"));
                StartDateTime            = group.Add(new VocabularyKey("startDateTime", VocabularyKeyDataType.DateTime));
                EndDateTime              = group.Add(new VocabularyKey("endDateTime", VocabularyKeyDataType.DateTime));
            });

            DayOfWeek = Add(new VocabularyKey("DayOfWeek", VocabularyKeyVisibility.Hidden));
            EditUrl   = Add(new VocabularyKey("editUrl"));

            AddMapping(DayOfWeek,         CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInEvent.DayOfWeek);
            AddMapping(Location,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInEvent.Location);
            AddMapping(StartDateTime,     CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInEvent.Start);
            AddMapping(EndDateTime,       CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInEvent.End);
            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey AcceptedEventInviteeIds { get; protected set; }
        public VocabularyKey ActivityDate { get; protected set; }
        public VocabularyKey ActivityDateTime { get; protected set; }
        public VocabularyKey ClientGuid { get; protected set; }
        public VocabularyKey CurrencyIsoCode { get; protected set; }
        public VocabularyKey DeclinedEventInviteeIds { get; protected set; }
        public VocabularyKey Division { get; protected set; }
        public VocabularyKey DurationInMinutes { get; protected set; }
        public VocabularyKey EventSubtype { get; protected set; }
        public VocabularyKey EventWhoIds { get; protected set; }
        public VocabularyKey GroupEventType { get; protected set; }
        public VocabularyKey IsAllDayEvent { get; protected set; }
        public VocabularyKey IsArchived { get; protected set; }
        public VocabularyKey IsChild { get; protected set; }
        public VocabularyKey IsClientManaged { get; protected set; }
        public VocabularyKey IsGroupEvent { get; protected set; }
        public VocabularyKey IsPrivate { get; protected set; }
        public VocabularyKey IsRecurrence { get; protected set; }
        public VocabularyKey IsReminderSet { get; protected set; }
        public VocabularyKey IsVisibleInSelfService { get; protected set; }
        public VocabularyKey RecurrenceActivityId { get; protected set; }
        public VocabularyKey RecurrenceDayOfMonth { get; protected set; }
        public VocabularyKey RecurrenceDayOfWeekMask { get; protected set; }
        public VocabularyKey RecurrenceEndDateOnly { get; protected set; }
        public VocabularyKey RecurrenceInstance { get; protected set; }
        public VocabularyKey RecurrenceMonthOfYear { get; protected set; }
        public VocabularyKey RecurrenceStartDateTime { get; protected set; }
        public VocabularyKey RecurrenceTimeZoneSidKey { get; protected set; }
        public VocabularyKey RecurrenceType { get; protected set; }
        public VocabularyKey ReminderDateTime { get; protected set; }
        public VocabularyKey ShowAs { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey UndecidedEventInviteeIds { get; protected set; }
        public VocabularyKey WhatCount { get; protected set; }
        public VocabularyKey WhatId { get; protected set; }
        public VocabularyKey WhoCount { get; protected set; }
        public VocabularyKey WhoId { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey Location { get; protected set; }
        public VocabularyKey StartDateTime { get; protected set; }
        public VocabularyKey EndDateTime { get; protected set; }
        public VocabularyKey DayOfWeek { get; protected set; }
    }
}