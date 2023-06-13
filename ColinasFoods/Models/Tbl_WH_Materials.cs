namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Materials
    {
        [Key]
        public int MaterialID { get; set; }

        [StringLength(100)]
        public string PartNo { get; set; }

        public int? FamilyID { get; set; }

        [StringLength(100)]
        public string MaterialShortDesc { get; set; }

        [StringLength(200)]
        public string MaterialDescription { get; set; }

        [StringLength(50)]
        public string Barcode { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string SalesTaxCode { get; set; }

        [StringLength(50)]
        public string SalesAccount { get; set; }

        [StringLength(200)]
        public string SalesAccountDescription { get; set; }

        [StringLength(50)]
        public string COGSAccount { get; set; }

        [StringLength(200)]
        public string COGSAccountDescription { get; set; }

        [StringLength(50)]
        public string AssetAccount { get; set; }

        [StringLength(200)]
        public string AssetAccountDescription { get; set; }

        [StringLength(200)]
        public string PurchaseDescription { get; set; }

        [StringLength(10)]
        public string UM { get; set; }

        [StringLength(20)]
        public string UMVendor { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastCost { get; set; }

        public float? BOMCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCost { get; set; }

        public int? PreferredVendorID { get; set; }

        [StringLength(100)]
        public string TaxAgency { get; set; }

        public float? Price { get; set; }

        public float? ReorderPoint { get; set; }

        public float? MaxPoint { get; set; }

        [StringLength(200)]
        public string MPN { get; set; }

        public float FactorForOpen { get; set; }

        [StringLength(20)]
        public string EANBarcode { get; set; }

        public float Weight { get; set; }

        public bool Inactive { get; set; }

        [Column(TypeName = "money")]
        public decimal RealLastCost { get; set; }

        [Column(TypeName = "money")]
        public decimal ActualAvgCost { get; set; }

        public float SalesAvgL3Month { get; set; }

        public int LabelNo { get; set; }

        [StringLength(50)]
        public string LabelDescription { get; set; }

        [StringLength(250)]
        public string LabelContent { get; set; }

        public int TaxGroup { get; set; }

        public int SalesMin { get; set; }

        public int SalesMultiple { get; set; }

        public bool PItem { get; set; }

        public int ItemID { get; set; }
    }
}
