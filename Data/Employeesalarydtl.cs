using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeesalarydtl")]
    [Index(nameof(EmployeeSalaryId), Name = "FK_EmployeeSalaryDtl_EmployeeSalary")]
    [Index(nameof(SalaryHeadId), Name = "FK_EmployeeSalaryDtl_SalaryHeads")]
    public partial class Employeesalarydtl
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeSalaryId { get; set; }
        public int SalaryHeadId { get; set; }
        public double Amount { get; set; }

        [ForeignKey(nameof(EmployeeSalaryId))]
        [InverseProperty(nameof(Employeesalary.Employeesalarydtls))]
        public virtual Employeesalary EmployeeSalary { get; set; }
        [ForeignKey(nameof(SalaryHeadId))]
        [InverseProperty(nameof(Salaryhead.Employeesalarydtls))]
        public virtual Salaryhead SalaryHead { get; set; }
    }
}
