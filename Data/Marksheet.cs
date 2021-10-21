using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksheet")]
    [Index(nameof(ClassId), Name = "FK_MarkSheet_Class")]
    [Index(nameof(PrintPolicyId), Name = "FK_MarkSheet_MarksheetPrintPolicy")]
    [Index(nameof(ScholarId), Name = "FK_MarkSheet_Scholar")]
    public partial class Marksheet
    {
        public Marksheet()
        {
            Marksheetdtls = new HashSet<Marksheetdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int ClassId { get; set; }
        public int? PrintPolicyId { get; set; }
        public double? Attendance { get; set; }
        public double? SchoolDays { get; set; }
        public double? TotMaxMarks { get; set; }
        public double? TotObtMarks { get; set; }
        [StringLength(15)]
        public string Result { get; set; }
        [StringLength(10)]
        public string Division { get; set; }
        [StringLength(3)]
        public string Grade { get; set; }
        public double? GraceMarks { get; set; }
        public double? Percentage { get; set; }
        public double? Classrank { get; set; }
        public double? Sectionrank { get; set; }
        [StringLength(50)]
        public string SuppSubjects { get; set; }
        [StringLength(200)]
        public string Remarks { get; set; }
        public int? GradePoint { get; set; }
        [Column("ASL")]
        [StringLength(8)]
        public string Asl { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Marksheets")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(PrintPolicyId))]
        [InverseProperty(nameof(Marksheetprintpolicy.Marksheets))]
        public virtual Marksheetprintpolicy PrintPolicy { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Marksheets")]
        public virtual Scholar Scholar { get; set; }
        [InverseProperty(nameof(Marksheetdtl.MarkSheet))]
        public virtual ICollection<Marksheetdtl> Marksheetdtls { get; set; }
    }
}
