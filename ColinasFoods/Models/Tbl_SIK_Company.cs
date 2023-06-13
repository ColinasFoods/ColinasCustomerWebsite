namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SIK_Company
    {
        [Key]
        public int CompanyID { get; set; }

        [StringLength(15)]
        public string TaxID { get; set; }

        [Required]
        [StringLength(45)]
        public string CompanyName { get; set; }

        [StringLength(200)]
        public string CompanyAddress1 { get; set; }

        [StringLength(200)]
        public string CompanyAddress2 { get; set; }

        [StringLength(50)]
        public string CompanyCity { get; set; }

        [StringLength(50)]
        public string CompanyState { get; set; }

        [StringLength(12)]
        public string CompanyZipCode { get; set; }

        [StringLength(200)]
        public string Logo { get; set; }

        public float ActualSalesTaxRate { get; set; }
    }
}
