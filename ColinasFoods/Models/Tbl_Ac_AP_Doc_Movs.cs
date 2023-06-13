namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_AP_Doc_Movs
    {
        [Key]
        public int APMovDetailsID { get; set; }

        public int AccountsPayableDetailsID { get; set; }

        public int POID { get; set; }

        public int PONo { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAP { get; set; }

        [StringLength(200)]
        public string APMComments { get; set; }

        public int ReceptionNo { get; set; }

        public int RecepcionID { get; set; }

        public virtual Tbl_Ac_AP_Doc Tbl_Ac_AP_Doc { get; set; }
    }
}
