namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SIK_Profiles_Production
    {
        [Key]
        public int ProfilesProdID { get; set; }

        public int ProfileNo { get; set; }

        public int TagMenu { get; set; }
    }
}
