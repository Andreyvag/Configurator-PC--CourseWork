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
    public class CoolingsController : CoolingsControllerRepository<Cooling, EfCoreCoolingRepository>
    {
        public CoolingsController(EfCoreCoolingRepository repository) : base(repository)
        {

        }
    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class CoolingsController : ControllerBase
    //{
    //    private readonly AccessoriesContext _context;

    //    public CoolingsController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/Coolings
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<Cooling>>> GetCoolings()
    //    {
    //        return await _context.Coolings.ToListAsync();
    //    }

    //    // GET: api/Coolings/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<Cooling>> GetCooling(int id)
    //    {
    //        var cooling = await _context.Coolings.FindAsync(id);

    //        if (cooling == null)
    //        {
    //            return NotFound();
    //        }

    //        return cooling;
    //    }

    //    // PUT: api/Coolings/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutCooling(int id, Cooling cooling)
    //    {
    //        if (id != cooling.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(cooling).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!CoolingExists(id))
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

    //    // POST: api/Coolings
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<Cooling>> PostCooling(Cooling cooling)
    //    {
    //        _context.Coolings.Add(cooling);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetCooling", new { id = cooling.Id }, cooling);
    //    }

    //    // DELETE: api/Coolings/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<Cooling>> DeleteCooling(int id)
    //    {
    //        var cooling = await _context.Coolings.FindAsync(id);
    //        if (cooling == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Coolings.Remove(cooling);
    //        await _context.SaveChangesAsync();

    //        return cooling;
    //    }

    //    private bool CoolingExists(int id)
    //    {
    //        return _context.Coolings.Any(e => e.Id == id);
    //    }
    //}
}
