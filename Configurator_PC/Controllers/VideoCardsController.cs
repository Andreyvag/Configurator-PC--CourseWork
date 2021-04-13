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
    public class VideoCardsController : VideoCardsControllerRepository<VideoCard, EfCoreVideoCardRepository>
    {
        public VideoCardsController(EfCoreVideoCardRepository repository) : base(repository)
        {

        }
    }
    //{
    //    private readonly AccessoriesContext _context;

    //    public VideoCardsController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class VideoCardsController : ControllerBase
    //{
    //    private readonly AccessoriesContext _context;

    //    public VideoCardsController(AccessoriesContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/VideoCards
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<VideoCard>>> GetVideoCards()
    //    {
    //        return await _context.VideoCards.ToListAsync();
    //    }

    //    // GET: api/VideoCards/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<VideoCard>> GetVideoCard(int id)
    //    {
    //        var videoCard = await _context.VideoCards.FindAsync(id);

    //        if (videoCard == null)
    //        {
    //            return NotFound();
    //        }

    //        return videoCard;
    //    }

    //    // PUT: api/VideoCards/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutVideoCard(int id, VideoCard videoCard)
    //    {
    //        if (id != videoCard.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(videoCard).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!VideoCardExists(id))
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

    //    // POST: api/VideoCards
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<VideoCard>> PostVideoCard(VideoCard videoCard)
    //    {
    //        _context.VideoCards.Add(videoCard);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetVideoCard", new { id = videoCard.Id }, videoCard);
    //    }

    //    // DELETE: api/VideoCards/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<VideoCard>> DeleteVideoCard(int id)
    //    {
    //        var videoCard = await _context.VideoCards.FindAsync(id);
    //        if (videoCard == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.VideoCards.Remove(videoCard);
    //        await _context.SaveChangesAsync();

    //        return videoCard;
    //    }

    //    private bool VideoCardExists(int id)
    //    {
    //        return _context.VideoCards.Any(e => e.Id == id);
    //    }
    //}
}
