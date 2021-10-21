using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classwiseskills")]
    [Index(nameof(UnitId), Name = "FK_ClassWiseSkills_BusinessUnits")]
    [Index(nameof(SkillId), Name = "FK_ClassWiseSkills_CCEDescriptiveSkills")]
    [Index(nameof(ClassId), Name = "FK_ClassWiseSkills_Class")]
    [Index(nameof(SessionId), Name = "FK_ClassWiseSkills_Session")]
    public partial class Classwiseskill
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ClassId { get; set; }
        public int SkillId { get; set; }
        public int SeqNo { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classwiseskills")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classwiseskills")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SkillId))]
        [InverseProperty(nameof(Ccedescriptiveskill.Classwiseskills))]
        public virtual Ccedescriptiveskill Skill { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classwiseskills))]
        public virtual Businessunit Unit { get; set; }
    }
}
