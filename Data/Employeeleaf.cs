using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeleaves")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeLeaves_Employee")]
    [Index(nameof(LeaveYearId), Name = "FK_EmployeeLeaves_LeaveYear")]
    [Index(nameof(LeaveId), Name = "FK_EmployeeLeaves_PersonnelLeaves")]
    public partial class Employeeleaf
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveYearId { get; set; }
        public int LeaveId { get; set; }
        public double NoOfLeave { get; set; }
        public double? LeavesUsed { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeeleaves")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(LeaveId))]
        [InverseProperty(nameof(Personnelleaf.Employeeleaves))]
        public virtual Personnelleaf Leave { get; set; }
        [ForeignKey(nameof(LeaveYearId))]
        [InverseProperty(nameof(Leaveyear.Employeeleaves))]
        public virtual Leaveyear LeaveYear { get; set; }
    }
}
