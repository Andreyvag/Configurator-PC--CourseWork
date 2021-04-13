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
    public class NetworkAdaptersController : NetworkAdaptersControllerRepository<NetworkAdapter, EfCoreNetworkAdapterRepository>
    {
        public NetworkAdaptersController(EfCoreNetworkAdapterRepository repository) : base(repository)
        {

        }
    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class NetworkAdaptersController : ControllerBase
    //{
    //    private readonly AccessoriesContext _context;

    //    public NetworkAdaptersController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/NetworkAdapters
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<NetworkAdapter>>> GetNetworkAdapters()
    //    {
    //        return await _context.NetworkAdapters.ToListAsync();
    //    }

    //    // GET: api/NetworkAdapters/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<NetworkAdapter>> GetNetworkAdapter(int id)
    //    {
    //        var networkAdapter = await _context.NetworkAdapters.FindAsync(id);

    //        if (networkAdapter == null)
    //        {
    //            return NotFound();
    //        }

    //        return networkAdapter;
    //    }

    //    // PUT: api/NetworkAdapters/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutNetworkAdapter(int id, NetworkAdapter networkAdapter)
    //    {
    //        if (id != networkAdapter.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(networkAdapter).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!NetworkAdapterExists(id))
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

    //    // POST: api/NetworkAdapters
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<NetworkAdapter>> PostNetworkAdapter(NetworkAdapter networkAdapter)
    //    {
    //        _context.NetworkAdapters.Add(networkAdapter);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetNetworkAdapter", new { id = networkAdapter.Id }, networkAdapter);
    //    }

    //    // DELETE: api/NetworkAdapters/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<NetworkAdapter>> DeleteNetworkAdapter(int id)
    //    {
    //        var networkAdapter = await _context.NetworkAdapters.FindAsync(id);
    //        if (networkAdapter == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.NetworkAdapters.Remove(networkAdapter);
    //        await _context.SaveChangesAsync();

    //        return networkAdapter;
    //    }

    //    private bool NetworkAdapterExists(int id)
    //    {
    //        return _context.NetworkAdapters.Any(e => e.Id == id);
    //    }
    //}
}
