namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_PaymentTerms
    {
        [Key]
        public int PaymentTermsID { get; set; }

        [StringLength(50)]
        public string PTDescription { get; set; }

        public int DaysDue { get; set; }

        public int DaysDiscount { get; set; }

        public float PorDiscount { get; set; }
    }
}
