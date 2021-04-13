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
    public class HardDrivesController : HardDrivesControllerRepository<HardDrive, EfCoreHardDriveRepository>
    { 
        public HardDrivesController(EfCoreHardDriveRepository repository) : base(repository)
        {

        }
    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class HardDrivesController : ControllerBase
    //{
    //    private readonly AccessoriesContext _context;

    //    public HardDrivesController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/HardDrives
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<HardDrive>>> GetHardDrives()
    //    {
    //        return await _context.HardDrives.ToListAsync();
    //    }

    //    // GET: api/HardDrives/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<HardDrive>> GetHardDrive(int id)
    //    {
    //        var hardDrive = await _context.HardDrives.FindAsync(id);

    //        if (hardDrive == null)
    //        {
    //            return NotFound();
    //        }

    //        return hardDrive;
    //    }

    //    // PUT: api/HardDrives/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutHardDrive(int id, HardDrive hardDrive)
    //    {
    //        if (id != hardDrive.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(hardDrive).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!HardDriveExists(id))
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

    //    // POST: api/HardDrives
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<HardDrive>> PostHardDrive(HardDrive hardDrive)
    //    {
    //        _context.HardDrives.Add(hardDrive);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetHardDrive", new { id = hardDrive.Id }, hardDrive);
    //    }

    //    // DELETE: api/HardDrives/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<HardDrive>> DeleteHardDrive(int id)
    //    {
    //        var hardDrive = await _context.HardDrives.FindAsync(id);
    //        if (hardDrive == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.HardDrives.Remove(hardDrive);
    //        await _context.SaveChangesAsync();

    //        return hardDrive;
    //    }

    //    private bool HardDriveExists(int id)
    //    {
    //        return _context.HardDrives.Any(e => e.Id == id);
    //    }
    //}
}
