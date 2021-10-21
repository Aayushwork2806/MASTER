using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("exam")]
    [Index(nameof(UnitId), Name = "FK_Exam_BusinessUnits")]
    public partial class Exam
    {
        public Exam()
        {
            Assessmentcalpolicies = new HashSet<Assessmentcalpolicy>();
            Assessmentcalpolicydtls = new HashSet<Assessmentcalpolicydtl>();
            Classexams = new HashSet<Classexam>();
            Classsubjectmarksprimaries = new HashSet<Classsubjectmarksprimary>();
            Classsubjmarks = new HashSet<Classsubjmark>();
            Markscceskills = new HashSet<Markscceskill>();
            Marksclasswisenonacademics = new HashSet<Marksclasswisenonacademic>();
            Marksclasswiseprimaries = new HashSet<Marksclasswiseprimary>();
            Marksclasswises = new HashSet<Marksclasswise>();
            MarksheetdtlExamId10Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId11Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId12Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId1Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId2Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId3Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId4Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId5Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId6Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId7Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId8Navigations = new HashSet<Marksheetdtl>();
            MarksheetdtlExamId9Navigations = new HashSet<Marksheetdtl>();
            Marksheetprintpolicydtls = new HashSet<Marksheetprintpolicydtl>();
            Qpapertasks = new HashSet<Qpapertask>();
            Results = new HashSet<Result>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string ExamTitle { get; set; }
        [StringLength(10)]
        public string ExamCode { get; set; }
        public bool Assessment { get; set; }
        public short Printseq { get; set; }
        [Column("CCEApplicable")]
        public bool Cceapplicable { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Exams))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Assessmentcalpolicy.AssesExam))]
        public virtual ICollection<Assessmentcalpolicy> Assessmentcalpolicies { get; set; }
        [InverseProperty(nameof(Assessmentcalpolicydtl.Exam))]
        public virtual ICollection<Assessmentcalpolicydtl> Assessmentcalpolicydtls { get; set; }
        [InverseProperty(nameof(Classexam.Exam))]
        public virtual ICollection<Classexam> Classexams { get; set; }
        [InverseProperty(nameof(Classsubjectmarksprimary.Exam))]
        public virtual ICollection<Classsubjectmarksprimary> Classsubjectmarksprimaries { get; set; }
        [InverseProperty(nameof(Classsubjmark.Exam))]
        public virtual ICollection<Classsubjmark> Classsubjmarks { get; set; }
        [InverseProperty(nameof(Markscceskill.Exam))]
        public virtual ICollection<Markscceskill> Markscceskills { get; set; }
        [InverseProperty(nameof(Marksclasswisenonacademic.Exam))]
        public virtual ICollection<Marksclasswisenonacademic> Marksclasswisenonacademics { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimary.Exam))]
        public virtual ICollection<Marksclasswiseprimary> Marksclasswiseprimaries { get; set; }
        [InverseProperty(nameof(Marksclasswise.Exam))]
        public virtual ICollection<Marksclasswise> Marksclasswises { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId10Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId10Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId11Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId11Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId12Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId12Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId1Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId1Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId2Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId2Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId3Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId3Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId4Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId4Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId5Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId5Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId6Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId6Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId7Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId7Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId8Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId8Navigations { get; set; }
        [InverseProperty(nameof(Marksheetdtl.ExamId9Navigation))]
        public virtual ICollection<Marksheetdtl> MarksheetdtlExamId9Navigations { get; set; }
        [InverseProperty(nameof(Marksheetprintpolicydtl.Exam))]
        public virtual ICollection<Marksheetprintpolicydtl> Marksheetprintpolicydtls { get; set; }
        [InverseProperty(nameof(Qpapertask.Exam))]
        public virtual ICollection<Qpapertask> Qpapertasks { get; set; }
        [InverseProperty(nameof(Result.Exam))]
        public virtual ICollection<Result> Results { get; set; }
    }
}
