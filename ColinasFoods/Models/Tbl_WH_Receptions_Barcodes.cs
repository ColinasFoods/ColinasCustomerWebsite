namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Receptions_Barcodes
    {
        [Key]
        public int ReceptionBarcodeID { get; set; }

        public int ReceptionID { get; set; }

        [StringLength(50)]
        public string Barcode { get; set; }

        public float Weight { get; set; }
    }
}
