using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeemonthlyattendance")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeMonthlyAttendance_Employee")]
    [Index(nameof(LeaveId), Name = "FK_EmployeeMonthlyAttendance_PersonnelLeaves")]
    public partial class Employeemonthlyattendance
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime LeaveDate { get; set; }
        public int LeaveId { get; set; }
        public double NoofLeaves { get; set; }
        public double? Presentday { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeemonthlyattendances")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(LeaveId))]
        [InverseProperty(nameof(Personnelleaf.Employeemonthlyattendances))]
        public virtual Personnelleaf Leave { get; set; }
    }
}
