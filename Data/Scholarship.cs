using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarship")]
    [Index(nameof(UnitId), Name = "FK_ScholarShip_BusinessUnits")]
    [Index(nameof(PrevCourseId), Name = "FK_ScholarShip_Class")]
    [Index(nameof(ScholarId), Name = "FK_ScholarShip_Scholar")]
    [Index(nameof(SessionId), Name = "FK_ScholarShip_Session")]
    [Index(nameof(PrevSessionId), Name = "FK_ScholarShip_Session1")]
    public partial class Scholarship
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        [Column(TypeName = "date")]
        public DateTime AppliedDate { get; set; }
        public int ScholarId { get; set; }
        public int? Attendance { get; set; }
        [Column("PrevCourseID")]
        public int? PrevCourseId { get; set; }
        public int? PrevSessionId { get; set; }
        [StringLength(20)]
        public string PrevResult { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string AcceptOrderNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AcceptedDate { get; set; }
        [Column("AWDNo")]
        [StringLength(20)]
        public string Awdno { get; set; }
        [Column("ANo")]
        [StringLength(20)]
        public string Ano { get; set; }
        [Column("FNo")]
        [StringLength(20)]
        public string Fno { get; set; }
        public long? Rate { get; set; }
        public int? PaidMonths { get; set; }
        public long? PaidAmount { get; set; }
        public long? TuitionFee { get; set; }
        public long? OtherFee { get; set; }
        [StringLength(8)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ChequeDate { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(PrevCourseId))]
        [InverseProperty(nameof(Class.Scholarships))]
        public virtual Class PrevCourse { get; set; }
        [ForeignKey(nameof(PrevSessionId))]
        [InverseProperty("ScholarshipPrevSessions")]
        public virtual Session PrevSession { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholarships")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("ScholarshipSessions")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Scholarships))]
        public virtual Businessunit Unit { get; set; }
    }
}
