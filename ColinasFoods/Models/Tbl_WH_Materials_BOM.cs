namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Materials_BOM
    {
        [Key]
        public int MaterialBOMID { get; set; }

        public int MaterialID { get; set; }

        public int MaterialComponentID { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemNo { get; set; }

        [StringLength(200)]
        public string MaterialDescription { get; set; }

        public float Quantity { get; set; }
    }
}
