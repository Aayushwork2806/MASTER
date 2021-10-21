using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseorderdetail")]
    [Index(nameof(ItemId), Name = "FK_PurchaseOrderDetail_Items")]
    [Index(nameof(PurchaseOrderId), Name = "FK_PurchaseOrderDetail_PurchaseOrder")]
    [Index(nameof(TaxSchemeId), Name = "FK_PurchaseOrderDetail_Tax")]
    public partial class Purchaseorderdetail
    {
        public Purchaseorderdetail()
        {
            Materialreceiptdetails = new HashSet<Materialreceiptdetail>();
            Purchaseorderdispatchschedules = new HashSet<Purchaseorderdispatchschedule>();
            Purchaseordertaxdetails = new HashSet<Purchaseordertaxdetail>();
        }

        [Key]
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountPer { get; set; }
        public int TaxSchemeId { get; set; }
        public decimal RateAfterDiscount { get; set; }
        public decimal AmountBeforeDiscount { get; set; }
        public decimal AmountAfterDiscount { get; set; }
        public decimal AmountAfterTax { get; set; }
        public decimal DistributedDiscount { get; set; }
        public decimal RateAfterTax { get; set; }
        public decimal RateBeforeTax { get; set; }
        public decimal? ReceivedQty { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Purchaseorderdetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(PurchaseOrderId))]
        [InverseProperty(nameof(Purchaseorder.Purchaseorderdetails))]
        public virtual Purchaseorder PurchaseOrder { get; set; }
        [ForeignKey(nameof(TaxSchemeId))]
        [InverseProperty(nameof(Tax.Purchaseorderdetails))]
        public virtual Tax TaxScheme { get; set; }
        [InverseProperty(nameof(Materialreceiptdetail.PurchaseOrderDetail))]
        public virtual ICollection<Materialreceiptdetail> Materialreceiptdetails { get; set; }
        [InverseProperty(nameof(Purchaseorderdispatchschedule.PurchaseOrderIdetail))]
        public virtual ICollection<Purchaseorderdispatchschedule> Purchaseorderdispatchschedules { get; set; }
        [InverseProperty(nameof(Purchaseordertaxdetail.PurchaseOrderDetail))]
        public virtual ICollection<Purchaseordertaxdetail> Purchaseordertaxdetails { get; set; }
    }
}
