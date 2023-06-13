namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SIK_Profiles
    {
        [Key]
        public int ProfileNo { get; set; }

        [Required]
        [StringLength(25)]
        public string ProfileDescription { get; set; }
    }
}
