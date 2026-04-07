using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Infrastructure.Persistence.Configurations.System
{
    public class ContentReportConfiguration : IEntityTypeConfiguration<ContentReport>
    {
        public void Configure(EntityTypeBuilder<ContentReport> builder)
        {

            builder.ToTable("ContentReports");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Reason).IsRequired().HasConversion<int>();
            builder.Property(r => r.Description).HasMaxLength(1000);
            builder.Property(r => r.IsResolved).HasDefaultValue(false);
            builder.Property(r => r.IsDeleted).HasDefaultValue(false);


            builder.HasOne(r => r.User)
            .WithMany(u => u.Reports)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(r => r.Movie)
           .WithMany(m => m.Reports)
           .HasForeignKey(r => r.MovieId)
           .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(r => r.Series)
                .WithMany(s => s.Reports)
                .HasForeignKey(r => r.SeriesId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(r => r.Episode)
                .WithMany()
                .HasForeignKey(r => r.EpisodeId)
                .OnDelete(DeleteBehavior.SetNull);


            builder.HasQueryFilter(r => !r.IsDeleted);

        }
    }
}
