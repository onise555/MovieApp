using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Identity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Infrastructure.Persistence.Configurations.Identity
{
    public class UserSecurityConfiguration : IEntityTypeConfiguration<UserSecurity>
    {
        public void Configure(EntityTypeBuilder<UserSecurity> builder)
        {
            builder.ToTable("UserSecurities");
            builder.HasKey(s => s.Id);

            builder.Property(s=>s.PasswordHash).IsRequired().HasMaxLength(256);
            builder.Property(s => s.IsEmailConfirmed).HasDefaultValue(false);
            builder.Property(s=>s.EmailConfirmationToken).HasMaxLength(500);
            builder.Property(s => s.ForgotPassword).HasMaxLength(500);
            builder.Property(s => s.ForgotPasswordExpiry).IsRequired(false);
        }
    }
}
