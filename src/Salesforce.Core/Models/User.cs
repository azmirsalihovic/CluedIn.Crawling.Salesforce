using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("User")]
    public class User : SystemObject
    {
        public const string SObjectTypeName = "User";

        public string AboutMe { get; set; }
        public string AccountId { get; set; }
        [QueryIgnore]
        public string Address { get; set; }
        public string Alias { get; set; }

        [QueryIgnore]
        public string BadgeText { get; set; }
        public string CallCenterId { get; set; }
        public string City { get; set; }
        public string CommunityNickname { get; set; }
        public string CompanyName { get; set; }
        public string ContactId { get; set; }
        public string Country { get; set; }
        [QueryIgnore]
        public string CountryCode { get; set; }
        [QueryIgnore]
        public string CurrentStatus { get; set; }
        [QueryIgnore]
        public string DefaultCurrencyIsoCode { get; set; }
        [QueryIgnore]
        public string DefaultDivision { get; set; }
        public string DefaultGroupNotificationFrequency { get; set; }
        public string DelegatedApproverId { get; set; }
        public string Department { get; set; }
        public string DigestFrequency { get; set; }
        public string Division { get; set; }
        public string Email { get; set; }
        public string EmailEncodingKey { get; set; }
        [QueryIgnore]
        public string EmailPreferencesAutoBcc { get; set; }
                        [QueryIgnore]
        public string EmailPreferencesAutoBccStayInTouch { get; set; }
           [QueryIgnore]
        public string EmailPreferencesStayInTouchReminder { get; set; }
        public string EmployeeNumber { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string FederationIdentifier { get; set; }
        public string FirstName { get; set; }
        public string ForecastEnabled { get; set; }
        public string FullPhotoUrl { get; set; }
        public string IsActive { get; set; }
        [QueryIgnore]
        public string IsPartner { get; set; }
        [QueryIgnore]
        public string IsPortalEnabled { get; set; }
        [QueryIgnore]
        public string IsPortalSelfRegistered { get; set; }
        [QueryIgnore]
        public string IsPrmSuperUser { get; set; }
                   [QueryIgnore]
        public string JigsawImportLimitOverride { get; set; }
        public string LanguageLocaleKey { get; set; }
        public string LastLoginDate { get; set; }
        public string LastName { get; set; }
                  [QueryIgnore]
        public string LastReferencedDate { get; set; }
                  [QueryIgnore]
        public string LastViewedDate { get; set; }
                     [QueryIgnore]
        public string Latitude { get; set; }
        public string LocaleSidKey { get; set; }
                     [QueryIgnore]
        public string Longitude { get; set; }
        [QueryIgnore]
        public string Manager { get; set; }
        public string ManagerId { get; set; }
        [QueryIgnore]
        public string MiddleName { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        public string OfflineTrialExpirationDate { get; set; }
        public string Phone { get; set; }
        [QueryIgnore]
        public string PortalRole { get; set; }
        public string PostalCode { get; set; }
        [QueryIgnore]
        public string ProfileId { get; set; }
        public string ReceivesAdminInfoEmails { get; set; }
        public string ReceivesInfoEmails { get; set; }
                [QueryIgnore]
        public string SenderEmail { get; set; }
               [QueryIgnore]
        public string SenderName { get; set; }
                 [QueryIgnore]
        public string Signature { get; set; }
        public string SmallPhotoUrl { get; set; }
        public string State { get; set; }
        [QueryIgnore]
        public string StateCode { get; set; }
              [QueryIgnore]
        public string StayInTouchNote { get; set; }
              [QueryIgnore]
        public string StayInTouchSignature { get; set; }
              [QueryIgnore]
        public string StayInTouchSubject { get; set; }
        public string Street { get; set; }
        [QueryIgnore]
        public string Suffix { get; set; }
        public string TimeZoneSidKey { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        //public string UserPermissionsCallCenterAutoLogin { get; set; }
        //public string UserPermissionsChatterAnswersUser { get; set; }
        //public string UserPermissionsInteractionUser { get; set; }
        //public string UserPermissionsJigsawProspectingUser { get; set; }
        //public string UserPermissionsKnowledgeUser { get; set; }
        //[QueryIgnore]
        //public string UserPermissionsLiveAgentUser { get; set; }
        //public string UserPermissionsMarketingUser { get; set; }
        //public string UserPermissionsMobileUser { get; set; }
        //public string UserPermissionsOfflineUser { get; set; }
        //public string UserPermissionsSFContentUser { get; set; }
        //public string UserPermissionsSiteforceContributorUser { get; set; }
        //public string UserPermissionsSiteforcePublisherUser { get; set; }
        //public string UserPermissionsSupportUser { get; set; }
        //[QueryIgnore]
        //public string UserPermissionsWirelessUser { get; set; }
        //public string UserPermissionsWorkDotComUserFeature { get; set; }
        //public string UserPreferencesActivityRemindersPopup { get; set; }
        //public string UserPreferencesApexPagesDeveloperMode { get; set; }
        //public string UserPreferencesContentEmailAsAndWhen { get; set; }
        //public string UserPreferencesContentNoEmail { get; set; }
        //public string UserPreferencesEnableAutoSubForFeeds { get; set; }
        //public string UserPreferencesDisableAllFeedsEmail { get; set; }
        //public string UserPreferencesDisableAutoSubForFeeds { get; set; }
        //public string UserPreferencesDisableBookmarkEmail { get; set; }
        //public string UserPreferencesDisableChangeCommentEmail { get; set; }
        //public string UserPreferencesDisableEndorsementEmail { get; set; }
        //public string UserPreferencesDisableFileShareNotificationsForApi { get; set; }
        //public string UserPreferencesDisableFollowersEmail { get; set; }
        //public string UserPreferencesDisableLaterCommentEmail { get; set; }
        //public string UserPreferencesDisableLikeEmail { get; set; }
        //public string UserPreferencesDisableMentionsPostEmail { get; set; }
        //public string UserPreferencesDisableProfilePostEmail { get; set; }
        //public string UserPreferencesDisableSharePostEmail { get; set; }
        //public string UserPreferencesDisableFeedbackEmail { get; set; }
        //public string UserPreferencesDisCommentAfterLikeEmail { get; set; }
        //public string UserPreferencesDisMentionsCommentEmail { get; set; }
        //public string UserPreferencesDisableMessageEmail { get; set; }
        //[QueryIgnore]
        //public string UserPreferencesDisableRewardEmail { get; set; }
        //public string UserPreferencesDisableWorkEmail { get; set; }
        //public string UserPreferencesDisProfPostCommentEmail { get; set; }
        //public string UserPreferencesEventRemindersCheckboxDefault { get; set; }
        //public string UserPreferencesHideChatterOnboardingSplash { get; set; }
        //public string UserPreferencesHideCSNDesktopTask { get; set; }
        //public string UserPreferencesHideCSNGetChatterMobileTask { get; set; }
        //public string UserPreferencesHideSecondChatterOnboardingSplash { get; set; }
        //public string UserPreferencesHideS1BrowserUI { get; set; }
        //public string UserPreferencesJigsawListUser { get; set; }
        //public string UserPreferencesLightningExperiencePreferred { get; set; }
        //public string UserPreferencesOptOutOfTouch { get; set; }
        //[QueryIgnore]
        //public string UserPreferencesPathAssistantCollapsed { get; set; }
        //public string UserPreferencesProcessAssistantCollapsed { get; set; }
        //public string UserPreferencesReminderSoundOff { get; set; }
        //public string UserPreferencesShowCityToExternalUsers { get; set; }
        //public string UserPreferencesShowCityToGuestUsers { get; set; }
        //public string UserPreferencesShowCountryToExternalUsers { get; set; }
        //public string UserPreferencesShowCountryToGuestUsers { get; set; }
        //public string UserPreferencesShowEmailToExternalUsers { get; set; }
        //public string UserPreferencesShowEmailToGuestUsers { get; set; }
        //public string UserPreferencesShowFaxToExternalUsers { get; set; }
        //public string UserPreferencesShowFaxToGuestUsers { get; set; }
        //public string UserPreferencesShowManagerToExternalUsers { get; set; }
        //public string UserPreferencesShowManagerToGuestUsers { get; set; }
        //public string UserPreferencesShowMobilePhoneToExternalUsers { get; set; }
        //public string UserPreferencesShowMobilePhoneToGuestUsers { get; set; }
        //public string UserPreferencesShowPostalCodeToExternalUsers { get; set; }
        //public string UserPreferencesShowPostalCodeToGuestUsers { get; set; }
        //public string UserPreferencesShowProfilePicToGuestUsers { get; set; }
        //public string UserPreferencesShowStateToExternalUsers { get; set; }
        //public string UserPreferencesShowStateToGuestUsers { get; set; }
        //public string UserPreferencesShowStreetAddressToExternalUsers { get; set; }
        //public string UserPreferencesShowStreetAddressToGuestUsers { get; set; }
        //public string UserPreferencesShowTitleToExternalUsers { get; set; }
        //public string UserPreferencesShowTitleToGuestUsers { get; set; }
        //public string UserPreferencesShowWorkPhoneToExternalUsers { get; set; }
        //public string UserPreferencesShowWorkPhoneToGuestUsers { get; set; }
        //public string UserPreferencesTaskRemindersCheckboxDefault { get; set; }
        public string UserRoleId { get; set; }
        public string UserType { get; set; }
        [QueryIgnore]
        public string WirelessEmail { get; set; }
    }
}
