using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Medias.MovieMedia;

namespace MovieHub.Domain.Entities.Cinema.Movies;

public class MovieDetail : BaseEntity
{
    public string Description { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public string? TrailerYoutubeKey { get; set; }

    public int MovieId { get; set; }
    public Movie Movie { get; set; } = null!;
    public List<MoviePlayer> Players { get; set; } = new List<MoviePlayer>();
    public List<MovieTrailer> Trailers { get; set; } = new List<MovieTrailer>();
    public List<MovieSubtitle> Subtitles { get; set; } = new List<MovieSubtitle>();
}
