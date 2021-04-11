namespace ModelFilm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmEpisode")]
    public partial class FilmEpisode
    {
        [Key]
        [StringLength(10)]
        public string filmEpID { get; set; }

        [StringLength(10)]
        public string filmID { get; set; }

        public int? Episode { get; set; }

        [StringLength(500)]
        public string linkEpisode { get; set; }

        public virtual Film Film { get; set; }
    }
}
