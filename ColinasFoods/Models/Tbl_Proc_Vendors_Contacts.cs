namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Proc_Vendors_Contacts
    {
        [Key]
        public int ContactVendorID { get; set; }

        public int VendorID { get; set; }

        [Required]
        [StringLength(190)]
        public string FullName { get; set; }

        [StringLength(70)]
        public string Title { get; set; }

        [StringLength(120)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(50)]
        public string WorkPhone { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public virtual Tbl_Proc_Vendors Tbl_Proc_Vendors { get; set; }
    }
}
