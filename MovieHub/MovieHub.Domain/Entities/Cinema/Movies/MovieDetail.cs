using MovieHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Cinema.Movies
{
    internal class MovieDetail:BaseEntity
    {

        public string Description { get; set; }
        public string Director { get; set; }

        public int Duration { get; set; }

        // ...
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
