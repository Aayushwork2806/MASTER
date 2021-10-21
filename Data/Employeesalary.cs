using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeesalary")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeSalary_Employee")]
    [Index(nameof(CategoryId), Name = "FK_EmployeeSalary_Masters")]
    [Index(nameof(BankId), Name = "FK_EmployeeSalary_Masters1")]
    public partial class Employeesalary
    {
        public Employeesalary()
        {
            Employeesalarydtls = new HashSet<Employeesalarydtl>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime SalaryDate { get; set; }
        public int EmployeeId { get; set; }
        public int? CategoryId { get; set; }
        public int? BankId { get; set; }
        [Column("MBasic")]
        public double? Mbasic { get; set; }
        public double? PayDays { get; set; }
        public double? Advance { get; set; }
        public double? TotEarn { get; set; }
        public double? TotDeduct { get; set; }
        public double? NetSalary { get; set; }
        public double? PfSalary { get; set; }
        [Column("OTHourDays")]
        public double? OthourDays { get; set; }
        [Column("OTAmount")]
        public double? Otamount { get; set; }
        public double? LoanInst { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        [StringLength(10)]
        public string ChequeNo { get; set; }
        [Required]
        public bool? SalDrawn { get; set; }
        public bool UnPaid { get; set; }
        public bool Posted { get; set; }
        public int? VchNo { get; set; }
        public bool Deleted { get; set; }
        [Column("OTEsicAmount")]
        public double? OtesicAmount { get; set; }
        [Column("EBasic")]
        public double? Ebasic { get; set; }

        [ForeignKey(nameof(BankId))]
        [InverseProperty(nameof(Master.EmployeesalaryBanks))]
        public virtual Master Bank { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.EmployeesalaryCategories))]
        public virtual Master Category { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeesalaries")]
        public virtual Employee Employee { get; set; }
        [InverseProperty(nameof(Employeesalarydtl.EmployeeSalary))]
        public virtual ICollection<Employeesalarydtl> Employeesalarydtls { get; set; }
    }
}
