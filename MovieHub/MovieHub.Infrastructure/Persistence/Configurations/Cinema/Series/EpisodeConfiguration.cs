using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Series;

namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema;

public class EpisodeConfiguration : IEntityTypeConfiguration<Episode>
{
    public void Configure(EntityTypeBuilder<Episode> builder)
    {
        builder.ToTable("Episodes");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.EpisodeNumber).IsRequired();
        builder.Property(e => e.EpisodeName).IsRequired().HasMaxLength(300);
        builder.Property(e => e.DurationMinutes).IsRequired();
        builder.Property(e => e.ThumbnailUrl).HasMaxLength(500);
        builder.Property(e => e.Description).HasMaxLength(2000);
        builder.Property(e => e.ArcName).HasMaxLength(200);
        builder.Property(e => e.IsFillerEpisode).HasDefaultValue(false);
        builder.Property(e => e.IsDeleted).HasDefaultValue(false);

        builder.HasOne(e => e.Season)
            .WithMany(s => s.Episodes)
            .HasForeignKey(e => e.SeasonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.NextEpisode)
            .WithMany()
            .HasForeignKey(e => e.NextEpisodeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}