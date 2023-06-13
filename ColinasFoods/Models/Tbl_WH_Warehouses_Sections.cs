namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Warehouses_Sections
    {
        [Key]
        public int SectionID { get; set; }

        public int? WarehouseID { get; set; }

        [StringLength(5)]
        public string SectionCode { get; set; }

        [StringLength(50)]
        public string SectionDescription { get; set; }
    }
}
