using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarleaveapps")]
    [Index(nameof(UnitId), Name = "FK_ScholarLeaveApps_BusinessUnits")]
    [Index(nameof(ScholarId), Name = "FK_ScholarLeaveApps_Scholar")]
    public partial class Scholarleaveapp
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ApplDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LeaveFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LeaveTo { get; set; }
        [StringLength(50)]
        public string Reason { get; set; }
        [StringLength(50)]
        public string SanctionBy { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholarleaveapps")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Scholarleaveapps))]
        public virtual Businessunit Unit { get; set; }
    }
}
