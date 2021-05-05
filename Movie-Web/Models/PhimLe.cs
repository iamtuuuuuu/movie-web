using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Web.Models
{
    public class PhimLe
    {
        public string filmID { get; set; }

        public string nameFilm { get; set; }

        public string nameEngFilm { get; set; }

        public string linkImgAvt { get; set; }

        public string linkImgDes { get; set; }

        public string linkBgImage { get; set; }

        public string linkTrailer { get; set; }

        public string desText { get; set; }

        public string contentText { get; set; }

        public DateTime? releaseFilm { get; set; }

        public string statusText { get; set; }

        public int? releasedEpisodes { get; set; }

        public int? totalEpisodes { get; set; }

        public double? imdb { get; set; }

        public string quality { get; set; }

        public string star { get; set; }

        public string nation { get; set; }

        public string actor { get; set; }

        public string director { get; set; }

        public string genre { get; set; }

        public DateTime? createDate { get; set; }
        public string createBy { get; set; }

        public string filmEpID { get; set; }

        public int? Episode { get; set; }

        public string linkEpisode { get; set; }
    }
}