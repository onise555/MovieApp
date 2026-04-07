using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Cinema.Medias.MovieMedia;

namespace MovieHub.Infrastructure.Persistence.Configurations.Cinema.Medias.MovieMedia
{

    public class MoviePlayerConfiguration : IEntityTypeConfiguration<MoviePlayer>
    {
        public void Configure(EntityTypeBuilder<MoviePlayer> builder)
        {
            builder.ToTable("MoviePlayers");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Url).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.Quality).IsRequired().HasConversion<int>();
            builder.Property(p => p.IsDefault).HasDefaultValue(false);

            builder.HasOne(p => p.MovieDetail)
                .WithMany(d => d.Players)
                .HasForeignKey(p => p.MovieDetailId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Language)
                .WithMany(l => l.MoviePlayers)
                .HasForeignKey(p => p.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
