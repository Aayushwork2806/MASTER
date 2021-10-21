using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("markscceskills")]
    [Index(nameof(UnitId), Name = "FK_MarksCCESkills_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_MarksCCESkills_Class")]
    [Index(nameof(ExamId), Name = "FK_MarksCCESkills_Exam")]
    [Index(nameof(ScholarId), Name = "FK_MarksCCESkills_Scholar")]
    [Index(nameof(SessionId), Name = "FK_MarksCCESkills_Session")]
    public partial class Markscceskill
    {
        public Markscceskill()
        {
            Markscceskillsdtls = new HashSet<Markscceskillsdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int SessionId { get; set; }
        public int ScholarId { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Markscceskills")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Markscceskills")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Markscceskills")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Markscceskills")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Markscceskills))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Markscceskillsdtl.Cceskills))]
        public virtual ICollection<Markscceskillsdtl> Markscceskillsdtls { get; set; }
    }
}
