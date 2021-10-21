using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("driver")]
    [Index(nameof(EmployeeId), Name = "FK_Driver_Employee")]
    public partial class Driver
    {
        public Driver()
        {
            VehicleConductors = new HashSet<Vehicle>();
            VehicleDrivers = new HashSet<Vehicle>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string DrvDesg { get; set; }
        [StringLength(50)]
        public string DrvName { get; set; }
        [Column("FHName")]
        [StringLength(20)]
        public string Fhname { get; set; }
        [StringLength(50)]
        public string DrvAddress { get; set; }
        [StringLength(50)]
        public string DrvAdddress1 { get; set; }
        [StringLength(22)]
        public string DrvPhoneNo { get; set; }
        [StringLength(22)]
        public string DrvMobileNo { get; set; }
        [Column("DOJ", TypeName = "date")]
        public DateTime? Doj { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(20)]
        public string DrvLicNo { get; set; }
        [StringLength(20)]
        public string DrvLicType { get; set; }
        [Column(TypeName = "date")]
        public DateTime? IssueDate { get; set; }
        [StringLength(50)]
        public string IssuedFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(10)]
        public string Experience { get; set; }
        [StringLength(15)]
        public string BadgeNo { get; set; }
        public bool? DrvStatus { get; set; }
        public bool Deleted { get; set; }
        public int? EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Drivers")]
        public virtual Employee Employee { get; set; }
        [InverseProperty(nameof(Vehicle.Conductor))]
        public virtual ICollection<Vehicle> VehicleConductors { get; set; }
        [InverseProperty(nameof(Vehicle.Driver))]
        public virtual ICollection<Vehicle> VehicleDrivers { get; set; }
    }
}
