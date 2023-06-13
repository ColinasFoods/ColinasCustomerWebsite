namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_SalesOrder
    {
        [Key]
        public int SalesOrderID { get; set; }

        public int SalesOrderNo { get; set; }

        public int CustomerID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateIssued { get; set; }

        public int DeliveryTermsID { get; set; }

        public DateTime? ShipDate { get; set; }

        [StringLength(15)]
        public string CustomerPO { get; set; }

        [StringLength(150)]
        public string CustomerContactName { get; set; }

        [Required]
        [StringLength(150)]
        public string CustomerName { get; set; }

        [StringLength(16)]
        public string CustomerTaxID { get; set; }

        [StringLength(255)]
        public string CustomerAddress1 { get; set; }

        [StringLength(10)]
        public string CustomerAddress2 { get; set; }

        [StringLength(255)]
        public string CustomerCounty { get; set; }

        [StringLength(70)]
        public string CustomerCity { get; set; }

        [StringLength(50)]
        public string CustomerState { get; set; }

        [StringLength(100)]
        public string CustomerCountry { get; set; }

        [StringLength(5)]
        public string CustomerZipcode { get; set; }

        [StringLength(150)]
        public string ShipTo { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(10)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToCounty { get; set; }

        [StringLength(70)]
        public string ShipToCity { get; set; }

        [StringLength(50)]
        public string ShipToState { get; set; }

        [StringLength(100)]
        public string ShipToCountry { get; set; }

        [StringLength(5)]
        public string ShipToZipcode { get; set; }

        public int ShipToRouteNo { get; set; }

        public int SalesmanID { get; set; }

        public int PaymentTermsID { get; set; }

        public int IncotermsID { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        public bool IsRelease { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ReleaseDate { get; set; }

        public int MadeBy { get; set; }

        public bool SalesOrderClosed { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ClosedDate { get; set; }

        public int ClosedBy { get; set; }

        [StringLength(255)]
        public string ClosedNotes { get; set; }

        [Column(TypeName = "money")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        public bool Cancel { get; set; }

        [StringLength(250)]
        public string CancelReason { get; set; }

        public DateTime? CancelDate { get; set; }

        public int CancelBy { get; set; }

        [StringLength(200)]
        public string ShipViaNote { get; set; }

        public float PerCC { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCC { get; set; }

        [StringLength(50)]
        public string StatusSh { get; set; }

        [StringLength(50)]
        public string StatusBi { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalBill { get; set; }
    }
}
