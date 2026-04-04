using MovieHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Features
{
    public class Language:BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;


        public List<MoviePlayer> MoviePlayers { get; set; } = new List<MoviePlayer>();
        public List<MovieTrailer> MovieTrailers { get; set; } = new List<MovieTrailer> ();
        public List<MovieSubtitle> MovieSubtitles { get; set; } = new List<MovieSubtitle>();
        public List<SeriesTrailer> SeriesTrailers { get; set; } = new List<SeriesTrailer>();
        public List<EpisodePlayer> EpisodePlayers { get; set; } = new List<EpisodePlayer>();
        public List<EpisodeSubtitle> EpisodeSubtitles { get; set; } = new List<EpisodeSubtitle>();
    }
}
