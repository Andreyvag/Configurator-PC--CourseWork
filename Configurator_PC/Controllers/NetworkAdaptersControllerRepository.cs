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
    public abstract class NetworkAdaptersControllerRepository<TEntity, TRepository> : ControllerBase
       where TEntity : class, IEntity
       where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public NetworkAdaptersControllerRepository(TRepository repository)
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
            var networkAdapter = await repository.Get(id);
            if (networkAdapter == null)
            {
                return NotFound();
            }
            return networkAdapter;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity networkAdapter)
        {
            if (id != networkAdapter.Id)
            {
                return BadRequest();
            }
            await repository.Update(networkAdapter);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity networkAdapter)
        {
            await repository.Add(networkAdapter);
            return CreatedAtAction("Get", new { id = networkAdapter.Id }, networkAdapter);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var networkAdapter = await repository.Delete(id);
            if (networkAdapter == null)
            {
                return NotFound();
            }
            return networkAdapter;
        }

    }
}
