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
    public class SoundCardsController : SoundCardsControllerRepository<SoundCard, EfCoreSoundCardRepository>
    {
        public SoundCardsController(EfCoreSoundCardRepository repository) : base(repository)
        {

        }
    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class SoundCardsController : ControllerBase
    //{
    //    private readonly AccessoriesContext _context;

    //    public SoundCardsController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/SoundCards
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<SoundCard>>> GetSoundCards()
    //    {
    //        return await _context.SoundCards.ToListAsync();
    //    }

    //    // GET: api/SoundCards/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<SoundCard>> GetSoundCard(int id)
    //    {
    //        var soundCard = await _context.SoundCards.FindAsync(id);

    //        if (soundCard == null)
    //        {
    //            return NotFound();
    //        }

    //        return soundCard;
    //    }

    //    // PUT: api/SoundCards/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutSoundCard(int id, SoundCard soundCard)
    //    {
    //        if (id != soundCard.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(soundCard).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!SoundCardExists(id))
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

    //    // POST: api/SoundCards
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<SoundCard>> PostSoundCard(SoundCard soundCard)
    //    {
    //        _context.SoundCards.Add(soundCard);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetSoundCard", new { id = soundCard.Id }, soundCard);
    //    }

    //    // DELETE: api/SoundCards/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<SoundCard>> DeleteSoundCard(int id)
    //    {
    //        var soundCard = await _context.SoundCards.FindAsync(id);
    //        if (soundCard == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.SoundCards.Remove(soundCard);
    //        await _context.SaveChangesAsync();

    //        return soundCard;
    //    }

    //    private bool SoundCardExists(int id)
    //    {
    //        return _context.SoundCards.Any(e => e.Id == id);
    //    }
    //}
}
