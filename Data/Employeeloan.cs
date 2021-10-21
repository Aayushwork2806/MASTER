using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeloan")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeLoan_Employee")]
    public partial class Employeeloan
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime LoanDate { get; set; }
        public double LoanAmount { get; set; }
        [Column("LoanEMI")]
        public double LoanEmi { get; set; }
        public int LoanPeriod { get; set; }
        public double? LoanPaid { get; set; }
        [Column("EMIPaid")]
        public double? Emipaid { get; set; }
        public bool LoanCompleted { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeeloans")]
        public virtual Employee Employee { get; set; }
    }
}
