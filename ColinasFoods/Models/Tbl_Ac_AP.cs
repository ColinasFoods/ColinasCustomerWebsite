namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_AP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Ac_AP()
        {
            Tbl_Ac_AP_Doc = new HashSet<Tbl_Ac_AP_Doc>();
        }

        [Key]
        public int AccountsPayableID { get; set; }

        public int? APNo { get; set; }

        public DateTime APDate { get; set; }

        public int APVendorID { get; set; }

        public int APMadeBy { get; set; }

        [StringLength(250)]
        public string APNotes { get; set; }

        public DateTime? APPrintDate { get; set; }

        public int APCreditDays { get; set; }

        [Column(TypeName = "money")]
        public decimal APTotal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ac_AP_Doc> Tbl_Ac_AP_Doc { get; set; }
    }
}
