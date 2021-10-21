using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseinvoicetaxdetail")]
    [Index(nameof(PurchaseInvoiceDetailId), Name = "FK_PurchaseInvoiceTaxDetail_PurchaseInvoiceDetail")]
    [Index(nameof(TaxId), Name = "FK_PurchaseInvoiceTaxDetail_Tax")]
    public partial class Purchaseinvoicetaxdetail
    {
        [Key]
        public int Id { get; set; }
        public int PurchaseInvoiceDetailId { get; set; }
        public int TaxId { get; set; }
        public decimal? TaxPer { get; set; }
        public decimal BilledTaxAmount { get; set; }
        public decimal PassedTaxAmount { get; set; }
        public bool IncludedInRate { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(PurchaseInvoiceDetailId))]
        [InverseProperty(nameof(Purchaseinvoicedetail.Purchaseinvoicetaxdetails))]
        public virtual Purchaseinvoicedetail PurchaseInvoiceDetail { get; set; }
        [ForeignKey(nameof(TaxId))]
        [InverseProperty("Purchaseinvoicetaxdetails")]
        public virtual Tax Tax { get; set; }
    }
}
