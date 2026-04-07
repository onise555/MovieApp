using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Identity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Infrastructure.Persistence.Configurations.Identity
{
    public class UserDetailConfiguration : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.ToTable("UserDetails");
            builder.HasKey(x=>x.Id);


            builder.Property(d => d.ProfileImg).HasMaxLength(500);
            builder.Property(d=>d.Biography).HasMaxLength(1000);
            builder.Property(d=>d.ThemeColor).HasMaxLength(50);

        }
    }
}
