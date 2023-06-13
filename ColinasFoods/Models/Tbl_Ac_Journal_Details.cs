namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_Journal_Details
    {
        [Key]
        public int JournalDetailsID { get; set; }

        public int JournalID { get; set; }

        public int Item { get; set; }

        [StringLength(13)]
        public string Account { get; set; }

        [StringLength(250)]
        public string AccountDesc { get; set; }

        [StringLength(250)]
        public string Concept { get; set; }

        [Column(TypeName = "money")]
        public decimal Charge { get; set; }

        [Column(TypeName = "money")]
        public decimal Credit { get; set; }

        public virtual Tbl_Ac_Journal Tbl_Ac_Journal { get; set; }
    }
}
