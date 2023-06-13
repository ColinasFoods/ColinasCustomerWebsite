namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SH_Packing
    {
        [Key]
        public int PackingID { get; set; }

        public int PackingNo { get; set; }

        public DateTime? PackingDate { get; set; }

        public int CustomerID { get; set; }

        public int MadeBy { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        public int WarehouseID { get; set; }

        [StringLength(50)]
        public string DriverName { get; set; }

        [StringLength(50)]
        public string Truck { get; set; }

        [StringLength(10)]
        public string TruckPlates { get; set; }

        public int LaneNo { get; set; }

        public DateTime? LoadStartTime { get; set; }

        public DateTime? LoadFinishTime { get; set; }

        public int SalesOrderNo { get; set; }

        public int SalesOrderID { get; set; }

        public int DeliveryTermsID { get; set; }
    }
}
