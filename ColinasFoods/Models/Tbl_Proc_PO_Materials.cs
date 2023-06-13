namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Proc_PO_Materials
    {
        [Key]
        public int POMaterialsID { get; set; }

        public int POID { get; set; }

        public int ItemNo { get; set; }

        [StringLength(100)]
        public string PartNo { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int MaterialID { get; set; }

        public float Quantity { get; set; }

        public int QuantityCs { get; set; }

        public float QuantityRec { get; set; }

        public float QuantityRecWeight { get; set; }

        public float QuantityRet { get; set; }

        public float QuantityBalance { get; set; }

        [StringLength(10)]
        public string UM { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal ExtendedPrice { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public bool Canceled { get; set; }

        public DateTime? CanceledDate { get; set; }

        public int CanceledBy { get; set; }

        [StringLength(200)]
        public string CanceledComments { get; set; }

        public DateTime? DeliveryDateFirst { get; set; }

        public DateTime? DeliveryDateLast { get; set; }

        public int DaysLastDelivery { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        public bool IsTaxable { get; set; }

        public float TaxRate { get; set; }
    }
}
