using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classallotment")]
    [Index(nameof(UnitId), Name = "FK_ClassAllotment_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassAllotment_Class")]
    [Index(nameof(DayId), Name = "FK_ClassAllotment_Masters")]
    [Index(nameof(SectionId), Name = "FK_ClassAllotment_Section")]
    [Index(nameof(SessionId), Name = "FK_ClassAllotment_Session")]
    [Index(nameof(SubjectId), Name = "FK_ClassAllotment_Subject")]
    [Index(nameof(FacultyId), Name = "FK_ClassAllotment_Teacher")]
    public partial class Classallotment
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int SubjectId { get; set; }
        public int? FacultyId { get; set; }
        public int DayId { get; set; }
        public int? PeriodNo { get; set; }
        public int SessionId { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classallotments")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(DayId))]
        [InverseProperty(nameof(Master.Classallotments))]
        public virtual Master Day { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Classallotments")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classallotments")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Classallotments")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classallotments))]
        public virtual Businessunit Unit { get; set; }
    }
}
