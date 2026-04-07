using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Activities.History;

namespace MovieHub.Infrastructure.Persistence.Configurations.Activities.History
{

    public class WatchingHistoryConfiguration : IEntityTypeConfiguration<WatchingHistory>
    {
        public void Configure(EntityTypeBuilder<WatchingHistory> builder)
        {
            builder.ToTable("WatchingHistories");
            builder.HasKey(w => w.Id);

            builder.Property(w => w.ProgressSeconds).IsRequired();
            builder.Property(w => w.IsCompleted).HasDefaultValue(false);

            builder.Ignore(w => w.IsValid);

            builder.HasOne(w => w.User)
                .WithMany(u => u.WatchingHistories)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(w => w.Movie)
                .WithMany(m => m.WatchingHistories)
                .HasForeignKey(w => w.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(w => w.Episode)
                .WithMany(e => e.WatchingHistories)
                .HasForeignKey(w => w.EpisodeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(w => w.LastAudioLanguage)
                .WithMany(l => l.AudioWatchingHistories)
                .HasForeignKey(w => w.LastAudioLanguageId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(w => w.LastSubtitleLanguage)
                .WithMany(l => l.SubtitleWatchingHistories)
                .HasForeignKey(w => w.LastSubtitleLanguageId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}