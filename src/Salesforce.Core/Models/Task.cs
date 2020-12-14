using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Task")]
    public class SalesForceTask : SystemObject
    {
        public const string SObjectTypeName = "Task";
        public string AccountId { get; set; }
        public string ActivityDate { get; set; }
        public string CallDisposition { get; set; }
        public string CallDurationInSeconds { get; set; }
        public string CallObject { get; set; }
        public string CallType { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
        [QueryIgnore]
        public string ConnectionSentId { get; set; }
        public string Description { get; set; }
        public string IsArchived { get; set; }
        public string IsClosed { get; set; }
        [QueryIgnore]
        public string IsHighPriority { get; set; }
        public string IsRecurrence { get; set; }
        public string IsReminderSet { get; set; }
        [QueryIgnore]
        public string IsVisibleInSelfService { get; set; }
        public string OwnerId { get; set; }
        public string Priority { get; set; }
        public string RecurrenceActivityId { get; set; }
        public string RecurrenceDayOfMonth { get; set; }
        public string RecurrenceDayOfWeekMask { get; set; }
        public string RecurrenceEndDateOnly { get; set; }
        public string RecurrenceInstance { get; set; }
        public string RecurrenceInterval { get; set; }
        public string RecurrenceMonthOfYear { get; set; }
                [QueryIgnore]
        public string RecurrenceRegeneratedType { get; set; }
        public string RecurrenceStartDateOnly { get; set; }
        public string RecurrenceTimeZoneSidKey { get; set; }
        public string RecurrenceType { get; set; }
        public string ReminderDateTime { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
        [QueryIgnore]
        public string TaskSubtype { get; set; }
        [QueryIgnore]
        public string TaskWhoIds { get; set; }
        [QueryIgnore]
        public string Type { get; set; }
        [QueryIgnore]
        public string WhatCount { get; set; }
        [QueryIgnore]
        public string WhatId { get; set; }
        [QueryIgnore]
        public string WhoCount { get; set; }
        [QueryIgnore]
        public string WhoId { get; set; }

    }
}
