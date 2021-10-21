using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("resultsdetails")]
    [Index(nameof(SubjectGradeId), Name = "FK_ResultsDetails_GradeDtl")]
    [Index(nameof(Type1GradeId), Name = "FK_ResultsDetails_GradeDtl1")]
    [Index(nameof(Type2GradeId), Name = "FK_ResultsDetails_GradeDtl2")]
    [Index(nameof(Type3GradeId), Name = "FK_ResultsDetails_GradeDtl3")]
    [Index(nameof(Type4GradeId), Name = "FK_ResultsDetails_GradeDtl4")]
    [Index(nameof(ResultsId), Name = "FK_ResultsDetails_Results")]
    [Index(nameof(SubjectId), Name = "FK_ResultsDetails_Subject")]
    public partial class Resultsdetail
    {
        [Key]
        public int Id { get; set; }
        public int ResultsId { get; set; }
        public int SubjectId { get; set; }
        public double? Type1Marks { get; set; }
        public double? Type2Marks { get; set; }
        public double? Type3Marks { get; set; }
        public double? Type4Marks { get; set; }
        public int? Type1GradeId { get; set; }
        public int? Type2GradeId { get; set; }
        public int? Type3GradeId { get; set; }
        public int? Type4GradeId { get; set; }
        [StringLength(1)]
        public string AddMarks { get; set; }
        [StringLength(1)]
        public string IsPrint { get; set; }
        public double? MaxMarks { get; set; }
        public double? SubjectTotal { get; set; }
        [StringLength(4)]
        public string Grade { get; set; }
        public int? SubjectGradeId { get; set; }
        public int? SubjectRank { get; set; }
        public bool? Distinction { get; set; }
        public bool? Supplementary { get; set; }
        public bool? Grace { get; set; }
        public double? GraceMarks { get; set; }
        [StringLength(1)]
        public string AttendanceStatus { get; set; }
        public double? Lowest { get; set; }
        public double? Highest { get; set; }
        [StringLength(15)]
        public string ResultStatus { get; set; }
        public double? Type1MaxMarks { get; set; }
        public double? Type2MaxMarks { get; set; }
        public double? Type3MaxMarks { get; set; }
        public double? Type4MaxMarks { get; set; }
        public bool? GradeUpgrade { get; set; }
        public double? Weightage { get; set; }
        public double? WeightageMarks { get; set; }
        public double? LastMaxMarks { get; set; }
        public double? LastObtMarks { get; set; }
        [StringLength(50)]
        public string LastSubResult { get; set; }

        [ForeignKey(nameof(ResultsId))]
        [InverseProperty(nameof(Result.Resultsdetails))]
        public virtual Result Results { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Resultsdetails")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(SubjectGradeId))]
        [InverseProperty(nameof(Gradedtl.ResultsdetailSubjectGrades))]
        public virtual Gradedtl SubjectGrade { get; set; }
        [ForeignKey(nameof(Type1GradeId))]
        [InverseProperty(nameof(Gradedtl.ResultsdetailType1Grades))]
        public virtual Gradedtl Type1Grade { get; set; }
        [ForeignKey(nameof(Type2GradeId))]
        [InverseProperty(nameof(Gradedtl.ResultsdetailType2Grades))]
        public virtual Gradedtl Type2Grade { get; set; }
        [ForeignKey(nameof(Type3GradeId))]
        [InverseProperty(nameof(Gradedtl.ResultsdetailType3Grades))]
        public virtual Gradedtl Type3Grade { get; set; }
        [ForeignKey(nameof(Type4GradeId))]
        [InverseProperty(nameof(Gradedtl.ResultsdetailType4Grades))]
        public virtual Gradedtl Type4Grade { get; set; }
    }
}
