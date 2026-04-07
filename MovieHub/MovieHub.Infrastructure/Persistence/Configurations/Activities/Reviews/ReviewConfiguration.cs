using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Activities.Reviews;

namespace MovieHub.Infrastructure.Persistence.Configurations.Activities.Reviews;
public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ComplexProperty("Reviews");
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Rating).IsRequired();
        builder.Property(r => r.Comment).IsRequired().HasMaxLength(2000);
        builder.Property(r => r.IsDeleted).Equals(false);

        builder.Ignore(r => r.IsValid);

        builder.HasOne(r => r.Movie)
            .WithMany(m => m.Reviews)
            .HasForeignKey(r => r.MovieId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(r => r.Series)
            .WithMany(s => s.Reviews)
            .HasForeignKey(r => r.SeriesId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(r => r.Likes)
            .WithOne(l => l.Review)
            .HasForeignKey(l => l.ReviewId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
