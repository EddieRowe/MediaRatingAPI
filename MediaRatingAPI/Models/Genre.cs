using System.Text.Json.Serialization;

namespace MediaRatingAPI.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        [JsonIgnore]
        public List<Media>? Medias { get; set; }
    }
}
