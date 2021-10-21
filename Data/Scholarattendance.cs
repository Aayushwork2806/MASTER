using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarattendance")]
    [Index(nameof(UnitId), Name = "FK_ScholarAttendance_BusinessUnits")]
    [Index(nameof(ScholarId), Name = "FK_ScholarAttendance_Scholar")]
    [Index(nameof(SessionId), Name = "FK_ScholarAttendance_Session")]
    [Index(nameof(SubjectId), Name = "FK_ScholarAttendance_Subject")]
    [Index(nameof(FacultyId), Name = "FK_ScholarAttendance_Teacher")]
    public partial class Scholarattendance
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int SessionId { get; set; }
        [Required]
        [Column("MMonth")]
        [StringLength(6)]
        public string Mmonth { get; set; }
        [Column(TypeName = "date")]
        public DateTime AttendDate { get; set; }
        [Required]
        [StringLength(2)]
        public string AttendStatus { get; set; }
        public short Period { get; set; }
        public int UnitId { get; set; }
        public int? FacultyId { get; set; }
        public int? SubjectId { get; set; }

        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholarattendances")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Scholarattendances")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Scholarattendances")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Scholarattendances))]
        public virtual Businessunit Unit { get; set; }
    }
}
