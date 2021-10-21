using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bedallocation")]
    [Index(nameof(BedId), Name = "FK_BedAllocation_Beds")]
    [Index(nameof(UnitId), Name = "FK_BedAllocation_BusinessUnits")]
    [Index(nameof(ScholarId), Name = "FK_BedAllocation_Scholar")]
    [Index(nameof(SessionId), Name = "FK_BedAllocation_Session")]
    public partial class Bedallocation
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int BedId { get; set; }
        public int AllocationNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime AllocationDate { get; set; }
        public int UnitId { get; set; }
        public int SessionId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(BedId))]
        [InverseProperty("Bedallocations")]
        public virtual Bed Bed { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Bedallocations")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Bedallocations")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Bedallocations))]
        public virtual Businessunit Unit { get; set; }
    }
}
