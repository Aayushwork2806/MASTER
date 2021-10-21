using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employeedocument")]
    [Index(nameof(EmployeeId), Name = "FK_EmployeeDocument_Employee")]
    [Index(nameof(DocId), Name = "FK_EmployeeDocument_Masters")]
    public partial class Employeedocument
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int DocId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SubmitDate { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        [StringLength(100)]
        public string DocPath { get; set; }

        [ForeignKey(nameof(DocId))]
        [InverseProperty(nameof(Master.Employeedocuments))]
        public virtual Master Doc { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Employeedocuments")]
        public virtual Employee Employee { get; set; }
    }
}
