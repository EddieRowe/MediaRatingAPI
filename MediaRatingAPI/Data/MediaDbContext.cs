using MediaRatingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaRatingAPI.Data
{
    public class MediaDbContext(DbContextOptions<MediaDbContext> options) : DbContext(options)
    {
        public DbSet<Media> Medias => Set<Media>();
        public DbSet<MediaDetails> MediaDetails => Set<MediaDetails>();

        public DbSet<Distributor> Distributors => Set<Distributor>();
        public DbSet<Genre> Genres => Set<Genre>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Media>().HasData(
                new Media
                {
                    Id = 1,
                    Title = "Bookworm",
                    Format = "Film"
                },
                new Media
                {
                    Id = 2,
                    Title = "Invincible (Season 1)",
                    Format = "TV"
                },
                new Media
                {
                    Id = 3,
                    Title = "Flow",
                    Format = "Film"
                },
                new Media
                {
                    Id = 4,
                    Title = "Hot Fuzz",
                    Format = "Film"
                },
                new Media
                {
                    Id = 5,
                    Title = "Ar y Ffin",
                    Format = "TV"
                }
            );
        }
    }
}
