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
    internal class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable("Notifications");
            builder.HasKey(n => n.Id);
                
            // Properties
            builder.Property(n => n.Message).IsRequired().HasMaxLength(500);
            builder.Property(n => n.Type).IsRequired().HasConversion<int>();
            builder.Property(n => n.IsRead).HasDefaultValue(false);
            builder.Property(n => n.CreatedAt).HasDefaultValueSql("GETUTCDATE()"); 


           
            builder.HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade); // იუზერის წაშლისას მისი ნოტიფიკაციებიც უნდა წაიშალოს

            // არჩევითი კავშირი ფილმთან
            builder.HasOne(n => n.Movie)
                .WithMany(m => m.Notifications)
                .HasForeignKey(n => n.MovieId)
                .OnDelete(DeleteBehavior.SetNull); // თუ ფილმი წაიშალა, ნოტიფიკაცია დარჩეს, უბრალოდ MovieId გახდეს null

            // არჩევითი კავშირი სერიალთან
            builder.HasOne(n => n.Series)
                .WithMany(s => s.Notifications)
                .HasForeignKey(n => n.SeriesId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
