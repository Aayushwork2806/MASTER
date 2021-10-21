using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classsubject")]
    [Index(nameof(UnitId), Name = "FK_ClassSubject_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassSubject_Class")]
    [Index(nameof(SubjectGroupId), Name = "FK_ClassSubject_Masters")]
    [Index(nameof(SessionId), Name = "FK_ClassSubject_Session")]
    [Index(nameof(SubjectId), Name = "FK_ClassSubject_Subject")]
    public partial class Classsubject
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectGroupId { get; set; }
        public int SubjectId { get; set; }
        public int? SessionId { get; set; }
        [Column("SEQ")]
        public int? Seq { get; set; }
        public int UnitId { get; set; }
        public bool? Deleted { get; set; }
        public int? WeekPeriod { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classsubjects")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classsubjects")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Classsubjects")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(SubjectGroupId))]
        [InverseProperty(nameof(Master.Classsubjects))]
        public virtual Master SubjectGroup { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classsubjects))]
        public virtual Businessunit Unit { get; set; }
    }
}
