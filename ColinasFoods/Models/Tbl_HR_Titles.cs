namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_HR_Titles
    {
        [Key]
        public int TitleID { get; set; }

        [Required]
        [StringLength(50)]
        public string TitleDesc { get; set; }
    }
}
