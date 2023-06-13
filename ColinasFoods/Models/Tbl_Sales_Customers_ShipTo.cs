namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Sales_Customers_ShipTo
    {
        [Key]
        public int ShipCustomerID { get; set; }

        public int? CustomerID { get; set; }

        [StringLength(150)]
        public string ShipTo { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(10)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToCounty { get; set; }

        [StringLength(70)]
        public string ShipToCity { get; set; }

        [StringLength(50)]
        public string ShipToState { get; set; }

        [StringLength(100)]
        public string ShipToCountry { get; set; }

        [StringLength(5)]
        public string ShipToZipcode { get; set; }

        public int? ShipToRouteNo { get; set; }
    }
}
