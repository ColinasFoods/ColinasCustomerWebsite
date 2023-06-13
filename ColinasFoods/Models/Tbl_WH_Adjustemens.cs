namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Adjustemens
    {
        [Key]
        public int AdjFolioID { get; set; }

        public int AdjFolio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AdjDate { get; set; }

        public int MadeBy { get; set; }

        [StringLength(250)]
        public string AdjDescription { get; set; }

        public int WarehouseID { get; set; }

        public DateTime? AdjPrintDate { get; set; }
    }
}
