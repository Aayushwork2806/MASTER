using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchasequotationdetail")]
    [Index(nameof(ItemId), Name = "FK_PurchaseQuotationDetail_Items")]
    [Index(nameof(PurchaseQuotationId), Name = "FK_PurchaseQuotationDetail_PurchaseQuotation")]
    [Index(nameof(TaxSchemeId), Name = "FK_PurchaseQuotationDetail_Tax")]
    public partial class Purchasequotationdetail
    {
        public Purchasequotationdetail()
        {
            Purchasequotationtaxdetails = new HashSet<Purchasequotationtaxdetail>();
        }

        [Key]
        public int Id { get; set; }
        public int PurchaseQuotationId { get; set; }
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
        public bool IsDeleted { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Purchasequotationdetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(PurchaseQuotationId))]
        [InverseProperty(nameof(Purchasequotation.Purchasequotationdetails))]
        public virtual Purchasequotation PurchaseQuotation { get; set; }
        [ForeignKey(nameof(TaxSchemeId))]
        [InverseProperty(nameof(Tax.Purchasequotationdetails))]
        public virtual Tax TaxScheme { get; set; }
        [InverseProperty(nameof(Purchasequotationtaxdetail.PurchaseQuotationDetail))]
        public virtual ICollection<Purchasequotationtaxdetail> Purchasequotationtaxdetails { get; set; }
    }
}
