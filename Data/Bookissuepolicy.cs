using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bookissuepolicy")]
    [Index(nameof(UnitId), Name = "FK_BookIssuePolicy_BusinessUnits")]
    [Index(nameof(FeeHeadId), Name = "FK_BookIssuePolicy_FeeHeads")]
    public partial class Bookissuepolicy
    {
        [Key]
        public int Id { get; set; }
        public int Faculty { get; set; }
        public int Scholar { get; set; }
        public int FacultyIssueDays { get; set; }
        public int ScholarIssueDays { get; set; }
        public double? LateFee { get; set; }
        public int? FeeHeadId { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(FeeHeadId))]
        [InverseProperty(nameof(Feehead.Bookissuepolicies))]
        public virtual Feehead FeeHead { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Bookissuepolicies))]
        public virtual Businessunit Unit { get; set; }
    }
}
