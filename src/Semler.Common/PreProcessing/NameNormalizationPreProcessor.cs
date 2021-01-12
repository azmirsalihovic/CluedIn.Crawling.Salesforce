using System;
using System.Collections.Generic;
using System.Globalization;
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
                TextInfo myTI = new CultureInfo("da-DK", false).TextInfo;
                if (!string.IsNullOrWhiteSpace(metadata.DisplayName))
                    metadata.DisplayName = myTI.ToTitleCase(myTI.ToLower(metadata.DisplayName));
                if (!string.IsNullOrWhiteSpace(metadata.Name))
                    metadata.Name = myTI.ToTitleCase(myTI.ToLower(metadata.Name));
            }
        }
    }
}
