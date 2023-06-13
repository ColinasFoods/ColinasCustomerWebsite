namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_Journal_AR
    {
        [Key]
        public int JournalARID { get; set; }

        public int JournalID { get; set; }

        public int PaymentAplicationID { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        public int OrderNo { get; set; }

        public virtual Tbl_Ac_Journal Tbl_Ac_Journal { get; set; }
    }
}
