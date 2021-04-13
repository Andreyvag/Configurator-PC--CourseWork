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
    public abstract class SoundCardsControllerRepository<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public SoundCardsControllerRepository(TRepository repository)
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
            var soundCard = await repository.Get(id);
            if (soundCard == null)
            {
                return NotFound();
            }
            return soundCard;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity soundCard)
        {
            if (id != soundCard.Id)
            {
                return BadRequest();
            }
            await repository.Update(soundCard);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity soundCard)
        {
            await repository.Add(soundCard);
            return CreatedAtAction("Get", new { id = soundCard.Id }, soundCard);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var soundCard = await repository.Delete(id);
            if (soundCard == null)
            {
                return NotFound();
            }
            return soundCard;
        }

    }
}
