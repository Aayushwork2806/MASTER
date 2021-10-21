using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feeadjusted")]
    [Index(nameof(UnitId), Name = "FK_FeeAdjusted_BusinessUnits")]
    [Index(nameof(FeeHeadId), Name = "FK_FeeAdjusted_FeeHeads")]
    [Index(nameof(ScholarId), Name = "FK_FeeAdjusted_Scholar")]
    [Index(nameof(SessionId), Name = "FK_FeeAdjusted_Session")]
    public partial class Feeadjusted
    {
        public Feeadjusted()
        {
            Feeadjusteddtls = new HashSet<Feeadjusteddtl>();
        }

        [Key]
        public int Id { get; set; }
        public int DocNo { get; set; }
        [MaxLength(6)]
        public DateTime DocDate { get; set; }
        public int SessionId { get; set; }
        public int ScholarId { get; set; }
        public int FeeHeadId { get; set; }
        public long Amount { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(FeeHeadId))]
        [InverseProperty(nameof(Feehead.Feeadjusteds))]
        public virtual Feehead FeeHead { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Feeadjusteds")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Feeadjusteds")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Feeadjusteds))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Feeadjusteddtl.FeeAdjusted))]
        public virtual ICollection<Feeadjusteddtl> Feeadjusteddtls { get; set; }
    }
}
