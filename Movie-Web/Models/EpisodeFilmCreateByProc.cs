using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Web.Models
{
    public class EpisodeFilmCreateByProc
    {
        public string filmID { get; set; }
        public string nameFilm { get; set; }
        public string nameEngFilm { get; set; }
        public string contentText { get; set; }
        public string linkBgImage { get; set; }
        public int releasedEpisodes { get; set; }
        public int totalEpisodes { get; set; }
        public int Episode { get; set; }
        public string linkEpisode { get; set; }
    }
}