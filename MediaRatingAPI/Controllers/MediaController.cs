using MediaRatingAPI.Data;
using MediaRatingAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MediaRatingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController(MediaDbContext context) : ControllerBase
    {
        // Injected context with primary constructor
        private readonly MediaDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<List<Media>>> GetMedias()
        {
            return Ok(await _context.Medias
                .Include(m => m.MediaDetails)
                .Include(m => m.Distributor)
                .ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Media>> GetMediaById(int id)
        {
            var media = await _context.Medias.FindAsync(id);
            if (media == null)
            {
                return NotFound();
            }

            return Ok(media);
        }

        [HttpPost]
        public async Task<ActionResult<Media>> AddMedia(Media newMedia)
        {
            if (newMedia == null)
            {
                return BadRequest();
            }

            _context.Medias.Add(newMedia);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMediaById), new { id = newMedia.Id }, newMedia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMedia(int id, Media updatedMedia)
        {
            var media = await _context.Medias.FindAsync(id);
            if (media == null)
            {
                return NotFound();
            }

            media.Title = updatedMedia.Title;
            //media.ReleaseDate = updatedMedia.ReleaseDate;
            media.Format = updatedMedia.Format;
            //media.Rating = updatedMedia.Rating;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedia(int id)
        {
            var media = await _context.Medias.FindAsync(id);
            if (media == null)
            {
                return NotFound();
            }

            _context.Medias.Remove(media);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
