namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_CRM
    {
        [Key]
        public int SegVentasID { get; set; }

        public int VendedorID { get; set; }

        public int ClienteID { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalFacturado { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCobrado { get; set; }

        public bool Contactado { get; set; }

        public DateTime? FechaContacto { get; set; }

        [StringLength(50)]
        public string Comentarios { get; set; }

        public bool Contactado1 { get; set; }

        public bool Contactado2 { get; set; }

        public bool Contactado3 { get; set; }

        public bool Contactado4 { get; set; }

        public bool Contactado5 { get; set; }

        public bool Contactado6 { get; set; }

        [StringLength(50)]
        public string Comentarios1 { get; set; }

        [StringLength(50)]
        public string Comentarios2 { get; set; }

        [StringLength(50)]
        public string Comentarios3 { get; set; }

        [StringLength(50)]
        public string Comentarios4 { get; set; }

        [StringLength(50)]
        public string Comentarios5 { get; set; }

        [StringLength(50)]
        public string Comentarios6 { get; set; }
    }
}
