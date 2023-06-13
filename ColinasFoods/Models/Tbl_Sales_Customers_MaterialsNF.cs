namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_Customers_MaterialsNF
    {
        [Key]
        public int CustomerNFItemsID { get; set; }

        public int CustomerID { get; set; }

        public int MaterialID { get; set; }

        public DateTime? DateFlag { get; set; }

        public int FlagBy { get; set; }

        [StringLength(200)]
        public string FlagNote { get; set; }
    }
}
