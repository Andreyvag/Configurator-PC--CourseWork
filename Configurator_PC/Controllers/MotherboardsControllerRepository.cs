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
    public abstract class MotherboardsControllerRepository<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public MotherboardsControllerRepository(TRepository repository)
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
            var motherboard = await repository.Get(id);
            if (motherboard == null)
            {
                return NotFound();
            }
            return motherboard;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity motherboard)
        {
            if (id != motherboard.Id)
            {
                return BadRequest();
            }
            await repository.Update(motherboard);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity motherboard)
        {
            await repository.Add(motherboard);
            return CreatedAtAction("Get", new { id = motherboard.Id }, motherboard);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var motherboard = await repository.Delete(id);
            if (motherboard == null)
            {
                return NotFound();
            }
            return motherboard;
        }

    }
}
