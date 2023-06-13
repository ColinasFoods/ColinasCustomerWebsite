namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Materials_Convertions
    {
        [Key]
        public int MatConversionID { get; set; }

        public int MaterialID1 { get; set; }

        public float Qty1 { get; set; }

        public int MaterialID2 { get; set; }

        public float Qty2 { get; set; }
    }
}
