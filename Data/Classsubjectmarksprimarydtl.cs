using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classsubjectmarksprimarydtl")]
    [Index(nameof(ClassSubMarksPrimaryId), Name = "FK_ClassSubjectMarksPrimaryDtl_ClassSubjectMarksPrimary")]
    [Index(nameof(SubTypeId), Name = "FK_ClassSubjectMarksPrimaryDtl_Masters")]
    [Index(nameof(SubjectId), Name = "FK_ClassSubjectMarksPrimaryDtl_Subject")]
    public partial class Classsubjectmarksprimarydtl
    {
        [Key]
        public int Id { get; set; }
        public int ClassSubMarksPrimaryId { get; set; }
        public int SubjectId { get; set; }
        public int SubTypeId { get; set; }
        public double? MaxMarks { get; set; }
        [StringLength(1)]
        public string AddMarks { get; set; }
        public short? Seq { get; set; }
        [StringLength(1)]
        public string IsPrint { get; set; }
        public bool? IsAdd { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExamDate { get; set; }

        [ForeignKey(nameof(ClassSubMarksPrimaryId))]
        [InverseProperty(nameof(Classsubjectmarksprimary.Classsubjectmarksprimarydtls))]
        public virtual Classsubjectmarksprimary ClassSubMarksPrimary { get; set; }
        [ForeignKey(nameof(SubTypeId))]
        [InverseProperty(nameof(Master.Classsubjectmarksprimarydtls))]
        public virtual Master SubType { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Classsubjectmarksprimarydtls")]
        public virtual Subject Subject { get; set; }
    }
}
