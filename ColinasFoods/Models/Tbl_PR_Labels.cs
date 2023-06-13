namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_PR_Labels
    {
        [Key]
        public int LabelID { get; set; }

        [StringLength(50)]
        public string ERBarcode { get; set; }

        public DateTime? GenDate { get; set; }

        public int WarehouseID { get; set; }

        public int MadeBy { get; set; }

        public int MaterialID { get; set; }

        [StringLength(100)]
        public string PartNo { get; set; }

        public float Quantity { get; set; }

        [StringLength(200)]
        public string MaterialDescription { get; set; }

        [StringLength(10)]
        public string UM { get; set; }

        public int WorkOrderID { get; set; }

        public int ReceptionDetailsID { get; set; }

        public int InStockValue { get; set; }
    }
}
