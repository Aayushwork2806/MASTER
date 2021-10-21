using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeshift")]
    public partial class Employeeshift
    {
        public Employeeshift()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string ShiftName { get; set; }
        [MaxLength(6)]
        public TimeSpan FromTime { get; set; }
        [MaxLength(6)]
        public TimeSpan ToTime { get; set; }
        public bool? Deleted { get; set; }

        [InverseProperty(nameof(Employee.Shift))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
