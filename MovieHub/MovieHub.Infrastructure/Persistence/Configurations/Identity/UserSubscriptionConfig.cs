using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieHub.Domain.Entities.Identity.Users;


namespace MovieHub.Infrastructure.Persistence.Configurations.Identity
{
    public class UserSubscriptionConfig : IEntityTypeConfiguration<UserSubscription>
    {
        public void Configure(EntityTypeBuilder<UserSubscription> builder)
        {
            builder.ToTable("UserSubscriptions");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Plan).IsRequired().HasConversion<int>().HasDefaultValue(0);
            builder.Property(s => s.IsActive).HasDefaultValue(true);
            builder.Property(s => s.MaxDevices).HasDefaultValue(1);
            builder.Property(s => s.StartsAt).IsRequired();
            builder.Property(s => s.ExpiresAt).IsRequired();
        }
    }
}
