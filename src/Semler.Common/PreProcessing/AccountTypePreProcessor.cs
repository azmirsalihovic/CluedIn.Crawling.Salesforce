using System;
using System.Collections.Generic;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Configuration;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;

namespace Semler.Common.PreProcessing
{
    public class AccountTypePreProcessor : CluedIn.Processing.Processors.PreProcessing.IPreProcessor
    {

        public bool Accepts(ExecutionContext context, IEnumerable<IEntityCode> codes)
        {
            return codes.Any(x => x.Origin.Code == "Salesforce" || x.Origin.Code == "Geomatic");
        }

        public void Process(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            if (ConfigurationManagerEx.AppSettings.GetFlag("Semler.ClueProcessing.EntityTypeTranslation", false))
            {
                if (metadata != null)
                {
                    var kukCodes = metadata.Codes.Where(x => x.ToString().Contains("KUK"));
                    IEntityCode code = null;
                    if (kukCodes.Any())
                    {
                        code = kukCodes.First();

                        if (metadata.EntityType.Is(EntityType.Organization))
                        {
                            code = new EntityCode(EntityType.Infrastructure.User, code.Origin, code.Value);
                        }
                        else if (metadata.EntityType.Is(EntityType.Infrastructure.User))
                        {
                            code = new EntityCode(EntityType.Organization, code.Origin, code.Value);
                        }

                        var entity = context.PrimaryDataStore.GetByEntityCode(context, code);

                        if (entity.ProcessedData.OriginEntityCode.Origin.Code == "KUK")
                        {
                            if (entity != null)
                            {
                                metadata.EntityType = entity.EntityType;
                                metadata.Codes.Add(code);
                            }
                        }
                    }
                }
            }
        }
    }
}
