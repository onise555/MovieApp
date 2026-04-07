using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Series;

namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema;

public class SeriesDetailConfiguration : IEntityTypeConfiguration<SeriesDetail>
{
    public void Configure(EntityTypeBuilder<SeriesDetail> builder)
    {
        builder.ToTable("SeriesDetails");
        builder.HasKey(d => d.Id);

        builder.Property(d => d.Description).IsRequired().HasMaxLength(3000);
        builder.Property(d => d.Director).IsRequired().HasMaxLength(200);
        builder.Property(d => d.AvgEpisodeMinutes).IsRequired();
        builder.Property(d => d.TrailerYoutubeKey).HasMaxLength(50);
    }
}