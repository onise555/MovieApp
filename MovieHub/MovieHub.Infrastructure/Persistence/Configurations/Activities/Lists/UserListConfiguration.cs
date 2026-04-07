using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Activities.Lists;

namespace MovieHub.Infrastructure.Persistence.Configurations.Activities.Lists
{
    public class UserListConfiguration : IEntityTypeConfiguration<UserList>
    {
        public void Configure(EntityTypeBuilder<UserList> builder)
        {
            builder.ToTable("UserLists");
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Type).IsRequired().HasConversion<int>();
            builder.Property(l => l.IsDeleted).HasDefaultValue(false);

            builder.HasMany(l => l.Items)
                .WithOne(i => i.UserList)
                .HasForeignKey(i => i.UserListId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
