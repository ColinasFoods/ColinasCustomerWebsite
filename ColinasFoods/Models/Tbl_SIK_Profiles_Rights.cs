namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SIK_Profiles_Rights
    {
        [Key]
        public int ProfileRightsID { get; set; }

        public int ProfileNo { get; set; }

        public int MenuID { get; set; }
    }
}
