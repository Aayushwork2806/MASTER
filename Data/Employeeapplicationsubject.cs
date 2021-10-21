using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeapplicationsubject")]
    [Index(nameof(EmployeeApplicationId), Name = "FK_EmpSubjectList_EmployeeApplication")]
    [Index(nameof(SubjectId), Name = "FK_EmpSubjectList_Subject")]
    public partial class Employeeapplicationsubject
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeApplicationId { get; set; }
        public int SubjectId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(EmployeeApplicationId))]
        [InverseProperty(nameof(Employeeapplication.Employeeapplicationsubjects))]
        public virtual Employeeapplication EmployeeApplication { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Employeeapplicationsubjects")]
        public virtual Subject Subject { get; set; }
    }
}
