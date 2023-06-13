namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Proc_PO
    {
        [Key]
        public int POID { get; set; }

        public int PONo { get; set; }

        public int VendorID { get; set; }

        public DateTime? DateIssued { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int PaymentTermsID { get; set; }

        public int DeliveryTermsID { get; set; }

        public int WarehouseID { get; set; }

        [StringLength(70)]
        public string VendorRef { get; set; }

        public int MadeBy { get; set; }

        [StringLength(55)]
        public string AtnSalesman { get; set; }

        [Column(TypeName = "money")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal Taxes { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        public bool Printed { get; set; }

        public DateTime? PrintedDate { get; set; }

        public int PrintedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAP { get; set; }

        public bool IsService { get; set; }
    }
}
