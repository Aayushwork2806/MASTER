using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("qpapertask")]
    [Index(nameof(UnitId), Name = "FK_QPaperTask_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_QPaperTask_Class")]
    [Index(nameof(ExamId), Name = "FK_QPaperTask_Exam")]
    [Index(nameof(SectionId), Name = "FK_QPaperTask_Section")]
    [Index(nameof(SessionId), Name = "FK_QPaperTask_Session")]
    [Index(nameof(SubjectId), Name = "FK_QPaperTask_Subject")]
    [Index(nameof(FacultyId), Name = "FK_QPaperTask_Teacher")]
    public partial class Qpapertask
    {
        [Key]
        public int Id { get; set; }
        public int? ClassId { get; set; }
        public int? SectionId { get; set; }
        public int? ExamId { get; set; }
        public int? FacultyId { get; set; }
        public int? SubjectId { get; set; }
        public bool? QuePaper { get; set; }
        public bool? AnsSheet { get; set; }
        [Column("QPSubmissionDate", TypeName = "date")]
        public DateTime? QpsubmissionDate { get; set; }
        [Column("ASSubmissionDate", TypeName = "date")]
        public DateTime? AssubmissionDate { get; set; }
        [Column("QPSubmittedDate", TypeName = "date")]
        public DateTime? QpsubmittedDate { get; set; }
        [Column("ASSubmittedDate", TypeName = "date")]
        public DateTime? AssubmittedDate { get; set; }
        public int? SessionId { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Qpapertasks")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Qpapertasks")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Qpapertasks")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Qpapertasks")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Qpapertasks")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Qpapertasks))]
        public virtual Businessunit Unit { get; set; }
    }
}
