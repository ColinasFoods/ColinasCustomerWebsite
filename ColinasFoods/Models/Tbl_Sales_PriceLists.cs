namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_PriceLists
    {
        [Key]
        public int PriceListID { get; set; }

        public int PriceListNo { get; set; }

        [StringLength(100)]
        public string PriceListDescription { get; set; }
    }
}
