namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_Customers
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(150)]
        public string CustomerShortName { get; set; }

        [Required]
        [StringLength(150)]
        public string CustomerName { get; set; }

        [StringLength(16)]
        public string CustomerTaxID { get; set; }

        [StringLength(255)]
        public string CustomerAddress1 { get; set; }

        [StringLength(255)]
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

        public int? SalesmanID { get; set; }

        [StringLength(10)]
        public string SalesRep { get; set; }

        public int? ManagerID { get; set; }

        [StringLength(40)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Fax { get; set; }

        public int? PaymentTermsID { get; set; }

        public int? DeliveryTermsID { get; set; }

        public int? CurrencyID { get; set; }

        [StringLength(20)]
        public string AccountNo { get; set; }

        [StringLength(60)]
        public string AccountDesc { get; set; }

        public int? RouteNo { get; set; }

        public bool Inactive { get; set; }

        [StringLength(50)]
        public string TaxItem { get; set; }

        [StringLength(50)]
        public string ResaleNum { get; set; }

        [StringLength(15)]
        public string CustomerType { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        public int? PriceListID { get; set; }

        [StringLength(50)]
        public string SalesTaxCode { get; set; }

        public bool IsLocked { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditLimit { get; set; }

        [Column(TypeName = "money")]
        public decimal CreditAP { get; set; }

        [Column(TypeName = "money")]
        public decimal CreditBO { get; set; }

        public int CreditDaysDue { get; set; }

        [StringLength(50)]
        public string CreditStatus { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
