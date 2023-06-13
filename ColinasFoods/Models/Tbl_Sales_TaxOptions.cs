namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_TaxOptions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxGroup { get; set; }

        [Required]
        [StringLength(50)]
        public string TaxDescription { get; set; }
    }
}
