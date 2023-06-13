namespace ColinasFoods.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_HR_Personnel
    {
        [Key]
        public int PersonalID { get; set; }

        public int EmployeeNo { get; set; }

        [StringLength(11)]
        public string SSN { get; set; }

        [StringLength(80)]
        public string FullName { get; set; }

        [StringLength(65)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string EmployeeAddress1 { get; set; }

        [StringLength(10)]
        public string EmployeeAddress2 { get; set; }

        [StringLength(255)]
        public string EmployeeCounty { get; set; }

        [StringLength(70)]
        public string EmployeeCity { get; set; }

        [StringLength(50)]
        public string EmployeeState { get; set; }

        [StringLength(5)]
        public string EmployeeZipcode { get; set; }

        [StringLength(40)]
        public string Phone { get; set; }

        public int TitleID { get; set; }

        public int DepartmentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(55)]
        public string Email { get; set; }

        [Column(TypeName = "money")]
        public decimal Rate { get; set; }

        public int ForemanNo { get; set; }

        public int ForemanID { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        public bool Inactive { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public bool Driver { get; set; }

        [StringLength(10)]
        public string DL { get; set; }

        public DateTime? DLExpDate { get; set; }
    }
}
