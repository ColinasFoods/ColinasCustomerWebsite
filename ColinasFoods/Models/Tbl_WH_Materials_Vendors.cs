namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Materials_Vendors
    {
        [Key]
        public int MatVendorID { get; set; }

        public int MaterialID { get; set; }

        public int VendorID { get; set; }

        [StringLength(50)]
        public string UPCCode { get; set; }
    }
}
