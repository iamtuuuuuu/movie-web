namespace Movie_Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
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
    }
}
