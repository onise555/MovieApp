using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Medias.MovieMedia;

namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema;

public class MovieTrailerConfiguration : IEntityTypeConfiguration<MovieTrailer>
{
    public void Configure(EntityTypeBuilder<MovieTrailer> builder)
    {
        builder.ToTable("MovieTrailers");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Url).IsRequired().HasMaxLength(1000);
        builder.Property(t => t.Quality).IsRequired().HasConversion<int>();
        builder.Property(t => t.IsDefault).HasDefaultValue(false);

        builder.HasOne(t => t.MovieDetail)
            .WithMany(d => d.Trailers)
            .HasForeignKey(t => t.MovieDetailId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(t => t.Language)
            .WithMany(l => l.MovieTrailers)
            .HasForeignKey(t => t.LanguageId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
