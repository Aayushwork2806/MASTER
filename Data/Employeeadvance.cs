using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeadvance")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeAdvance_Employee")]
    public partial class Employeeadvance
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime AdvanceDate { get; set; }
        public double AdvanceAmount { get; set; }
        public bool Adjusted { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeeadvances")]
        public virtual Employee Employee { get; set; }
    }
}
