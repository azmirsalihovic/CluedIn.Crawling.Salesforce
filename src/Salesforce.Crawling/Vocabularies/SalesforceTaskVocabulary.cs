// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceTaskVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceTaskVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce task vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceTaskVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceTaskVocabulary"/> class.
        /// </summary>
        public SalesforceTaskVocabulary()
        {
            VocabularyName = "Salesforce Task";
            KeyPrefix      = "salesforce.task";
            KeySeparator   = ".";
            Grouping       = EntityType.Task;

            AddGroup("Salesforce Task Details", group =>
            {
                ActivityDate               = group.Add(new VocabularyKey("activityDate", VocabularyKeyDataType.DateTime));
                CallDisposition            = group.Add(new VocabularyKey("callDisposition"));
                CallDurationInSeconds      = group.Add(new VocabularyKey("callDurationInSeconds", VocabularyKeyDataType.Duration));
                CallObject                 = group.Add(new VocabularyKey("callObject"));
                CallType                   = group.Add(new VocabularyKey("callType"));
                ConnectionReceivedId       = group.Add(new VocabularyKey("connectionReceivedId", VocabularyKeyVisibility.Hidden));
                ConnectionSentId           = group.Add(new VocabularyKey("connectionSentId", VocabularyKeyVisibility.Hidden));
                IsArchived                 = group.Add(new VocabularyKey("isArchived", VocabularyKeyVisibility.Hidden));
                IsClosed                   = group.Add(new VocabularyKey("isClosed", VocabularyKeyDataType.Boolean));
                IsHighPriority             = group.Add(new VocabularyKey("isHighPriority", VocabularyKeyDataType.Boolean));
                IsRecurrence               = group.Add(new VocabularyKey("isRecurrence", VocabularyKeyDataType.Boolean));
                IsReminderSet              = group.Add(new VocabularyKey("isReminderSet", VocabularyKeyDataType.Boolean));
                IsVisibleInSelfService     = group.Add(new VocabularyKey("isVisibleInSelfService", VocabularyKeyVisibility.Hidden));
                SystemModstamp             = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                RecurrenceActivityId       = group.Add(new VocabularyKey("recurrenceActivityId", VocabularyKeyVisibility.Hidden));
                RecurrenceDayOfMonth       = group.Add(new VocabularyKey("recurrenceDayOfMonth"));
                RecurrenceDayOfWeekMask    = group.Add(new VocabularyKey("recurrenceDayOfWeekMask"));
                RecurrenceEndDateOnly      = group.Add(new VocabularyKey("recurrenceEndDateOnly"));
                RecurrenceInstance         = group.Add(new VocabularyKey("recurrenceInstance"));
                RecurrenceInterval         = group.Add(new VocabularyKey("recurrenceInterval"));
                RecurrenceMonthOfYear      = group.Add(new VocabularyKey("recurrenceMonthOfYear"));
                RecurrenceRegeneratedType  = group.Add(new VocabularyKey("recurrenceRegeneratedType"));
                RecurrenceStartDateOnly    = group.Add(new VocabularyKey("recurrenceStartDateOnly"));
                RecurrenceTimeZoneSidKey   = group.Add(new VocabularyKey("recurrenceTimeZoneSidKey"));
                RecurrenceType             = group.Add(new VocabularyKey("recurrenceType"));
                ReminderDateTime           = group.Add(new VocabularyKey("reminderDateTime", VocabularyKeyDataType.DateTime));
                TaskSubtype                = group.Add(new VocabularyKey("taskSubtype"));
                TaskWhoIds                 = group.Add(new VocabularyKey("taskWhoIds", VocabularyKeyVisibility.Hidden));
                WhatCount                  = group.Add(new VocabularyKey("whatCount", VocabularyKeyDataType.Number));
                WhatId                     = group.Add(new VocabularyKey("whatId", VocabularyKeyVisibility.Hidden));
                WhoCount                   = group.Add(new VocabularyKey("whoCount", VocabularyKeyDataType.Number));
                WhoId                      = group.Add(new VocabularyKey("whoId", VocabularyKeyVisibility.Hidden));
                Priority                   = group.Add(new VocabularyKey("priority"));
                Status                     = group.Add(new VocabularyKey("status"));
                Type                       = group.Add(new VocabularyKey("type"));
                OwnerName                  = group.Add(new VocabularyKey("ownerName"));
                CreatedByName              = group.Add(new VocabularyKey("createdByName"));
                EditUrl                    = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(Priority,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInTask.Priority);
            AddMapping(Status,            CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInTask.State);
            AddMapping(Type,              CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInTask.TaskType);
            AddMapping(IsClosed,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInTask.IsCompleted);
            AddMapping(OwnerName,         CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInTask.Owner);
            AddMapping(CreatedByName,     CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInTask.Requester);
            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey ActivityDate { get; protected set; }
        public VocabularyKey CallDisposition { get; protected set; }
        public VocabularyKey CallDurationInSeconds { get; protected set; }
        public VocabularyKey CallObject { get; protected set; }
        public VocabularyKey CallType { get; protected set; }
        public VocabularyKey ConnectionReceivedId { get; protected set; }
        public VocabularyKey ConnectionSentId { get; protected set; }
        public VocabularyKey IsArchived { get; protected set; }
        public VocabularyKey IsClosed { get; protected set; }
        public VocabularyKey IsHighPriority { get; protected set; }
        public VocabularyKey IsRecurrence { get; protected set; }
        public VocabularyKey IsReminderSet { get; protected set; }
        public VocabularyKey IsVisibleInSelfService { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey RecurrenceActivityId { get; protected set; }
        public VocabularyKey RecurrenceDayOfMonth { get; protected set; }
        public VocabularyKey RecurrenceDayOfWeekMask { get; protected set; }
        public VocabularyKey RecurrenceEndDateOnly { get; protected set; }
        public VocabularyKey RecurrenceInstance { get; protected set; }
        public VocabularyKey RecurrenceInterval { get; protected set; }
        public VocabularyKey RecurrenceMonthOfYear { get; protected set; }
        public VocabularyKey RecurrenceRegeneratedType { get; protected set; }
        public VocabularyKey RecurrenceStartDateOnly { get; protected set; }
        public VocabularyKey RecurrenceTimeZoneSidKey { get; protected set; }
        public VocabularyKey RecurrenceType { get; protected set; }
        public VocabularyKey ReminderDateTime { get; protected set; }
        public VocabularyKey TaskSubtype { get; protected set; }
        public VocabularyKey TaskWhoIds { get; protected set; }
        public VocabularyKey WhatCount { get; protected set; }
        public VocabularyKey WhatId { get; protected set; }
        public VocabularyKey WhoCount { get; protected set; }
        public VocabularyKey WhoId { get; protected set; }
        public VocabularyKey Priority { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey OwnerName { get; protected set; }
        public VocabularyKey CreatedByName { get; protected set; }
    }
}