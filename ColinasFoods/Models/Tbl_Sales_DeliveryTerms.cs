namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_DeliveryTerms
    {
        [Key]
        public int DeliveryTermsID { get; set; }

        [StringLength(50)]
        public string DeliveryTermsDesc { get; set; }
    }
}
