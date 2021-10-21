using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseinvoice")]
    [Index(nameof(SupplierAccId), Name = "FK_PurchaseInvoice_Accounts")]
    [Index(nameof(BusinessUnitId), Name = "FK_PurchaseInvoice_BusinessUnits")]
    [Index(nameof(StoreId), Name = "FK_PurchaseInvoice_Stores")]
    [Index(nameof(AddedBy), Name = "FK_PurchaseInvoice_Users")]
    [Index(nameof(VoucherId), Name = "FK_PurchaseInvoice_Voucher")]
    [Index(nameof(ReturnVoucherId), Name = "FK_PurchaseInvoice_Voucher1")]
    public partial class Purchaseinvoice
    {
        public Purchaseinvoice()
        {
            Purchaseinvoicedetails = new HashSet<Purchaseinvoicedetail>();
        }

        [Key]
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public int StoreId { get; set; }
        public int? SupplierId { get; set; }
        [Required]
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime InvoiceDate { get; set; }
        public decimal BilledBasicAmount { get; set; }
        public decimal PassedBasicAmount { get; set; }
        public decimal BilledTaxAmount { get; set; }
        public decimal PassedTaxAmount { get; set; }
        public decimal? RoundOff { get; set; }
        public decimal? DiscountPer { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal BilledAmount { get; set; }
        public decimal PassedAmount { get; set; }
        public decimal? ReturnBasicAmount { get; set; }
        public decimal? ReturnTaxAmount { get; set; }
        public decimal? ReturnAmount { get; set; }
        public int AddedBy { get; set; }
        [MaxLength(6)]
        public DateTime AddedOn { get; set; }
        public int? VoucherId { get; set; }
        public bool IsApproved { get; set; }
        public int? ReturnVoucherId { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }
        public int? SupplierAccId { get; set; }
        public decimal? AdjAmt { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Purchaseinvoices))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Purchaseinvoices))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(ReturnVoucherId))]
        [InverseProperty("PurchaseinvoiceReturnVouchers")]
        public virtual Voucher ReturnVoucher { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Purchaseinvoices")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(SupplierAccId))]
        [InverseProperty(nameof(Account.Purchaseinvoices))]
        public virtual Account SupplierAcc { get; set; }
        [ForeignKey(nameof(VoucherId))]
        [InverseProperty("PurchaseinvoiceVouchers")]
        public virtual Voucher Voucher { get; set; }
        [InverseProperty(nameof(Purchaseinvoicedetail.PurchaseInvoice))]
        public virtual ICollection<Purchaseinvoicedetail> Purchaseinvoicedetails { get; set; }
    }
}
