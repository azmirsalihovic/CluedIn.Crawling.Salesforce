using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;

namespace CluedIn.Semler.Common.PreProcessing
{
    public class NameNormalizationPreProcessor : Processing.Processors.PreProcessing.IPreProcessor
    {
        public bool Accepts(ExecutionContext context, IEnumerable<IEntityCode> codes)
        {
            return true;
        }

        public void Process(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            if (metadata != null)
            {
                metadata.DisplayName = metadata.DisplayName.ToLower().ToTitleCase();
            }
        }
    }
}
