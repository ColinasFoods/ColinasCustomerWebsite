namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_Invoice_Details
    {
        [Key]
        public int InvoiceDetailsID { get; set; }

        public int InvoiceID { get; set; }

        public int ItemNo { get; set; }

        public int? MaterialID { get; set; }

        [StringLength(50)]
        public string PartNo { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int QuantityCount { get; set; }

        public float Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public bool IsTaxable { get; set; }

        [StringLength(50)]
        public string UofM { get; set; }

        public int SalesOrderNo { get; set; }

        public int SalesOrderID { get; set; }

        public int SalesOrderDetailID { get; set; }

        public int PackingNo { get; set; }

        public int PackingID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitCost { get; set; }

        public float Margin { get; set; }

        public float TaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal RealCost { get; set; }

        [Column(TypeName = "money")]
        public decimal RealMargin { get; set; }

        public virtual Tbl_Ac_Invoice Tbl_Ac_Invoice { get; set; }
    }
}
