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
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable("RefreshTokens");
            builder.HasKey(r => r.Id);

            builder.Property(r=>r.Token).IsRequired().HasMaxLength(500);
            builder.HasIndex(r => r.Token).IsUnique();

            builder.Ignore(r=>r.IsExpired); 
            builder.Ignore(r=>r.IsActive);
            builder.Property(r => r.ExpiresAt).IsRequired();
            builder.Property(r => r.RevokedAt).IsRequired(false);


        }
    }
}
