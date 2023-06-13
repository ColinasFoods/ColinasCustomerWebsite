namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Materials_WH
    {
        [Key]
        public int StockID { get; set; }

        public int MaterialID { get; set; }

        public int WarehouseID { get; set; }

        public float TransitPO { get; set; }

        public float BackOrder { get; set; }

        public float InputsPr { get; set; }

        public float InputsReceptions { get; set; }

        public float InputsReturns { get; set; }

        public float OutputsSh { get; set; }

        public float OutputsPr { get; set; }

        public float Conversions { get; set; }

        public float Adjustments { get; set; }

        public float ActualStock { get; set; }

        public float StockAvailable { get; set; }

        public float StockVirtual { get; set; }
    }
}
