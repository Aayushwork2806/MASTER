using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feecautionmoney")]
    [Index(nameof(UnitId), Name = "FK_FeeCautionMoney_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_FeeCautionMoney_Class")]
    [Index(nameof(ScholarId), Name = "FK_FeeCautionMoney_Scholar")]
    [Index(nameof(SessionId), Name = "FK_FeeCautionMoney_Session")]
    [Index(nameof(RefundSessId), Name = "FK_FeeCautionMoney_Session1")]
    public partial class Feecautionmoney
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int SessionId { get; set; }
        public int ClassId { get; set; }
        public int RecNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime RecDate { get; set; }
        public long Amount { get; set; }
        public bool? Refund { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RefundDate { get; set; }
        public int? RefundNo { get; set; }
        [StringLength(10)]
        public string PayMode { get; set; }
        [StringLength(20)]
        public string ChqNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ChqDate { get; set; }
        public long? RefundAmount { get; set; }
        [StringLength(20)]
        public string ChqBank { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        public int? RefundSessId { get; set; }
        public bool? Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Feecautionmoneys")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(RefundSessId))]
        [InverseProperty("FeecautionmoneyRefundSesses")]
        public virtual Session RefundSess { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Feecautionmoneys")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("FeecautionmoneySessions")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Feecautionmoneys))]
        public virtual Businessunit Unit { get; set; }
    }
}
