using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarsubject")]
    [Index(nameof(ClassId), Name = "FK_ScholarSubject_Class")]
    [Index(nameof(ScholarId), Name = "FK_ScholarSubject_Scholar")]
    [Index(nameof(SessId), Name = "FK_ScholarSubject_Session")]
    [Index(nameof(SubjectId), Name = "FK_ScholarSubject_Subject")]
    public partial class Scholarsubject
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int SessId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public long? Seq { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Scholarsubjects")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholarsubjects")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessId))]
        [InverseProperty(nameof(Session.Scholarsubjects))]
        public virtual Session Sess { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Scholarsubjects")]
        public virtual Subject Subject { get; set; }
    }
}
