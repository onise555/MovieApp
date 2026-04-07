using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Movies;


namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema.Movies
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(m=>m.Id);

            builder.Property(m => m.Title).IsRequired().HasMaxLength(300);
            builder.Property(m => m.CoverImg).IsRequired().HasMaxLength(500);
            builder.Property(m => m.BackdropImg).IsRequired().HasMaxLength(500);
            builder.Property(m => m.Rating).HasColumnType("decimal(3,1)");

            builder.Property(m => m.Status).IsRequired().HasConversion<int>();
            builder.Property(m => m.Type).IsRequired().HasConversion<int>();
            builder.Property(m => m.AgeRating).IsRequired().HasConversion<int>();

            builder.Property(m => m.ImdbId).HasMaxLength(20);


            builder.Property(m => m.ViewCount).HasDefaultValue(0);
            builder.Property(m => m.PopularityScore).HasDefaultValue(0);
            builder.Property(m => m.IsFeatured).HasDefaultValue(false);
            builder.Property(m => m.IsTrending).HasDefaultValue(false);
            builder.Property(m => m.IsPremium).HasDefaultValue(false);
            builder.Property(m => m.IsDeleted).HasDefaultValue(false);

            builder.HasIndex(m => m.Title);

            builder.HasIndex(m => m.ImdbId).IsUnique().HasFilter("[ImdbId] IS NOT NULL");
            builder.HasIndex(m => m.TmdbId).IsUnique().HasFilter("[TmdbId] IS NOT NULL");
            
            // 5. Relationships (One-to-One)

            builder.HasOne(m=>m.Detail)
                .WithOne(d=>d.Movie)
                .HasForeignKey<MovieDetail>(d=>d.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            // 6. Self-Referencing (Prequel & Sequel)
            builder.HasOne(m => m.Prequel)
                .WithMany()
                .HasForeignKey(m => m.PrequelId)
                .OnDelete(DeleteBehavior.Restrict);

           
            builder.HasOne(m=>m.Sequel)
                .WithMany()
                .HasForeignKey(m=>m.SequelId)
                .OnDelete(DeleteBehavior.Restrict);

            // 7.Many - to - Many Relationships (ავტომატური შუალედური ცხრილები)
            builder.HasMany(m => m.Genres)
                .WithMany(g => g.Movies)
                .UsingEntity(j => j.ToTable("MovieGenres"));

            builder.HasMany(m => m.Actors)
                .WithMany(a => a.Movies)
                .UsingEntity(j => j.ToTable("MovieActors"));

            builder.HasMany(m => m.Countries)
                .WithMany(c => c.Movies)
                .UsingEntity(j => j.ToTable("MovieCountries"));

            builder.HasMany(m => m.Tags)
                .WithMany(t => t.Movies)
                .UsingEntity(j => j.ToTable("MovieTags"));


            builder.HasMany(m => m.DubbingLanguages)
            .WithMany()
            .UsingEntity(j => j.ToTable("MovieDubbingLanguages"));

            builder.HasMany(m => m.SubtitleLanguages)
                .WithMany()
                .UsingEntity(j => j.ToTable("MovieSubtitleLanguages"));

            builder.HasQueryFilter(m => !m.IsDeleted);






        }
    }
}
