using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeapplication")]
    [Index(nameof(CompanyId), Name = "FK_EmployeeApplication_BusinessUnit")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeApplication_Employee")]
    [Index(nameof(QualificationId), Name = "FK_EmployeeApplication_Masters")]
    [Index(nameof(DesignationId), Name = "FK_EmployeeApplication_Masters1")]
    public partial class Employeeapplication
    {
        public Employeeapplication()
        {
            Employeeapplicationclasses = new HashSet<Employeeapplicationclass>();
            Employeeapplicationsubjects = new HashSet<Employeeapplicationsubject>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime ApplicationDate { get; set; }
        [Required]
        [StringLength(4)]
        public string Initials { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(25)]
        public string FatherName { get; set; }
        [StringLength(25)]
        public string MotherName { get; set; }
        [StringLength(25)]
        public string HusbandName { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(50)]
        public string PresentAddress1 { get; set; }
        [StringLength(50)]
        public string PresentAddress2 { get; set; }
        [StringLength(50)]
        public string PresentAddress3 { get; set; }
        [StringLength(30)]
        public string PresentCity { get; set; }
        [StringLength(25)]
        public string PresentPhoneNo { get; set; }
        [StringLength(50)]
        public string PermanentAddress1 { get; set; }
        [StringLength(50)]
        public string PermanentAddress2 { get; set; }
        [StringLength(50)]
        public string PermanentAddress3 { get; set; }
        [StringLength(50)]
        public string PermanentCity { get; set; }
        [StringLength(30)]
        public string PermanentPhoneNo { get; set; }
        [StringLength(10)]
        public string MobileNo { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        public int? QualificationId { get; set; }
        public double? Experience { get; set; }
        [StringLength(1)]
        public string MaritalStatus { get; set; }
        [StringLength(20)]
        public string AadharNo { get; set; }
        public int CompanyId { get; set; }
        [StringLength(100)]
        public string ResumePath { get; set; }
        public bool Deleted { get; set; }
        [StringLength(0)]
        public string Remark { get; set; }
        public int? EmployeeId { get; set; }
        public int? ApplicationNo { get; set; }
        public int? DesignationId { get; set; }
        [StringLength(2)]
        public string Selected { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Businessunit.Employeeapplications))]
        public virtual Businessunit Company { get; set; }
        [ForeignKey(nameof(DesignationId))]
        [InverseProperty(nameof(Master.EmployeeapplicationDesignations))]
        public virtual Master Designation { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeeapplications")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(QualificationId))]
        [InverseProperty(nameof(Master.EmployeeapplicationQualifications))]
        public virtual Master Qualification { get; set; }
        [InverseProperty(nameof(Employeeapplicationclass.EmployeeApplication))]
        public virtual ICollection<Employeeapplicationclass> Employeeapplicationclasses { get; set; }
        [InverseProperty(nameof(Employeeapplicationsubject.EmployeeApplication))]
        public virtual ICollection<Employeeapplicationsubject> Employeeapplicationsubjects { get; set; }
    }
}
