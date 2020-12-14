
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("AccountContactRole")]
    public class AccountContactRole : SystemObject
    {
        public const string SObjectTypeName = "AccountContactRole";

        public string AccountId { get; set; }
        public string ContactId { get; set; }
        public string IsDeleted { get; set; }
        public string IsPrimary { get; set; }
        public string Role { get; set; }
    }
}
