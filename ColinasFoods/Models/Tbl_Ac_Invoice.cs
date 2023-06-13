namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Ac_Invoice()
        {
            Tbl_Ac_Invoice_Details = new HashSet<Tbl_Ac_Invoice_Details>();
        }

        [Key]
        public int InvoiceID { get; set; }

        public int InvoiceNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? InvoicePDueDate { get; set; }

        public DateTime? ShipDate { get; set; }

        [StringLength(15)]
        public string CustomerPO { get; set; }

        [StringLength(150)]
        public string CustomerContactName { get; set; }

        public int CustomerID { get; set; }

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

        public int PaymentTermsID { get; set; }

        [Column(TypeName = "money")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal Taxes { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeCC { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        [Column(TypeName = "money")]
        public decimal Paid { get; set; }

        [Column(TypeName = "money")]
        public decimal Credits { get; set; }

        [Column(TypeName = "money")]
        public decimal Charges { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public int MadeBy { get; set; }

        [StringLength(200)]
        public string Comments { get; set; }

        public DateTime? PrintDate { get; set; }

        public int SalesmanID { get; set; }

        public bool Cancelled { get; set; }

        public DateTime? CancelledDate { get; set; }

        public int CancelledBy { get; set; }

        [StringLength(250)]
        public string CancelledComments { get; set; }

        public bool CCUsed { get; set; }

        public float PerCC { get; set; }

        [Column(TypeName = "money")]
        public decimal CCCharge { get; set; }

        public int DeliveryTermsID { get; set; }

        [StringLength(200)]
        public string ShipViaNote { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCC { get; set; }

        public int PackingID { get; set; }

        public int PackingNo { get; set; }

        [StringLength(50)]
        public string DocumentType { get; set; }

        public int CMInvoiceRef { get; set; }

        public int CMReturnNo { get; set; }

        public int CMInvoiceID { get; set; }

        public int CMReturnID { get; set; }

        public float TotalMargin { get; set; }

        public int InvoiceOldNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ac_Invoice_Details> Tbl_Ac_Invoice_Details { get; set; }
    }
}
