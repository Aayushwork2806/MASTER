using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("accountscompany")]
    [Index(nameof(DaheadId), Name = "FK_AccountsCompany_SalaryHeads")]
    [Index(nameof(PfheadId), Name = "FK_AccountsCompany_SalaryHeads1")]
    [Index(nameof(EsiheadId), Name = "FK_AccountsCompany_SalaryHeads2")]
    [Index(nameof(PtaxHeadId), Name = "FK_AccountsCompany_SalaryHeads3")]
    [Index(nameof(TdsheadId), Name = "FK_AccountsCompany_SalaryHeads4")]
    [Index(nameof(CpfheadId), Name = "FK_AccountsCompany_SalaryHeads5")]
    [Index(nameof(CesiheadId), Name = "FK_AccountsCompany_SalaryHeads6")]
    public partial class Accountscompany
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string UnitName { get; set; }
        [StringLength(60)]
        public string Address1 { get; set; }
        [StringLength(60)]
        public string Address2 { get; set; }
        [StringLength(25)]
        public string City { get; set; }
        [StringLength(25)]
        public string PhoneNo { get; set; }
        [StringLength(25)]
        public string FaxNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FinYrFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FinYrTo { get; set; }
        [Column("TIN")]
        [StringLength(15)]
        public string Tin { get; set; }
        [Column("TINDate", TypeName = "date")]
        public DateTime? Tindate { get; set; }
        [Column("PANNo")]
        [StringLength(15)]
        public string Panno { get; set; }
        [Column("TDSAccNo")]
        [StringLength(20)]
        public string TdsaccNo { get; set; }
        [Column("UnitPFNo")]
        [StringLength(12)]
        public string UnitPfno { get; set; }
        [Column("DAPerc")]
        public double? Daperc { get; set; }
        [Column("HRAPerc")]
        public double? Hraperc { get; set; }
        public double? PfPerc { get; set; }
        [Column("EPFShare")]
        public double? Epfshare { get; set; }
        public double? PensionFundShare { get; set; }
        [Column("PFCutOffLimit")]
        public double? PfcutOffLimit { get; set; }
        public double? BonusPerc { get; set; }
        [Column("ESIEmployeePerc")]
        public double? EsiemployeePerc { get; set; }
        [Column("ESIEmployerPerc")]
        public double? EsiemployerPerc { get; set; }
        [Column("ESICutOffLimit")]
        public double? EsicutOffLimit { get; set; }
        [Column("ESIMinimumLimit")]
        public double? EsiminimumLimit { get; set; }
        [Column("TDSAuthorisedName")]
        [StringLength(30)]
        public string TdsauthorisedName { get; set; }
        [Column("TDSAuthorisedFName")]
        [StringLength(30)]
        public string TdsauthorisedFname { get; set; }
        [StringLength(30)]
        public string TdsAuthorisedDesig { get; set; }
        [StringLength(1)]
        public string SalaryCalOn { get; set; }
        public int? SalaryCalDays { get; set; }
        [Column("OTCalOn")]
        [StringLength(1)]
        public string OtcalOn { get; set; }
        [Column("OTAddInSalary")]
        public bool? OtaddInSalary { get; set; }
        public int? LeaveYearId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SalaryLockDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SalaryVchPostDate { get; set; }
        [Column("DAHeadId")]
        public int? DaheadId { get; set; }
        [Column("PFHeadId")]
        public int? PfheadId { get; set; }
        [Column("ESIHeadId")]
        public int? EsiheadId { get; set; }
        [Column("PTaxHeadId")]
        public int? PtaxHeadId { get; set; }
        [Column("TDSHeadId")]
        public int? TdsheadId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [Column("CPFHeadId")]
        public int? CpfheadId { get; set; }
        [Column("CESIHeadId")]
        public int? CesiheadId { get; set; }

        [ForeignKey(nameof(CesiheadId))]
        [InverseProperty(nameof(Salaryhead.AccountscompanyCesiheads))]
        public virtual Salaryhead Cesihead { get; set; }
        [ForeignKey(nameof(CpfheadId))]
        [InverseProperty(nameof(Salaryhead.AccountscompanyCpfheads))]
        public virtual Salaryhead Cpfhead { get; set; }
        [ForeignKey(nameof(DaheadId))]
        [InverseProperty(nameof(Salaryhead.AccountscompanyDaheads))]
        public virtual Salaryhead Dahead { get; set; }
        [ForeignKey(nameof(EsiheadId))]
        [InverseProperty(nameof(Salaryhead.AccountscompanyEsiheads))]
        public virtual Salaryhead Esihead { get; set; }
        [ForeignKey(nameof(PfheadId))]
        [InverseProperty(nameof(Salaryhead.AccountscompanyPfheads))]
        public virtual Salaryhead Pfhead { get; set; }
        [ForeignKey(nameof(PtaxHeadId))]
        [InverseProperty(nameof(Salaryhead.AccountscompanyPtaxHeads))]
        public virtual Salaryhead PtaxHead { get; set; }
        [ForeignKey(nameof(TdsheadId))]
        [InverseProperty(nameof(Salaryhead.AccountscompanyTdsheads))]
        public virtual Salaryhead Tdshead { get; set; }
    }
}
