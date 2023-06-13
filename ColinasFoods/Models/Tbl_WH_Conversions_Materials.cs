namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Conversions_Materials
    {
        [Key]
        public int ConversionDetailsID { get; set; }

        public int ConversionID { get; set; }

        public int ItemNo { get; set; }

        public int MaterialID { get; set; }

        [Required]
        [StringLength(100)]
        public string PartNo { get; set; }

        [Required]
        [StringLength(200)]
        public string MaterialDescription { get; set; }

        public float Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal ExtendedPrice { get; set; }

        [Required]
        [StringLength(10)]
        public string UM { get; set; }
    }
}
