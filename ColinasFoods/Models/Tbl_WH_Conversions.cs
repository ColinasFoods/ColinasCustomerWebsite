namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Conversions
    {
        [Key]
        public int ConversionID { get; set; }

        public int? ConversionNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ConversionDate { get; set; }

        public int? MadeBy { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PrintDate { get; set; }

        public int? WarehouseID { get; set; }
    }
}
