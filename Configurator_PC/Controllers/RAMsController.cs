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
    public class RAMsController : RAMsControllerRepository<RAM, EfCoreRAMRepository>
    {
        public RAMsController(EfCoreRAMRepository repository) : base(repository)
        {

        }
    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class RAMsController : ControllerBase
    //{
    //    private readonly AccessoriesContext _context;

    //    public RAMsController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/RAMs
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<RAM>>> GetRAMs()
    //    {
    //        return await _context.RAMs.ToListAsync();
    //    }

    //    // GET: api/RAMs/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<RAM>> GetRAM(int id)
    //    {
    //        var rAM = await _context.RAMs.FindAsync(id);

    //        if (rAM == null)
    //        {
    //            return NotFound();
    //        }

    //        return rAM;
    //    }

    //    // PUT: api/RAMs/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutRAM(int id, RAM rAM)
    //    {
    //        if (id != rAM.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(rAM).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!RAMExists(id))
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

    //    // POST: api/RAMs
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<RAM>> PostRAM(RAM rAM)
    //    {
    //        _context.RAMs.Add(rAM);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetRAM", new { id = rAM.Id }, rAM);
    //    }

    //    // DELETE: api/RAMs/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<RAM>> DeleteRAM(int id)
    //    {
    //        var rAM = await _context.RAMs.FindAsync(id);
    //        if (rAM == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.RAMs.Remove(rAM);
    //        await _context.SaveChangesAsync();

    //        return rAM;
    //    }

    //    private bool RAMExists(int id)
    //    {
    //        return _context.RAMs.Any(e => e.Id == id);
    //    }
    //}
}
