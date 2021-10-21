using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("assessmentcalpolicydtl")]
    [Index(nameof(AssessmentCalPolicyId), Name = "FK_AssessmentCalPolicyDtl_AssessmentCalPolicy")]
    [Index(nameof(ExamId), Name = "FK_AssessmentCalPolicyDtl_Exam")]
    public partial class Assessmentcalpolicydtl
    {
        [Key]
        public int Id { get; set; }
        public int AssessmentCalPolicyId { get; set; }
        public int ExamId { get; set; }
        public double? AddPerc { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(AssessmentCalPolicyId))]
        [InverseProperty(nameof(Assessmentcalpolicy.Assessmentcalpolicydtls))]
        public virtual Assessmentcalpolicy AssessmentCalPolicy { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Assessmentcalpolicydtls")]
        public virtual Exam Exam { get; set; }
    }
}
