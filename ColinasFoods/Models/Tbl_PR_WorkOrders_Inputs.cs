namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_PR_WorkOrders_Inputs
    {
        [Key]
        public int WorkOrderInputsID { get; set; }

        public int WorkOrderID { get; set; }

        public int ItemNo { get; set; }

        public int MaterialID { get; set; }

        [StringLength(50)]
        public string PartNo { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public float Quantity { get; set; }

        [StringLength(50)]
        public string UM { get; set; }

        [StringLength(50)]
        public string ERBarcode { get; set; }

        public int LabelID { get; set; }
    }
}
