using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tmpfeereceiptdtl")]
    [Index(nameof(FeeHeadId), Name = "FK_tmpFeeReceiptDtl_FeeHeads")]
    [Index(nameof(ReceiptId), Name = "FK_tmpFeeReceiptDtl_tmpFeeReceipt")]
    public partial class Tmpfeereceiptdtl
    {
        [Key]
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public int FeeHeadId { get; set; }
        public double Amount { get; set; }
        [StringLength(10)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(60)]
        public string Narration { get; set; }
        public double? DueAmount { get; set; }
        [Column("UnitRNo")]
        public int? UnitRno { get; set; }
        [Column("FeeHDRno")]
        public int? FeeHdrno { get; set; }

        [ForeignKey(nameof(FeeHeadId))]
        [InverseProperty(nameof(Feehead.Tmpfeereceiptdtls))]
        public virtual Feehead FeeHead { get; set; }
        [ForeignKey(nameof(ReceiptId))]
        [InverseProperty(nameof(Tmpfeereceipt.Tmpfeereceiptdtls))]
        public virtual Tmpfeereceipt Receipt { get; set; }
    }
}
