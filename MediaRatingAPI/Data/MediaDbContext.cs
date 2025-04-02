using MediaRatingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaRatingAPI.Data
{
    public class MediaDbContext(DbContextOptions<MediaDbContext> options) : DbContext(options)
    {
        public DbSet<Media> Medias => Set<Media>();
        public DbSet<MediaDetails> MediaDetails => Set<MediaDetails>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Media>().HasData(
                new Media
                {
                    Id = 1,
                    Title = "Bookworm",
                    //ReleaseDate = DateTime.Parse("2024-08-29"),
                    Format = "Film",
                    //Rating = 9
                },
                new Media
                {
                    Id = 2,
                    Title = "Invincible (Season 1)",
                    //ReleaseDate = DateTime.Parse("2021-03-25"),
                    Format = "TV",
                    //Rating = 10
                },
                new Media
                {
                    Id = 3,
                    Title = "Flow",
                    //ReleaseDate = DateTime.Parse("2024-10-30"),
                    Format = "Film",
                    //Rating = 9
                },
                new Media
                {
                    Id = 4,
                    Title = "Hot Fuzz",
                    //ReleaseDate = DateTime.Parse("2007-02-16"),
                    Format = "Film",
                    //Rating = 10
                },
                new Media
                {
                    Id = 5,
                    Title = "Ar y Ffin",
                    //ReleaseDate = DateTime.Parse("2024-12-29"),
                    Format = "TV",
                    //Rating = 7
                }
            );
        }
    }
}
