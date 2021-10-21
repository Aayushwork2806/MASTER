using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bedshifting")]
    [Index(nameof(FromBedId), Name = "FK_BedShifting_Beds")]
    [Index(nameof(ToBedId), Name = "FK_BedShifting_Beds1")]
    [Index(nameof(UnitId), Name = "FK_BedShifting_BusinessUnits")]
    [Index(nameof(SessionId), Name = "FK_BedShifting_Session")]
    public partial class Bedshifting
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime ShiftingDate { get; set; }
        public int FromBedId { get; set; }
        public int ToBedId { get; set; }
        public bool Deleted { get; set; }
        public int SessionId { get; set; }
        public int UnitId { get; set; }
        public int ScholarId { get; set; }

        [ForeignKey(nameof(FromBedId))]
        [InverseProperty(nameof(Bed.BedshiftingFromBeds))]
        public virtual Bed FromBed { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Bedshiftings")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(ToBedId))]
        [InverseProperty(nameof(Bed.BedshiftingToBeds))]
        public virtual Bed ToBed { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Bedshiftings))]
        public virtual Businessunit Unit { get; set; }
    }
}
