using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Activities.Reviews;
using MovieHub.Domain.Entities.Identity.Users;

namespace MovieHub.Domain.Entities.Activities.Reviews;

public class ReviewLike : BaseEntity
{
    public DateTime LikedAt { get; set; }


    public int UserId { get; set; }
    public Review Review { get; set; } = null!;
    public int ReviewId { get; set; }
    public User User { get; set; } = null!;
}
