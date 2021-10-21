using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchasequotationtaxdetail")]
    [Index(nameof(TaxId), Name = "FK_PurchaseQuotationTaxDetail_Masters")]
    [Index(nameof(PurchaseQuotationDetailId), Name = "FK_PurchaseQuotationTaxDetail_PurchaseQuotationDetail")]
    public partial class Purchasequotationtaxdetail
    {
        [Key]
        public int Id { get; set; }
        public int PurchaseQuotationDetailId { get; set; }
        public int TaxId { get; set; }
        public decimal? TaxPer { get; set; }
        public decimal Amount { get; set; }
        public bool IncludeInItemRate { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(PurchaseQuotationDetailId))]
        [InverseProperty(nameof(Purchasequotationdetail.Purchasequotationtaxdetails))]
        public virtual Purchasequotationdetail PurchaseQuotationDetail { get; set; }
        [ForeignKey(nameof(TaxId))]
        [InverseProperty(nameof(Master.Purchasequotationtaxdetails))]
        public virtual Master Tax { get; set; }
    }
}
