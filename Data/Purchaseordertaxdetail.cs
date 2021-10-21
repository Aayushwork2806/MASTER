using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseordertaxdetail")]
    [Index(nameof(PurchaseOrderDetailId), Name = "FK_PurchaseOrderTaxDetail_PurchaseOrderDetail")]
    [Index(nameof(TaxId), Name = "FK_PurchaseOrderTaxDetail_Tax")]
    public partial class Purchaseordertaxdetail
    {
        [Key]
        public int Id { get; set; }
        public int PurchaseOrderDetailId { get; set; }
        public int TaxId { get; set; }
        public decimal? TaxPer { get; set; }
        public decimal Amount { get; set; }
        public bool IncludeInItemRate { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(PurchaseOrderDetailId))]
        [InverseProperty(nameof(Purchaseorderdetail.Purchaseordertaxdetails))]
        public virtual Purchaseorderdetail PurchaseOrderDetail { get; set; }
        [ForeignKey(nameof(TaxId))]
        [InverseProperty("Purchaseordertaxdetails")]
        public virtual Tax Tax { get; set; }
    }
}
