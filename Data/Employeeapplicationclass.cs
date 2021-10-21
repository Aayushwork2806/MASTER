using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeapplicationclass")]
    [Index(nameof(ClassId), Name = "FK_EmployeeApplicationClass_Class")]
    [Index(nameof(EmployeeApplicationId), Name = "FK_EmployeeApplicationClass_EmployeeApplication")]
    public partial class Employeeapplicationclass
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeApplicationId { get; set; }
        public int ClassId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Employeeapplicationclasses")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(EmployeeApplicationId))]
        [InverseProperty(nameof(Employeeapplication.Employeeapplicationclasses))]
        public virtual Employeeapplication EmployeeApplication { get; set; }
    }
}
