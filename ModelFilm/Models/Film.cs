namespace ModelFilm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            Feedbacks = new HashSet<Feedback>();
            FilmEpisodes = new HashSet<FilmEpisode>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmEpisode> FilmEpisodes { get; set; }
    }
}
