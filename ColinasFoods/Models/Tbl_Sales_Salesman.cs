namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_Salesman
    {
        [Key]
        public int SalesmanID { get; set; }

        [Required]
        [StringLength(3)]
        public string SalesmanInitials { get; set; }

        public int PersonalID { get; set; }

        [StringLength(80)]
        public string SalesmanName { get; set; }

        [StringLength(200)]
        public string SalesmanOther { get; set; }

        public float SalesCommision { get; set; }
    }
}
