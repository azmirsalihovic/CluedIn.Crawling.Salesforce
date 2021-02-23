using System;
using System.Collections.Generic;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Configuration;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;

namespace Semler.Common.PreProcessing
{
    public class TranslateTypesPreProcessor : CluedIn.Processing.Processors.PreProcessing.IPreProcessor
    {

        public bool Accepts(ExecutionContext context, IEnumerable<IEntityCode> codes)
        {
            return codes.Any(x => x.Origin.Code == "Salesforce" || x.Origin.Code == "Geomatic" || x.Origin.Code == "KUK");
        }

        public void Process(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            if (ConfigurationManagerEx.AppSettings.GetFlag("Semler.ClueProcessing.TempTranslateTypes", true))
            {
                if (metadata != null)
                {
                    if (metadata.EntityType == "/Person")
                    {
                        metadata.EntityType = "/Infrastructure/User";
                    }
                }
            }
        }
    }
}
