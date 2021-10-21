using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksclasswisenonacademic")]
    [Index(nameof(UnitId), Name = "FK_MarksClassWiseNonAcademic_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_MarksClassWiseNonAcademic_Class")]
    [Index(nameof(ExamId), Name = "FK_MarksClassWiseNonAcademic_Exam")]
    [Index(nameof(ScholarId), Name = "FK_MarksClassWiseNonAcademic_Scholar")]
    [Index(nameof(SectionId), Name = "FK_MarksClassWiseNonAcademic_Section")]
    [Index(nameof(SessionId), Name = "FK_MarksClassWiseNonAcademic_Session")]
    public partial class Marksclasswisenonacademic
    {
        public Marksclasswisenonacademic()
        {
            Marksclasswisenonacademicdtls = new HashSet<Marksclasswisenonacademicdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int ScholarId { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Marksclasswisenonacademics")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Marksclasswisenonacademics")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Marksclasswisenonacademics")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Marksclasswisenonacademics")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Marksclasswisenonacademics")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Marksclasswisenonacademics))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Marksclasswisenonacademicdtl.MarksNonAcademicClass))]
        public virtual ICollection<Marksclasswisenonacademicdtl> Marksclasswisenonacademicdtls { get; set; }
    }
}
