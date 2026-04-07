using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Identity.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Infrastructure.Persistence.Configurations.Identity
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            builder.Property(u=>u.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(100);

            builder.Property(u => u.Email).HasMaxLength(256);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.Role).IsRequired().HasConversion<int>();
            builder.Property(u => u.IsActive).HasDefaultValue(true);
            builder.Property(u => u.IsDeleted).HasDefaultValue(false);

            // 4. Relationships (1:1 Connections)
            builder.HasOne(u=>u.Security)
                .WithOne(s=>s.User)
                .HasForeignKey<UserSecurity>(s=>s.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(u => u.Detail)
                .WithOne(d => d.User)
                .HasForeignKey<UserDetail>(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.Subscription)
                .WithOne(s => s.User)
                .HasForeignKey<UserSubscription>(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);








        }
    }
}
