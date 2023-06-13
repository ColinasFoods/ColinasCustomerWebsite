namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SH_Packing_Details
    {
        [Key]
        public int PackingDetailsID { get; set; }

        public int PackingID { get; set; }

        public int ItemNo { get; set; }

        public int MaterialID { get; set; }

        [StringLength(50)]
        public string PartNo { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public float Quantity { get; set; }

        [StringLength(50)]
        public string UofM { get; set; }

        public int SalesOrderNo { get; set; }

        public int SalesOrderID { get; set; }

        public int SalesOrderDetailID { get; set; }

        [StringLength(50)]
        public string ERBarcode { get; set; }

        public DateTime? DTScan { get; set; }

        public int DTScanBy { get; set; }
    }
}
