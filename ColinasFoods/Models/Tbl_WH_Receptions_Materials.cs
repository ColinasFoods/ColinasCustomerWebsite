namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Receptions_Materials
    {
        [Key]
        public int ReceptionDetailsID { get; set; }

        public int ReceptionID { get; set; }

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

        public int PurchaseOrder { get; set; }

        public int POID { get; set; }

        public int POMaterialsID { get; set; }

        [Required]
        [StringLength(10)]
        public string UM { get; set; }

        public bool IsTaxable { get; set; }
    }
}
