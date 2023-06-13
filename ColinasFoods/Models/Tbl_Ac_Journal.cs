namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_Journal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Ac_Journal()
        {
            Tbl_Ac_Journal_AR = new HashSet<Tbl_Ac_Journal_AR>();
            Tbl_Ac_Journal_Details = new HashSet<Tbl_Ac_Journal_Details>();
            Tbl_Ac_Journal_AP = new HashSet<Tbl_Ac_Journal_AP>();
        }

        [Key]
        public int JournalID { get; set; }

        public int JournalNo { get; set; }

        public int JournalConsecutive { get; set; }

        public DateTime JournalDate { get; set; }

        [Required]
        [StringLength(1)]
        public string JournalType { get; set; }

        [StringLength(255)]
        public string JournalConcept { get; set; }

        [Column(TypeName = "money")]
        public decimal JournalTotalCharges { get; set; }

        [Column(TypeName = "money")]
        public decimal JournalTotalCredits { get; set; }

        [Column(TypeName = "money")]
        public decimal JournalDifference { get; set; }

        public int JournalMadeBy { get; set; }

        public DateTime? JournalPrintDate { get; set; }

        public bool JournalIsCheck { get; set; }

        public int JournalCheckNo { get; set; }

        public int JournalVendorID { get; set; }

        [StringLength(100)]
        public string JournalBeneficiary { get; set; }

        [Column(TypeName = "money")]
        public decimal JournalCheckAmount { get; set; }

        [StringLength(150)]
        public string JournalCheckTotalWord { get; set; }

        public int JournalBankID { get; set; }

        [StringLength(20)]
        public string JournalBanckAccount { get; set; }

        [StringLength(20)]
        public string JournalVendorAccount { get; set; }

        public bool JournalCheckInTransit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? JournalRealPayCheck { get; set; }

        public bool JournalYearClose { get; set; }

        [StringLength(20)]
        public string JournalYearCloseAccount { get; set; }

        [StringLength(250)]
        public string JournalYearCloseAccountDesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ac_Journal_AR> Tbl_Ac_Journal_AR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ac_Journal_Details> Tbl_Ac_Journal_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ac_Journal_AP> Tbl_Ac_Journal_AP { get; set; }
    }
}
