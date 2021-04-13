using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Configurator_PC.Data;

namespace Configurator_PC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerSuppliesControllerRepository : ControllerBase
    {
    }

    [Route("api/[controller]")]
    [ApiController]
    public abstract class PowerSupplies1Controller<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public PowerSupplies1Controller(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var powerSupply = await repository.Get(id);
            if (powerSupply == null)
            {
                return NotFound();
            }
            return powerSupply;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity powerSupply)
        {
            if (id != powerSupply.Id)
            {
                return BadRequest();
            }
            await repository.Update(powerSupply);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity powerSupply)
        {
            await repository.Add(powerSupply);
            return CreatedAtAction("Get", new { id = powerSupply.Id }, powerSupply);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var powerSupply = await repository.Delete(id);
            if (powerSupply == null)
            {
                return NotFound();
            }
            return powerSupply;
        }

    }
}
