using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarhistory")]
    [Index(nameof(ClassId), Name = "FK_ScholarHistory_Class")]
    [Index(nameof(ScholarId), Name = "FK_ScholarHistory_Scholar")]
    [Index(nameof(SessId), Name = "FK_ScholarHistory_Session")]
    public partial class Scholarhistory
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int? ClassId { get; set; }
        public int? SessId { get; set; }
        [Column("DOA", TypeName = "date")]
        public DateTime? Doa { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PassDate { get; set; }
        public double? SchoolDays { get; set; }
        public double? Present { get; set; }
        [StringLength(30)]
        public string Result { get; set; }
        public double? TotMarks { get; set; }
        public double? ObtMarks { get; set; }
        public int? TotalScholars { get; set; }
        public int? Rank { get; set; }
        public long? Percentage { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Scholarhistories")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholarhistories")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessId))]
        [InverseProperty(nameof(Session.Scholarhistories))]
        public virtual Session Sess { get; set; }
    }
}
