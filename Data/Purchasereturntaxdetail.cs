using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchasereturntaxdetail")]
    [Index(nameof(PurchaseReturnDetailId), Name = "FK_PurchaseReturnTaxDetail_PurchaseReturnDetail")]
    [Index(nameof(TaxId), Name = "FK_PurchaseReturnTaxDetail_Tax")]
    public partial class Purchasereturntaxdetail
    {
        [Key]
        public int Id { get; set; }
        public int PurchaseReturnDetailId { get; set; }
        public int TaxId { get; set; }
        public decimal TaxAmount { get; set; }
        public bool IncludedInRate { get; set; }

        [ForeignKey(nameof(PurchaseReturnDetailId))]
        [InverseProperty(nameof(Purchasereturndetail.Purchasereturntaxdetails))]
        public virtual Purchasereturndetail PurchaseReturnDetail { get; set; }
        [ForeignKey(nameof(TaxId))]
        [InverseProperty("Purchasereturntaxdetails")]
        public virtual Tax Tax { get; set; }
    }
}
