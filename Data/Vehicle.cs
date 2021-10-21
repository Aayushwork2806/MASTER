using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("vehicle")]
    [Index(nameof(DriverId), Name = "FK_Vehicle_Driver")]
    [Index(nameof(ConductorId), Name = "FK_Vehicle_Driver1")]
    [Index(nameof(RouteId), Name = "FK_Vehicle_Masters")]
    public partial class Vehicle
    {
        public Vehicle()
        {
            Vehicleaccessories = new HashSet<Vehicleaccessory>();
            Vehiclemaintenances = new HashSet<Vehiclemaintenance>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string VehicleNo { get; set; }
        [StringLength(50)]
        public string Category { get; set; }
        [StringLength(50)]
        public string VehicleOwner { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PurDate { get; set; }
        public double? Cost { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        public double? SittingCapacity { get; set; }
        [StringLength(20)]
        public string Chasisno { get; set; }
        [StringLength(20)]
        public string Modelno { get; set; }
        public int? DriverId { get; set; }
        public int? ConductorId { get; set; }
        public int? RouteId { get; set; }
        public double? LastReading { get; set; }
        public double? TankCap { get; set; }
        public double? DieselQty { get; set; }
        public double? DieselRead { get; set; }
        [Column(TypeName = "date")]
        public DateTime? InsDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FitDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PermitDate { get; set; }
        [StringLength(50)]
        public string Finance { get; set; }
        [StringLength(15)]
        public string EngineNo { get; set; }
        [StringLength(1)]
        public string FuelType { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TaxDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PollutionDate { get; set; }
        [StringLength(100)]
        public string InsComp { get; set; }
        [StringLength(10)]
        public string VechileType { get; set; }
        [StringLength(50)]
        public string BatteryMfg { get; set; }
        [StringLength(15)]
        public string BatteryNo { get; set; }
        [StringLength(10)]
        public string BatteryPlates { get; set; }
        [StringLength(50)]
        public string ToolBoxDesc { get; set; }
        [StringLength(50)]
        public string ToolBoxMfg { get; set; }
        [StringLength(15)]
        public string ToolBoxSize { get; set; }
        public int? AccountId { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(ConductorId))]
        [InverseProperty("VehicleConductors")]
        public virtual Driver Conductor { get; set; }
        [ForeignKey(nameof(DriverId))]
        [InverseProperty("VehicleDrivers")]
        public virtual Driver Driver { get; set; }
        [ForeignKey(nameof(RouteId))]
        [InverseProperty(nameof(Master.Vehicles))]
        public virtual Master Route { get; set; }
        [InverseProperty(nameof(Vehicleaccessory.Vehicle))]
        public virtual ICollection<Vehicleaccessory> Vehicleaccessories { get; set; }
        [InverseProperty(nameof(Vehiclemaintenance.Vehicle))]
        public virtual ICollection<Vehiclemaintenance> Vehiclemaintenances { get; set; }
    }
}
