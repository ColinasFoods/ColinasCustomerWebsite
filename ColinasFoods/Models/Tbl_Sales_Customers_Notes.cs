namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_Customers_Notes
    {
        [Key]
        public int CustomerNotesID { get; set; }

        public int CustomerID { get; set; }

        public DateTime? NoteDate { get; set; }

        [StringLength(200)]
        public string NoteDescription { get; set; }

        public int NoteMadeBy { get; set; }
    }
}
