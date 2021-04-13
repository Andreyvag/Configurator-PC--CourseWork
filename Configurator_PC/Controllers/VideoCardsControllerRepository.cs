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
    public abstract class VideoCardsControllerRepository<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public VideoCardsControllerRepository(TRepository repository)
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
            var videoCard = await repository.Get(id);
            if (videoCard == null)
            {
                return NotFound();
            }
            return videoCard;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity videoCard)
        {
            if (id != videoCard.Id)
            {
                return BadRequest();
            }
            await repository.Update(videoCard);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity videoCard)
        {
            await repository.Add(videoCard);
            return CreatedAtAction("Get", new { id = videoCard.Id }, videoCard);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var videoCard = await repository.Delete(id);
            if (videoCard == null)
            {
                return NotFound();
            }
            return videoCard;
        }

    }
}
