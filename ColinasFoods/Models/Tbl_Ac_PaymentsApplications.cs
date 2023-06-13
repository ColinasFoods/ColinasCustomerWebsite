namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_PaymentsApplications
    {
        [Key]
        public int PaymentAplicationID { get; set; }

        public int PaymentNo { get; set; }

        public DateTime? PaymentDate { get; set; }

        public int PaymentCustomerID { get; set; }

        public int PaymentMethodID { get; set; }

        [StringLength(50)]
        public string PaymentMethodDetails { get; set; }

        public int PaymentMadeBy { get; set; }

        [StringLength(200)]
        public string PaymentNotes { get; set; }

        [Column(TypeName = "money")]
        public decimal PaymentTotal { get; set; }

        public int PaymentRegisterNo { get; set; }
    }
}
