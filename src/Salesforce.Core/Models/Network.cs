using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Network")]
    public class Network : SystemObject
    {
        public const string SObjectTypeName = "Network";
        public string AllowedExtensions { get; set; }
        public string CaseCommentEmailTemplateId { get; set; }
        public string ChangePasswordEmailTemplateId { get; set; }
        public string Description { get; set; }
        public string EmailFooterLogoId { get; set; }
        public string EmailFooterText { get; set; }
        public string EmailSenderAddress { get; set; }
        public string EmailSenderName { get; set; }
        public string FirstActivationDate { get; set; }
        public string ForgotPasswordEmailTemplateId { get; set; }
        public string MaxFileSizeKb { get; set; }
        public string Name { get; set; }
        public string NewSenderAddress { get; set; }
        public string OptionsAllowMembersToFlag { get; set; }
        public string OptionsGuestChatterEnabled { get; set; }
        public string OptionsInvitationsEnabled { get; set; }
        public string OptionsKnowledgeableEnabled { get; set; }
        public string OptionsNicknameDisplayEnabled { get; set; }
        public string OptionsPrivateMessagesEnabled { get; set; }
        public string OptionsReputationEnabled { get; set; }
        public string OptionsSelfRegistrationEnabled { get; set; }
        public string OptionsSendWelcomeEmail { get; set; }
        public string OptionsShowAllNetworkSettings { get; set; }
        public string OptionsSiteAsContainerEnabled { get; set; }
        public string SelfRegProfileId { get; set; }
        public string Status { get; set; }
        public string UrlPathPrefix { get; set; }
        public string WelcomeEmailTemplateId { get; set; }

    }
}
