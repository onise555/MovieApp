using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Cinema.Series;

namespace MovieHub.Domain.Entities.Activities.Lists;

public class UserListItem : AuditableEntity, ISoftDelete
{

    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }

    public bool IsValid => MovieId.HasValue != SeriesId.HasValue;





    public int UserListId { get; set; }
    public UserList UserList { get; set; } = null!;

    public int? MovieId { get; set; }
    public Movie? Movie { get; set; }

    public int? SeriesId { get; set; }
    public Serie? Series { get; set; }
}
