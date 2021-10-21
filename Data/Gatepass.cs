using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("gatepass")]
    [Index(nameof(UnitId), Name = "FK_GatePass_BusinessUnits")]
    [Index(nameof(ScholarId), Name = "FK_GatePass_Scholar")]
    public partial class Gatepass
    {
        [Key]
        public int Id { get; set; }
        public int GatePassNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime GatePassDate { get; set; }
        [Required]
        [StringLength(1)]
        public string GatePassType { get; set; }
        [StringLength(50)]
        public string VisitorName { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(25)]
        public string PhoneNo { get; set; }
        [Required]
        [StringLength(50)]
        public string Purpose { get; set; }
        [StringLength(50)]
        public string ToMeet { get; set; }
        public int? ScholarId { get; set; }
        [StringLength(8)]
        public string InTime { get; set; }
        [StringLength(8)]
        public string OutTime { get; set; }
        [StringLength(250)]
        public string MaterialDesc { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Gatepasses")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Gatepasses))]
        public virtual Businessunit Unit { get; set; }
    }
}
