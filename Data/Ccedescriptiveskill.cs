using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("ccedescriptiveskills")]
    [Index(nameof(UnitId), Name = "FK_CCEDescriptiveSkills_BusinessUnits")]
    [Index(nameof(SkillGroupId), Name = "FK_CCEDescriptiveSkills_CCESkillsGroup")]
    [Index(nameof(SessionId), Name = "FK_CCEDescriptiveSkills_Session")]
    public partial class Ccedescriptiveskill
    {
        public Ccedescriptiveskill()
        {
            Ccedescriptiveindicators = new HashSet<Ccedescriptiveindicator>();
            Classwiseskills = new HashSet<Classwiseskill>();
            Markscceskillsdtls = new HashSet<Markscceskillsdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int SkillGroupId { get; set; }
        [Required]
        [StringLength(50)]
        public string SkillHeading { get; set; }
        [StringLength(10)]
        public string ShortName { get; set; }
        public int Seq { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Ccedescriptiveskills")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SkillGroupId))]
        [InverseProperty(nameof(Cceskillsgroup.Ccedescriptiveskills))]
        public virtual Cceskillsgroup SkillGroup { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Ccedescriptiveskills))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Ccedescriptiveindicator.Skill))]
        public virtual ICollection<Ccedescriptiveindicator> Ccedescriptiveindicators { get; set; }
        [InverseProperty(nameof(Classwiseskill.Skill))]
        public virtual ICollection<Classwiseskill> Classwiseskills { get; set; }
        [InverseProperty(nameof(Markscceskillsdtl.SkillSubGroup))]
        public virtual ICollection<Markscceskillsdtl> Markscceskillsdtls { get; set; }
    }
}
