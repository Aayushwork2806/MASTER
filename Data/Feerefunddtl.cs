using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feerefunddtl")]
    [Index(nameof(FeeHeadId), Name = "FK_FeeRefundDtl_FeeHeads")]
    [Index(nameof(RefundId), Name = "FK_FeeRefundDtl_FeeRefund")]
    public partial class Feerefunddtl
    {
        [Key]
        public int Id { get; set; }
        public int RefundId { get; set; }
        public int FeeHeadId { get; set; }
        public long Amount { get; set; }

        [ForeignKey(nameof(FeeHeadId))]
        [InverseProperty(nameof(Feehead.Feerefunddtls))]
        public virtual Feehead FeeHead { get; set; }
        [ForeignKey(nameof(RefundId))]
        [InverseProperty(nameof(Feerefund.Feerefunddtls))]
        public virtual Feerefund Refund { get; set; }
    }
}
