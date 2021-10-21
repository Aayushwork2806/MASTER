using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksclasswise")]
    [Index(nameof(UnitId), Name = "FK_MarksClassWise_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_MarksClassWise_Class")]
    [Index(nameof(ExamId), Name = "FK_MarksClassWise_Exam")]
    [Index(nameof(SubjectGroupId), Name = "FK_MarksClassWise_Masters")]
    [Index(nameof(RemarkId1), Name = "FK_MarksClassWise_Masters1")]
    [Index(nameof(RemarkId2), Name = "FK_MarksClassWise_Masters2")]
    [Index(nameof(ScholarId), Name = "FK_MarksClassWise_Scholar")]
    [Index(nameof(SessionId), Name = "FK_MarksClassWise_Session")]
    public partial class Marksclasswise
    {
        public Marksclasswise()
        {
            Marksclasswisedtls = new HashSet<Marksclasswisedtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int ScholarId { get; set; }
        public int SubjectGroupId { get; set; }
        public int? PresentDays { get; set; }
        public int? TotalDays { get; set; }
        public double? MaxMarks { get; set; }
        public double? ObtMarks { get; set; }
        public double? Percentage { get; set; }
        [StringLength(15)]
        public string Result { get; set; }
        [StringLength(8)]
        public string Grade { get; set; }
        public int? ExamRank { get; set; }
        public int? ClassRank { get; set; }
        public int? SectionRank { get; set; }
        public double? TotGraceMarks { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public int UnitId { get; set; }
        public int? RemarkId1 { get; set; }
        public int? RemarkId2 { get; set; }
        [Column("ASL")]
        [StringLength(8)]
        public string Asl { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Marksclasswises")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Marksclasswises")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(RemarkId1))]
        [InverseProperty(nameof(Master.MarksclasswiseRemarkId1Navigations))]
        public virtual Master RemarkId1Navigation { get; set; }
        [ForeignKey(nameof(RemarkId2))]
        [InverseProperty(nameof(Master.MarksclasswiseRemarkId2Navigations))]
        public virtual Master RemarkId2Navigation { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Marksclasswises")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Marksclasswises")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectGroupId))]
        [InverseProperty(nameof(Master.MarksclasswiseSubjectGroups))]
        public virtual Master SubjectGroup { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Marksclasswises))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Marksclasswisedtl.MarksClass))]
        public virtual ICollection<Marksclasswisedtl> Marksclasswisedtls { get; set; }
    }
}
