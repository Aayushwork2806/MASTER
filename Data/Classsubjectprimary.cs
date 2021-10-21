using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classsubjectprimary")]
    [Index(nameof(UnitId), Name = "FK_ClassSubjectPrimary_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassSubjectPrimary_Class")]
    [Index(nameof(SubTypeId), Name = "FK_ClassSubjectPrimary_Masters")]
    [Index(nameof(SessionId), Name = "FK_ClassSubjectPrimary_Session")]
    [Index(nameof(SubjectId), Name = "FK_ClassSubjectPrimary_Subject")]
    public partial class Classsubjectprimary
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int SubTypeId { get; set; }
        public int? SessionId { get; set; }
        public int? Seq { get; set; }
        public int UnitId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classsubjectprimaries")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classsubjectprimaries")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubTypeId))]
        [InverseProperty(nameof(Master.Classsubjectprimaries))]
        public virtual Master SubType { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Classsubjectprimaries")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classsubjectprimaries))]
        public virtual Businessunit Unit { get; set; }
    }
}
