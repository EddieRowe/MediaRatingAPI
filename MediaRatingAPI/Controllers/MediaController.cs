using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaRatingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        static private List<Media> medias = new List<Media>
        {
            new Media
            {
                Id = 1,
                Title = "Bookworm",
                ReleaseDate = DateTime.Parse("2024-08-29"),
                Format = "Film",
                Rating = 9
            },
            new Media
            {
                Id = 2,
                Title = "Invincible Season 1",
                ReleaseDate = DateTime.Parse("2021-03-25"),
                Format = "TV",
                Rating = 10
            },
            new Media
            {
                Id = 3,
                Title = "Flow",
                ReleaseDate = DateTime.Parse("2024-10-30"),
                Format = "Film",
                Rating = 9
            }
        };

        [HttpGet]
        public ActionResult<List<Media>> GetMedias()
        {
            return Ok(medias);
        }

        [HttpGet("{id}")]
        public ActionResult<Media> GetMediaById(int id)
        {
            var media = medias.FirstOrDefault(x => x.Id == id);
            if (media == null)
            {
                return NotFound();
            }

            return Ok(media);
        }

        [HttpPost]
        public ActionResult<Media> AddMedia(Media newMedia)
        {
            if (newMedia == null)
            {
                return BadRequest();
            }

            newMedia.Id = medias.Max(m => m.Id) + 1;
            medias.Add(newMedia);
            return CreatedAtAction(nameof(GetMediaById), new { id = newMedia.Id }, newMedia);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMedia(int id, Media updatedMedia)
        {
            var media = medias.FirstOrDefault(x => x.Id == id);
            if (media == null)
            {
                return NotFound();
            }

            media.Title = updatedMedia.Title;
            media.ReleaseDate = updatedMedia.ReleaseDate;
            media.Format = updatedMedia.Format;
            media.Rating = updatedMedia.Rating;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMedia(int id)
        {
            var media = medias.FirstOrDefault(x => x.Id == id);
            if (media == null)
            {
                return NotFound();
            }

            medias.Remove(media);
            return NoContent();
        }
    }
}
