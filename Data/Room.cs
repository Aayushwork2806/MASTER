using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("rooms")]
    [Index(nameof(UnitId), Name = "FK_Rooms_BusinessUnits")]
    [Index(nameof(FloorId), Name = "FK_Rooms_Masters")]
    public partial class Room
    {
        public Room()
        {
            Beds = new HashSet<Bed>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string RoomNo { get; set; }
        public int? NoOfBeds { get; set; }
        public bool? IsActive { get; set; }
        public bool? Deleted { get; set; }
        public int UnitId { get; set; }
        public int FloorId { get; set; }

        [ForeignKey(nameof(FloorId))]
        [InverseProperty(nameof(Master.Rooms))]
        public virtual Master Floor { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Rooms))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Bed.Room))]
        public virtual ICollection<Bed> Beds { get; set; }
    }
}
