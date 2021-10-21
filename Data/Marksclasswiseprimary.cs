using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksclasswiseprimary")]
    [Index(nameof(ClassId), Name = "FK_MarksClassWisePrimary_Class")]
    [Index(nameof(ExamId), Name = "FK_MarksClassWisePrimary_Exam")]
    [Index(nameof(RemarkId1), Name = "FK_MarksClassWisePrimary_Masters1")]
    [Index(nameof(RemarkId2), Name = "FK_MarksClassWisePrimary_Masters2")]
    [Index(nameof(ScholarId), Name = "FK_MarksClassWisePrimary_Scholar")]
    [Index(nameof(SectionId), Name = "FK_MarksClassWisePrimary_Section")]
    [Index(nameof(SessionId), Name = "FK_MarksClassWisePrimary_Session")]
    public partial class Marksclasswiseprimary
    {
        public Marksclasswiseprimary()
        {
            Marksclasswiseprimarydtls = new HashSet<Marksclasswiseprimarydtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int ScholarId { get; set; }
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

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Marksclasswiseprimaries")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Marksclasswiseprimaries")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(RemarkId1))]
        [InverseProperty(nameof(Master.MarksclasswiseprimaryRemarkId1Navigations))]
        public virtual Master RemarkId1Navigation { get; set; }
        [ForeignKey(nameof(RemarkId2))]
        [InverseProperty(nameof(Master.MarksclasswiseprimaryRemarkId2Navigations))]
        public virtual Master RemarkId2Navigation { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Marksclasswiseprimaries")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Marksclasswiseprimaries")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Marksclasswiseprimaries")]
        public virtual Session Session { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimarydtl.MarksClassWisePrimary))]
        public virtual ICollection<Marksclasswiseprimarydtl> Marksclasswiseprimarydtls { get; set; }
    }
}
