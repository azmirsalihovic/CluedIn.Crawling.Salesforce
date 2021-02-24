// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DuplicateEntityHomePhoneQuery.cs" company="Clued In">
//   Copyright (c) 2019 Clued In. All rights reserved.
// </copyright>
// <summary>
//   Implements the duplicate entity Home Phone query class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CluedIn.Core;
using CluedIn.Core.Configuration;
using CluedIn.Core.Data;
using CluedIn.Core.DataStore;
using Core.Data.Repositories;
using Core.Data.Repositories.Search;
using Core.Data.Repositories.Search.Aggregations;
using Core.Data.Repositories.Search.Filtering;

namespace CluedIn.Processing.EntityResolution.Queries
{
    public class DuplicateEntityAccountHomePhoneQuery : IOnlineDuplicateEntityQuery
    {
        public string Name { get; } = "Home Phone";

        public string DisplayName { get; } = "Duplicate Entity Home Phones";

        public async Task<IEnumerable<IDuplicateEntityQueryResultSet>> GetPotentialDuplicatesAsync(ExecutionContext context, EntityType entityType = null)
        {
            var repos = new CluedInRepositories();

            IEnumerable<EntityType> entityTypes;

            if (entityType == null)
            {
                var query = new ParsedQuery();
                query.Query = "*";
                query.Fields = new List<string>() { "entityType" };
                query.Cursor = PagingCursor.Default;
                query.Aggregations = new List<AggregationQuery>() { new TermAggregationQuery("entityType", 150) };
                query.RankingSettings = ParsedQuery.DefaultRanking;
                query.IncludeUnstructuredData = !ConfigurationManagerEx.AppSettings.GetFlag("Feature.Filters.ShadowEntities", true);
                query.OptionalFields = new List<string>();
                query.SearchSpecificEntityTypesByName = new List<string>();

                var results = await repos.Search.ExecuteQuery(context, query);

                var entityTypeAggregation = (TermAggregationBucket)results.Aggregations.First().Value;

                entityTypes = entityTypeAggregation.Items.Select(t => (EntityType)t.Name).ToList();
            }
            else
                entityTypes = new[] { entityType };

            var resultSets = new List<IDuplicateEntityQueryResultSet>(entityTypes.Count());

            foreach (var type in entityTypes)
            {
                var query = new ParsedQuery();
                query.Query = "*";
                query.Fields = new List<string>() { "properties.semler.privatecustomer.HomePhoneNr" };
                query.Cursor = PagingCursor.Default;
                query.Aggregations = new List<AggregationQuery>() { new TermAggregationQuery("properties.semler.privatecustomer.HomePhoneNr", 150) };
                query.RankingSettings = ParsedQuery.DefaultRanking;
                query.IncludeUnstructuredData = !ConfigurationManagerEx.AppSettings.GetFlag("Feature.Filters.ShadowEntities", true);
                query.OptionalFields = new List<string>();
                query.SearchSpecificEntityTypesByName = new List<string>();

                query.Filters = ParsedFilteringQuery.Parse(context, query, null, new[]
                                                                                 {
                                                                                     new FilterQuery()
                                                                                     {
                                                                                         FieldName       = "entityType",
                                                                                         AggregationName = "entityType",
                                                                                         Operator        = DefaultSearchOperator.And,
                                                                                         Value           = type.ToString()
                                                                                     }
                                                                                 });

                var results = await repos.Search.ExecuteQuery(context, query);

                var nameAggregation = (TermAggregationBucket)results.Aggregations.First().Value;

                if (nameAggregation.Items.Any(f => f.Count > 1))
                {
                    resultSets.Add(
                        new DuplicateEntityQueryResultSet(
                            this,
                            type,
                            $"Possible {type} Duplicates",
                            nameAggregation.Items.Where(f => f.Count > 1).Select(f => new DuplicateEntityQueryGrouping(f.Name, f.Name, f.Count)))
                    );
                }
            }

            return resultSets;
        }

        public async Task<PagedDataResultWithCount<IEntity>> GetPotentialDuplicateEntityInstancesAsync(ExecutionContext context, string resultSetKey, string itemGroupingKey, PagingCursor cursor = null)
        {
            var repos = new CluedInRepositories();

            cursor = cursor ?? PagingCursor.Default;

            var query = new ParsedQuery();
            query.Query = "*";
            query.Fields = new List<string>() { "properties.semler.privatecustomer.HomePhoneNr" };
            query.Cursor = cursor;
            query.RankingSettings = ParsedQuery.DefaultRanking;
            query.IncludeUnstructuredData = !ConfigurationManagerEx.AppSettings.GetFlag("Feature.Filters.ShadowEntities", true);
            query.OptionalFields = new List<string>();
            query.SearchSpecificEntityTypesByName = new List<string>();

            query.Filters = ParsedFilteringQuery.Parse(context, query, null, new[]
                                                                             {
                                                                                 new FilterQuery()
                                                                                 {
                                                                                     FieldName       = "entityType",
                                                                                     AggregationName = "entityType",
                                                                                     Operator        = DefaultSearchOperator.And,
                                                                                     Value           = resultSetKey
                                                                                 },
                                                                                 new FilterQuery()
                                                                                 {
                                                                                     FieldName       = "properties.semler.privatecustomer.HomePhoneNr",
                                                                                     AggregationName = "properties.semler.privatecustomer.HomePhoneNr",
                                                                                     Operator        = DefaultSearchOperator.And,
                                                                                     Value           = itemGroupingKey
                                                                                 }
                                                                             });

            var results = await repos.Search.ExecuteQuery(context, query);

            return new PagedDataResultWithCount<IEntity>(results.Entries.Select(e => e.Entity), results.TotalResults, ((cursor.Page + 1) * cursor.PageSize) < results.TotalResults ? results.NextCursor : null);
        }
    }
}
