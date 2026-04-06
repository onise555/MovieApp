using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Series;
using MovieHub.Domain.Entities.Features;
using MovieHub.Domain.Enums.Cinema;

namespace MovieHub.Domain.Entities.Cinema.Medias.SerieMedia;

public class SeriesTrailer : BaseEntity
{
    public string Url { get; set; } = string.Empty;
    public VideoQuality Quality { get; set; } = VideoQuality.FullHD;
    public bool IsDefault { get; set; } = false;


    public int SeriesDetailId { get; set; }
    public SeriesDetail SeriesDetail { get; set; } = null!;

    public int LanguageId { get; set; }
    public Language Language { get; set; } = null!;
}
