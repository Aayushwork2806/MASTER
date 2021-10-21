using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classsubjmarksdtl")]
    [Index(nameof(ClassSubMarksId), Name = "FK_ClassSubjMarksDtl_ClassSubjMarks")]
    [Index(nameof(SubjectId), Name = "FK_ClassSubjMarksDtl_Subject")]
    public partial class Classsubjmarksdtl
    {
        [Key]
        public int Id { get; set; }
        public int ClassSubMarksId { get; set; }
        public int SubjectId { get; set; }
        public double? MaxMarks { get; set; }
        [StringLength(1)]
        public string AddMarks { get; set; }
        public double? Type1 { get; set; }
        [StringLength(1)]
        public string AddType1 { get; set; }
        public double? Type2 { get; set; }
        [StringLength(1)]
        public string AddType2 { get; set; }
        public double? Type3 { get; set; }
        [StringLength(1)]
        public string AddType3 { get; set; }
        public double? Type4 { get; set; }
        [StringLength(1)]
        public string AddType4 { get; set; }
        public short? Seq { get; set; }
        [StringLength(50)]
        public string IsPrint { get; set; }
        public bool? IsAdd { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExamDate { get; set; }
        public double? Weightage { get; set; }

        [ForeignKey(nameof(ClassSubMarksId))]
        [InverseProperty(nameof(Classsubjmark.Classsubjmarksdtls))]
        public virtual Classsubjmark ClassSubMarks { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Classsubjmarksdtls")]
        public virtual Subject Subject { get; set; }
    }
}
