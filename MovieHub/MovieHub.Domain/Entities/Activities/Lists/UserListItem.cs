using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Cinema.Series;

public class UserListItem : AuditableEntity, ISoftDelete
{
    public int UserListId { get; set; }
    public int? MovieId { get; set; }
    public int? SeriesId { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }

    public bool IsValid => MovieId.HasValue != SeriesId.HasValue;

    public UserList UserList { get; set; } = null!;
    public Movie? Movie { get; set; }
    public Serie? Series { get; set; }
}
