using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Series;
using MovieHub.Domain.Entities.Features;

public class EpisodePlayer : BaseEntity
{
    public string Url { get; set; } = string.Empty;
    public VideoQuality Quality { get; set; } = VideoQuality.FullHD;
    public bool IsDefault { get; set; } = false;
    public int EpisodeId { get; set; }
    public int LanguageId { get; set; }
    public Episode Episode { get; set; } = null!;
    public Language Language { get; set; } = null!;
}