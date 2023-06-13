namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Warehouses
    {
        [Key]
        public int WarehouseID { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseDescription { get; set; }
    }
}
