namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SIK_Menu
    {
        [Key]
        public int MenuID { get; set; }

        [StringLength(50)]
        public string Menu { get; set; }

        public int? MenuLevel { get; set; }

        public int? MenuParent { get; set; }

        [StringLength(50)]
        public string MenuScreenName { get; set; }

        public int? MenuOrder { get; set; }

        public int? MenuIcon { get; set; }

        public byte? MenuType { get; set; }

        [StringLength(10)]
        public string SCName { get; set; }
    }
}
