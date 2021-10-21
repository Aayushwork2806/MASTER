using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("yearlyattendence")]
    [Index(nameof(UnitId), Name = "FK_YearlyAttendence_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_YearlyAttendence_Class")]
    [Index(nameof(ScholarId), Name = "FK_YearlyAttendence_Scholar")]
    [Index(nameof(SectionId), Name = "FK_YearlyAttendence_Section")]
    [Index(nameof(SessionId), Name = "FK_YearlyAttendence_Session")]
    public partial class Yearlyattendence
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SessionId { get; set; }
        public int ScholarId { get; set; }
        public int? SchoolDays { get; set; }
        public int? PresentDays { get; set; }
        public double? AttPercentage { get; set; }
        public int? UnitId { get; set; }
        public int? SectionId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Yearlyattendences")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Yearlyattendences")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Yearlyattendences")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Yearlyattendences")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Yearlyattendences))]
        public virtual Businessunit Unit { get; set; }
    }
}
