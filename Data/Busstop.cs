using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("busstop")]
    [Index(nameof(RouteId), Name = "FK_BusStop_Masters")]
    [Index(nameof(UnitId), Name = "FK_BusinessUnits_BusStop")]
    public partial class Busstop
    {
        public Busstop()
        {
            Busstopwisefees = new HashSet<Busstopwisefee>();
            ScholardtlDropBusStops = new HashSet<Scholardtl>();
            ScholardtlPickupBusStops = new HashSet<Scholardtl>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string StopName { get; set; }
        [StringLength(1)]
        public string Shift1 { get; set; }
        public int? RouteId { get; set; }
        [StringLength(5)]
        public string TimePick1 { get; set; }
        [StringLength(5)]
        public string TimeDrop1 { get; set; }
        [StringLength(1)]
        public string Shift2 { get; set; }
        [StringLength(5)]
        public string TimePick2 { get; set; }
        [StringLength(5)]
        public string TimeDrop2 { get; set; }
        [StringLength(1)]
        public string Shift3 { get; set; }
        [StringLength(5)]
        public string TimePick3 { get; set; }
        [StringLength(5)]
        public string TimeDrop3 { get; set; }
        public double? StopFeeAmount { get; set; }
        public int? Shift1Id { get; set; }
        public int? Shift2Id { get; set; }
        public int? Shift3Id { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(RouteId))]
        [InverseProperty(nameof(Master.Busstops))]
        public virtual Master Route { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Busstops))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Busstopwisefee.BusStop))]
        public virtual ICollection<Busstopwisefee> Busstopwisefees { get; set; }
        [InverseProperty(nameof(Scholardtl.DropBusStop))]
        public virtual ICollection<Scholardtl> ScholardtlDropBusStops { get; set; }
        [InverseProperty(nameof(Scholardtl.PickupBusStop))]
        public virtual ICollection<Scholardtl> ScholardtlPickupBusStops { get; set; }
    }
}
