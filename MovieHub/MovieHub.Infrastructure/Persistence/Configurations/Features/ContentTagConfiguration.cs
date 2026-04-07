using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Features;

namespace MovieHub.Infrastructure.Persistence.Configurations.Features;

public class ContentTagConfiguration : IEntityTypeConfiguration<ContentTag>
{
    public void Configure(EntityTypeBuilder<ContentTag> builder)
    {
        builder.ToTable("ContentTags");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
        builder.Property(t => t.IsMood).HasDefaultValue(false);
        builder.HasIndex(t => t.Name).IsUnique();
    }
}