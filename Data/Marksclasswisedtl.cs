using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksclasswisedtl")]
    [Index(nameof(MarksClassId), Name = "FK_MarksClassWiseDtl_MarksClassWise")]
    [Index(nameof(SubjectId), Name = "FK_MarksClassWiseDtl_Subject")]
    public partial class Marksclasswisedtl
    {
        [Key]
        public int Id { get; set; }
        public int MarksClassId { get; set; }
        public int SubjectId { get; set; }
        public double? Type1 { get; set; }
        public double? Type2 { get; set; }
        public double? Type3 { get; set; }
        public double? Type4 { get; set; }
        public double? SubjectTotal { get; set; }
        public double? GraceMarks { get; set; }
        [StringLength(4)]
        public string Status { get; set; }
        public int? SubjectRank { get; set; }
        public int? SubClassRank { get; set; }
        public int? SubClassSecRank { get; set; }
        [StringLength(5)]
        public string SubGrade { get; set; }
        [StringLength(5)]
        public string NonAcGrade { get; set; }
        [StringLength(30)]
        public string Remark { get; set; }
        public bool? Submitted { get; set; }
        public int? UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey(nameof(MarksClassId))]
        [InverseProperty(nameof(Marksclasswise.Marksclasswisedtls))]
        public virtual Marksclasswise MarksClass { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Marksclasswisedtls")]
        public virtual Subject Subject { get; set; }
    }
}
