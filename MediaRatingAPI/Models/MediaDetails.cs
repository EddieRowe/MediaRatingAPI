namespace MediaRatingAPI.Models
{
    public class MediaDetails
    {
        public int Id { get; set; }
        public int? Rating { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int MediaId { get; set; }
    }
}
