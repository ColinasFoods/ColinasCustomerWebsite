namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_SalesOrder_Details
    {
        [Key]
        public int SalesOrderDetailID { get; set; }

        public int SalesOrderID { get; set; }

        public int ItemNo { get; set; }

        public int MaterialID { get; set; }

        [StringLength(50)]
        public string PartNo { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int QuantityCs { get; set; }

        public float Quantity { get; set; }

        public float QuantityShip { get; set; }

        public float QuantityShipWeight { get; set; }

        public float QuantityBalance { get; set; }

        public float QuantityBill { get; set; }

        public float QuantityXBill { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPriceList { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        public bool IsTaxable { get; set; }

        [StringLength(50)]
        public string UofM { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitCost { get; set; }

        public float Margin { get; set; }

        public float QtyOnHand { get; set; }

        public float TaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal RealCost { get; set; }

        [Column(TypeName = "money")]
        public decimal RealMargin { get; set; }

        public bool CancelBO { get; set; }

        public int CancelBOBy { get; set; }

        public DateTime? CancelBODate { get; set; }

        public int ShPriority { get; set; }
    }
}
