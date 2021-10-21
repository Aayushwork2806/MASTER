using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("markscceskillsdtl")]
    [Index(nameof(IndicatorId), Name = "FK_MarksCCESkillsDtl_CCEDescriptiveIndicator")]
    [Index(nameof(SkillSubGroupId), Name = "FK_MarksCCESkillsDtl_CCEDescriptiveSkills")]
    [Index(nameof(SkillGroupId), Name = "FK_MarksCCESkillsDtl_CCESkillsGroup")]
    [Index(nameof(CceskillsId), Name = "FK_MarksCCESkillsDtl_MarksCCESkills")]
    public partial class Markscceskillsdtl
    {
        [Key]
        public int Id { get; set; }
        [Column("CCESkillsId")]
        public int CceskillsId { get; set; }
        public int SkillGroupId { get; set; }
        public int SkillSubGroupId { get; set; }
        public int IndicatorId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(CceskillsId))]
        [InverseProperty(nameof(Markscceskill.Markscceskillsdtls))]
        public virtual Markscceskill Cceskills { get; set; }
        [ForeignKey(nameof(IndicatorId))]
        [InverseProperty(nameof(Ccedescriptiveindicator.Markscceskillsdtls))]
        public virtual Ccedescriptiveindicator Indicator { get; set; }
        [ForeignKey(nameof(SkillGroupId))]
        [InverseProperty(nameof(Cceskillsgroup.Markscceskillsdtls))]
        public virtual Cceskillsgroup SkillGroup { get; set; }
        [ForeignKey(nameof(SkillSubGroupId))]
        [InverseProperty(nameof(Ccedescriptiveskill.Markscceskillsdtls))]
        public virtual Ccedescriptiveskill SkillSubGroup { get; set; }
    }
}
