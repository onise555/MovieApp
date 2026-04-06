using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Activities.History;
using MovieHub.Domain.Entities.Cinema.Medias.SerieMedia;

namespace MovieHub.Domain.Entities.Cinema.Series;

public class Episode : AuditableEntity, ISoftDelete
{
    public int EpisodeNumber { get; set; }
    public string EpisodeName { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public string? ThumbnailUrl { get; set; }
    public string? Description { get; set; }
    public DateTime? AirDate { get; set; }
    public bool IsFillerEpisode { get; set; } = false;
    public string? ArcName { get; set; }
    public int? IntroStartSeconds { get; set; }
    public int? IntroEndSeconds { get; set; }
    public int? OutroStartSeconds { get; set; }
    public int? OutroEndSeconds { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }


    public int? NextEpisodeId { get; set; }
    public Episode? NextEpisode { get; set; }

    public int SeasonId { get; set; }
    public Season Season { get; set; } = null!;

    public List<EpisodePlayer> Players { get; set; } = new List<EpisodePlayer>();
    public List<EpisodeSubtitle> Subtitles { get; set; } = new List<EpisodeSubtitle>();
    public List<WatchingHistory> WatchingHistories { get; set; } = new List<WatchingHistory>();
}
