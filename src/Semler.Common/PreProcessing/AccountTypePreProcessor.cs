using System;
using System.Collections.Generic;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;

namespace Semler.Common.PreProcessing
{
    public class AccountTypePreProcessor : CluedIn.Processing.Processors.PreProcessing.IPreProcessor
    {
        private IEnumerable<IEntityCode> codes;

        public bool Accepts(ExecutionContext context, IEnumerable<IEntityCode> codes)
        {
            return true;
        }

        public void Process(ExecutionContext context, IEntityMetadataPart metadata, IDataPart data)
        {
            if (metadata != null)
            {
                //then in the process method what we'll have to do is get out the kuk entity
                var entity = context.PrimaryDataStore.GetByEntityCode(context, (IEntityCode)codes);

                //then we can take out individual properties with something like this
                var input = entity.Properties.GetValues("kuk.account.Customertype");

                //Dennises Exmple (simplified)
                var entityIsPerson = !string.IsNullOrEmpty(input.ToString()) && new string[] { "1", "9", "a", "e" }.Contains(input.ToString().ToLower());

                //then based on the value of that kuk property we set the entity type, I think you can just do this, or whatever type it needs to be
                metadata.EntityType = entityIsPerson ? EntityType.Infrastructure.User : EntityType.Organization;

                /* Dennises Example from KUK
                var clue = _factory.Create(EntityType.Organization, input.Customerid, id);
                var entityIsPerson = !string.IsNullOrEmpty(input?.Customertype) && (new string[] { "1", "9", "a", "e" }.Contains(input.Customertype.ToLower()));
                if (entityIsPerson)
                    clue = _factory.Create(EntityType.Infrastructure.User, input.Customerid, id);
                */
            }
        }
    }
}
