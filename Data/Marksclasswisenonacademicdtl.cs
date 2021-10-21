using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksclasswisenonacademicdtl")]
    [Index(nameof(MarksNonAcademicClassId), Name = "FK_MarksClassWiseNonAcademicDtl_MarksClassWiseNonAcademic")]
    [Index(nameof(SubjectId), Name = "FK_MarksClassWiseNonAcademicDtl_Subject")]
    public partial class Marksclasswisenonacademicdtl
    {
        [Key]
        public int Id { get; set; }
        public int MarksNonAcademicClassId { get; set; }
        public int SubjectId { get; set; }
        [StringLength(4)]
        public string Grade { get; set; }
        [StringLength(4)]
        public string Status { get; set; }

        [ForeignKey(nameof(MarksNonAcademicClassId))]
        [InverseProperty(nameof(Marksclasswisenonacademic.Marksclasswisenonacademicdtls))]
        public virtual Marksclasswisenonacademic MarksNonAcademicClass { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Marksclasswisenonacademicdtls")]
        public virtual Subject Subject { get; set; }
    }
}
