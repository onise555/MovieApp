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
    public class Country:BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? IsoCode { get; set; }

        public List<Movie> Movies { get; set; } = new List<Movie> ();
        public List<Serie> Series { get; set; } =  new List<Serie> ();
    }
}
