using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("vehicleaccessories")]
    [Index(nameof(VehicleAccessoriesId), Name = "FK_VehicleAccessories_Masters")]
    [Index(nameof(VehicleId), Name = "FK_VehicleAccessories_Vehicle")]
    public partial class Vehicleaccessory
    {
        [Key]
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int VehicleAccessoriesId { get; set; }
        [Column("description1")]
        [StringLength(50)]
        public string Description1 { get; set; }
        [Column("description2")]
        [StringLength(50)]
        public string Description2 { get; set; }
        [Column("description3")]
        [StringLength(50)]
        public string Description3 { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(VehicleId))]
        [InverseProperty("Vehicleaccessories")]
        public virtual Vehicle Vehicle { get; set; }
        [ForeignKey(nameof(VehicleAccessoriesId))]
        [InverseProperty(nameof(Master.Vehicleaccessories))]
        public virtual Master VehicleAccessories { get; set; }
    }
}
