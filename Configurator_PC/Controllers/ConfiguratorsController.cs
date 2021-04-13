using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Configurator_PC.Models;

namespace Configurator_PC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfiguratorsController : ControllerBase
    {
        private readonly AccessoriesContext _context;

        public ConfiguratorsController(AccessoriesContext context)
        {
            _context = context;
        }

        // GET: api/Configurators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Configurator>>> GetConfigurators()
        {
            return await _context.Configurators.Include(c => c.Cooling).Include(c => c.HardDrive).Include(c => c.Motherboard).Include(c => c.NetworkAdapter).Include(c => c.PowerSupply).Include(c => c.Processor).Include(c => c.RAM).Include(c => c.SSD).Include(c => c.SoundCard).Include(c => c.VideoCard).ToListAsync();
        }

        // GET: api/Configurators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Configurator>> GetConfigurator(int id)
        {
            var configurator = await _context.Configurators.FindAsync(id);

            if (configurator == null)
            {
                return NotFound();
            }

            return configurator;
        }

        // PUT: api/Configurators/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfigurator(int id, Configurator configurator)
        {
            if (id != configurator.Id)
            {
                return BadRequest();
            }

            _context.Entry(configurator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfiguratorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Configurators
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Configurator>> PostConfigurator(Configurator configurator)
        {
            _context.Configurators.Add(configurator);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfigurator", new { id = configurator.Id }, configurator);
        }

        // DELETE: api/Configurators/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Configurator>> DeleteConfigurator(int id)
        {
            var configurator = await _context.Configurators.FindAsync(id);
            if (configurator == null)
            {
                return NotFound();
            }

            _context.Configurators.Remove(configurator);
            await _context.SaveChangesAsync();

            return configurator;
        }

        private bool ConfiguratorExists(int id)
        {
            return _context.Configurators.Any(e => e.Id == id);
        }
    }
}
