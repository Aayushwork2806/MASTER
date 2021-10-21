using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("vehiclemaintenance")]
    [Index(nameof(ExpHeadId), Name = "FK_VehicleMaintenance_Masters")]
    [Index(nameof(VehicleId), Name = "FK_VehicleMaintenance_Vehicle")]
    public partial class Vehiclemaintenance
    {
        [Key]
        public int Id { get; set; }
        public int DocNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime DocDate { get; set; }
        public int VehicleId { get; set; }
        public int ExpHeadId { get; set; }
        public double Amount { get; set; }
        [StringLength(150)]
        public string Remark { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(ExpHeadId))]
        [InverseProperty(nameof(Master.Vehiclemaintenances))]
        public virtual Master ExpHead { get; set; }
        [ForeignKey(nameof(VehicleId))]
        [InverseProperty("Vehiclemaintenances")]
        public virtual Vehicle Vehicle { get; set; }
    }
}
