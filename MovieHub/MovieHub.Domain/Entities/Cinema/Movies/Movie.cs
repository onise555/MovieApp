using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Activities.History;
using MovieHub.Domain.Entities.Features;
using MovieHub.Domain.Entities.System;

namespace MovieHub.Domain.Entities.Cinema.Movies;

public class Movie : AuditableEntity, ISoftDelete
{
    public string Title { get; set; } = string.Empty;
    public string CoverImg { get; set; } = string.Empty;
    public string? BackdropImg { get; set; }
    public double Rating { get; set; }
    public int ReleaseYear { get; set; }
    public ContentStatus Status { get; set; } = ContentStatus.Released;
    public MovieType Type { get; set; } = MovieType.Movie;
    public AgeRating AgeRating { get; set; } = AgeRating.PG;
    public bool IsFeatured { get; set; } = false;
    public bool IsTrending { get; set; } = false;
    public bool IsPremium { get; set; } = false;
    public int ViewCount { get; set; } = 0;
    public double PopularityScore { get; private set; } = 0;
    public string? ImdbId { get; set; }
    public int? TmdbId { get; set; }
    public int? SequelId { get; set; }
    public int? PrequelId { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }

    public Movie? Sequel { get; set; }
    public Movie? Prequel { get; set; }

    public MovieDetail Detail { get; set; } = null!;
    public List<UserListItem> UserListItems { get; set; }= new List<UserListItem>(); 
    public List<Review> Reviews { get; set; } = [];
    public List<WatchingHistory> WatchingHistories { get; set; } = new List<WatchingHistory>();
    public List<ContentReport> Reports { get; set; } = new List<ContentReport>();
    public List<Actor> Actors { get; set; } = new List<Actor>  ();
    public List<Genre> Genres { get; set; } = new List<Genre>();
    public List<Country> Countries { get; set; } = new List<Country>();
    public List<ContentTag> Tags { get; set; } = new List<ContentTag>();
    public  List<Notification> Notifications { get; set; } = new List<Notification>();

    private const double ViewWeight = 0.4;
    private const double RatingWeight = 0.4;
    private const double RecentWeight = 0.2;

    public void UpdatePopularity(int recentViews) =>
        PopularityScore = ViewCount * ViewWeight + Rating * RatingWeight + recentViews * RecentWeight;
}
