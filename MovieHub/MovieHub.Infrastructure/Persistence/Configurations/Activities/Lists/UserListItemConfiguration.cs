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
    public class UserListItemConfiguration : IEntityTypeConfiguration<UserListItem>
    {
        public void Configure(EntityTypeBuilder<UserListItem> builder)
        {
            builder.ToTable("UserListItems");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.IsDeleted).HasDefaultValue(false);

            builder.Ignore(i => i.IsValid);

            builder.HasOne(i => i.Movie)
                .WithMany(m => m.UserListItems)
                .HasForeignKey(i => i.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(i => i.Series)
                .WithMany(s => s.UserListItems)
                .HasForeignKey(i => i.SeriesId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
