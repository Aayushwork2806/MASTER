using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeleaveapps")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeLeaveApps_Employee")]
    [Index(nameof(LeaveId), Name = "FK_EmployeeLeaveApps_PersonnelLeaves")]
    public partial class Employeeleaveapp
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime ApplDate { get; set; }
        public int LeaveId { get; set; }
        [Column(TypeName = "date")]
        public DateTime LeaveFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime LeaveTo { get; set; }
        [StringLength(50)]
        public string Reason { get; set; }
        [StringLength(30)]
        public string SanctionBy { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }
        [StringLength(2)]
        public string AttendStatus { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeeleaveapps")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(LeaveId))]
        [InverseProperty(nameof(Personnelleaf.Employeeleaveapps))]
        public virtual Personnelleaf Leave { get; set; }
    }
}
