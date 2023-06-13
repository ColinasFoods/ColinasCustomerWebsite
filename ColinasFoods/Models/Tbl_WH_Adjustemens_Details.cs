namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Adjustemens_Details
    {
        [Key]
        public int AdjFolioDetailsID { get; set; }

        public int AdjFolioID { get; set; }

        public int ItemNo { get; set; }

        public int MaterialID { get; set; }

        [StringLength(50)]
        public string PartNo { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public float Quantity { get; set; }

        public float ActualInv { get; set; }

        public float FinalInv { get; set; }

        [StringLength(50)]
        public string UM { get; set; }

        [StringLength(50)]
        public string ERBarcode { get; set; }

        [Column(TypeName = "money")]
        public decimal RealCost { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCost { get; set; }
    }
}
