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
using System.IO;
using System.Text;

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
        public readonly string filePathOutput;
        public readonly bool createCSVFile;

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
            filePathOutput = _jobData.FilePathOutput;
            bool.TryParse(_jobData.CreateCSVFile, out createCSVFile);

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
                            firstHundredeIds.Select(r => "'" + r.KUKCustomerID + "'"));

                        if (_jobData.LastCrawlFinishTime > DateTimeOffset.MinValue)
                        {
                            qry = string.Format("SELECT {0} FROM {1} WHERE SystemModStamp >= {2} AND KUKCustomerID__c IN ({3})", GetObjectFieldsSelectList(typeName), typeName, _jobData.LastCrawlFinishTime.AddDays(-2).ToString("o"), resourceParams);
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(kukCustomerID) && !string.IsNullOrEmpty(recordTypeId))
                            {
                                qry = string.Format("SELECT {0} FROM {1} WHERE RecordTypeId = '{2}' AND KUKCustomerID__c = '{3}'", GetObjectFieldsSelectList(typeName), typeName, recordTypeId, kukCustomerID);
                                kukCustomerIdList.Clear();
                            }
                            if (!string.IsNullOrEmpty(recordTypeId))
                            {
                                qry = string.Format("SELECT {0} FROM {1} WHERE RecordTypeId = '{2}' AND KUKCustomerID__c IN ({3})", GetObjectFieldsSelectList(typeName), typeName, recordTypeId, resourceParams);
                                kukCustomerIdList.RemoveRange(0, records);
                            }
                            else
                            {
                                qry = string.Format("SELECT {0} FROM {1} WHERE KUKCustomerID__c IN ({2})", GetObjectFieldsSelectList(typeName), typeName, resourceParams);
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
                foreach (var item in Get<T>(recordTypeId, kukCustomerID, default))
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<T> Get<T>(string recordTypeId = null, string kukCustomerID = null, string contactID = null) where T : SystemObject
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
                if (!string.IsNullOrEmpty(contactID))
                {
                    if (!string.IsNullOrEmpty(recordTypeId))
                        qry = string.Format("SELECT {0} FROM {1} WHERE RecordTypeId = '{2}' AND id = '{3}'", GetObjectFieldsSelectList(typeName), typeName, recordTypeId, contactID);
                    else
                        qry = string.Format("SELECT {0} FROM {1} WHERE id = '{2}'", GetObjectFieldsSelectList(typeName), typeName, contactID);
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

        public List<Customers> GetKUKCustomerIDList()
        {
            List<Customers> KUKCustomerIDList = new List<Customers>();
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
                            KUKCustomerIDList.Add(new Customers
                            {
                                KUKCustomerID = filterByCustomersIds[1]
                            });
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

        public void GetCSVOutput()
        {
            var customerListFull = GetKUKCustomerIDList();
            var customerListFound = new List<Customers>();
            var customerListCombined = new List<Customers>();

            foreach (var item in GetById<Account>(default, default))
            {
                customerListFound.Add(new Customers
                {
                    KUKCustomerID = item.KUKCustomerID__c,
                    RecordTypeID = item.RecordTypeId,
                    Match = "Y"
                });
            }

            try
            {
                //Clear CSV file
                File.WriteAllText(filePathOutput + "_" + DateTime.Now.ToShortDateString() + ".csv", "");

                //Build output to a CSV file
                var csv = new StringBuilder();
                var header = string.Format("{0};{1};{2}", "KUKCustomerID", "RecordTypeID", "Match");
                csv.AppendLine(header);

                foreach (var item in customerListFull)
                {
                    var containsItem = customerListFound.Any(items => items.KUKCustomerID == item.KUKCustomerID);

                    if (containsItem)
                    {
                        var recordTypeID = customerListFound.FirstOrDefault(x => x.KUKCustomerID == item.KUKCustomerID).RecordTypeID.ToString();

                        customerListCombined.Add(new Customers
                        {
                            KUKCustomerID = item.KUKCustomerID,
                            RecordTypeID = recordTypeID,
                            Match = "Y"
                        });
                    }
                    else
                    {
                        customerListCombined.Add(new Customers
                        {
                            KUKCustomerID = item.KUKCustomerID,
                            RecordTypeID = item.RecordTypeID,
                            Match = "N"
                        });
                    }
                }

                foreach (var item in customerListCombined)
                {
                    var newLine = string.Format("{0};{1};{2}", item.KUKCustomerID, item.RecordTypeID, item.Match);
                    csv.AppendLine(newLine);
                }

                File.WriteAllText(filePathOutput + "_" + DateTime.Now.ToShortDateString() + ".csv", csv.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public class Customers
        {
            public string KUKCustomerID { get; set; }
            public string RecordTypeID { get; set; }
            public string Match { get; set; }

            public override string ToString()
            {
                return string.Format("KUKCustomerID {0};RecordTypeID {1};Match {2}", KUKCustomerID, RecordTypeID, Match);
            }
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
