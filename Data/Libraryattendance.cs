using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("libraryattendance")]
    [Index(nameof(UnitId), Name = "FK_LibraryAttendance_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_LibraryAttendance_Class")]
    [Index(nameof(ScholarId), Name = "FK_LibraryAttendance_Scholar")]
    [Index(nameof(SectionId), Name = "FK_LibraryAttendance_Section")]
    [Index(nameof(SessionId), Name = "FK_LibraryAttendance_Session")]
    [Index(nameof(FacultyId), Name = "FK_LibraryAttendance_Teacher")]
    public partial class Libraryattendance
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public short Period { get; set; }
        public int ScholarId { get; set; }
        public int? FacultyId { get; set; }
        [Column(TypeName = "date")]
        public DateTime AttendDate { get; set; }
        [Required]
        [StringLength(2)]
        public string AttendStatus { get; set; }
        public int SessionId { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Libraryattendances")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Libraryattendances")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Libraryattendances")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Libraryattendances")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Libraryattendances))]
        public virtual Businessunit Unit { get; set; }
    }
}
