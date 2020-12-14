// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceCaseVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceCaseVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce case vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceCaseVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceCaseVocabulary"/> class.
        /// </summary>
        public SalesforceCaseVocabulary()
        {
            VocabularyName = "Salesforce Case";
            KeyPrefix      = "salesforce.case";
            KeySeparator   = ".";
            Grouping       = EntityType.Issue;

            AddGroup("Salesforce Case Details", group =>
            {
                SystemModstamp             = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                CaseNumber                 = group.Add(new VocabularyKey("caseNumber", VocabularyKeyDataType.Number));
                ClosedDate                 = group.Add(new VocabularyKey("closedDate", VocabularyKeyDataType.DateTime));
                ConnectionReceivedId       = group.Add(new VocabularyKey("connectionReceivedId", VocabularyKeyVisibility.Hidden));
                ConnectionSentId           = group.Add(new VocabularyKey("connectionSentId", VocabularyKeyVisibility.Hidden));
                CreatorName                = group.Add(new VocabularyKey("creatorName"));
                CreatorSmallPhotoUrl       = group.Add(new VocabularyKey("creatorSmallPhotoUrl", VocabularyKeyDataType.Uri));
                HasCommentsUnreadByOwner   = group.Add(new VocabularyKey("hasCommentsUnreadByOwner", VocabularyKeyDataType.Boolean));
                HasSelfServiceComments     = group.Add(new VocabularyKey("hasSelfServiceComments", VocabularyKeyDataType.Boolean));
                IsClosed                   = group.Add(new VocabularyKey("isClosed", VocabularyKeyDataType.Boolean));
                IsClosedOnCreate           = group.Add(new VocabularyKey("isClosedOnCreate", VocabularyKeyVisibility.Hidden));
                IsDeleted                  = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                IsEscalated                = group.Add(new VocabularyKey("isEscalated", VocabularyKeyDataType.Boolean));
                IsSelfServiceClosed        = group.Add(new VocabularyKey("isSelfServiceClosed", VocabularyKeyDataType.Boolean));
                IsStopped                  = group.Add(new VocabularyKey("isStopped", VocabularyKeyDataType.Boolean));
                IsVisibleInSelfService     = group.Add(new VocabularyKey("isVisibleInSelfService", VocabularyKeyVisibility.Hidden));
                LastReferencedDate         = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate             = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                Origin                     = group.Add(new VocabularyKey("origin"));
                RecordTypeId               = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                SlaStartDate               = group.Add(new VocabularyKey("slaStartDate", VocabularyKeyDataType.DateTime));
                StopStartDate              = group.Add(new VocabularyKey("stopStartDate", VocabularyKeyDataType.DateTime));
                Subject                    = group.Add(new VocabularyKey("subject"));
                SuppliedCompany            = group.Add(new VocabularyKey("suppliedCompany"));
                SuppliedEmail              = group.Add(new VocabularyKey("suppliedEmail", VocabularyKeyDataType.Email));
                SuppliedName               = group.Add(new VocabularyKey("suppliedName"));
                SuppliedPhone              = group.Add(new VocabularyKey("suppliedPhone", VocabularyKeyDataType.PhoneNumber));
                Type                       = group.Add(new VocabularyKey("type"));
                Reason                     = group.Add(new VocabularyKey("reason"));
                Status                     = group.Add(new VocabularyKey("status"));
                Priority                   = group.Add(new VocabularyKey("priority"));
                EditUrl                    = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
            });

            AddMapping(Status,            CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInTask.State);
            AddMapping(Priority,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInTask.Priority);
            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey CaseNumber { get; protected set; }
        public VocabularyKey ClosedDate { get; protected set; }
        public VocabularyKey ConnectionReceivedId { get; protected set; }
        public VocabularyKey ConnectionSentId { get; protected set; }
        public VocabularyKey CreatorName { get; protected set; }
        public VocabularyKey CreatorSmallPhotoUrl { get; protected set; }
        public VocabularyKey HasCommentsUnreadByOwner { get; protected set; }
        public VocabularyKey HasSelfServiceComments { get; protected set; }
        public VocabularyKey IsClosed { get; protected set; }
        public VocabularyKey IsClosedOnCreate { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey IsEscalated { get; protected set; }
        public VocabularyKey IsSelfServiceClosed { get; protected set; }
        public VocabularyKey IsStopped { get; protected set; }
        public VocabularyKey IsVisibleInSelfService { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey Origin { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey SlaStartDate { get; protected set; }
        public VocabularyKey StopStartDate { get; protected set; }
        public VocabularyKey Subject { get; protected set; }
        public VocabularyKey SuppliedCompany { get; protected set; }
        public VocabularyKey SuppliedEmail { get; protected set; }
        public VocabularyKey SuppliedName { get; protected set; }
        public VocabularyKey SuppliedPhone { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey Reason { get; protected set; }
        public VocabularyKey Status { get; protected set; }
        public VocabularyKey Priority { get; protected set; }
        public VocabularyKey EditUrl { get; protected set; }
    }
}