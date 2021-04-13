using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Configurator_PC.Models;

namespace Configurator_PC.Data.EFCore
{
    public class EfCoreSSDRepository : EfCoreRepository<SSD, AccessoriesContext>
    {
        public EfCoreSSDRepository(AccessoriesContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
