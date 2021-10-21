using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeedailyattendance")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeDailyAttendance_Employee")]
    [Index(nameof(LeaveId), Name = "FK_EmployeeDailyAttendance_PersonnelLeaves")]
    public partial class Employeedailyattendance
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime AttendDate { get; set; }
        [Required]
        [StringLength(2)]
        public string AttendStatus { get; set; }
        public int? LeaveId { get; set; }
        [MaxLength(6)]
        public DateTime? Intime { get; set; }
        [MaxLength(6)]
        public DateTime? OutTime { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeedailyattendances")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(LeaveId))]
        [InverseProperty(nameof(Personnelleaf.Employeedailyattendances))]
        public virtual Personnelleaf Leave { get; set; }
    }
}
