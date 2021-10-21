using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bonussetup")]
    [Index(nameof(UnitId), Name = "FK_BonusSetup_BusinessUnits")]
    [Index(nameof(FinYearId), Name = "FK_BonusSetup_FinancialYear")]
    [Index(nameof(LastUpdatedByUserId), Name = "FK_BonusSetup_Users")]
    [Index(nameof(CreateByUserId), Name = "FK_BonusSetup_Usersbyuser")]
    public partial class Bonussetup
    {
        public Bonussetup()
        {
            Employeebonus = new HashSet<Employeebonu>();
        }

        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int FinYearId { get; set; }
        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ToDate { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LastUpdatedDate { get; set; }
        public int CreateByUserId { get; set; }
        public int? LastUpdatedByUserId { get; set; }
        public double BonusPerc { get; set; }

        [ForeignKey(nameof(CreateByUserId))]
        [InverseProperty(nameof(User.BonussetupCreateByUsers))]
        public virtual User CreateByUser { get; set; }
        [ForeignKey(nameof(FinYearId))]
        [InverseProperty(nameof(Financialyear.Bonussetups))]
        public virtual Financialyear FinYear { get; set; }
        [ForeignKey(nameof(LastUpdatedByUserId))]
        [InverseProperty(nameof(User.BonussetupLastUpdatedByUsers))]
        public virtual User LastUpdatedByUser { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Bonussetups))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Employeebonu.BonusSetup))]
        public virtual ICollection<Employeebonu> Employeebonus { get; set; }
    }
}
