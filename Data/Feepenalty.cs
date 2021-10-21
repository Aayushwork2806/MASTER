using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feepenalty")]
    [Index(nameof(UnitId), Name = "FK_FeePenalty_BusinessUnits")]
    [Index(nameof(FeeHeadId), Name = "FK_FeePenalty_FeeHeads")]
    [Index(nameof(FeeReceiptId), Name = "FK_FeePenalty_FeeReceipt")]
    [Index(nameof(ScholarId), Name = "FK_FeePenalty_Scholar")]
    [Index(nameof(SessionId), Name = "FK_FeePenalty_Session")]
    public partial class Feepenalty
    {
        [Key]
        public int Id { get; set; }
        public int DocNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime PenaltyDate { get; set; }
        public int SessionId { get; set; }
        public int ScholarId { get; set; }
        public int FeeHeadId { get; set; }
        public long PenaltyAmount { get; set; }
        public long? AmountAdj { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        public int? FeeReceiptId { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(FeeHeadId))]
        [InverseProperty(nameof(Feehead.Feepenalties))]
        public virtual Feehead FeeHead { get; set; }
        [ForeignKey(nameof(FeeReceiptId))]
        [InverseProperty(nameof(Feereceipt.Feepenalties))]
        public virtual Feereceipt FeeReceipt { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Feepenalties")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Feepenalties")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Feepenalties))]
        public virtual Businessunit Unit { get; set; }
    }
}
