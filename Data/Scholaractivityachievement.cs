using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholaractivityachievement")]
    [Index(nameof(EventLevelId), Name = "FK_ScholarActivityAchievement_Masters")]
    [Index(nameof(ScholarId), Name = "FK_ScholarActivityAchievement_Scholar")]
    public partial class Scholaractivityachievement
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ActivityDate { get; set; }
        [Required]
        [StringLength(100)]
        public string EventTitle { get; set; }
        [Required]
        [StringLength(20)]
        public string EventType { get; set; }
        [StringLength(100)]
        public string Venue { get; set; }
        public int EventLevelId { get; set; }
        [StringLength(20)]
        public string PositionHeld { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(EventLevelId))]
        [InverseProperty(nameof(Master.Scholaractivityachievements))]
        public virtual Master EventLevel { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholaractivityachievements")]
        public virtual Scholar Scholar { get; set; }
    }
}
