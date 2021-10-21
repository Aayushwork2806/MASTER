using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchasereturn")]
    [Index(nameof(SupplierAccId), Name = "FK_PurchaseReturn_Accounts")]
    [Index(nameof(BusinessUnitId), Name = "FK_PurchaseReturn_BusinessUnits")]
    [Index(nameof(StoreId), Name = "FK_PurchaseReturn_Stores")]
    [Index(nameof(AddedBy), Name = "FK_PurchaseReturn_Users")]
    [Index(nameof(VoucherId), Name = "FK_PurchaseReturn_Voucher")]
    public partial class Purchasereturn
    {
        public Purchasereturn()
        {
            Purchasereturndetails = new HashSet<Purchasereturndetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime PurchaseReturnDate { get; set; }
        [Required]
        [StringLength(1)]
        public string ReturnType { get; set; }
        public int? SupplierId { get; set; }
        public int StoreId { get; set; }
        public int BusinessUnitId { get; set; }
        public decimal? BasicAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? ReturnAmount { get; set; }
        public int AddedBy { get; set; }
        public int? VoucherId { get; set; }
        public int? SupplierAccId { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Purchasereturns))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Purchasereturns))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Purchasereturns")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(SupplierAccId))]
        [InverseProperty(nameof(Account.Purchasereturns))]
        public virtual Account SupplierAcc { get; set; }
        [ForeignKey(nameof(VoucherId))]
        [InverseProperty("Purchasereturns")]
        public virtual Voucher Voucher { get; set; }
        [InverseProperty(nameof(Purchasereturndetail.PurchaseReturn))]
        public virtual ICollection<Purchasereturndetail> Purchasereturndetails { get; set; }
    }
}
