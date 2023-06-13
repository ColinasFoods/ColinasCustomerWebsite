namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Ac_Accounts_Balance
    {
        [Key]
        public int AccountBalanceID { get; set; }

        public int AccountID { get; set; }

        [Required]
        [StringLength(13)]
        public string Account { get; set; }

        public int Año { get; set; }

        public byte Mes { get; set; }

        [Column(TypeName = "money")]
        public decimal SaldoInicial { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCargos { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAbonos { get; set; }

        [Column(TypeName = "money")]
        public decimal SaldoFinal { get; set; }
    }
}
