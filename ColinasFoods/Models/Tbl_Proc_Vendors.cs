namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Proc_Vendors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Proc_Vendors()
        {
            Tbl_Proc_Vendors_Contacts = new HashSet<Tbl_Proc_Vendors_Contacts>();
        }

        [Key]
        public int VendorID { get; set; }

        [StringLength(150)]
        public string VendorShortName { get; set; }

        [Required]
        [StringLength(150)]
        public string VendorName { get; set; }

        [StringLength(16)]
        public string VendorTaxID { get; set; }

        [StringLength(255)]
        public string VendorAddress1 { get; set; }

        [StringLength(255)]
        public string VendorAddress2 { get; set; }

        [StringLength(255)]
        public string VendorCounty { get; set; }

        [StringLength(70)]
        public string VendorCity { get; set; }

        [StringLength(50)]
        public string VendorState { get; set; }

        [StringLength(100)]
        public string VendorCountry { get; set; }

        [StringLength(5)]
        public string VendorZipcode { get; set; }

        [StringLength(40)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string website { get; set; }

        public int? PaymentTermsID { get; set; }

        public int? DeliveryTermsID { get; set; }

        public int? CurrencyID { get; set; }

        [StringLength(20)]
        public string AccountNo { get; set; }

        [StringLength(60)]
        public string AccountDesc { get; set; }

        public int? PurchasingConceptID { get; set; }

        public int? CreditDays { get; set; }

        public bool Inactive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Proc_Vendors_Contacts> Tbl_Proc_Vendors_Contacts { get; set; }
    }
}
