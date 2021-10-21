using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("personnelleaves")]
    [Index(nameof(CompanyId), Name = "FK_PersonnelLeaves_BusinessUnits")]
    public partial class Personnelleaf
    {
        public Personnelleaf()
        {
            Employeedailyattendances = new HashSet<Employeedailyattendance>();
            Employeeleaveapps = new HashSet<Employeeleaveapp>();
            Employeeleaves = new HashSet<Employeeleaf>();
            Employeemonthlyattendances = new HashSet<Employeemonthlyattendance>();
            Financialunits = new HashSet<Financialunit>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string LeaveName { get; set; }
        [Required]
        [StringLength(1)]
        public string LeaveType { get; set; }
        public double LeavePerYear { get; set; }
        public double? LeavePerMonth { get; set; }
        public bool? CarryNextYear { get; set; }
        public bool? CarryNextMonth { get; set; }
        public bool Deleted { get; set; }
        public int CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Businessunit.Personnelleaves))]
        public virtual Businessunit Company { get; set; }
        [InverseProperty(nameof(Employeedailyattendance.Leave))]
        public virtual ICollection<Employeedailyattendance> Employeedailyattendances { get; set; }
        [InverseProperty(nameof(Employeeleaveapp.Leave))]
        public virtual ICollection<Employeeleaveapp> Employeeleaveapps { get; set; }
        [InverseProperty(nameof(Employeeleaf.Leave))]
        public virtual ICollection<Employeeleaf> Employeeleaves { get; set; }
        [InverseProperty(nameof(Employeemonthlyattendance.Leave))]
        public virtual ICollection<Employeemonthlyattendance> Employeemonthlyattendances { get; set; }
        [InverseProperty(nameof(Financialunit.LeaveType))]
        public virtual ICollection<Financialunit> Financialunits { get; set; }
    }
}
