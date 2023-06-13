namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Materials_Subs
    {
        [Key]
        public int OptMaterialSubID { get; set; }

        public int MaterialID { get; set; }

        public int MaterialSubID { get; set; }

        public int ItemNo { get; set; }

        [StringLength(50)]
        public string PartNo { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
