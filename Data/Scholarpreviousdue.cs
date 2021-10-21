using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarpreviousdues")]
    [Index(nameof(UnitId), Name = "FK_ScholarPreviousDues_BusinessUnits")]
    [Index(nameof(FeeHeadId), Name = "FK_ScholarPreviousDues_FeeHeads")]
    [Index(nameof(ScholarId), Name = "FK_ScholarPreviousDues_Scholar")]
    [Index(nameof(SessionId), Name = "FK_ScholarPreviousDues_Session")]
    [Index(nameof(InstallmentId), Name = "FK_ScholarPreviousDues_SessionDtl")]
    public partial class Scholarpreviousdue
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ScholarId { get; set; }
        public int FeeHeadId { get; set; }
        public int InstallmentId { get; set; }
        public double DueAmount { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(FeeHeadId))]
        [InverseProperty(nameof(Feehead.Scholarpreviousdues))]
        public virtual Feehead FeeHead { get; set; }
        [ForeignKey(nameof(InstallmentId))]
        [InverseProperty(nameof(Sessiondtl.Scholarpreviousdues))]
        public virtual Sessiondtl Installment { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholarpreviousdues")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Scholarpreviousdues")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Scholarpreviousdues))]
        public virtual Businessunit Unit { get; set; }
    }
}
