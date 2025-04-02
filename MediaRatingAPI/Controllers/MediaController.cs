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
    }
}
