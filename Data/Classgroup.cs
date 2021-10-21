using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classgroup")]
    [Index(nameof(UnitId), Name = "FK_ClassGroup_BusinessUnits")]
    public partial class Classgroup
    {
        public Classgroup()
        {
            Classes = new HashSet<Class>();
            Grades = new HashSet<Grade>();
            Teacherdtls = new HashSet<Teacherdtl>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string GroupName { get; set; }
        [StringLength(5)]
        public string StartFrom { get; set; }
        [StringLength(5)]
        public string Upto { get; set; }
        public int? NoofPeriods { get; set; }
        public int? PeriodDuration { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classgroups))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Class.ClassGroup))]
        public virtual ICollection<Class> Classes { get; set; }
        [InverseProperty(nameof(Grade.ClassGroup))]
        public virtual ICollection<Grade> Grades { get; set; }
        [InverseProperty(nameof(Teacherdtl.ClassGroup))]
        public virtual ICollection<Teacherdtl> Teacherdtls { get; set; }
    }
}
