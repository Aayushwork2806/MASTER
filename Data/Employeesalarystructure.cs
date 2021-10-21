using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeesalarystructure")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeSalaryStructure_Employee")]
    [Index(nameof(SalHeadId), Name = "FK_EmployeeSalaryStructure_SalaryHeads")]
    public partial class Employeesalarystructure
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int SalHeadId { get; set; }
        public double Amount { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeesalarystructures")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(SalHeadId))]
        [InverseProperty(nameof(Salaryhead.Employeesalarystructures))]
        public virtual Salaryhead SalHead { get; set; }
    }
}
