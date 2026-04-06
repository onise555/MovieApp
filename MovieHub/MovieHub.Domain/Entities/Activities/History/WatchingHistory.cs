using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Identity.Users;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Cinema.Series;
using MovieHub.Domain.Entities.Features;

namespace MovieHub.Domain.Entities.Activities.History;

public class WatchingHistory : BaseEntity
{
    public int ProgressSeconds { get; set; }
    public bool IsCompleted { get; set; } = false;
    public DateTime LastWatchedAt { get; set; }

    public bool IsValid => MovieId.HasValue != EpisodeId.HasValue;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int? MovieId { get; set; }
    public Movie? Movie { get; set; }

    public int? EpisodeId { get; set; }
    public Episode? Episode { get; set; }

    public int? LastAudioLanguageId { get; set; }
    public Language? LastAudioLanguage { get; set; }

    public int? LastSubtitleLanguageId { get; set; }
    public Language? LastSubtitleLanguage { get; set; }
}
