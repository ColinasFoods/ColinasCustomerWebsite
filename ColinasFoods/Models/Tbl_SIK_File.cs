namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SIK_File
    {
        [Key]
        public int FileID { get; set; }

        [Required]
        [StringLength(50)]
        public string ActualFile { get; set; }

        [StringLength(50)]
        public string ProductionFile { get; set; }
    }
}
