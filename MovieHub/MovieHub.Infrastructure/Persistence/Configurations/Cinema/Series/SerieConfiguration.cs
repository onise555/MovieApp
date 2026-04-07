using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Series;

namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema;

public class SerieConfiguration : IEntityTypeConfiguration<Serie>
{
    public void Configure(EntityTypeBuilder<Serie> builder)
    {
        builder.ToTable("Series");
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Title).IsRequired().HasMaxLength(300);
        builder.Property(s => s.CoverImg).IsRequired().HasMaxLength(500);
        builder.Property(s => s.BackdropImg).HasMaxLength(500);
        builder.Property(s => s.Status).IsRequired().HasConversion<int>();
        builder.Property(s => s.Type).IsRequired().HasConversion<int>();
        builder.Property(s => s.AgeRating).IsRequired().HasConversion<int>();
        builder.Property(s => s.IsFeatured).HasDefaultValue(false);
        builder.Property(s => s.IsTrending).HasDefaultValue(false);
        builder.Property(s => s.IsPremium).HasDefaultValue(false);
        builder.Property(s => s.ViewCount).HasDefaultValue(0);
        builder.Property(s => s.IsDeleted).HasDefaultValue(false);
        builder.Property(s => s.ImdbId).HasMaxLength(20);

        builder.HasIndex(s => s.Title);
        builder.HasIndex(s => s.ImdbId).IsUnique().HasFilter("\"ImdbId\" IS NOT NULL");
        builder.HasIndex(s => s.TmdbId).IsUnique().HasFilter("\"TmdbId\" IS NOT NULL");

        builder.Ignore(s => s.TotalEpisodes);

        builder.HasOne(s => s.Detail)
            .WithOne(d => d.Series)
            .HasForeignKey<SeriesDetail>(d => d.SeriesId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(s => s.Genres)
            .WithMany(g => g.Series)
            .UsingEntity(j => j.ToTable("SeriesGenres"));

        builder.HasMany(s => s.Actors)
            .WithMany(a => a.Series)
            .UsingEntity(j => j.ToTable("SeriesActors"));

        builder.HasMany(s => s.Countries)
            .WithMany(c => c.Series)
            .UsingEntity(j => j.ToTable("SeriesCountries"));

        builder.HasMany(s => s.Tags)
            .WithMany(t => t.Series)
            .UsingEntity(j => j.ToTable("SeriesTags"));

        builder.HasMany(s => s.DubbingLanguages)
            .WithMany()
            .UsingEntity(j => j.ToTable("SeriesDubbingLanguages"));

        builder.HasMany(s => s.SubtitleLanguages)
            .WithMany()
            .UsingEntity(j => j.ToTable("SeriesSubtitleLanguages"));
    }
}
