using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Cinema.Series;
using MovieHub.Domain.Entities.Identity.Users;
using MovieHub.Domain.Enums.System;

namespace MovieHub.Domain.Entities.System;

public class ContentReport : AuditableEntity, ISoftDelete
{
    public ReportReason Reason { get; set; }
    public string? Description { get; set; }
    public bool IsResolved { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
    public int UserId { get; set; }
    public int? MovieId { get; set; }
    public int? SeriesId { get; set; }
    public int? EpisodeId { get; set; }

    public User User { get; set; } = null!;
    public Movie? Movie { get; set; }
    public Serie? Series { get; set; }
    public Episode? Episode { get; set; }
}
