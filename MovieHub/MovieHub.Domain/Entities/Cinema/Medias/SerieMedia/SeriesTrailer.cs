using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Features;

public class SeriesTrailer : BaseEntity
{
    public string Url { get; set; } = string.Empty;
    public VideoQuality Quality { get; set; } = VideoQuality.FullHD;
    public bool IsDefault { get; set; } = false;
    public int SeriesDetailId { get; set; }
    public int LanguageId { get; set; }
    public SeriesDetail SeriesDetail { get; set; } = null!;
    public Language Language { get; set; } = null!;
}
