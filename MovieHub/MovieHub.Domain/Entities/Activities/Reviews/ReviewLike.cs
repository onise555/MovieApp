using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Activities;
using MovieHub.Domain.Entities.Identity.Users;

public class ReviewLike : BaseEntity
{
    public DateTime LikedAt { get; set; }
    public int ReviewId { get; set; }
    public int UserId { get; set; }
    public Review review { get; set; } = null!;
    public User User { get; set; } = null!;
}