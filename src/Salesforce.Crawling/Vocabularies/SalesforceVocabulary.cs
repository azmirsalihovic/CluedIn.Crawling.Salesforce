// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce vocabulary</summary>
    public static class SalesforceVocabulary
    {
        /// <summary>Initializes the <see cref="SalesforceVocabulary"/> class.</summary>
        static SalesforceVocabulary()
        {
            //Account     = new SalesforceAccountVocabulary();
            PrivateCustomer = new SalesforcePrivateCustomerVocabulary();
            BusinessCustomer = new SalesforceBusinessCustomerVocabulary();
            Asset       = new SalesforceAssetVocabulary();
            Attachment  = new SalesforceAttachmentVocabulary();
            Campaign    = new SalesforceCampaignVocabulary();
            Case        = new SalesforceCaseVocabulary();
            Contact     = new SalesforceContactVocabulary();
            Contract    = new SalesforceContractVocabulary();
            Document    = new SalesforceDocumentVocabulary();
            Event       = new SalesforceEventVocabulary();
            Comment     = new SalesforceCommentVocabulary();
            Group       = new SalesforceGroupVocabulary();
            Idea        = new SalesforceIdeaVocabulary();
            Lead        = new SalesforceLeadVocabulary();
            Note        = new SalesforceNoteVocabulary();
            Opportunity = new SalesforceOppurtunityVocabulary();
            User        = new SalesforceUserVocabulary();
            Task        = new SalesforceTaskVocabulary();
            Solution    = new SalesforceSolutionVocabulary();
            Quote       = new SalesforceQuoteVocabulary();
            Profile     = new SalesforceProfileVocabulary();
            Product     = new SalesforceProductVocabulary();
            Partner     = new SalesforcePartnerVocabulary();
            Order       = new SalesforceOrderVocabulary();
            Company     = new SalesforceCompanyVocabulary();
            Site        = new SalesforceSiteVocabulary();
            FeedItem    = new SalesforceFeedItemVocabulary();
            GroupDetail = new SalesforceGroupDetailVocabulary();
        }

        public static SalesforceAssetVocabulary Asset { get; private set; }

        //public static SalesforceAccountVocabulary Account { get; private set; }

        public static SalesforcePrivateCustomerVocabulary PrivateCustomer { get; private set; }
        public static SalesforceBusinessCustomerVocabulary BusinessCustomer { get; private set; }

        public static SalesforceAttachmentVocabulary Attachment { get; private set; }

        public static SalesforceCampaignVocabulary Campaign { get; private set; }

        public static SalesforceCaseVocabulary Case { get; private set; }

        public static SalesforceContactVocabulary Contact { get; private set; }

        public static SalesforceContractVocabulary Contract { get; private set; }

        public static SalesforceDocumentVocabulary Document { get; private set; }

        public static SalesforceEventVocabulary Event { get; private set; }

        public static SalesforceCommentVocabulary Comment { get; private set; }

        public static SalesforceGroupVocabulary Group { get; private set; }

        public static SalesforceIdeaVocabulary Idea { get; private set; }

        public static SalesforceLeadVocabulary Lead { get; private set; }

        public static SalesforceNoteVocabulary Note { get; private set; }

        public static SalesforceOppurtunityVocabulary Opportunity { get; private set; }

        public static SalesforceUserVocabulary User { get; private set; }

        public static SalesforceTaskVocabulary Task { get; private set; }

        public static SalesforceSolutionVocabulary Solution { get; private set; }

        public static SalesforceQuoteVocabulary Quote { get; private set; }

        public static SalesforceProfileVocabulary Profile { get; private set; }

        public static SalesforceProductVocabulary Product { get; private set; }

        public static SalesforcePartnerVocabulary Partner { get; private set; }

        public static SalesforceOrderVocabulary Order { get; private set; }
        
        public static SalesforceCompanyVocabulary Company { get; private set; }

        public static SalesforceSiteVocabulary Site { get; private set; }

        public static SalesforceFeedItemVocabulary FeedItem { get; private set; }

        public static SalesforceGroupDetailVocabulary GroupDetail { get; private set; }
    }
}
