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
    public abstract class CoolingsControllerRepository<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public CoolingsControllerRepository(TRepository repository)
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
            var cooling = await repository.Get(id);
            if (cooling == null)
            {
                return NotFound();
            }
            return cooling;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity cooling)
        {
            if (id != cooling.Id)
            {
                return BadRequest();
            }
            await repository.Update(cooling);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity cooling)
        {
            await repository.Add(cooling);
            return CreatedAtAction("Get", new { id = cooling.Id }, cooling);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var cooling = await repository.Delete(id);
            if (cooling == null)
            {
                return NotFound();
            }
            return cooling;
        }

    }
}
