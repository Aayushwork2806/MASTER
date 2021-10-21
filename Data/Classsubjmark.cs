using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classsubjmarks")]
    [Index(nameof(UnitId), Name = "FK_ClassSubjMarks_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassSubjMarks_Class")]
    [Index(nameof(ExamId), Name = "FK_ClassSubjMarks_Exam")]
    [Index(nameof(SubjectGroupId), Name = "FK_ClassSubjMarks_Masters")]
    [Index(nameof(SessionId), Name = "FK_ClassSubjMarks_Session")]
    public partial class Classsubjmark
    {
        public Classsubjmark()
        {
            Classsubjmarksdtls = new HashSet<Classsubjmarksdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public int SubjectGroupId { get; set; }
        public double TotalMarks { get; set; }
        public double PassPer { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }
        [Column("QPaperSubDate", TypeName = "date")]
        public DateTime? QpaperSubDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AnsSheetSubDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExamCompletion { get; set; }
        [Column(TypeName = "date")]
        public DateTime? MrksEntryCompletion { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classsubjmarks")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Classsubjmarks")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classsubjmarks")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectGroupId))]
        [InverseProperty(nameof(Master.Classsubjmarks))]
        public virtual Master SubjectGroup { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classsubjmarks))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Classsubjmarksdtl.ClassSubMarks))]
        public virtual ICollection<Classsubjmarksdtl> Classsubjmarksdtls { get; set; }
    }
}
