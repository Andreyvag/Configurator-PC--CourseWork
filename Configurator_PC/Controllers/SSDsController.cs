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
    public class SSDsController : SSDsControllerRepository<SSD, EfCoreSSDRepository>
    { 
        public SSDsController(EfCoreSSDRepository repository) : base(repository)
        {

        }
    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class SSDsController : ControllerBase
    //{
    //    private readonly AccessoriesContext _context;

    //    public SSDsController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/SSDs
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<SSD>>> GetSSDs()
    //    {
    //        return await _context.SSDs.ToListAsync();
    //    }

    //    // GET: api/SSDs/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<SSD>> GetSSD(int id)
    //    {
    //        var sSD = await _context.SSDs.FindAsync(id);

    //        if (sSD == null)
    //        {
    //            return NotFound();
    //        }

    //        return sSD;
    //    }

    //    // PUT: api/SSDs/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutSSD(int id, SSD sSD)
    //    {
    //        if (id != sSD.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(sSD).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!SSDExists(id))
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

    //    // POST: api/SSDs
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<SSD>> PostSSD(SSD sSD)
    //    {
    //        _context.SSDs.Add(sSD);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetSSD", new { id = sSD.Id }, sSD);
    //    }

    //    // DELETE: api/SSDs/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<SSD>> DeleteSSD(int id)
    //    {
    //        var sSD = await _context.SSDs.FindAsync(id);
    //        if (sSD == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.SSDs.Remove(sSD);
    //        await _context.SaveChangesAsync();

    //        return sSD;
    //    }

    //    private bool SSDExists(int id)
    //    {
    //        return _context.SSDs.Any(e => e.Id == id);
    //    }
    //}
}
