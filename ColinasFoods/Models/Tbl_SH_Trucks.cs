namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SH_Trucks
    {
        [Key]
        public int TruckID { get; set; }

        [StringLength(10)]
        public string TruckPlates { get; set; }

        [StringLength(50)]
        public string TruckDescription { get; set; }

        public int DriverID { get; set; }

        [StringLength(80)]
        public string DriverName { get; set; }
    }
}
