namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_PaymentsApplications_Details
    {
        [Key]
        public int PaymentReceivedID { get; set; }

        public int PaymentAplicationID { get; set; }

        public int InvoiceID { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public DateTime? PaymentTran { get; set; }
    }
}
