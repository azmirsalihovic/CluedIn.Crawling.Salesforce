namespace CluedIn.Provider.Salesforce.WebApi
{
    public class SalesforceTokenResponse
    {
        public string access_token { get; set; }

        public string expires_in { get; set; }

        public string refresh_token { get; set; }

        public string instance_url { get; set; }

        public string id { get; set; }
    }
}
