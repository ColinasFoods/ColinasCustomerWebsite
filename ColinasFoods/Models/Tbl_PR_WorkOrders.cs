namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_PR_WorkOrders
    {
        [Key]
        public int WorkOrderID { get; set; }

        public int WONo { get; set; }

        public DateTime? WODate { get; set; }

        public int WOMadeBy { get; set; }

        [StringLength(100)]
        public string WODescription { get; set; }

        public DateTime? WOStartTime { get; set; }

        public DateTime? WOFinishTime { get; set; }

        [StringLength(50)]
        public string WOLocation { get; set; }

        public float WeightIN { get; set; }

        public float WeightOUT { get; set; }

        public int WarehouseID { get; set; }

        public bool WOClosed { get; set; }

        public DateTime? WOClosedDate { get; set; }

        public int WOClosedBy { get; set; }
    }
}
