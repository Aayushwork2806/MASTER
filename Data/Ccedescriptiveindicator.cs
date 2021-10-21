using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("ccedescriptiveindicator")]
    [Index(nameof(UnitId), Name = "FK_CCEDescriptiveIndicator_BusinessUnits")]
    [Index(nameof(SkillId), Name = "FK_CCEDescriptiveIndicator_CCEDescriptiveSkills")]
    [Index(nameof(SessionId), Name = "FK_CCEDescriptiveIndicator_Session")]
    public partial class Ccedescriptiveindicator
    {
        public Ccedescriptiveindicator()
        {
            Markscceskillsdtls = new HashSet<Markscceskillsdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int SkillId { get; set; }
        public int IndicatorNo { get; set; }
        [Required]
        [StringLength(1500)]
        public string IndicatorDesc { get; set; }
        [Required]
        [StringLength(4)]
        public string Grade { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Ccedescriptiveindicators")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SkillId))]
        [InverseProperty(nameof(Ccedescriptiveskill.Ccedescriptiveindicators))]
        public virtual Ccedescriptiveskill Skill { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Ccedescriptiveindicators))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Markscceskillsdtl.Indicator))]
        public virtual ICollection<Markscceskillsdtl> Markscceskillsdtls { get; set; }
    }
}
