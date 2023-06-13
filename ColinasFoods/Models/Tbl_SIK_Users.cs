namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SIK_Users
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(8)]
        public string UserName { get; set; }

        [Required]
        [StringLength(8)]
        public string Password { get; set; }

        public int? PersonalID { get; set; }

        public byte? AccesoTotal { get; set; }

        public int? ProfileNo { get; set; }

        [StringLength(10)]
        public string BackgroundColor { get; set; }

        public int? NIP { get; set; }

        public virtual Tbl_SIK_Users Tbl_SIK_Users1 { get; set; }

        public virtual Tbl_SIK_Users Tbl_SIK_Users2 { get; set; }

        public virtual Tbl_SIK_Users Tbl_SIK_Users11 { get; set; }

        public virtual Tbl_SIK_Users Tbl_SIK_Users3 { get; set; }
    }
}
