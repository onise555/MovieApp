using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Series;

namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema;

public class SeasonConfiguration : IEntityTypeConfiguration<Season>
{
    public void Configure(EntityTypeBuilder<Season> builder)
    {
        builder.ToTable("Seasons");
        builder.HasKey(s => s.Id);

        builder.Property(s => s.SeasonNumber).IsRequired();
        builder.Property(s => s.Title).HasMaxLength(200);
        builder.Property(s => s.CoverImg).HasMaxLength(500);
        builder.Property(s => s.ReleaseYear).IsRequired();
        builder.Property(s => s.IsDeleted).HasDefaultValue(false);

        builder.HasOne(s => s.Series)
            .WithMany(sr => sr.Seasons)
            .HasForeignKey(s => s.SeriesId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}