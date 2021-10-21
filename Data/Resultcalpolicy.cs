using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("resultcalpolicy")]
    [Index(nameof(UnitId), Name = "FK_ResultCalPolicy_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ResultCalPolicy_Class")]
    [Index(nameof(SessionId), Name = "FK_ResultCalPolicy_Session")]
    public partial class Resultcalpolicy
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ClassId { get; set; }
        [Required]
        [StringLength(1)]
        public string ResultCalculationOn { get; set; }
        public double PassPercent { get; set; }
        public int NoofSuppSubject { get; set; }
        [StringLength(4)]
        public string SuppSymbol { get; set; }
        public int DistinctionAfter { get; set; }
        [Required]
        [StringLength(4)]
        public string DistinctionSymbol { get; set; }
        public int NoofGraceSubject { get; set; }
        [StringLength(4)]
        public string GraceSymbol { get; set; }
        public int? TotGraceMarks { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Resultcalpolicies")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Resultcalpolicies")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Resultcalpolicies))]
        public virtual Businessunit Unit { get; set; }
    }
}
