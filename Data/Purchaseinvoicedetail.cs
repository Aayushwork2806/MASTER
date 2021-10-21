using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseinvoicedetail")]
    [Index(nameof(ItemId), Name = "FK_PurchaseInvoiceDetail_Items")]
    [Index(nameof(MaterialReceiptDetailId), Name = "FK_PurchaseInvoiceDetail_MaterialReceiptDetail")]
    [Index(nameof(PurchaseInvoiceId), Name = "FK_PurchaseInvoiceDetail_PurchaseInvoice")]
    [Index(nameof(TaxSchemeId), Name = "FK_PurchaseInvoiceDetail_Tax")]
    public partial class Purchaseinvoicedetail
    {
        public Purchaseinvoicedetail()
        {
            Purchaseinvoicetaxdetails = new HashSet<Purchaseinvoicetaxdetail>();
            Purchasereturndetails = new HashSet<Purchasereturndetail>();
        }

        [Key]
        public int Id { get; set; }
        public int PurchaseInvoiceId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal BilledQty { get; set; }
        public decimal PassedQty { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal? DiscountPer { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int TaxSchemeId { get; set; }
        public decimal BilledAmount { get; set; }
        public decimal PassedAmount { get; set; }
        public int? MaterialReceiptDetailId { get; set; }
        public decimal PurchaseRateBeforeTax { get; set; }
        public decimal PurchaseRateAfterTax { get; set; }
        public decimal? BillDiscount { get; set; }
        public decimal? PurchaseReturnQty { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }
        public decimal? FreeQty { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Purchaseinvoicedetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(MaterialReceiptDetailId))]
        [InverseProperty(nameof(Materialreceiptdetail.Purchaseinvoicedetails))]
        public virtual Materialreceiptdetail MaterialReceiptDetail { get; set; }
        [ForeignKey(nameof(PurchaseInvoiceId))]
        [InverseProperty(nameof(Purchaseinvoice.Purchaseinvoicedetails))]
        public virtual Purchaseinvoice PurchaseInvoice { get; set; }
        [ForeignKey(nameof(TaxSchemeId))]
        [InverseProperty(nameof(Tax.Purchaseinvoicedetails))]
        public virtual Tax TaxScheme { get; set; }
        [InverseProperty(nameof(Purchaseinvoicetaxdetail.PurchaseInvoiceDetail))]
        public virtual ICollection<Purchaseinvoicetaxdetail> Purchaseinvoicetaxdetails { get; set; }
        [InverseProperty(nameof(Purchasereturndetail.PurchaseInvoiceDetail))]
        public virtual ICollection<Purchasereturndetail> Purchasereturndetails { get; set; }
    }
}
