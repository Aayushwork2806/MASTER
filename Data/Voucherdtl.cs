using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("voucherdtl")]
    [Index(nameof(AccountId), Name = "FK_VoucherDtl_Accounts")]
    [Index(nameof(BankId), Name = "FK_VoucherDtl_Masters")]
    [Index(nameof(VoucherId), Name = "FK_VoucherDtl_Voucher")]
    public partial class Voucherdtl
    {
        [Key]
        public int Id { get; set; }
        public int VoucherId { get; set; }
        public int AccountId { get; set; }
        [Required]
        [StringLength(1)]
        public string DrCr { get; set; }
        public double Amount { get; set; }
        [StringLength(20)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(250)]
        public string Narration { get; set; }
        public int? BankId { get; set; }
        [StringLength(30)]
        public string Branch { get; set; }
        public double? AdjAmt { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ClearingDate { get; set; }
        public int? SubLedgerId { get; set; }
        [StringLength(50)]
        public string PrintOnCheque { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("Voucherdtls")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(BankId))]
        [InverseProperty(nameof(Master.Voucherdtls))]
        public virtual Master Bank { get; set; }
        [ForeignKey(nameof(VoucherId))]
        [InverseProperty("Voucherdtls")]
        public virtual Voucher Voucher { get; set; }
    }
}
