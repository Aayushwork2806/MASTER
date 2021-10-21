using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("beds")]
    [Index(nameof(UnitId), Name = "FK_Beds_BusinessUnits")]
    [Index(nameof(RoomId), Name = "FK_Beds_Rooms")]
    public partial class Bed
    {
        public Bed()
        {
            Bedallocations = new HashSet<Bedallocation>();
            BedshiftingFromBeds = new HashSet<Bedshifting>();
            BedshiftingToBeds = new HashSet<Bedshifting>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string BedNo { get; set; }
        public int RoomId { get; set; }
        [Required]
        [StringLength(10)]
        public string Status { get; set; }
        public bool? IsActive { get; set; }
        public bool? Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(RoomId))]
        [InverseProperty("Beds")]
        public virtual Room Room { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Beds))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Bedallocation.Bed))]
        public virtual ICollection<Bedallocation> Bedallocations { get; set; }
        [InverseProperty(nameof(Bedshifting.FromBed))]
        public virtual ICollection<Bedshifting> BedshiftingFromBeds { get; set; }
        [InverseProperty(nameof(Bedshifting.ToBed))]
        public virtual ICollection<Bedshifting> BedshiftingToBeds { get; set; }
    }
}
