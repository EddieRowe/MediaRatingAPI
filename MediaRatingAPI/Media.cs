namespace MediaRatingAPI
{
    public class Media
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Format { get; set; }
        public int? Rating { get; set; }
    }
}
