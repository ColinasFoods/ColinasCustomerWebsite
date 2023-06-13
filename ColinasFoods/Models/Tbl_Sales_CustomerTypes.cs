namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_CustomerTypes
    {
        [Key]
        [StringLength(15)]
        public string CustomerType { get; set; }

        public int TaxGroup { get; set; }
    }
}
