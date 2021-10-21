using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classwiseadmschedule")]
    [Index(nameof(UnitId), Name = "FK_ClassWiseAdmSchedule_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassWiseAdmSchedule_Class")]
    [Index(nameof(SessionId), Name = "FK_ClassWiseAdmSchedule_Session")]
    public partial class Classwiseadmschedule
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int SessionId { get; set; }
        public int ClassId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }
        public bool IsActive { get; set; }
        public double? AdmissionPercentage { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classwiseadmschedules")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classwiseadmschedules")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classwiseadmschedules))]
        public virtual Businessunit Unit { get; set; }
    }
}
