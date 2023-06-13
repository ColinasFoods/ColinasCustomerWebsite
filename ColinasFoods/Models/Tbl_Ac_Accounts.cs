namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_Accounts
    {
        [Key]
        public int AccountID { get; set; }

        [StringLength(13)]
        public string Account { get; set; }

        [StringLength(250)]
        public string AccountDesc { get; set; }

        public byte Nivel { get; set; }

        public byte Tipo { get; set; }

        [StringLength(1)]
        public string DoA { get; set; }
    }
}
