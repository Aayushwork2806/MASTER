using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeeeducationdtl")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeEducationDtl_Employee")]
    public partial class Employeeeducationdtl
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(30)]
        public string ExamName { get; set; }
        [Required]
        [StringLength(4)]
        public string ExamYear { get; set; }
        [StringLength(50)]
        public string Board { get; set; }
        [Required]
        [StringLength(20)]
        public string Result { get; set; }
        [StringLength(100)]
        public string Subjects { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeeeducationdtls")]
        public virtual Employee Employee { get; set; }
    }
}
