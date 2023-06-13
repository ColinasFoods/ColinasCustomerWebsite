namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_AP_Doc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Ac_AP_Doc()
        {
            Tbl_Ac_AP_Doc_Movs = new HashSet<Tbl_Ac_AP_Doc_Movs>();
        }

        [Key]
        public int AccountsPayableDetailsID { get; set; }

        public int AccountsPayableID { get; set; }

        [Required]
        [StringLength(15)]
        public string APInvoice { get; set; }

        public DateTime APInvoiceDate { get; set; }

        public DateTime? APInvoiceDueDate { get; set; }

        public DateTime? APPayDate { get; set; }

        [Column(TypeName = "money")]
        public decimal APTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal APPaid { get; set; }

        [Column(TypeName = "money")]
        public decimal APCredits { get; set; }

        [Column(TypeName = "money")]
        public decimal APBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal APMatch { get; set; }

        [StringLength(100)]
        public string APComments { get; set; }

        public virtual Tbl_Ac_AP Tbl_Ac_AP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ac_AP_Doc_Movs> Tbl_Ac_AP_Doc_Movs { get; set; }
    }
}
