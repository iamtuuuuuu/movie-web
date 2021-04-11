namespace Movie_Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [StringLength(10)]
        public string filmID { get; set; }

        [StringLength(100)]
        public string nameFilm { get; set; }

        [StringLength(100)]
        public string nameEngFilm { get; set; }

        [StringLength(500)]
        public string linkImgAvt { get; set; }

        [StringLength(500)]
        public string linkImgDes { get; set; }

        [StringLength(500)]
        public string linkBgImage { get; set; }

        [StringLength(500)]
        public string linkTrailer { get; set; }

        [StringLength(500)]
        public string desText { get; set; }

        [StringLength(2000)]
        public string contentText { get; set; }

        public DateTime? releaseFilm { get; set; }

        [StringLength(500)]
        public string statusText { get; set; }

        public int? releasedEpisodes { get; set; }

        public int? totalEpisodes { get; set; }

        public double? imdb { get; set; }

        [StringLength(100)]
        public string quality { get; set; }

        [StringLength(10)]
        public string star { get; set; }

        [StringLength(500)]
        public string nation { get; set; }

        [StringLength(500)]
        public string actor { get; set; }

        [StringLength(500)]
        public string director { get; set; }

        [StringLength(500)]
        public string genre { get; set; }

        public DateTime? createDate { get; set; }

        [StringLength(100)]
        public string createBy { get; set; }
    }
}
