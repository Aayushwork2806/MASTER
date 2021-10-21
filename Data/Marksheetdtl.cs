using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksheetdtl")]
    [Index(nameof(ExamId1), Name = "FK_MarkSheetDtl_Exam")]
    [Index(nameof(ExamId2), Name = "FK_MarkSheetDtl_Exam1")]
    [Index(nameof(ExamId11), Name = "FK_MarkSheetDtl_Exam10")]
    [Index(nameof(ExamId12), Name = "FK_MarkSheetDtl_Exam11")]
    [Index(nameof(ExamId3), Name = "FK_MarkSheetDtl_Exam2")]
    [Index(nameof(ExamId4), Name = "FK_MarkSheetDtl_Exam3")]
    [Index(nameof(ExamId5), Name = "FK_MarkSheetDtl_Exam4")]
    [Index(nameof(ExamId6), Name = "FK_MarkSheetDtl_Exam5")]
    [Index(nameof(ExamId7), Name = "FK_MarkSheetDtl_Exam6")]
    [Index(nameof(ExamId8), Name = "FK_MarkSheetDtl_Exam7")]
    [Index(nameof(ExamId9), Name = "FK_MarkSheetDtl_Exam8")]
    [Index(nameof(ExamId10), Name = "FK_MarkSheetDtl_Exam9")]
    [Index(nameof(MarkSheetId), Name = "FK_MarkSheetDtl_MarkSheet")]
    [Index(nameof(SubjectId), Name = "FK_MarkSheetDtl_Subject")]
    public partial class Marksheetdtl
    {
        [Key]
        public int Id { get; set; }
        public int MarkSheetId { get; set; }
        public int SubjectId { get; set; }
        public short? SubjectRank { get; set; }
        public int? ExamId1 { get; set; }
        public double? MaxMarks1 { get; set; }
        public double? ObtMarks1 { get; set; }
        [StringLength(5)]
        public string Grade1 { get; set; }
        public int? ExamId2 { get; set; }
        public double? MaxMarks2 { get; set; }
        public double? ObtMarks2 { get; set; }
        [StringLength(5)]
        public string Grade2 { get; set; }
        public int? ExamId3 { get; set; }
        public double? MaxMarks3 { get; set; }
        public double? ObtMarks3 { get; set; }
        [StringLength(5)]
        public string Grade3 { get; set; }
        public int? ExamId4 { get; set; }
        public double? MaxMarks4 { get; set; }
        public double? ObtMarks4 { get; set; }
        [StringLength(5)]
        public string Grade4 { get; set; }
        public int? ExamId5 { get; set; }
        public double? MaxMarks5 { get; set; }
        public double? ObtMarks5 { get; set; }
        [StringLength(5)]
        public string Grade5 { get; set; }
        public int? ExamId6 { get; set; }
        public double? MaxMarks6 { get; set; }
        public double? ObtMarks6 { get; set; }
        [StringLength(5)]
        public string Grade6 { get; set; }
        public int? ExamId7 { get; set; }
        public double? MaxMarks7 { get; set; }
        public double? ObtMarks7 { get; set; }
        [StringLength(5)]
        public string Grade7 { get; set; }
        public int? ExamId8 { get; set; }
        public double? MaxMarks8 { get; set; }
        public double? ObtMarks8 { get; set; }
        [StringLength(5)]
        public string Grade8 { get; set; }
        public int? ExamId9 { get; set; }
        public double? MaxMarks9 { get; set; }
        public double? ObtMarks9 { get; set; }
        [StringLength(5)]
        public string Grade9 { get; set; }
        public int? ExamId10 { get; set; }
        public double? MaxMarks10 { get; set; }
        public double? ObtMarks10 { get; set; }
        [StringLength(5)]
        public string Grade10 { get; set; }
        public double? Type1MaxMarks { get; set; }
        public double? Type1ObtMarks { get; set; }
        public double? Type2MaxMarks { get; set; }
        public double? Type2ObtMarks { get; set; }
        public double? Type3MaxMarks { get; set; }
        public double? Type3ObtMarks { get; set; }
        public double? Type4MaxMarks { get; set; }
        public double? Type4ObtMarks { get; set; }
        public double? ClassHighest { get; set; }
        public int? ExamId11 { get; set; }
        public double? MaxMarks11 { get; set; }
        public double? ObtMarks11 { get; set; }
        [StringLength(5)]
        public string Grade11 { get; set; }
        public int? ExamId12 { get; set; }
        public double? MaxMarks12 { get; set; }
        public double? ObtMarks12 { get; set; }
        [StringLength(5)]
        public string Grade12 { get; set; }
        public int? GradePoint1 { get; set; }
        public int? GradePoint2 { get; set; }
        public int? GradePoint3 { get; set; }
        public int? GradePoint4 { get; set; }
        public int? GradePoint5 { get; set; }
        public int? GradePoint6 { get; set; }
        public int? GradePoint7 { get; set; }
        public int? GradePoint8 { get; set; }
        public int? GradePoint9 { get; set; }
        public int? GradePoint10 { get; set; }
        public int? GradePoint11 { get; set; }
        public int? GradePoint12 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus1 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus2 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus3 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus4 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus5 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus6 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus7 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus8 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus9 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus10 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus11 { get; set; }
        [StringLength(1)]
        public string AttendanceStatus12 { get; set; }
        public bool? GradeUpgrade { get; set; }

        [ForeignKey(nameof(ExamId10))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId10Navigations))]
        public virtual Exam ExamId10Navigation { get; set; }
        [ForeignKey(nameof(ExamId11))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId11Navigations))]
        public virtual Exam ExamId11Navigation { get; set; }
        [ForeignKey(nameof(ExamId12))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId12Navigations))]
        public virtual Exam ExamId12Navigation { get; set; }
        [ForeignKey(nameof(ExamId1))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId1Navigations))]
        public virtual Exam ExamId1Navigation { get; set; }
        [ForeignKey(nameof(ExamId2))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId2Navigations))]
        public virtual Exam ExamId2Navigation { get; set; }
        [ForeignKey(nameof(ExamId3))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId3Navigations))]
        public virtual Exam ExamId3Navigation { get; set; }
        [ForeignKey(nameof(ExamId4))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId4Navigations))]
        public virtual Exam ExamId4Navigation { get; set; }
        [ForeignKey(nameof(ExamId5))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId5Navigations))]
        public virtual Exam ExamId5Navigation { get; set; }
        [ForeignKey(nameof(ExamId6))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId6Navigations))]
        public virtual Exam ExamId6Navigation { get; set; }
        [ForeignKey(nameof(ExamId7))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId7Navigations))]
        public virtual Exam ExamId7Navigation { get; set; }
        [ForeignKey(nameof(ExamId8))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId8Navigations))]
        public virtual Exam ExamId8Navigation { get; set; }
        [ForeignKey(nameof(ExamId9))]
        [InverseProperty(nameof(Exam.MarksheetdtlExamId9Navigations))]
        public virtual Exam ExamId9Navigation { get; set; }
        [ForeignKey(nameof(MarkSheetId))]
        [InverseProperty(nameof(Marksheet.Marksheetdtls))]
        public virtual Marksheet MarkSheet { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Marksheetdtls")]
        public virtual Subject Subject { get; set; }
    }
}
