using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("culturalactivity")]
    [Index(nameof(CourseId), Name = "FK_CulturalActivity_Class")]
    [Index(nameof(SectionId), Name = "FK_CulturalActivity_Section")]
    [Index(nameof(SessionId), Name = "FK_CulturalActivity_Session")]
    [Index(nameof(UserId), Name = "FK_CulturalActivity_Users")]
    public partial class Culturalactivity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ActivityDate { get; set; }
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        [StringLength(0)]
        public string Description { get; set; }
        [StringLength(100)]
        public string DocPath { get; set; }
        public int? UserId { get; set; }
        public bool? Deleted { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public int? SessionId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(Class.Culturalactivities))]
        public virtual Class Course { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Culturalactivities")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Culturalactivities")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Culturalactivities")]
        public virtual User User { get; set; }
    }
}
