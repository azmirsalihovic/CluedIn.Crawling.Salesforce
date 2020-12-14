// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the CompanyObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class CompanyClueProducer : BaseClueProducer<Company>
    {
        private readonly IClueFactory _factory;

        public CompanyClueProducer([NotNull] IClueFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Company value, Guid id)
        {
            var clue = _factory.Create(EntityType.Organization, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            if (value.Description != null)
                data.Description = value.Description;

            if (value.CreatedDate != null)
            {
                DateTimeOffset createdDate;
                if (DateTimeOffset.TryParse(value.CreatedDate, out createdDate))
                {
                    data.CreatedDate = createdDate;
                }
            }

            if (value.CreatedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
                data.Authors.Add(createdBy);
            }

            if (value.LastModifiedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);
            }

            if (value.LastModifiedDate != null)
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastModifiedDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }

            data.Properties[SalesforceVocabulary.Company.SystemModstamp] = value.SystemModstamp;
            data.Properties[SalesforceVocabulary.Company.Fax] = value.Fax;
            data.Properties[SalesforceVocabulary.Company.MailingAddress] = value.MailingAddress;
            data.Properties[SalesforceVocabulary.Company.MailingCity] = value.MailingCity;
            data.Properties[SalesforceVocabulary.Company.MailingCountry] = value.MailingCountry;
            data.Properties[SalesforceVocabulary.Company.MailingPostalCode] = value.MailingPostalCode;
            data.Properties[SalesforceVocabulary.Company.MailingState] = value.MailingState;
            data.Properties[SalesforceVocabulary.Company.MailingStreet] = value.MailingStreet;
            data.Properties[SalesforceVocabulary.Company.Phone] = value.Phone;
            data.Properties[SalesforceVocabulary.Company.Address] = value.Address;
            data.Properties[SalesforceVocabulary.Company.City] = value.City;
            data.Properties[SalesforceVocabulary.Company.CompanyCurrencyIsoCode] = value.CompanyCurrencyIsoCode;
            data.Properties[SalesforceVocabulary.Company.Country] = value.Country;
            data.Properties[SalesforceVocabulary.Company.CountryAccessCode] = value.CountryAccessCode;
            data.Properties[SalesforceVocabulary.Company.CurrencyCode] = value.CurrencyCode;
            data.Properties[SalesforceVocabulary.Company.DomesticUltimateBusinessName] = value.DomesticUltimateBusinessName;
            data.Properties[SalesforceVocabulary.Company.DomesticUltimateDunsNumber] = value.DomesticUltimateDunsNumber;
            data.Properties[SalesforceVocabulary.Company.DunsNumber] = value.DunsNumber;
            data.Properties[SalesforceVocabulary.Company.EmployeeQuantityGrowthRate] = value.EmployeeQuantityGrowthRate;
            data.Properties[SalesforceVocabulary.Company.EmployeesHere] = value.EmployeesHere;
            data.Properties[SalesforceVocabulary.Company.EmployeesHereReliability] = value.EmployeesHereReliability;
            data.Properties[SalesforceVocabulary.Company.EmployeesTotal] = value.EmployeesTotal;
            data.Properties[SalesforceVocabulary.Company.EmployeesTotalReliability] = value.EmployeesTotalReliability;
            data.Properties[SalesforceVocabulary.Company.FamilyMembers] = value.FamilyMembers;
            data.Properties[SalesforceVocabulary.Company.FifthNaics] = value.FifthNaics;
            data.Properties[SalesforceVocabulary.Company.FifthNaicsDesc] = value.FifthNaicsDesc;
            data.Properties[SalesforceVocabulary.Company.FifthSic] = value.FifthSic;
            data.Properties[SalesforceVocabulary.Company.FifthSic8] = value.FifthSic8;
            data.Properties[SalesforceVocabulary.Company.FifthSic8Desc] = value.FifthSic8Desc;
            data.Properties[SalesforceVocabulary.Company.FifthSicDesc] = value.FifthSicDesc;
            data.Properties[SalesforceVocabulary.Company.FipsMsaCode] = value.FipsMsaCode;
            data.Properties[SalesforceVocabulary.Company.FipsMsaDesc] = value.FipsMsaDesc;
            data.Properties[SalesforceVocabulary.Company.FortuneRank] = value.FortuneRank;
            data.Properties[SalesforceVocabulary.Company.FourthNaics] = value.FourthNaics;
            data.Properties[SalesforceVocabulary.Company.FourthNaicsDesc] = value.FourthNaicsDesc;
            data.Properties[SalesforceVocabulary.Company.FourthSic] = value.FourthSic;
            data.Properties[SalesforceVocabulary.Company.FourthSic8] = value.FourthSic8;
            data.Properties[SalesforceVocabulary.Company.FourthSic8Desc] = value.FourthSic8Desc;
            data.Properties[SalesforceVocabulary.Company.FourthSicDesc] = value.FourthSicDesc;
            data.Properties[SalesforceVocabulary.Company.GeoCodeAccuracy] = value.GeoCodeAccuracy;
            data.Properties[SalesforceVocabulary.Company.GlobalUltimateBusinessName] = value.GlobalUltimateBusinessName;
            data.Properties[SalesforceVocabulary.Company.GlobalUltimateDunsNumber] = value.GlobalUltimateDunsNumber;
            data.Properties[SalesforceVocabulary.Company.GlobalUltimateTotalEmployees] = value.GlobalUltimateTotalEmployees;
            data.Properties[SalesforceVocabulary.Company.ImportExportAgent] = value.ImportExportAgent;
            data.Properties[SalesforceVocabulary.Company.IncludedInSnP500] = value.IncludedInSnP500;
            data.Properties[SalesforceVocabulary.Company.Latitude] = value.Latitude;
            data.Properties[SalesforceVocabulary.Company.LegalStatus] = value.LegalStatus;
            data.Properties[SalesforceVocabulary.Company.LocationStatus] = value.LocationStatus;
            data.Properties[SalesforceVocabulary.Company.Longitude] = value.Longitude;
            data.Properties[SalesforceVocabulary.Company.MarketingPreScreen] = value.MarketingPreScreen;
            data.Properties[SalesforceVocabulary.Company.MarketingSegmentationCluster] = value.MarketingSegmentationCluster;
            data.Properties[SalesforceVocabulary.Company.MinorityOwned] = value.MinorityOwned;
            data.Properties[SalesforceVocabulary.Company.NationalId] = value.NationalId;
            data.Properties[SalesforceVocabulary.Company.NationalIdType] = value.NationalIdType;
            data.Properties[SalesforceVocabulary.Company.OutOfBusiness] = value.OutOfBusiness;
            data.Properties[SalesforceVocabulary.Company.OwnOrRent] = value.OwnOrRent;
            data.Properties[SalesforceVocabulary.Company.ParentOrHqBusinessName] = value.ParentOrHqBusinessName;
            data.Properties[SalesforceVocabulary.Company.ParentOrHqDunsNumber] = value.ParentOrHqDunsNumber;
            data.Properties[SalesforceVocabulary.Company.PostalCode] = value.PostalCode;
            data.Properties[SalesforceVocabulary.Company.PremisesMeasure] = value.PremisesMeasure;
            data.Properties[SalesforceVocabulary.Company.PremisesMeasureReliability] = value.PremisesMeasureReliability;
            data.Properties[SalesforceVocabulary.Company.PremisesMeasureUnit] = value.PremisesMeasureUnit;
            data.Properties[SalesforceVocabulary.Company.PrimaryNaics] = value.PrimaryNaics;
            data.Properties[SalesforceVocabulary.Company.PrimaryNaicsDesc] = value.PrimaryNaicsDesc;
            data.Properties[SalesforceVocabulary.Company.PrimarySic] = value.PrimarySic;
            data.Properties[SalesforceVocabulary.Company.PrimarySic8] = value.PrimarySic8;
            data.Properties[SalesforceVocabulary.Company.PrimarySic8Desc] = value.PrimarySic8Desc;
            data.Properties[SalesforceVocabulary.Company.PrimarySicDesc] = value.PrimarySicDesc;
            data.Properties[SalesforceVocabulary.Company.PriorYearEmployees] = value.PriorYearEmployees;
            data.Properties[SalesforceVocabulary.Company.PriorYearRevenue] = value.PriorYearRevenue;
            data.Properties[SalesforceVocabulary.Company.PublicIndicator] = value.PublicIndicator;
            data.Properties[SalesforceVocabulary.Company.SalesTurnoverGrowthRate] = value.SalesTurnoverGrowthRate;
            data.Properties[SalesforceVocabulary.Company.SalesVolume] = value.SalesVolume;
            data.Properties[SalesforceVocabulary.Company.SalesVolumeReliability] = value.SalesVolumeReliability;
            data.Properties[SalesforceVocabulary.Company.SecondNaics] = value.SecondNaics;
            data.Properties[SalesforceVocabulary.Company.SecondNaicsDesc] = value.SecondNaicsDesc;
            data.Properties[SalesforceVocabulary.Company.SecondSic] = value.SecondSic;
            data.Properties[SalesforceVocabulary.Company.SecondSic8] = value.SecondSic8;
            data.Properties[SalesforceVocabulary.Company.SecondSic8Desc] = value.SecondSic8Desc;
            data.Properties[SalesforceVocabulary.Company.SecondSicDesc] = value.SecondSicDesc;
            data.Properties[SalesforceVocabulary.Company.SixthNaics] = value.SixthNaics;
            data.Properties[SalesforceVocabulary.Company.SixthNaicsDesc] = value.SixthNaicsDesc;
            data.Properties[SalesforceVocabulary.Company.SixthSic] = value.SixthSic;
            data.Properties[SalesforceVocabulary.Company.SixthSic8] = value.SixthSic8;
            data.Properties[SalesforceVocabulary.Company.SixthSic8Desc] = value.SixthSic8Desc;
            data.Properties[SalesforceVocabulary.Company.SixthSicDesc] = value.SixthSicDesc;
            data.Properties[SalesforceVocabulary.Company.SmallBusiness] = value.SmallBusiness;
            data.Properties[SalesforceVocabulary.Company.State] = value.State;
            data.Properties[SalesforceVocabulary.Company.StockExchange] = value.StockExchange;
            data.Properties[SalesforceVocabulary.Company.StockSymbol] = value.StockSymbol;
            data.Properties[SalesforceVocabulary.Company.Street] = value.Street;
            data.Properties[SalesforceVocabulary.Company.Subsidiary] = value.Subsidiary;
            data.Properties[SalesforceVocabulary.Company.ThirdNaics] = value.ThirdNaics;
            data.Properties[SalesforceVocabulary.Company.ThirdNaicsDesc] = value.ThirdNaicsDesc;
            data.Properties[SalesforceVocabulary.Company.ThirdSic] = value.ThirdSic;
            data.Properties[SalesforceVocabulary.Company.ThirdSic8] = value.ThirdSic8;
            data.Properties[SalesforceVocabulary.Company.ThirdSic8Desc] = value.ThirdSic8Desc;
            data.Properties[SalesforceVocabulary.Company.ThirdSicDesc] = value.ThirdSicDesc;
            data.Properties[SalesforceVocabulary.Company.TradeStyle1] = value.TradeStyle1;
            data.Properties[SalesforceVocabulary.Company.TradeStyle2] = value.TradeStyle2;
            data.Properties[SalesforceVocabulary.Company.TradeStyle3] = value.TradeStyle3;
            data.Properties[SalesforceVocabulary.Company.TradeStyle4] = value.TradeStyle4;
            data.Properties[SalesforceVocabulary.Company.TradeStyle5] = value.TradeStyle5;
            data.Properties[SalesforceVocabulary.Company.URL] = value.URL;
            data.Properties[SalesforceVocabulary.Company.UsTaxId] = value.UsTaxId;
            data.Properties[SalesforceVocabulary.Company.WomenOwned] = value.WomenOwned;
            data.Properties[SalesforceVocabulary.Company.YearStarted] = value.YearStarted;

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Company.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
