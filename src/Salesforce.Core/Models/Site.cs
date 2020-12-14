using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Site")]
    public class Site : SystemObject
    {
        public const string SObjectTypeName = "Site";
        public string AdminId { get; set; }
        public string AnalyticsTrackingCode { get; set; }
        [QueryIgnore]
        public string ClickjackProtectionLevel { get; set; }
        public string DailyBandwidthLimit { get; set; }
        public string DailyBandwidthUsed { get; set; }
        public string DailyRequestTimeLimit { get; set; }
        public string DailyRequestTimeUsed { get; set; }
        public string Description { get; set; }
        [QueryIgnore]
        public string GuestUserId { get; set; }
        public string MasterLabel { get; set; }
        public string MonthlyPageViewsEntitlement { get; set; }
        public string Name { get; set; }
        public string OptionsAllowHomePage { get; set; }
        public string OptionsAllowStandardAnswersPages { get; set; }
        public string OptionsAllowStandardIdeasPages { get; set; }
        public string OptionsAllowStandardLookups { get; set; }
        public string OptionsAllowStandardSearch { get; set; }
        public string OptionsEnableFeeds { get; set; }
        public string OptionsRequireHttps { get; set; }
        public string SiteType { get; set; }
        public string Status { get; set; }
        public string Subdomain { get; set; }
        [QueryIgnore]
        public string TopLevelDomain { get; set; }
        public string UrlPathPrefix { get; set; }
    }
}
