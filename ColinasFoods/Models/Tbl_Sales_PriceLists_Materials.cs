namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_PriceLists_Materials
    {
        [Key]
        public int PriceListMaterialID { get; set; }

        public int PriceListID { get; set; }

        public int MaterialID { get; set; }

        [Required]
        [StringLength(100)]
        public string PartNo { get; set; }

        [StringLength(200)]
        public string MaterialDescription { get; set; }

        [StringLength(10)]
        public string UM { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
