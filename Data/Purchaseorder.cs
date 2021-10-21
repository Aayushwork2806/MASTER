using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseorder")]
    [Index(nameof(SupplierAccId), Name = "FK_PurchaseOrder_Accounts")]
    [Index(nameof(BusinessUnitId), Name = "FK_PurchaseOrder_BusinessUnits")]
    [Index(nameof(StoreId), Name = "FK_PurchaseOrder_Stores")]
    [Index(nameof(AddedBy), Name = "FK_PurchaseOrder_Users")]
    public partial class Purchaseorder
    {
        public Purchaseorder()
        {
            Purchaseindentdetails = new HashSet<Purchaseindentdetail>();
            Purchaseorderdetails = new HashSet<Purchaseorderdetail>();
            Purchaseorderremarks = new HashSet<Purchaseorderremark>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime PurchaseOrderDate { get; set; }
        public int? PurchaseOrderNo { get; set; }
        public int? SupplierId { get; set; }
        public int StoreId { get; set; }
        public decimal BasicAmount { get; set; }
        public decimal? BillDiscount { get; set; }
        public decimal? BillDiscountPer { get; set; }
        public decimal AmountAfterDiscount { get; set; }
        public decimal AmountAfterTax { get; set; }
        [Required]
        [StringLength(2)]
        public string SourceDoc { get; set; }
        public int AddedBy { get; set; }
        [MaxLength(6)]
        public DateTime AddedOn { get; set; }
        public int BusinessUnitId { get; set; }
        public int? SupplierAccId { get; set; }
        public bool IsCancel { get; set; }
        public bool IsClose { get; set; }
        [StringLength(250)]
        public string Remark { get; set; }
        [StringLength(0)]
        public string DeliveryInst { get; set; }
        [StringLength(200)]
        public string DeliveryAt { get; set; }
        [StringLength(2)]
        public string Freight { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? OrderValue { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Purchaseorders))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Purchaseorders))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Purchaseorders")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(SupplierAccId))]
        [InverseProperty(nameof(Account.Purchaseorders))]
        public virtual Account SupplierAcc { get; set; }
        [InverseProperty(nameof(Purchaseindentdetail.Order))]
        public virtual ICollection<Purchaseindentdetail> Purchaseindentdetails { get; set; }
        [InverseProperty(nameof(Purchaseorderdetail.PurchaseOrder))]
        public virtual ICollection<Purchaseorderdetail> Purchaseorderdetails { get; set; }
        [InverseProperty(nameof(Purchaseorderremark.PurchaseOrder))]
        public virtual ICollection<Purchaseorderremark> Purchaseorderremarks { get; set; }
    }
}
