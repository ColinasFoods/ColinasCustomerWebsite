namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_PR_WorkOrders_Workers
    {
        [Key]
        public int WorkOrderPeopleID { get; set; }

        public int? WorkOrderID { get; set; }

        public int EmployeeNo { get; set; }

        public int? PersonalID { get; set; }
    }
}
