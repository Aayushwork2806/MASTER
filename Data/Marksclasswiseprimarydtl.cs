using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksclasswiseprimarydtl")]
    [Index(nameof(MarksClassWisePrimaryId), Name = "FK_MarksClassWisePrimaryDtl_MarksClassWisePrimary")]
    [Index(nameof(SubTypeId), Name = "FK_MarksClassWisePrimaryDtl_Masters")]
    [Index(nameof(SubjectId), Name = "FK_MarksClassWisePrimaryDtl_Subject")]
    public partial class Marksclasswiseprimarydtl
    {
        [Key]
        public int Id { get; set; }
        public int MarksClassWisePrimaryId { get; set; }
        public int SubjectId { get; set; }
        public int SubTypeId { get; set; }
        public double? MaxMarks { get; set; }
        public double? ObtainedMarks { get; set; }
        [StringLength(1)]
        public string AddMarks { get; set; }
        public int? SubjectRank { get; set; }
        public int? SubClassRank { get; set; }
        public int? SubClassSecRank { get; set; }
        [StringLength(5)]
        public string SubGrade { get; set; }
        [StringLength(5)]
        public string NonAcGrade { get; set; }
        public short? Seq { get; set; }
        [StringLength(4)]
        public string Status { get; set; }
        [StringLength(15)]
        public string ResultStatus { get; set; }
        public bool? Submitted { get; set; }
        public int? UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LastUpdate { get; set; }
        public bool? Distinction { get; set; }
        public bool? Supplementary { get; set; }
        public bool? Grace { get; set; }
        public double? GraceMarks { get; set; }

        [ForeignKey(nameof(MarksClassWisePrimaryId))]
        [InverseProperty(nameof(Marksclasswiseprimary.Marksclasswiseprimarydtls))]
        public virtual Marksclasswiseprimary MarksClassWisePrimary { get; set; }
        [ForeignKey(nameof(SubTypeId))]
        [InverseProperty(nameof(Master.Marksclasswiseprimarydtls))]
        public virtual Master SubType { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Marksclasswiseprimarydtls")]
        public virtual Subject Subject { get; set; }
    }
}
