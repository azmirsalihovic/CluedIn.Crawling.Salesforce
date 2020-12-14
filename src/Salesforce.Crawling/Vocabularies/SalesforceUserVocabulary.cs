// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceUserVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   The salesforce user vocabulary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce user vocabulary.</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceUserVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceUserVocabulary"/> class.
        /// </summary>
        public SalesforceUserVocabulary()
        {
            VocabularyName = "Salesforce User";
            KeyPrefix      = "salesforce.user";
            KeySeparator   = ".";
            Grouping       = EntityType.Person;

            AddGroup("Salesforce User Details", group =>
            {
                AboutMe                             = group.Add(new VocabularyKey("aboutMe"));
                BadgeText                           = group.Add(new VocabularyKey("badgeText"));
                CallCenterId                        = group.Add(new VocabularyKey("callCenterId", VocabularyKeyVisibility.Hidden));
                CommunityNickname                   = group.Add(new VocabularyKey("communityNickname"));
                Country                             = group.Add(new VocabularyKey("country", VocabularyKeyDataType.GeographyCountry));
                CurrentStatus                       = group.Add(new VocabularyKey("currentStatus"));
                DefaultCurrencyIsoCode              = group.Add(new VocabularyKey("defaultCurrencyIsoCode"));
                DefaultDivision                     = group.Add(new VocabularyKey("defaultDivision"));
                DefaultGroupNotificationFrequency   = group.Add(new VocabularyKey("defaultGroupNotificationFrequency", VocabularyKeyVisibility.Hidden));
                DigestFrequency                     = group.Add(new VocabularyKey("digestFrequency", VocabularyKeyVisibility.Hidden));
                Division                            = group.Add(new VocabularyKey("division"));
                EmailEncodingKey                    = group.Add(new VocabularyKey("emailEncodingKey", VocabularyKeyVisibility.Hidden));
                EmailPreferencesAutoBcc             = group.Add(new VocabularyKey("emailPreferencesAutoBcc"));
                EmailPreferencesAutoBccStayInTouch  = group.Add(new VocabularyKey("emailPreferencesAutoBccStayInTouch"));
                EmailPreferencesStayInTouchReminder = group.Add(new VocabularyKey("emailPreferencesStayInTouchReminder"));
                Extension                           = group.Add(new VocabularyKey("extension"));
                Fax                                 = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.PhoneNumber));
                FederationIdentifier                = group.Add(new VocabularyKey("federationIdentifier"));
                ForecastEnabled                     = group.Add(new VocabularyKey("forecastEnabled", VocabularyKeyDataType.Boolean));
                IsActive                            = group.Add(new VocabularyKey("isActive", VocabularyKeyDataType.Boolean));
                IsPartner                           = group.Add(new VocabularyKey("isPartner", VocabularyKeyDataType.Boolean));
                IsPortalEnabled                     = group.Add(new VocabularyKey("isPortalEnabled", VocabularyKeyVisibility.Hidden));
                IsPortalSelfRegistered              = group.Add(new VocabularyKey("isPortalSelfRegistered", VocabularyKeyVisibility.Hidden));
                IsPrmSuperUser                      = group.Add(new VocabularyKey("isPrmSuperUser", VocabularyKeyVisibility.Hidden));
                JigsawImportLimitOverride           = group.Add(new VocabularyKey("jigsawImportLimitOverride", VocabularyKeyDataType.Boolean));
                LanguageLocaleKey                   = group.Add(new VocabularyKey("languageLocaleKey", VocabularyKeyVisibility.Hidden));
                LastReferencedDate                  = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate                      = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.ExcludeFromHashing));
                Latitude                            = group.Add(new VocabularyKey("latitude", VocabularyKeyDataType.GeographyCoordinates));
                LocaleSidKey                        = group.Add(new VocabularyKey("localeSidKey", VocabularyKeyVisibility.Hidden));
                Longitude                           = group.Add(new VocabularyKey("longitude", VocabularyKeyDataType.GeographyCoordinates));
                Manager                             = group.Add(new VocabularyKey("manager"));
                OfflineTrialExpirationDate          = group.Add(new VocabularyKey("offlineTrialExpirationDate", VocabularyKeyDataType.DateTime));
                PortalRole                          = group.Add(new VocabularyKey("portalRole"));
                PostalCode                          = group.Add(new VocabularyKey("postalCode", VocabularyKeyDataType.GeographyLocation));
                ReceivesAdminInfoEmails             = group.Add(new VocabularyKey("receivesAdminInfoEmails", VocabularyKeyDataType.Boolean));
                ReceivesInfoEmails                  = group.Add(new VocabularyKey("receivesInfoEmails", VocabularyKeyDataType.Boolean));
                SenderEmail                         = group.Add(new VocabularyKey("senderEmail", VocabularyKeyDataType.Email));
                SenderName                          = group.Add(new VocabularyKey("senderName"));
                Signature                           = group.Add(new VocabularyKey("signature"));
                SmallPhotoUrl                       = group.Add(new VocabularyKey("smallPhotoUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Hidden));
                StateCode                           = group.Add(new VocabularyKey("stateCode", VocabularyKeyDataType.GeographyLocation));
                StayInTouchNote                     = group.Add(new VocabularyKey("stayInTouchNote"));
                StayInTouchSignature                = group.Add(new VocabularyKey("stayInTouchSignature"));
                StayInTouchSubject                  = group.Add(new VocabularyKey("stayInTouchSubject"));
                Suffix                              = group.Add(new VocabularyKey("suffix"));
                TimeZoneSidKey                      = group.Add(new VocabularyKey("timeZoneSidKey", VocabularyKeyVisibility.Hidden));
                SystemModstamp                      = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                UserType                            = group.Add(new VocabularyKey("userType"));
                WirelessEmail                       = group.Add(new VocabularyKey("wirelessEmail", VocabularyKeyVisibility.Hidden));

                Address                             = group.Add(new VocabularyKey("address", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                ChatterActivity                     = group.Add(new VocabularyKey("chatterActivity", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                ChatterInfluence                    = group.Add(new VocabularyKey("chatterInfluence", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                CompanyName                         = group.Add(new VocabularyKey("companyName"));
                Email                               = group.Add(new VocabularyKey("email", VocabularyKeyDataType.Email));
                FirstName                           = group.Add(new VocabularyKey("firstName"));
                FollowersCount                      = group.Add(new VocabularyKey("followersCount", VocabularyKeyDataType.Number));
                FollowingCounts                     = group.Add(new VocabularyKey("followingCounts", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                GroupCount                          = group.Add(new VocabularyKey("groupCount", VocabularyKeyDataType.Number));
                IsInThisCommunity                   = group.Add(new VocabularyKey("isInThisCommunity", VocabularyKeyDataType.Boolean));
                LastName                            = group.Add(new VocabularyKey("lastName"));
                ManagerId                           = group.Add(new VocabularyKey("managerId", VocabularyKeyVisibility.Hidden));
                ManagerName                         = group.Add(new VocabularyKey("managerName"));
                Motif                               = group.Add(new VocabularyKey("motif", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                MySubscription                      = group.Add(new VocabularyKey("mySubscription", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                PhoneNumbers                        = group.Add(new VocabularyKey("phoneNumbers", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                Photo                               = group.Add(new VocabularyKey("photo", VocabularyKeyDataType.Json, VocabularyKeyVisibility.Hidden));
                ThanksReceived                      = group.Add(new VocabularyKey("thanksReceived", VocabularyKeyDataType.Boolean));
                Title                               = group.Add(new VocabularyKey("title"));
                Type                                = group.Add(new VocabularyKey("type"));

                City                                = group.Add(new VocabularyKey("city", VocabularyKeyDataType.GeographyLocation));
                CountryCode                         = group.Add(new VocabularyKey("countryCode", VocabularyKeyDataType.GeographyLocation));
                Department                          = group.Add(new VocabularyKey("department"));
                EmployeeNumber                      = group.Add(new VocabularyKey("employeeNumber", VocabularyKeyDataType.Number));
                MiddleName                          = group.Add(new VocabularyKey("middleName"));
                MobilePhone                         = group.Add(new VocabularyKey("mobilePhone", VocabularyKeyDataType.PhoneNumber));
                Phone                               = group.Add(new VocabularyKey("phone", VocabularyKeyDataType.PhoneNumber));
                State                               = group.Add(new VocabularyKey("state", VocabularyKeyDataType.GeographyLocation));
                Street                              = group.Add(new VocabularyKey("street", VocabularyKeyDataType.GeographyLocation));
                UserName                            = group.Add(new VocabularyKey("userName"));
                EditUrl                             = group.Add(new VocabularyKey("editUrl"));
                AddressCity                         = group.Add(new VocabularyKey("addressCity"));
                AddressCountry                      = group.Add(new VocabularyKey("addressCountry"));
                AddressFormattedAddress             = group.Add(new VocabularyKey("addressFormattedAddress"));
                AddressState                        = group.Add(new VocabularyKey("addressState"));
                AddressStreet                       = group.Add(new VocabularyKey("addressStreet"));
                AddressZip                          = group.Add(new VocabularyKey("addressZip"));
                ChatterActivityCommentCount         = group.Add(new VocabularyKey("chatterActivityCommentCount"));
                ChatterActivityCommentReceivedCount = group.Add(new VocabularyKey("chatterActivityCommentReceivedCount"));
                ChatterActivityLikeReceivedCount    = group.Add(new VocabularyKey("chatterActivityLikeReceivedCount"));
                ChatterActivityPostCount            = group.Add(new VocabularyKey("chatterActivityPostCount"));
                ChatterInfluencePercentile          = group.Add(new VocabularyKey("chatterInfluencePercentile"));
                ChatterInfluenceRank                = group.Add(new VocabularyKey("chatterInfluenceRank"));
                FollowingCountsPeople               = group.Add(new VocabularyKey("followingCountsPeople"));
                FollowingCountsRecords              = group.Add(new VocabularyKey("followingCountsRecords"));
                FollowingCountsTotal                = group.Add(new VocabularyKey("followingCountsTotal"));
                MotifColor                          = group.Add(new VocabularyKey("motifColor"));
                MotifLargeIconUrl                   = group.Add(new VocabularyKey("motifLargeIconUrl"));
                MotifMediumIconUrl                  = group.Add(new VocabularyKey("motifMediumIconUrl"));
                MotifSmallIconUrl                   = group.Add(new VocabularyKey("motifSmallIconUrl"));
                MySubscriptionUrl                   = group.Add(new VocabularyKey("mySubscriptionUrl"));
                MySubscriptionId                    = group.Add(new VocabularyKey("mySubscriptionId"));
                
            });

            LastLoginDate                       = Add(new VocabularyKey("lastLoginDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.ExcludeFromHashing | VocabularyKeyVisibility.Hidden));

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);

            AddMapping(CompanyName,       CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Organization);
            AddMapping(Email,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName,         CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(LastName,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(Title,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.JobTitle);
            AddMapping(MiddleName,        CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MiddleName);
            AddMapping(MobilePhone,       CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MobileNumber);
            AddMapping(Phone,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(UserName,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.UserName);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey AboutMe { get; protected set; }
        public VocabularyKey BadgeText { get; protected set; }
        public VocabularyKey CallCenterId { get; protected set; }
        public VocabularyKey CommunityNickname { get; protected set; }
        public VocabularyKey Country { get; protected set; }
        public VocabularyKey CurrentStatus { get; protected set; }
        public VocabularyKey DefaultCurrencyIsoCode { get; protected set; }
        public VocabularyKey DefaultDivision { get; protected set; }
        public VocabularyKey DefaultGroupNotificationFrequency { get; protected set; }
        public VocabularyKey DigestFrequency { get; protected set; }
        public VocabularyKey Division { get; protected set; }
        public VocabularyKey EmailEncodingKey { get; protected set; }
        public VocabularyKey EmailPreferencesAutoBcc { get; protected set; }
        public VocabularyKey EmailPreferencesAutoBccStayInTouch { get; protected set; }
        public VocabularyKey EmailPreferencesStayInTouchReminder { get; protected set; }
        public VocabularyKey Extension { get; protected set; }
        public VocabularyKey Fax { get; protected set; }
        public VocabularyKey FederationIdentifier { get; protected set; }
        public VocabularyKey ForecastEnabled { get; protected set; }
        public VocabularyKey IsActive { get; protected set; }
        public VocabularyKey IsPartner { get; protected set; }
        public VocabularyKey IsPortalEnabled { get; protected set; }
        public VocabularyKey IsPortalSelfRegistered { get; protected set; }
        public VocabularyKey IsPrmSuperUser { get; protected set; }
        public VocabularyKey JigsawImportLimitOverride { get; protected set; }
        public VocabularyKey LanguageLocaleKey { get; protected set; }
        public VocabularyKey LastLoginDate { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey Latitude { get; protected set; }
        public VocabularyKey LocaleSidKey { get; protected set; }
        public VocabularyKey Longitude { get; protected set; }
        public VocabularyKey Manager { get; protected set; }
        public VocabularyKey OfflineTrialExpirationDate { get; protected set; }
        public VocabularyKey PortalRole { get; protected set; }
        public VocabularyKey PostalCode { get; protected set; }
        public VocabularyKey ReceivesAdminInfoEmails { get; protected set; }
        public VocabularyKey ReceivesInfoEmails { get; protected set; }
        public VocabularyKey SenderEmail { get; protected set; }
        public VocabularyKey SenderName { get; protected set; }
        public VocabularyKey Signature { get; protected set; }
        public VocabularyKey SmallPhotoUrl { get; protected set; }
        public VocabularyKey StateCode { get; protected set; }
        public VocabularyKey StayInTouchNote { get; protected set; }
        public VocabularyKey StayInTouchSignature { get; protected set; }
        public VocabularyKey StayInTouchSubject { get; protected set; }
        public VocabularyKey Suffix { get; protected set; }
        public VocabularyKey TimeZoneSidKey { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey UserType { get; protected set; }
        public VocabularyKey WirelessEmail { get; protected set; }

        public VocabularyKey Address            { get; protected set; }
        public VocabularyKey ChatterActivity    { get; protected set; }
        public VocabularyKey ChatterInfluence   { get; protected set; }
        public VocabularyKey CompanyName        { get; protected set; }
        public VocabularyKey Email              { get; protected set; }
        public VocabularyKey FirstName          { get; protected set; }
        public VocabularyKey FollowersCount     { get; protected set; }
        public VocabularyKey FollowingCounts    { get; protected set; }
        public VocabularyKey GroupCount         { get; protected set; }
        public VocabularyKey IsInThisCommunity  { get; protected set; }
        public VocabularyKey LastName           { get; protected set; }
        public VocabularyKey ManagerId          { get; protected set; }
        public VocabularyKey ManagerName        { get; protected set; }
        public VocabularyKey Motif              { get; protected set; }
        public VocabularyKey MySubscription     { get; protected set; }
        public VocabularyKey PhoneNumbers       { get; protected set; }
        public VocabularyKey Photo              { get; protected set; }
        public VocabularyKey ThanksReceived     { get; protected set; }
        public VocabularyKey Title              { get; protected set; }
        public VocabularyKey Type               { get; protected set; }

        public VocabularyKey City { get; protected set; }
        public VocabularyKey CountryCode { get; protected set; }
        public VocabularyKey Department { get; protected set; }
        public VocabularyKey EmployeeNumber { get; protected set; }
        public VocabularyKey MiddleName { get; protected set; }
        public VocabularyKey MobilePhone { get; protected set; }
        public VocabularyKey Phone { get; protected set; }
        public VocabularyKey State { get; protected set; }
        public VocabularyKey Street { get; protected set; }
        public VocabularyKey UserName { get; protected set; }
        public VocabularyKey AddressCity { get; set; }
        public VocabularyKey AddressCountry { get; set; }
        public VocabularyKey AddressFormattedAddress { get; set; }
        public VocabularyKey AddressState { get; set; }
        public VocabularyKey AddressStreet { get; set; }
        public VocabularyKey AddressZip { get; set; }
        public VocabularyKey ChatterActivityCommentCount { get; set; }
        public VocabularyKey ChatterActivityCommentReceivedCount { get; set; }
        public VocabularyKey ChatterActivityLikeReceivedCount { get; set; }
        public VocabularyKey ChatterActivityPostCount { get; set; }
        public VocabularyKey ChatterInfluencePercentile { get; set; }
        public VocabularyKey ChatterInfluenceRank { get; set; }
        public VocabularyKey FollowingCountsPeople { get; set; }
        public VocabularyKey FollowingCountsRecords { get; set; }
        public VocabularyKey FollowingCountsTotal { get; set; }
        public VocabularyKey MotifColor { get; set; }
        public VocabularyKey MotifLargeIconUrl { get; set; }
        public VocabularyKey MotifMediumIconUrl { get; set; }
        public VocabularyKey MotifSmallIconUrl { get; set; }
        public VocabularyKey MySubscriptionUrl { get; set; }
        public VocabularyKey MySubscriptionId { get; set; }
    }
}
