using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("issuedslc")]
    [Index(nameof(UnitId), Name = "FK_IssuedSLC_BusinessUnits")]
    [Index(nameof(PromotedClassId), Name = "FK_IssuedSLC_Class")]
    [Index(nameof(LastClassId), Name = "FK_IssuedSLC_Class1")]
    [Index(nameof(ScholarId), Name = "FK_IssuedSLC_Scholar")]
    [Index(nameof(SessionId), Name = "FK_IssuedSLC_Session")]
    public partial class Issuedslc
    {
        [Key]
        public int Id { get; set; }
        public int IssueNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime ApplicationDate { get; set; }
        public int? BookNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; }
        public int SessionId { get; set; }
        public int ScholarId { get; set; }
        public bool? ScSt { get; set; }
        [StringLength(20)]
        public string Result { get; set; }
        [StringLength(50)]
        public string LastSchool { get; set; }
        public bool FailedClass { get; set; }
        public bool Promotion { get; set; }
        public int PromotedClassId { get; set; }
        [StringLength(20)]
        public string FeeConcession { get; set; }
        [StringLength(15)]
        public string FeePaidUpto { get; set; }
        public short? WorkDays { get; set; }
        public short? AttnDays { get; set; }
        [Column("NCC")]
        [StringLength(50)]
        public string Ncc { get; set; }
        [StringLength(50)]
        public string Games { get; set; }
        [StringLength(50)]
        public string Conduct { get; set; }
        [StringLength(50)]
        public string Reason { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        public bool Cancel { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CancelDate { get; set; }
        [StringLength(50)]
        public string CancelRemark { get; set; }
        public bool FinalPrint { get; set; }
        public byte PrintCount { get; set; }
        public int UnitId { get; set; }
        [StringLength(50)]
        public string Preparedby { get; set; }
        [StringLength(50)]
        public string LastClass { get; set; }
        [StringLength(20)]
        public string SessName { get; set; }
        public int? LastClassId { get; set; }
        [StringLength(80)]
        public string LastExamPassedandSchool { get; set; }
        [StringLength(80)]
        public string ClassRemark { get; set; }

        [ForeignKey(nameof(LastClassId))]
        [InverseProperty(nameof(Class.IssuedslcLastClassNavigations))]
        public virtual Class LastClassNavigation { get; set; }
        [ForeignKey(nameof(PromotedClassId))]
        [InverseProperty(nameof(Class.IssuedslcPromotedClasses))]
        public virtual Class PromotedClass { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Issuedslcs")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Issuedslcs")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Issuedslcs))]
        public virtual Businessunit Unit { get; set; }
    }
}
