using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Medias.MovieMedia;

namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema;

public class MovieSubtitleConfiguration : IEntityTypeConfiguration<MovieSubtitle>
{
    public void Configure(EntityTypeBuilder<MovieSubtitle> builder)
    {
        builder.ToTable("MovieSubtitles");
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Url).IsRequired().HasMaxLength(1000);
        builder.Property(s => s.IsDefault).HasDefaultValue(false);

        builder.HasOne(s => s.MovieDetail)
            .WithMany(d => d.Subtitles)
            .HasForeignKey(s => s.MovieDetailId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(s => s.Language)
            .WithMany(l => l.MovieSubtitles)
            .HasForeignKey(s => s.LanguageId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}