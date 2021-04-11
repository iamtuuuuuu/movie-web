namespace Movie_Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        [StringLength(10)]
        public string feedbackID { get; set; }

        [StringLength(10)]
        public string filmID { get; set; }

        [StringLength(10)]
        public string accountID { get; set; }

        [StringLength(2000)]
        public string cmt { get; set; }

        public DateTime? sentDate { get; set; }

        public virtual Account Account { get; set; }

        public virtual Film Film { get; set; }
    }
}
