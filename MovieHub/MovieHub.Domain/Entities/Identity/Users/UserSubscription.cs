using MovieHub.Domain.Common;
using MovieHub.Domain.Enums.User;

namespace MovieHub.Domain.Entities.Identity.Users;

public class UserSubscription : BaseEntity
{
    public SubscriptionPlan Plan { get; set; } = SubscriptionPlan.Free;
    public DateTime StartsAt { get; set; }
    public DateTime ExpiresAt { get; set; }
    public bool IsActive { get; set; } = true;
    public int MaxDevices { get; set; } = 1;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}
