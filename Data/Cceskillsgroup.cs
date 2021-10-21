using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("cceskillsgroup")]
    public partial class Cceskillsgroup
    {
        public Cceskillsgroup()
        {
            Ccedescriptiveskills = new HashSet<Ccedescriptiveskill>();
            Markscceskillsdtls = new HashSet<Markscceskillsdtl>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string SkillGroupName { get; set; }
        public int Sequence { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [InverseProperty(nameof(Ccedescriptiveskill.SkillGroup))]
        public virtual ICollection<Ccedescriptiveskill> Ccedescriptiveskills { get; set; }
        [InverseProperty(nameof(Markscceskillsdtl.SkillGroup))]
        public virtual ICollection<Markscceskillsdtl> Markscceskillsdtls { get; set; }
    }
}
