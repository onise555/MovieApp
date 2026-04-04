using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Cinema.Series;
using MovieHub.Domain.Entities.Identity.Users;
using MovieHub.Domain.Enums.System;

namespace MovieHub.Domain.Entities.System;

public class Notification : BaseEntity
{
    public string Message { get; set; } = string.Empty;
    public NotificationType Type { get; set; }
    public bool IsRead { get; set; } = false;
    public DateTime CreatedAt { get; set; }
    public int UserId { get; set; }
    public int? MovieId { get; set; }
    public int? SeriesId { get; set; }

    public User User { get; set; } = null!;
    public Movie? Movie { get; set; }
    public Serie? Series { get; set; }
}
