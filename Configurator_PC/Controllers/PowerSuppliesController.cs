using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Configurator_PC.Models;
using Configurator_PC.Data.EFCore;

namespace Configurator_PC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerSuppliesController : PowerSupplies1Controller<PowerSupply, EfCorePowerSupplyRepository>
    {
        public PowerSuppliesController(EfCorePowerSupplyRepository repository) : base(repository)
        {

        }
    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class PowerSuppliesController : ControllerBase
    //{
    //    private readonly AccessoriesContext _context;

    //    public PowerSuppliesController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/PowerSupplies
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<PowerSupply>>> GetPowerSupplies()
    //    {
    //        return await _context.PowerSupplies.ToListAsync();
    //    }

    //    // GET: api/PowerSupplies/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<PowerSupply>> GetPowerSupply(int id)
    //    {
    //        var powerSupply = await _context.PowerSupplies.FindAsync(id);

    //        if (powerSupply == null)
    //        {
    //            return NotFound();
    //        }

    //        return powerSupply;
    //    }

    //    // PUT: api/PowerSupplies/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutPowerSupply(int id, PowerSupply powerSupply)
    //    {
    //        if (id != powerSupply.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(powerSupply).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!PowerSupplyExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return NoContent();
    //    }

    //    // POST: api/PowerSupplies
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<PowerSupply>> PostPowerSupply(PowerSupply powerSupply)
    //    {
    //        _context.PowerSupplies.Add(powerSupply);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetPowerSupply", new { id = powerSupply.Id }, powerSupply);
    //    }

    //    // DELETE: api/PowerSupplies/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<PowerSupply>> DeletePowerSupply(int id)
    //    {
    //        var powerSupply = await _context.PowerSupplies.FindAsync(id);
    //        if (powerSupply == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.PowerSupplies.Remove(powerSupply);
    //        await _context.SaveChangesAsync();

    //        return powerSupply;
    //    }

    //    private bool PowerSupplyExists(int id)
    //    {
    //        return _context.PowerSupplies.Any(e => e.Id == id);
    //    }
    //}
}
