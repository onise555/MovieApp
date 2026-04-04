using MovieHub.Domain.Common;
using MovieHub.Domain.Entities.Cinema.Movies;
using MovieHub.Domain.Entities.Cinema.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Features
{
    public class Actor:BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Biography { get; set; }
        public string? PhotoUrl { get; set; }
        public DateTime? BirthDate { get; set; }


        public List<Movie> Movies { get; set; } =  new List<Movie>();
        public List<Serie> Series { get; set; } = new List<Serie>();

    }
}
