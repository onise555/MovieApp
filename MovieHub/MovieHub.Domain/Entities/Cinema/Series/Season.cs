using MovieHub.Domain.Common;

namespace MovieHub.Domain.Entities.Cinema.Series;

public class Season : AuditableEntity, ISoftDelete
{
    public int SeasonNumber { get; set; }
    public string? Title { get; set; }
    public string? CoverImg { get; set; }
    public int ReleaseYear { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }


    public int SeriesId { get; set; }
    public Serie Series { get; set; } = null!;

    public List<Episode> Episodes { get; set; } = new List<Episode>();
}
