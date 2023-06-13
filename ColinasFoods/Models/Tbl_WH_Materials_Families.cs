namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WH_Materials_Families
    {
        [Key]
        public int FamilyID { get; set; }

        [StringLength(2)]
        public string FamilyCode { get; set; }

        [StringLength(100)]
        public string FamilyDescription { get; set; }

        public int FamilyLevel { get; set; }

        public int FamilyParentID { get; set; }

        public int TaxGroup { get; set; }

        [StringLength(100)]
        public string FamilyGroup { get; set; }
    }
}
