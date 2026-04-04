using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Features;

public class MovieSubtitle : BaseEntity
{
    public string Url { get; set; } = string.Empty;
    public bool IsDefault { get; set; } = false;
    public int MovieDetailId { get; set; }
    public int LanguageId { get; set; }
    public MovieDetail MovieDetail { get; set; } = null!;
    public Language Language { get; set; } = null!;
}
