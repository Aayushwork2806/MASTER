using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("results")]
    [Index(nameof(UnitId), Name = "FK_Results_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_Results_Class")]
    [Index(nameof(ProClassId), Name = "FK_Results_Class1")]
    [Index(nameof(ExamId), Name = "FK_Results_Exam")]
    [Index(nameof(GradeId), Name = "FK_Results_GradeDtl")]
    [Index(nameof(ScholarId), Name = "FK_Results_Scholar")]
    [Index(nameof(ProSectionId), Name = "FK_Results_Section")]
    [Index(nameof(SessionId), Name = "FK_Results_Session")]
    public partial class Result
    {
        public Result()
        {
            Resultsdetails = new HashSet<Resultsdetail>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public int ScholarId { get; set; }
        public double MaxMarks { get; set; }
        public double ObtMarks { get; set; }
        public int? GradeId { get; set; }
        public double? GraceMarks { get; set; }
        [Column("Result")]
        [StringLength(20)]
        public string Result1 { get; set; }
        public double? Percentage { get; set; }
        public int? Seq { get; set; }
        public int? SupplementarySubjects { get; set; }
        public int? ClassRank { get; set; }
        public int? SectionRank { get; set; }
        public int? PresentDays { get; set; }
        public int? TotalDays { get; set; }
        [StringLength(200)]
        public string Remark { get; set; }
        public int? RemarkId { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public int UnitId { get; set; }
        public int? GradePoint { get; set; }
        [Column("ASL")]
        [StringLength(8)]
        public string Asl { get; set; }
        [StringLength(1)]
        public string Promoted { get; set; }
        public int? ProClassId { get; set; }
        public int? ProSectionId { get; set; }
        [StringLength(50)]
        public string LastResult { get; set; }
        public double? LastTotMaxMarks { get; set; }
        public double? LastTotObtMarks { get; set; }
        public double? LastPercentage { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("ResultClasses")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Results")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(GradeId))]
        [InverseProperty(nameof(Gradedtl.Results))]
        public virtual Gradedtl Grade { get; set; }
        [ForeignKey(nameof(ProClassId))]
        [InverseProperty("ResultProClasses")]
        public virtual Class ProClass { get; set; }
        [ForeignKey(nameof(ProSectionId))]
        [InverseProperty(nameof(Section.Results))]
        public virtual Section ProSection { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Results")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Results")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Results))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Resultsdetail.Results))]
        public virtual ICollection<Resultsdetail> Resultsdetails { get; set; }
    }
}
