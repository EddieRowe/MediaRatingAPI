namespace MediaRatingAPI.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Format { get; set; }

        public int? DistributorId { get; set; }
        public Distributor? Distributor { get; set; }
        
        public MediaDetails? MediaDetails { get; set; }
        public List<Genre>? Genres { get; set; }
    }
}
