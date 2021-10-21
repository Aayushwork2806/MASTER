using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("gradedtl")]
    [Index(nameof(GradeId), Name = "FK_GradeDtl_Grade")]
    public partial class Gradedtl
    {
        public Gradedtl()
        {
            Results = new HashSet<Result>();
            ResultsdetailSubjectGrades = new HashSet<Resultsdetail>();
            ResultsdetailType1Grades = new HashSet<Resultsdetail>();
            ResultsdetailType2Grades = new HashSet<Resultsdetail>();
            ResultsdetailType3Grades = new HashSet<Resultsdetail>();
            ResultsdetailType4Grades = new HashSet<Resultsdetail>();
        }

        [Key]
        public int Id { get; set; }
        public int GradeId { get; set; }
        [Required]
        [StringLength(5)]
        public string Grade { get; set; }
        public double GradeFrom { get; set; }
        public double GradeTo { get; set; }
        public bool Deleted { get; set; }
        public int? GradePoint { get; set; }

        [ForeignKey(nameof(GradeId))]
        [InverseProperty("Gradedtls")]
        public virtual Grade GradeNavigation { get; set; }
        [InverseProperty(nameof(Result.Grade))]
        public virtual ICollection<Result> Results { get; set; }
        [InverseProperty(nameof(Resultsdetail.SubjectGrade))]
        public virtual ICollection<Resultsdetail> ResultsdetailSubjectGrades { get; set; }
        [InverseProperty(nameof(Resultsdetail.Type1Grade))]
        public virtual ICollection<Resultsdetail> ResultsdetailType1Grades { get; set; }
        [InverseProperty(nameof(Resultsdetail.Type2Grade))]
        public virtual ICollection<Resultsdetail> ResultsdetailType2Grades { get; set; }
        [InverseProperty(nameof(Resultsdetail.Type3Grade))]
        public virtual ICollection<Resultsdetail> ResultsdetailType3Grades { get; set; }
        [InverseProperty(nameof(Resultsdetail.Type4Grade))]
        public virtual ICollection<Resultsdetail> ResultsdetailType4Grades { get; set; }
    }
}
