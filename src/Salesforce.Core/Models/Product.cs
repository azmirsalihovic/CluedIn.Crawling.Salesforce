using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Product2")]
    public class Product : SystemObject
    {
        public const string SObjectTypeName = "Product2";
          [QueryIgnore]
        public string CanUseQuantitySchedule { get; set; }
          [QueryIgnore]
        public string CanUseRevenueSchedule { get; set; }
          [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
          [QueryIgnore]
        public string ConnectionSentId { get; set; }
          [QueryIgnore]
        public string CurrencyIsoCode { get; set; }
            [QueryIgnore]
        public string DefaultPrice { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
          [QueryIgnore]
        public string LastReferencedDate { get; set; }
          [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string Name { get; set; }
         [QueryIgnore]
        public string NumberOfQuantityInstallments { get; set; }
         [QueryIgnore]
        public string NumberOfRevenueInstallments { get; set; }
        public string ProductCode { get; set; }
           [QueryIgnore]
        public string QuantityInstallmentPeriod { get; set; }
           [QueryIgnore]
        public string QuantityScheduleType { get; set; }
            [QueryIgnore]
        public string RecalculateTotalPrice { get; set; }
           [QueryIgnore]
        public string RevenueInstallmentPeriod { get; set; }
           [QueryIgnore]
        public string RevenueScheduleType { get; set; }

    }
}
