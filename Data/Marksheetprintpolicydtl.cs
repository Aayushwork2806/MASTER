using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksheetprintpolicydtl")]
    [Index(nameof(ExamId), Name = "FK_MarksheetPrintPolicyDtl_Exam")]
    [Index(nameof(MarkSheetPolicyId), Name = "FK_MarksheetPrintPolicyDtl_MarksheetPrintPolicy")]
    public partial class Marksheetprintpolicydtl
    {
        [Key]
        public int Id { get; set; }
        public int MarkSheetPolicyId { get; set; }
        public int ExamId { get; set; }
        [Required]
        [StringLength(40)]
        public string ExamTitle { get; set; }
        public bool IsDetailed { get; set; }
        public bool IsResult { get; set; }
        public bool Deleted { get; set; }
        public short PrintSeq { get; set; }

        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Marksheetprintpolicydtls")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(MarkSheetPolicyId))]
        [InverseProperty(nameof(Marksheetprintpolicy.Marksheetprintpolicydtls))]
        public virtual Marksheetprintpolicy MarkSheetPolicy { get; set; }
    }
}
