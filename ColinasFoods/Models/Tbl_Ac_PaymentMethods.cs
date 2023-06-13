namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_PaymentMethods
    {
        [Key]
        public int PaymentMethodID { get; set; }

        [Required]
        [StringLength(3)]
        public string PaymentMethodCode { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentMethodDesc { get; set; }
    }
}
