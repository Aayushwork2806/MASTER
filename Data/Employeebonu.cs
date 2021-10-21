using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeebonus")]
    [Index(nameof(BonusSetupId), Name = "FK_EmployeeBonus_BusinessUnits")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeBonus_Employee")]
    [Index(nameof(FinYearId), Name = "FK_EmployeeBonus_FinancialYear")]
    public partial class Employeebonu
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int EmployeeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime BonusMonth { get; set; }
        public int FinYearId { get; set; }
        public int? TotalMonthOfBonus { get; set; }
        public double? TotalDaysOfBonus { get; set; }
        public double? TotalNetSalary { get; set; }
        public double? BonusAmount { get; set; }
        public int BonusSetupId { get; set; }

        [ForeignKey(nameof(BonusSetupId))]
        [InverseProperty(nameof(Bonussetup.Employeebonus))]
        public virtual Bonussetup BonusSetup { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeebonus")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(FinYearId))]
        [InverseProperty(nameof(Financialyear.Employeebonus))]
        public virtual Financialyear FinYear { get; set; }
    }
}
