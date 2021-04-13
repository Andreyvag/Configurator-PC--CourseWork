using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Configurator_PC.Models;
using Configurator_PC.Data.EFCore;

namespace Configurator_PC.Data.EFCore
{
    public class EfCoreProcessorRepository : EfCoreRepository<Processor, AccessoriesContext>
    {
        public EfCoreProcessorRepository(AccessoriesContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
