using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Features;

namespace MovieHub.Infrastructure.Persistence.Configurations.Features;

public class ActorConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.ToTable("Actors");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(a => a.LastName).IsRequired().HasMaxLength(100);
        builder.Property(a => a.Biography).HasMaxLength(2000);
        builder.Property(a => a.PhotoUrl).HasMaxLength(500);
    }
}