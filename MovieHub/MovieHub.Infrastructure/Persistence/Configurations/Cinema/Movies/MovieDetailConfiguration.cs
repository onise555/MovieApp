using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Movies;

namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema;

public class MovieDetailConfiguration : IEntityTypeConfiguration<MovieDetail>
{
    public void Configure(EntityTypeBuilder<MovieDetail> builder)
    {
        builder.ToTable("MovieDetails");
        builder.HasKey(d => d.Id);

        builder.Property(d => d.Description).IsRequired().HasMaxLength(3000);
        builder.Property(d => d.Director).IsRequired().HasMaxLength(200);
        builder.Property(d => d.DurationMinutes).IsRequired();
        builder.Property(d => d.TrailerYoutubeKey).HasMaxLength(50);
    }
}