using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classsubwsteacher")]
    [Index(nameof(UnitId), Name = "FK_ClassSubWsTeacher_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassSubWsTeacher_Class")]
    [Index(nameof(SectionId), Name = "FK_ClassSubWsTeacher_Section")]
    [Index(nameof(SessionId), Name = "FK_ClassSubWsTeacher_Session")]
    [Index(nameof(SubjectId), Name = "FK_ClassSubWsTeacher_Subject")]
    [Index(nameof(TeacherId), Name = "FK_ClassSubWsTeacher_Teacher")]
    public partial class Classsubwsteacher
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int SessionId { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classsubwsteachers")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Classsubwsteachers")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classsubwsteachers")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Classsubwsteachers")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classsubwsteachers))]
        public virtual Businessunit Unit { get; set; }
    }
}
