namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Materials_UM
    {
        [Key]
        [StringLength(10)]
        public string UM { get; set; }

        [StringLength(50)]
        public string UMDescrption { get; set; }
    }
}
