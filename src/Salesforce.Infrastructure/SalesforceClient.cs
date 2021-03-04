using System;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Salesforce.Core;
using RestSharp;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using CluedIn.Crawling.Salesforce.Core.Models.Descriptions;
using System.Collections.Concurrent;
using Salesforce.Force;
using CluedIn.Crawling.Salesforce.Core.Models;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using Salesforce.Common;
using Microsoft.VisualBasic.FileIO;

namespace CluedIn.Crawling.Salesforce.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class SalesforceClient
    {
        private ConcurrentDictionary<string, ObjectDescription> descriptionCache = new ConcurrentDictionary<string, ObjectDescription>();
        private readonly ILogger<SalesforceClient> _log;
        private readonly ForceClient salesforceClient;
        private readonly SalesforceCrawlJobData _jobData;
        private readonly string token;

        public SalesforceClient(ILogger<SalesforceClient> log, SalesforceCrawlJobData salesforceCrawlJobData) // TODO: pass on any extra dependencies
        {
            if (salesforceCrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(salesforceCrawlJobData));
            }

            //if (client == null)
            //{
            //    throw new ArgumentNullException(nameof(client));
            //}

            _jobData = salesforceCrawlJobData;

            _log = log ?? throw new ArgumentNullException(nameof(log));
            //salesforceClient = client ?? throw new ArgumentNullException(nameof(client));

            AuthenticationClient auth = Auth().Result;
            token = auth.AccessToken;
            salesforceClient = new ForceClient(auth.InstanceUrl, auth.AccessToken, auth.ApiVersion);
        }

        private async System.Threading.Tasks.Task<AuthenticationClient> Auth()
        {
            var auth = new AuthenticationClient();
            var clientid = _jobData.ClientId;
            var clientSecret = _jobData.ClientSecret;
            var userName = _jobData.UserName;
            var password = _jobData.Password;

            await auth.UsernamePasswordAsync(clientid, clientSecret, userName, password);
            return auth;
        }

        public IEnumerable<T> GetById<T>(string recordTypeId = null, string kukCustomerID = null) where T : SystemObject
        {
            var records = 100;
            var kukCustomerIdList = GetKUKCustomerIDList();
            var onlyReturnCustomersFromFilter = kukCustomerIdList != null && kukCustomerIdList.Count > 0;
            var typeName = ((DisplayNameAttribute)typeof(T).GetCustomAttribute(typeof(DisplayNameAttribute))).DisplayName;
            global::Salesforce.Common.Models.Json.QueryResult<T> results;

            if (onlyReturnCustomersFromFilter)
            {
                while (kukCustomerIdList.Count > 0)
                {
                    records = kukCustomerIdList.Count < records ? kukCustomerIdList.Count : records;
                    try
                    {
                        var qry = string.Empty;
                        var firstHundredeIds = kukCustomerIdList.Take(records);
                        var resourceParams = string.Join(",",
                            firstHundredeIds.Select(r => "'" + r.ToString() + "'"));

                        if (_jobData.LastCrawlFinishTime > DateTimeOffset.MinValue)
                        {
                            qry = string.Format("SELECT {0} FROM {1} WHERE SystemModStamp >= {2} AND KUKCustomerID__c IN ({3})", GetObjectFieldsSelectList(typeName), typeName, _jobData.LastCrawlFinishTime.AddDays(-2).ToString("o"), resourceParams);
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(kukCustomerID))
                            {
                                qry = string.Format("SELECT {0} FROM {1} WHERE RecordTypeId = '{2}' AND KUKCustomerID__c = '{3}'", GetObjectFieldsSelectList(typeName), typeName, recordTypeId, kukCustomerID);
                                kukCustomerIdList.Clear();
                            }
                            else
                            {
                                qry = string.Format("SELECT {0} FROM {1} WHERE RecordTypeId = '{2}' AND KUKCustomerID__c IN ({3})", GetObjectFieldsSelectList(typeName), typeName, recordTypeId, resourceParams);
                                kukCustomerIdList.RemoveRange(0, records);
                            }
                        }

                        results = salesforceClient.QueryAsync<T>(qry).Result;
                    }
                    catch (Exception ex)
                    {
                        _log.LogError("Could not fetch Salesforce Data", ex);
                        yield break;
                    }
                    foreach (var item in results.Records)
                    {
                        yield return item;
                    }
                }
            }
            else
            {
                Get<Account>(recordTypeId, kukCustomerID);
            }
        }

        public IEnumerable<T> Get<T>(string recordTypeId = null, string kukCustomerID = null) where T : SystemObject
        {
            var typeName = ((DisplayNameAttribute)typeof(T).GetCustomAttribute(typeof(DisplayNameAttribute))).DisplayName;
            string nextRecordsUrl;
            global::Salesforce.Common.Models.Json.QueryResult<T> results;

            try
            {
                var qry = string.Empty;
                if (_jobData.LastCrawlFinishTime > DateTimeOffset.MinValue)
                {
                    qry = string.Format("SELECT {0} FROM {1} WHERE SystemModStamp >= {2}", GetObjectFieldsSelectList(typeName), typeName, _jobData.LastCrawlFinishTime.AddDays(-2).ToString("o"));
                }
                if (!string.IsNullOrEmpty(kukCustomerID))
                {
                    if (!string.IsNullOrEmpty(recordTypeId))
                        qry = string.Format("SELECT {0} FROM {1} WHERE RecordTypeId = '{2}' AND KUKCustomerID__c = '{3}'", GetObjectFieldsSelectList(typeName), typeName, recordTypeId, kukCustomerID);
                    else
                        qry = string.Format("SELECT {0} FROM {1} WHERE KUKCustomerID__c = '{2}'", GetObjectFieldsSelectList(typeName), typeName, kukCustomerID);
                }
                else
                {
                    if (!string.IsNullOrEmpty(recordTypeId))
                        qry = string.Format("SELECT {0} FROM {1} WHERE RecordTypeId = '{2}'", GetObjectFieldsSelectList(typeName), typeName, recordTypeId);
                    else
                        qry = string.Format("SELECT {0} FROM {1}", GetObjectFieldsSelectList(typeName), typeName);
                }
                results = salesforceClient.QueryAsync<T>(qry).Result;
                nextRecordsUrl = results.NextRecordsUrl;
            }
            catch (Exception ex)
            {
                _log.LogError("Could not fetch Salesforce Data", ex);
                yield break;
            }
            foreach (var item in results.Records)
            {
                yield return item;
            }
            while (!string.IsNullOrEmpty(nextRecordsUrl))
            {
                try
                {
                    results = salesforceClient.QueryContinuationAsync<T>(nextRecordsUrl).Result;
                }
                catch (Exception ex)
                {
                    _log.LogError("Could not fetch Salesforce Data", ex);
                    yield break;
                }
                foreach (var item in results.Records)
                {
                    yield return item;
                }

                if (string.IsNullOrEmpty(results.NextRecordsUrl))
                    yield break;

                //pass nextRecordsUrl back to client.QueryAsync to request next set of records
                nextRecordsUrl = results.NextRecordsUrl;
            }
        }

        public List<string> GetKUKCustomerIDList()
        {
            List<string> KUKCustomerIDList = new List<string>();
            try
            {
                using (var parser = new TextFieldParser(_jobData.FilePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(new string[] { ";" });
                    parser.ReadFields();
                    while (!parser.EndOfData)
                    {
                        try
                        {
                            var filterByCustomersIds = parser.ReadFields();
                            KUKCustomerIDList.Add(filterByCustomersIds[1]);
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return KUKCustomerIDList;
        }

        public AccountInformation GetAccountInformation()
        {
            return new AccountInformation("", "");
        }

        private string GetObjectFieldsSelectList(string objectType)
        {
            return string.Join(", ", GetObjectDescriptionFields(objectType));
        }

        private string[] GetObjectDescriptionFields(string objectType)
        {
            var description = this.GetObjectDescription(objectType);

            return description.Fields.Select(f => f.Name)
                                     .ToArray();
        }

        private ObjectDescription GetObjectDescription(string objectType)
        {
            ObjectDescription description;
            if (descriptionCache.TryGetValue(objectType, out description))
                return description;

            var client = new RestClient(_jobData.ApiKey);

            var request = new RestRequest(string.Format("/services/data/v26.0/sobjects/{0}/describe", objectType), Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);

            var response = client.Execute<ObjectDescription>(request);

            if (response.Content == "[{\"message\":\"Session expired or invalid\",\"errorCode\":\"INVALID_SESSION_ID\"}]")
                throw new Exception("Could not get object description: Invalid session id");

            if (response.ErrorException != null)
                throw new Exception("Could not get object description: " + objectType, response.ErrorException);

            if (response.ErrorMessage != null)
                throw new Exception("Could not get object description: " + objectType + " : " + response.ErrorMessage);

            return descriptionCache[objectType] = response.Data;
        }
    }
}
