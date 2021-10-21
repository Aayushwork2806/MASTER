using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("salaryheads")]
    [Index(nameof(AccountId), Name = "FK_SalaryHeads_Accounts")]
    [Index(nameof(CompanyId), Name = "FK_SalaryHeads_BusinessUnits")]
    public partial class Salaryhead
    {
        public Salaryhead()
        {
            AccountscompanyCesiheads = new HashSet<Accountscompany>();
            AccountscompanyCpfheads = new HashSet<Accountscompany>();
            AccountscompanyDaheads = new HashSet<Accountscompany>();
            AccountscompanyEsiheads = new HashSet<Accountscompany>();
            AccountscompanyPfheads = new HashSet<Accountscompany>();
            AccountscompanyPtaxHeads = new HashSet<Accountscompany>();
            AccountscompanyTdsheads = new HashSet<Accountscompany>();
            Employeesalarydtls = new HashSet<Employeesalarydtl>();
            Employeesalarystructures = new HashSet<Employeesalarystructure>();
            FinancialunitCesiheads = new HashSet<Financialunit>();
            FinancialunitCpfheads = new HashSet<Financialunit>();
            FinancialunitDaheads = new HashSet<Financialunit>();
            FinancialunitEsiheads = new HashSet<Financialunit>();
            FinancialunitPfheads = new HashSet<Financialunit>();
            FinancialunitPtaxHeads = new HashSet<Financialunit>();
            FinancialunitTdsheads = new HashSet<Financialunit>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1)]
        public string HeadType { get; set; }
        [Required]
        [StringLength(40)]
        public string HeadName { get; set; }
        [Required]
        [StringLength(10)]
        public string PrintName { get; set; }
        public bool FixedAmt { get; set; }
        [Column("CalOnLWP")]
        public bool CalOnLwp { get; set; }
        [Column("CalPF")]
        public bool CalPf { get; set; }
        [Column("CalESI")]
        public bool CalEsi { get; set; }
        [Column("CalDA")]
        public bool CalDa { get; set; }
        public bool PostInAc { get; set; }
        public int? AccountId { get; set; }
        public short? PrintSeq { get; set; }
        public bool Deleted { get; set; }
        public int? CompanyId { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("Salaryheads")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Businessunit.Salaryheads))]
        public virtual Businessunit Company { get; set; }
        [InverseProperty(nameof(Accountscompany.Cesihead))]
        public virtual ICollection<Accountscompany> AccountscompanyCesiheads { get; set; }
        [InverseProperty(nameof(Accountscompany.Cpfhead))]
        public virtual ICollection<Accountscompany> AccountscompanyCpfheads { get; set; }
        [InverseProperty(nameof(Accountscompany.Dahead))]
        public virtual ICollection<Accountscompany> AccountscompanyDaheads { get; set; }
        [InverseProperty(nameof(Accountscompany.Esihead))]
        public virtual ICollection<Accountscompany> AccountscompanyEsiheads { get; set; }
        [InverseProperty(nameof(Accountscompany.Pfhead))]
        public virtual ICollection<Accountscompany> AccountscompanyPfheads { get; set; }
        [InverseProperty(nameof(Accountscompany.PtaxHead))]
        public virtual ICollection<Accountscompany> AccountscompanyPtaxHeads { get; set; }
        [InverseProperty(nameof(Accountscompany.Tdshead))]
        public virtual ICollection<Accountscompany> AccountscompanyTdsheads { get; set; }
        [InverseProperty(nameof(Employeesalarydtl.SalaryHead))]
        public virtual ICollection<Employeesalarydtl> Employeesalarydtls { get; set; }
        [InverseProperty(nameof(Employeesalarystructure.SalHead))]
        public virtual ICollection<Employeesalarystructure> Employeesalarystructures { get; set; }
        [InverseProperty(nameof(Financialunit.Cesihead))]
        public virtual ICollection<Financialunit> FinancialunitCesiheads { get; set; }
        [InverseProperty(nameof(Financialunit.Cpfhead))]
        public virtual ICollection<Financialunit> FinancialunitCpfheads { get; set; }
        [InverseProperty(nameof(Financialunit.Dahead))]
        public virtual ICollection<Financialunit> FinancialunitDaheads { get; set; }
        [InverseProperty(nameof(Financialunit.Esihead))]
        public virtual ICollection<Financialunit> FinancialunitEsiheads { get; set; }
        [InverseProperty(nameof(Financialunit.Pfhead))]
        public virtual ICollection<Financialunit> FinancialunitPfheads { get; set; }
        [InverseProperty(nameof(Financialunit.PtaxHead))]
        public virtual ICollection<Financialunit> FinancialunitPtaxHeads { get; set; }
        [InverseProperty(nameof(Financialunit.Tdshead))]
        public virtual ICollection<Financialunit> FinancialunitTdsheads { get; set; }
    }
}
