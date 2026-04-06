using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Cinema.Series;
using MovieHub.Domain.Entities.Identity.Users;

namespace MovieHub.Domain.Entities.Activities.Reviews;

public class Review : AuditableEntity, ISoftDelete
{
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }

    public bool IsValid => MovieId.HasValue != SeriesId.HasValue;


    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int? MovieId { get; set; }
    public Movie? Movie { get; set; }

    public int? SeriesId { get; set; }
    public Serie? Series { get; set; }

    public List<ReviewLike> Likes { get; set; } = new List<ReviewLike>();
}