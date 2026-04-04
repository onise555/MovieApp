using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Cinema.Series;

namespace MovieHub.Domain.Entities.Features;

public class ContentTag : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public bool IsMood { get; set; } = false;

    public List<Movie> Movies { get; set; } =  new List<Movie>();
    public List<Serie> Series { get; set; } = new List<Serie>();
}
