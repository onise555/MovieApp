using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Medias.SerieMedia;

namespace MovieHub.Domain.Entities.Cinema.Series;

public class SeriesDetail : BaseEntity
{
    public string Description { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public int AvgEpisodeMinutes { get; set; }
    public string? TrailerYoutubeKey { get; set; }

    public int SeriesId { get; set; }
    public Serie Series { get; set; } = null!;

    public List<SeriesTrailer> Trailers { get; set; } = new List<SeriesTrailer>();
}
