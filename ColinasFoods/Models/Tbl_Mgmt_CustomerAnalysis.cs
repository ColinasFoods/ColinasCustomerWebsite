namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Mgmt_CustomerAnalysis
    {
        [Key]
        public int CustomerAnalysisID { get; set; }

        public int? CustomerID { get; set; }

        public int? YearPr { get; set; }

        public int? MonthPr { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bill { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillLY { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillLM { get; set; }

        public float? YrToYr { get; set; }

        public float? MoToMo { get; set; }

        public float? MoShare { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillToDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillToDateLY { get; set; }

        public float? YrShare { get; set; }

        public float? YrAcumToYrAcum { get; set; }
    }
}
