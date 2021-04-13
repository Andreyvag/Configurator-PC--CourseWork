using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Configurator_PC.Models;
using Configurator_PC.Data.EFCore;

namespace Configurator_PC.Data.EFCore
{
    public class EfCoreVideoCardRepository : EfCoreRepository<VideoCard, AccessoriesContext>
    {
        public EfCoreVideoCardRepository(AccessoriesContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
