namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Receptions
    {
        [Key]
        public int ReceptionID { get; set; }

        public int ReceptionNo { get; set; }

        public int VendorID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ReceptionDate { get; set; }

        public int PurchaseOrder { get; set; }

        public int POID { get; set; }

        public int DocumentType { get; set; }

        [StringLength(15)]
        public string VendorDocument { get; set; }

        public int MadeBy { get; set; }

        [StringLength(50)]
        public string OtherCostsDesc { get; set; }

        [Column(TypeName = "money")]
        public decimal OtherCost { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        public DateTime? PrintDate { get; set; }

        public int WarehouseID { get; set; }

        [StringLength(50)]
        public string DriverName { get; set; }

        [StringLength(50)]
        public string Truck { get; set; }

        [StringLength(10)]
        public string TruckPlates { get; set; }

        public int CreditDays { get; set; }

        public DateTime? PaymentDate { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAP { get; set; }
    }
}
