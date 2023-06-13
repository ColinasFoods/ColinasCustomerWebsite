namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SIK_Branches
    {
        [Key]
        public int BranchID { get; set; }

        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string BranchDescription { get; set; }

        [Required]
        [StringLength(3)]
        public string BranchShortName { get; set; }

        [StringLength(200)]
        public string BranchAddress1 { get; set; }

        [StringLength(200)]
        public string BranchAddress2 { get; set; }

        [StringLength(50)]
        public string BranchCity { get; set; }

        [StringLength(50)]
        public string BranchState { get; set; }

        [StringLength(12)]
        public string BranchZipCode { get; set; }
    }
}
