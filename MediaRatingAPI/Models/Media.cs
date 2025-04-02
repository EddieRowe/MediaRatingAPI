namespace MediaRatingAPI.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Format { get; set; }
        
        public MediaDetails? MediaDetails { get; set; }
    }
}
