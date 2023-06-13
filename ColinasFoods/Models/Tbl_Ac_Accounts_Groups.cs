namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_Accounts_Groups
    {
        [Key]
        public int AcGroupID { get; set; }

        [StringLength(50)]
        public string DescGrupo { get; set; }

        [StringLength(13)]
        public string CuentaInicial { get; set; }

        [StringLength(13)]
        public string CuentaFinal { get; set; }

        public byte TipoR { get; set; }

        public byte Orden { get; set; }

        public byte Valor { get; set; }

        public bool Resumen { get; set; }

        [StringLength(50)]
        public string TituloResumen { get; set; }
    }
}
