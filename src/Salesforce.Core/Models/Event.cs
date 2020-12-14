
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Event")]
    public class Event : SystemObject
    {
        public const string SObjectTypeName = "Event";

        [QueryIgnore]
        public string AcceptedEventInviteeIds { get; set; }
        public string AccountId { get; set; }
        public string ActivityDate { get; set; }
        public string ActivityDateTime { get; set; }
         [QueryIgnore]
        public string ClientGuid { get; set; }
         [QueryIgnore]
        public string CurrencyIsoCode { get; set; }
         [QueryIgnore]
        public string DeclinedEventInviteeIds { get; set; }
        public string Description { get; set; }
          [QueryIgnore]
        public string Division { get; set; }
        public string DurationInMinutes { get; set; }
        public string EndDateTime { get; set; }
           [QueryIgnore]
        public string EventSubtype { get; set; }
          [QueryIgnore]
        public string EventWhoIds { get; set; }
        public string GroupEventType { get; set; }
        public string IsAllDayEvent { get; set; }
           [QueryIgnore]
        public string IsArchived { get; set; }
           [QueryIgnore]
        public string IsChild { get; set; }
           [QueryIgnore]
        public string IsClientManaged { get; set; }
           [QueryIgnore]
        public string IsGroupEvent { get; set; }
           [QueryIgnore]
        public string IsPrivate { get; set; }
        public string IsRecurrence { get; set; }
        public string IsReminderSet { get; set; }
         [QueryIgnore]
        public string IsVisibleInSelfService { get; set; }
        public string Location { get; set; }
        public string OwnerId { get; set; }
        public string RecurrenceActivityId { get; set; }
        public string RecurrenceDayOfMonth { get; set; }
        public string RecurrenceDayOfWeekMask { get; set; }
        public string RecurrenceEndDateOnly { get; set; }
        public string RecurrenceInstance { get; set; }
        public string RecurrenceInterval { get; set; }
        public string RecurrenceMonthOfYear { get; set; }
        public string RecurrenceStartDateTime { get; set; }
        public string RecurrenceTimeZoneSidKey { get; set; }
        public string RecurrenceType { get; set; }
        public string ReminderDateTime { get; set; }
        public string ShowAs { get; set; }
        public string StartDateTime { get; set; }
        public string Subject { get; set; }
        [QueryIgnore]
        public string Type { get; set; }
           [QueryIgnore]
        public string UndecidedEventInviteeIds { get; set; }
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
