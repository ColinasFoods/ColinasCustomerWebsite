namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_HR_Departaments
    {
        [Key]
        public int DepartmentID { get; set; }

        [Required]
        [StringLength(45)]
        public string DepartmentDesc { get; set; }
    }
}
