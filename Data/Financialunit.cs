using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("financialunits")]
    [Index(nameof(PurchaseDiscountAccountId), Name = "FK_FinancialUnits_Accounts")]
    [Index(nameof(UnitId), Name = "FK_FinancialUnits_BusinessUnits")]
    [Index(nameof(LeaveYearId), Name = "FK_FinancialUnits_LeaveYear")]
    [Index(nameof(LeaveTypeId), Name = "FK_FinancialUnits_PersonnelLeaves")]
    [Index(nameof(CesiheadId), Name = "FK_FinancialUnits_SalaryHeads")]
    [Index(nameof(CpfheadId), Name = "FK_FinancialUnits_SalaryHeads1")]
    [Index(nameof(DaheadId), Name = "FK_FinancialUnits_SalaryHeads2")]
    [Index(nameof(EsiheadId), Name = "FK_FinancialUnits_SalaryHeads3")]
    [Index(nameof(PfheadId), Name = "FK_FinancialUnits_SalaryHeads4")]
    [Index(nameof(PtaxHeadId), Name = "FK_FinancialUnits_SalaryHeads5")]
    [Index(nameof(TdsheadId), Name = "FK_FinancialUnits_SalaryHeads6")]
    public partial class Financialunit
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        [Required]
        [StringLength(50)]
        public string UnitName { get; set; }
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
        [StringLength(5)]
        public string LateHours { get; set; }
        public int? LateDays { get; set; }
        [StringLength(1)]
        public string AttendanceDeduct { get; set; }
        public int? LeaveTypeId { get; set; }
        [StringLength(1)]
        public string AttendanceMode { get; set; }
        public int? PurchaseDiscountAccountId { get; set; }
        [StringLength(2)]
        public string AttenType { get; set; }
        [StringLength(4)]
        public string RoundOffOn { get; set; }
        [Column("OTcalculationOnSalary")]
        [StringLength(2)]
        public string OtcalculationOnSalary { get; set; }
        [Column("AddEmpPFESI")]
        public bool? AddEmpPfesi { get; set; }

        [ForeignKey(nameof(CesiheadId))]
        [InverseProperty(nameof(Salaryhead.FinancialunitCesiheads))]
        public virtual Salaryhead Cesihead { get; set; }
        [ForeignKey(nameof(CpfheadId))]
        [InverseProperty(nameof(Salaryhead.FinancialunitCpfheads))]
        public virtual Salaryhead Cpfhead { get; set; }
        [ForeignKey(nameof(DaheadId))]
        [InverseProperty(nameof(Salaryhead.FinancialunitDaheads))]
        public virtual Salaryhead Dahead { get; set; }
        [ForeignKey(nameof(EsiheadId))]
        [InverseProperty(nameof(Salaryhead.FinancialunitEsiheads))]
        public virtual Salaryhead Esihead { get; set; }
        [ForeignKey(nameof(LeaveTypeId))]
        [InverseProperty(nameof(Personnelleaf.Financialunits))]
        public virtual Personnelleaf LeaveType { get; set; }
        [ForeignKey(nameof(LeaveYearId))]
        [InverseProperty(nameof(Leaveyear.Financialunits))]
        public virtual Leaveyear LeaveYear { get; set; }
        [ForeignKey(nameof(PfheadId))]
        [InverseProperty(nameof(Salaryhead.FinancialunitPfheads))]
        public virtual Salaryhead Pfhead { get; set; }
        [ForeignKey(nameof(PtaxHeadId))]
        [InverseProperty(nameof(Salaryhead.FinancialunitPtaxHeads))]
        public virtual Salaryhead PtaxHead { get; set; }
        [ForeignKey(nameof(PurchaseDiscountAccountId))]
        [InverseProperty(nameof(Account.Financialunits))]
        public virtual Account PurchaseDiscountAccount { get; set; }
        [ForeignKey(nameof(TdsheadId))]
        [InverseProperty(nameof(Salaryhead.FinancialunitTdsheads))]
        public virtual Salaryhead Tdshead { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Financialunits))]
        public virtual Businessunit Unit { get; set; }
    }
}
