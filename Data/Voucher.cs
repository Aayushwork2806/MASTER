using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("voucher")]
    [Index(nameof(CompanyId), Name = "FK_Voucher_BusinessUnits")]
    [Index(nameof(ReceiptId), Name = "FK_Voucher_FeeReceipt")]
    [Index(nameof(FinYearId), Name = "FK_Voucher_FinancialYear")]
    public partial class Voucher
    {
        public Voucher()
        {
            Despatches = new HashSet<Despatch>();
            Feereceipts = new HashSet<Feereceipt>();
            Inwards = new HashSet<Inward>();
            PurchaseinvoiceReturnVouchers = new HashSet<Purchaseinvoice>();
            PurchaseinvoiceVouchers = new HashSet<Purchaseinvoice>();
            Purchasereturns = new HashSet<Purchasereturn>();
            Voucherdtls = new HashSet<Voucherdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int VoucherNo { get; set; }
        [Required]
        [StringLength(2)]
        public string VoucherType { get; set; }
        [Column(TypeName = "date")]
        public DateTime VoucherDate { get; set; }
        public int FinYearId { get; set; }
        public bool Generated { get; set; }
        public int? OldNo { get; set; }
        public bool Deleted { get; set; }
        public int CompanyId { get; set; }
        [StringLength(1)]
        public string DocumentType { get; set; }
        public int? ReceiptId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Businessunit.Vouchers))]
        public virtual Businessunit Company { get; set; }
        [ForeignKey(nameof(FinYearId))]
        [InverseProperty(nameof(Financialyear.Vouchers))]
        public virtual Financialyear FinYear { get; set; }
        [ForeignKey(nameof(ReceiptId))]
        [InverseProperty(nameof(Feereceipt.Vouchers))]
        public virtual Feereceipt Receipt { get; set; }
        [InverseProperty(nameof(Despatch.Voucher))]
        public virtual ICollection<Despatch> Despatches { get; set; }
        [InverseProperty(nameof(Feereceipt.Voucher))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Inward.Voucher))]
        public virtual ICollection<Inward> Inwards { get; set; }
        [InverseProperty(nameof(Purchaseinvoice.ReturnVoucher))]
        public virtual ICollection<Purchaseinvoice> PurchaseinvoiceReturnVouchers { get; set; }
        [InverseProperty(nameof(Purchaseinvoice.Voucher))]
        public virtual ICollection<Purchaseinvoice> PurchaseinvoiceVouchers { get; set; }
        [InverseProperty(nameof(Purchasereturn.Voucher))]
        public virtual ICollection<Purchasereturn> Purchasereturns { get; set; }
        [InverseProperty(nameof(Voucherdtl.Voucher))]
        public virtual ICollection<Voucherdtl> Voucherdtls { get; set; }
    }
}
