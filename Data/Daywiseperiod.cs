using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("daywiseperiod")]
    [Index(nameof(UnitId), Name = "FK_DayWisePeriod_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_DayWisePeriod_Class")]
    [Index(nameof(DayId), Name = "FK_DayWisePeriod_Masters")]
    [Index(nameof(SessionId), Name = "FK_DayWisePeriod_Session")]
    public partial class Daywiseperiod
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int DayId { get; set; }
        public int? Period { get; set; }
        public int SessionId { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Daywiseperiods")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(DayId))]
        [InverseProperty(nameof(Master.Daywiseperiods))]
        public virtual Master Day { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Daywiseperiods")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Daywiseperiods))]
        public virtual Businessunit Unit { get; set; }
    }
}
