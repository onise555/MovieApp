using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Identity.Users;
using MovieHub.Domain.Enums.Activities;

namespace MovieHub.Domain.Entities.Activities.Lists;

public class UserList : AuditableEntity, ISoftDelete
{
    public UserListType Type { get; set; }
    public int UserId { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }

    public User User { get; set; } = null!;
    public List<UserListItem> Items { get; set; } = new List<UserListItem>();
}
