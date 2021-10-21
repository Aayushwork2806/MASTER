using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tax")]
    [Index(nameof(TaxTypeId), Name = "FK_Tax_Masters")]
    public partial class Tax
    {
        public Tax()
        {
            ItemPurchaseTaxes = new HashSet<Item>();
            ItemSaleTaxes = new HashSet<Item>();
            Purchaseinvoicedetails = new HashSet<Purchaseinvoicedetail>();
            Purchaseinvoicetaxdetails = new HashSet<Purchaseinvoicetaxdetail>();
            Purchaseorderdetails = new HashSet<Purchaseorderdetail>();
            Purchaseordertaxdetails = new HashSet<Purchaseordertaxdetail>();
            Purchasequotationdetails = new HashSet<Purchasequotationdetail>();
            Purchasereturndetails = new HashSet<Purchasereturndetail>();
            Purchasereturntaxdetails = new HashSet<Purchasereturntaxdetail>();
            Stockattributes = new HashSet<Stockattribute>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string TaxDesc { get; set; }
        public int TaxTypeId { get; set; }
        public bool IsActive { get; set; }
        public decimal? TaxPercentage { get; set; }

        [ForeignKey(nameof(TaxTypeId))]
        [InverseProperty(nameof(Master.Taxes))]
        public virtual Master TaxType { get; set; }
        [InverseProperty(nameof(Item.PurchaseTax))]
        public virtual ICollection<Item> ItemPurchaseTaxes { get; set; }
        [InverseProperty(nameof(Item.SaleTax))]
        public virtual ICollection<Item> ItemSaleTaxes { get; set; }
        [InverseProperty(nameof(Purchaseinvoicedetail.TaxScheme))]
        public virtual ICollection<Purchaseinvoicedetail> Purchaseinvoicedetails { get; set; }
        [InverseProperty(nameof(Purchaseinvoicetaxdetail.Tax))]
        public virtual ICollection<Purchaseinvoicetaxdetail> Purchaseinvoicetaxdetails { get; set; }
        [InverseProperty(nameof(Purchaseorderdetail.TaxScheme))]
        public virtual ICollection<Purchaseorderdetail> Purchaseorderdetails { get; set; }
        [InverseProperty(nameof(Purchaseordertaxdetail.Tax))]
        public virtual ICollection<Purchaseordertaxdetail> Purchaseordertaxdetails { get; set; }
        [InverseProperty(nameof(Purchasequotationdetail.TaxScheme))]
        public virtual ICollection<Purchasequotationdetail> Purchasequotationdetails { get; set; }
        [InverseProperty(nameof(Purchasereturndetail.TaxScheme))]
        public virtual ICollection<Purchasereturndetail> Purchasereturndetails { get; set; }
        [InverseProperty(nameof(Purchasereturntaxdetail.Tax))]
        public virtual ICollection<Purchasereturntaxdetail> Purchasereturntaxdetails { get; set; }
        [InverseProperty(nameof(Stockattribute.Tax))]
        public virtual ICollection<Stockattribute> Stockattributes { get; set; }
    }
}
