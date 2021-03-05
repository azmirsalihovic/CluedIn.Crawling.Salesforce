using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;

namespace Semler.Common.PreProcessing
{
    public class NameNormalizationPreProcessor : CluedIn.Processing.Processors.PreProcessing.IPreProcessor
    {
        public bool Accepts(ExecutionContext context, IEnumerable<IEntityCode> codes)
        {
            return true;
        }

        public void Process(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            if (metadata != null)
            {
                NormalizeTitles(metadata);
                RemovingNonNumericCharsAndLeadingZero(metadata);
            }
        }

        #region Main methods
        /// <summary>This method is normalizing entities into TitleCapitals </summary>
        public void NormalizeTitles(IEntityMetadataPart metadata)
        {
            //Normalization of CAPITALS to Title Capitals
            if (!string.IsNullOrWhiteSpace(metadata.DisplayName))
            {
                metadata.DisplayName = GetLettersWithWhiteSpaces(GetTitleCapital(metadata.DisplayName));
            }

            if (!string.IsNullOrWhiteSpace(metadata.Name))
            {
                if (metadata.EntityType.Is(EntityType.Infrastructure.User))
                    metadata.Name = GetLettersWithWhiteSpaces(GetTitleCapital(metadata.Name));
                else if (metadata.EntityType.Is(EntityType.Organization))
                    metadata.Name = GetTitleCapital(metadata.Name);
            }

            //Business Customer
            if (metadata.Properties.TryGetValue("semler.businesscustomer.AdrLine1", out var adrLine1B))
            {
                metadata.Properties["semler.businesscustomer.AdrLine1"] = GetTitleCapital(adrLine1B);
            }

            if (metadata.Properties.TryGetValue("semler.businesscustomer.AdrLine2", out var adrLine2B))
            {
                metadata.Properties["semler.businesscustomer.AdrLine2"] = GetTitleCapital(adrLine2B);
            }

            if (metadata.Properties.TryGetValue("semler.customer.AdrLine1", out var adrLine1C))
            {
                metadata.Properties["semler.customer.AdrLine1"] = GetTitleCapital(adrLine1C);
            }

            if (metadata.Properties.TryGetValue("semler.customer.AdrLine2", out var adrLine2C))
            {
                metadata.Properties["semler.customer.AdrLine2"] = GetTitleCapital(adrLine2C);
            }

            if (metadata.Properties.TryGetValue("semler.businesscustomer.City", out var cityB))
            {
                metadata.Properties["semler.businesscustomer.City"] = GetTitleCapital(cityB);
            }

            if (metadata.Properties.TryGetValue("semler.customer.City", out var cityC))
            {
                metadata.Properties["semler.customer.City"] = GetTitleCapital(cityC);
            }

            if (metadata.Properties.TryGetValue("semler.businesscustomer.Country", out var countryB))
            {
                metadata.Properties["semler.businesscustomer.Country"] = GetTitleCapital(countryB);
            }

            if (metadata.Properties.TryGetValue("semler.customer.Country", out var countryC))
            {
                metadata.Properties["semler.customer.Country"] = GetTitleCapital(countryC);
            }

            //Private Customer
            if (metadata.Properties.TryGetValue("semler.privatecustomer.FirstName", out var firstNameP))
            {
                metadata.Properties["semler.privatecustomer.FirstName"] = GetTitleCapital(firstNameP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.FirstName", out var firstNameC))
            {
                metadata.Properties["semler.customer.FirstName"] = GetTitleCapital(firstNameC);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.FirstNamePer1", out var firstNamePer1P))
            {
                metadata.Properties["semler.privatecustomer.FirstNamePer1"] = GetTitleCapital(firstNamePer1P);
            }

            if (metadata.Properties.TryGetValue("semler.customer.FirstNamePer1", out var firstNamePer1C))
            {
                metadata.Properties["semler.customer.FirstNamePer1"] = GetTitleCapital(firstNamePer1C);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.COName", out var cONameP))
            {
                metadata.Properties["semler.privatecustomer.COName"] = GetTitleCapital(cONameP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.COName", out var cONameC))
            {
                metadata.Properties["semler.customer.COName"] = GetTitleCapital(cONameC);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.CONamePer1", out var cONamePer1P))
            {
                metadata.Properties["semler.privatecustomer.CONamePer1"] = GetTitleCapital(cONamePer1P);
            }

            if (metadata.Properties.TryGetValue("semler.customer.CONamePer1", out var cONamePer1C))
            {
                metadata.Properties["semler.customer.CONamePer1"] = GetTitleCapital(cONamePer1C);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.LastName", out var lastNameP))
            {
                metadata.Properties["semler.privatecustomer.LastName"] = GetTitleCapital(lastNameP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.LastName", out var lastNameC))
            {
                metadata.Properties["semler.customer.LastName"] = GetTitleCapital(lastNameC);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.LastNamePer1", out var lastNamePer1P))
            {
                metadata.Properties["semler.privatecustomer.LastNamePer1"] = GetTitleCapital(lastNamePer1P);
            }

            if (metadata.Properties.TryGetValue("semler.customer.LastNamePer1", out var lastNamePer1C))
            {
                metadata.Properties["semler.customer.LastNamePer1"] = GetTitleCapital(lastNamePer1C);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.Name", out var nameP))
            {
                metadata.Properties["semler.privatecustomer.Name"] = GetTitleCapital(nameP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.Name", out var nameC))
            {
                metadata.Properties["semler.customer.Name"] = GetTitleCapital(nameC);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.NamePer1", out var namePer1P))
            {
                metadata.Properties["semler.privatecustomer.NamePer1"] = GetTitleCapital(namePer1P);
            }

            if (metadata.Properties.TryGetValue("semler.customer.NamePer1", out var namePer1C))
            {
                metadata.Properties["semler.customer.NamePer1"] = GetTitleCapital(namePer1C);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.City", out var cityP))
            {
                metadata.Properties["semler.privatecustomer.City"] = GetTitleCapital(cityP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.City", out var cityC1))
            {
                metadata.Properties["semler.customer.City"] = GetTitleCapital(cityC1);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.Country", out var countryP))
            {
                countryP = EqualsIgnoreCase(countryP, "Denmark") ? "Danmark" : EqualsIgnoreCase(countryP, "DK") ? "Danmark" : countryP;
                metadata.Properties["semler.privatecustomer.Country"] = GetTitleCapital(countryP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.Country", out var countryC1))
            {
                countryC1 = EqualsIgnoreCase(countryC1, "Denmark") ? "Danmark" : EqualsIgnoreCase(countryC1, "DK") ? "Danmark" : countryC1;
                metadata.Properties["semler.customer.Country"] = GetTitleCapital(countryC1);
            }

            //Contact
            if (metadata.Properties.TryGetValue("semler.contact.FirstName", out var firstNameCo))
            {
                metadata.Properties["semler.contact.FirstName"] = GetTitleCapital(firstNameCo);
            }

            if (metadata.Properties.TryGetValue("semler.contact.LastName", out var lastNameCo))
            {
                metadata.Properties["semler.contact.LastName"] = GetTitleCapital(lastNameCo);
            }

            if (metadata.Properties.TryGetValue("semler.contact.Name", out var nameCo))
            {
                metadata.Properties["semler.contact.Name"] = GetTitleCapital(nameCo);
            }

            if (metadata.Properties.TryGetValue("Semler.contact.City", out var cityCo))
            {
                metadata.Properties["Semler.contact.City"] = GetTitleCapital(cityCo);
            }

            if (metadata.Properties.TryGetValue("semler.contact.Country", out var countryCo))
            {
                countryCo = EqualsIgnoreCase(countryCo, "Denmark") ? "Danmark" : EqualsIgnoreCase(countryCo, "DK") ? "Danmark" : countryCo;
                metadata.Properties["semler.contact.Country"] = GetTitleCapital(countryCo);
            }
        }

        public void RemovingNonNumericCharsAndLeadingZero(IEntityMetadataPart metadata)
        {
            //Business Customer
            if (metadata.Properties.TryGetValue("semler.businesscustomer.CVRNumber", out var cvrB))
            {
                if (metadata.Properties.TryGetValue("semler.businesscustomer.Country", out var countryB))
                {
                    //Check if it is a Danish customer
                    countryB = EqualsIgnoreCase(countryB, "Denmark") ? "Danmark" : EqualsIgnoreCase(countryB, "DK") ? "Danmark" : countryB;
                    if (countryB == "Danmark") 
                        metadata.Properties["semler.businesscustomer.CVRNumber"] = GetNumbersAndRemoveLeadingZero(cvrB);
                }
            }

            if (metadata.Properties.TryGetValue("semler.customer.CVRNumber", out var cvrC))
            {
                if (metadata.Properties.TryGetValue("semler.customer.Country", out var countryC))
                {
                    //Check if it is a Danish customer
                    countryC = EqualsIgnoreCase(countryC, "Denmark") ? "Danmark" : EqualsIgnoreCase(countryC, "DK") ? "Danmark" : countryC;
                    if (countryC == "Danmark")
                        metadata.Properties["semler.customer.CVRNumber"] = GetNumbersAndRemoveLeadingZero(cvrC);
                }
            }

            if (metadata.Properties.TryGetValue("semler.businesscustomer.PhoneNumber", out var phoneB))
            {
                metadata.Properties["semler.businesscustomer.PhoneNumber"] = GetNumbersAndRemoveLeadingZero(phoneB);
            }

            if (metadata.Properties.TryGetValue("semler.Customer.PhoneNumber", out var phoneC))
            {
                metadata.Properties["semler.customer.PhoneNumber"] = GetNumbersAndRemoveLeadingZero(phoneC);
            }

            if (metadata.Properties.TryGetValue("semler.business.PostalCode", out var postalCodeB))
            {
                metadata.Properties["semler.business.PostalCode"] = GetNumbersAndRemoveLeadingZero(postalCodeB);
            }

            if (metadata.Properties.TryGetValue("semler.businesscustomer.PostalCode", out var postalCodeC))
            {
                metadata.Properties["semler.businesscustomer.PostalCode"] = GetNumbersAndRemoveLeadingZero(postalCodeC);
            }

            //Private Customer
            if (metadata.Properties.TryGetValue("semler.privatecustomer.HomePhoneNr", out var homePhoneNrP))
            {
                metadata.Properties["semler.privatecustomer.HomePhoneNr"] = GetNumbersAndRemoveLeadingZero(homePhoneNrP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.HomePhoneNr", out var homePhoneNrC))
            {
                metadata.Properties["semler.customer.HomePhoneNr"] = GetNumbersAndRemoveLeadingZero(homePhoneNrC);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.LandPhoneNum", out var landPhoneNumP))
            {
                metadata.Properties["semler.privatecustomer.LandPhoneNum"] = GetNumbersAndRemoveLeadingZero(landPhoneNumP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.LandPhoneNum", out var landPhoneNumC))
            {
                metadata.Properties["semler.customer.LandPhoneNum"] = GetNumbersAndRemoveLeadingZero(landPhoneNumC);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.MobPhoneNr", out var mobPhoneNrP))
            {
                metadata.Properties["semler.privatecustomer.MobPhoneNr"] = GetNumbersAndRemoveLeadingZero(mobPhoneNrP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.MobPhoneNr", out var mobPhoneNrC))
            {
                metadata.Properties["semler.customer.MobPhoneNr"] = GetNumbersAndRemoveLeadingZero(mobPhoneNrC);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.PhoneNumber", out var phoneNumberP))
            {
                metadata.Properties["semler.privatecustomer.PhoneNumber"] = GetNumbersAndRemoveLeadingZero(phoneNumberP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.PhoneNumber", out var phoneNumberC))
            {
                metadata.Properties["semler.customer.PhoneNumber"] = GetNumbersAndRemoveLeadingZero(phoneNumberC);
            }

            if (metadata.Properties.TryGetValue("semler.privatecustomer.AccPhone", out var accPhoneP))
            {
                metadata.Properties["semler.privatecustomer.AccPhone"] = GetNumbersAndRemoveLeadingZero(accPhoneP);
            }

            if (metadata.Properties.TryGetValue("semler.customer.AccPhone", out var accPhoneC))
            {
                metadata.Properties["semler.customer.AccPhone"] = GetNumbersAndRemoveLeadingZero(accPhoneC);
            }

            //Contact
            if (metadata.Properties.TryGetValue("semler.contact.PostalCode", out var postalCodeCo))
            {
                metadata.Properties["semler.contact.PostalCode"] = GetNumbersAndRemoveLeadingZero(postalCodeCo);
            }

            if (metadata.Properties.TryGetValue("semler.contact.MobPhoneNum", out var mobPhoneNumCo))
            {
                metadata.Properties["semler.contact.MobPhoneNum"] = GetNumbersAndRemoveLeadingZero(mobPhoneNumCo);
            }
        }
        #endregion

        #region Helping methods  
        public static string GetTitleCapital(string input)
        {
            TextInfo textInfo = new CultureInfo("da-DK", false).TextInfo;
            string result = string.Join(" ", input.Split(' ')
                                                  .Select(word => textInfo.ToTitleCase(textInfo.ToLower(word)))
                                                  .ToArray());
            return result;
        }

        public static string GetNumbersAndRemoveLeadingZero(string input)
        {
            return Convert.ToInt64(new string(input.Where(c => char.IsDigit(c)).ToArray())).ToString();
        }

        public static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

        private static string GetLetters(string input)
        {
            return new string(input.Where(c => char.IsLetter(c)).ToArray());
        }

        private static string GetLettersWithWhiteSpaces(string input)
        {
            return new string(input.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c.Equals('&')).ToArray());
        }

        public static bool EqualsIgnoreCase(string strA, string strB)
        {
            return strA.Equals(strB, StringComparison.CurrentCultureIgnoreCase);
        }
        #endregion 
    }
}
