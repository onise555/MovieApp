using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Activities.History;
using MovieHub.Domain.Entities.Activities.Lists;
using MovieHub.Domain.Entities.Activities.Reviews;
using MovieHub.Domain.Entities.Features;
using MovieHub.Domain.Entities.System;
using MovieHub.Domain.Enums.User;

namespace MovieHub.Domain.Entities.Identity.Users;

public class User : AuditableEntity, ISoftDelete
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get;  set; } = string.Empty;
    public UserRole Role { get; set; }

    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
    public bool IsActive { get;  set; } = true;

    public DateTime? LastLoginAt { get; set; }


    public UserSecurity Security { get; set; } = null!;
    public UserDetail? Detail { get; set; }
    public UserSubscription? Subscription { get; set; }
    public List<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();

    public List<UserList> Lists { get; set; } = new List<UserList>();
    public List<Review> Reviews { get; set; } = new List<Review>();
    public List<WatchingHistory> WatchingHistories { get; set; } = new List<WatchingHistory>();
    public List<Notification> Notifications { get; set; } = new List<Notification>();
    public List<ContentReport> Reports { get; set; } = new List<ContentReport>();
}
