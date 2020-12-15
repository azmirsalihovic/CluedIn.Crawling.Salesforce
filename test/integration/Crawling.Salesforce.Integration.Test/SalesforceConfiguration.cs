using System.Collections.Generic;
using CluedIn.Crawling.Salesforce.Core;

namespace CluedIn.Crawling.Salesforce.Integration.Test
{
    public static class SalesforceConfiguration
    {
        public static Dictionary<string, object> Create()
        {
            return new Dictionary<string, object>
            {
                { SalesforceConstants.KeyName.ApiKey, "" },
                { SalesforceConstants.KeyName.GrantType, "" },
                { SalesforceConstants.KeyName.ClientId, "" },
                { SalesforceConstants.KeyName.ClientSecret, "" },
                { SalesforceConstants.KeyName.UserName, "" },
                { SalesforceConstants.KeyName.Password, "" }
            };
        }
    }
}
