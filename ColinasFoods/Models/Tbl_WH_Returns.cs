namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Returns
    {
        [Key]
        public int ReturnID { get; set; }

        public int? ReturnNo { get; set; }

        public int? CustomerID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }

        public int? InvoiceNo { get; set; }

        public int? InvoiceID { get; set; }

        public int? MadeBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PrintDate { get; set; }

        public int? WarehouseID { get; set; }

        [StringLength(50)]
        public string DriverName { get; set; }

        [StringLength(50)]
        public string Truck { get; set; }

        [StringLength(10)]
        public string TruckPlates { get; set; }

        public DateTime? LoadStartTime { get; set; }

        public DateTime? LoadFinishTime { get; set; }
    }
}
