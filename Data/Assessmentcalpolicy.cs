using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("assessmentcalpolicy")]
    [Index(nameof(UnitId), Name = "FK_AssessmentCalPolicy_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_AssessmentCalPolicy_Class")]
    [Index(nameof(AssesExamId), Name = "FK_AssessmentCalPolicy_Exam")]
    [Index(nameof(SessionId), Name = "FK_AssessmentCalPolicy_Session")]
    public partial class Assessmentcalpolicy
    {
        public Assessmentcalpolicy()
        {
            Assessmentcalpolicydtls = new HashSet<Assessmentcalpolicydtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int AssesExamId { get; set; }
        public int ClassId { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }
        public bool? GroupWise { get; set; }

        [ForeignKey(nameof(AssesExamId))]
        [InverseProperty(nameof(Exam.Assessmentcalpolicies))]
        public virtual Exam AssesExam { get; set; }
        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Assessmentcalpolicies")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Assessmentcalpolicies")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Assessmentcalpolicies))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Assessmentcalpolicydtl.AssessmentCalPolicy))]
        public virtual ICollection<Assessmentcalpolicydtl> Assessmentcalpolicydtls { get; set; }
    }
}
