using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classweekwiseperiod")]
    [Index(nameof(UnitId), Name = "FK_ClassWeekWisePeriod_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassWeekWisePeriod_Class")]
    [Index(nameof(SessionId), Name = "FK_ClassWeekWisePeriod_Session")]
    [Index(nameof(SubjectId), Name = "FK_ClassWeekWisePeriod_Subject")]
    [Index(nameof(TeacherId), Name = "FK_ClassWeekWisePeriod_Teacher")]
    public partial class Classweekwiseperiod
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        [Required]
        [StringLength(1)]
        public string Priority { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int SessionId { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classweekwiseperiods")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classweekwiseperiods")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Classweekwiseperiods")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classweekwiseperiods))]
        public virtual Businessunit Unit { get; set; }
    }
}
