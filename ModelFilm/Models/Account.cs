namespace ModelFilm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        [StringLength(10)]
        public string accountID { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(100)]
        public string passwordAcc { get; set; }

        public bool? roleAcc { get; set; }

        [StringLength(100)]
        public string username { get; set; }

        [StringLength(100)]
        public string avartar { get; set; }

        public DateTime? createDate { get; set; }

        [StringLength(100)]
        public string createBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
