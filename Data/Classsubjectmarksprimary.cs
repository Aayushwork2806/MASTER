using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classsubjectmarksprimary")]
    [Index(nameof(ClassId), Name = "FK_ClassSubjectMarksPrimary_Class")]
    [Index(nameof(ExamId), Name = "FK_ClassSubjectMarksPrimary_Exam")]
    [Index(nameof(SubjectGroupId), Name = "FK_ClassSubjectMarksPrimary_Masters")]
    [Index(nameof(SessionId), Name = "FK_ClassSubjectMarksPrimary_Session")]
    public partial class Classsubjectmarksprimary
    {
        public Classsubjectmarksprimary()
        {
            Classsubjectmarksprimarydtls = new HashSet<Classsubjectmarksprimarydtl>();
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
        [InverseProperty("Classsubjectmarksprimaries")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Classsubjectmarksprimaries")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classsubjectmarksprimaries")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectGroupId))]
        [InverseProperty(nameof(Master.Classsubjectmarksprimaries))]
        public virtual Master SubjectGroup { get; set; }
        [InverseProperty(nameof(Classsubjectmarksprimarydtl.ClassSubMarksPrimary))]
        public virtual ICollection<Classsubjectmarksprimarydtl> Classsubjectmarksprimarydtls { get; set; }
    }
}
