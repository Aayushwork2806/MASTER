using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchasereturndetail")]
    [Index(nameof(ItemId), Name = "FK_PurchaseReturnDetail_Items")]
    [Index(nameof(MaterialReceiptDetailId), Name = "FK_PurchaseReturnDetail_MaterialReceiptDetail")]
    [Index(nameof(PurchaseInvoiceDetailId), Name = "FK_PurchaseReturnDetail_PurchaseInvoiceDetail")]
    [Index(nameof(PurchaseReturnId), Name = "FK_PurchaseReturnDetail_PurchaseReturn")]
    [Index(nameof(TaxSchemeId), Name = "FK_PurchaseReturnDetail_Tax")]
    public partial class Purchasereturndetail
    {
        public Purchasereturndetail()
        {
            Purchasereturntaxdetails = new HashSet<Purchasereturntaxdetail>();
        }

        [Key]
        public int Id { get; set; }
        public int PurchaseReturnId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal ReturnQty { get; set; }
        public decimal? PurchaseRate { get; set; }
        public decimal? PurchaseRateBeforeTax { get; set; }
        public decimal? PurchaseRateAfterTax { get; set; }
        public int? TaxSchemeId { get; set; }
        public int? MaterialReceiptDetailId { get; set; }
        public int? PurchaseInvoiceDetailId { get; set; }
        public decimal? ReturnAmount { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Purchasereturndetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(MaterialReceiptDetailId))]
        [InverseProperty(nameof(Materialreceiptdetail.Purchasereturndetails))]
        public virtual Materialreceiptdetail MaterialReceiptDetail { get; set; }
        [ForeignKey(nameof(PurchaseInvoiceDetailId))]
        [InverseProperty(nameof(Purchaseinvoicedetail.Purchasereturndetails))]
        public virtual Purchaseinvoicedetail PurchaseInvoiceDetail { get; set; }
        [ForeignKey(nameof(PurchaseReturnId))]
        [InverseProperty(nameof(Purchasereturn.Purchasereturndetails))]
        public virtual Purchasereturn PurchaseReturn { get; set; }
        [ForeignKey(nameof(TaxSchemeId))]
        [InverseProperty(nameof(Tax.Purchasereturndetails))]
        public virtual Tax TaxScheme { get; set; }
        [InverseProperty(nameof(Purchasereturntaxdetail.PurchaseReturnDetail))]
        public virtual ICollection<Purchasereturntaxdetail> Purchasereturntaxdetails { get; set; }
    }
}
