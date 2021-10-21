using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("materialreceiptdetail")]
    [Index(nameof(ItemId), Name = "FK_MaterialReceiptDetail_Items")]
    [Index(nameof(MaterialReceiptId), Name = "FK_MaterialReceiptDetail_MaterialReceipt")]
    [Index(nameof(PurchaseOrderDetailId), Name = "FK_MaterialReceiptDetail_PurchaseOrderDetail")]
    public partial class Materialreceiptdetail
    {
        public Materialreceiptdetail()
        {
            Purchaseinvoicedetails = new HashSet<Purchaseinvoicedetail>();
            Purchasereturndetails = new HashSet<Purchasereturndetail>();
        }

        [Key]
        public int Id { get; set; }
        public int MaterialReceiptId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal ChallanQty { get; set; }
        public decimal ReceivedQty { get; set; }
        public decimal? ShortageQty { get; set; }
        public decimal? ExcessQty { get; set; }
        [Column("QtyUnderQC")]
        public decimal? QtyUnderQc { get; set; }
        public int? PurchaseOrderDetailId { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        public decimal? ApprovedQty { get; set; }
        public decimal? RejectedQty { get; set; }
        [Column("IsQCRequired")]
        public bool IsQcrequired { get; set; }
        [Column("QCDate")]
        [MaxLength(6)]
        public DateTime? Qcdate { get; set; }
        public decimal? BilledQty { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? PurchaseReturnQty { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }
        public decimal? FreeQty { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Materialreceiptdetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(MaterialReceiptId))]
        [InverseProperty(nameof(Materialreceipt.Materialreceiptdetails))]
        public virtual Materialreceipt MaterialReceipt { get; set; }
        [ForeignKey(nameof(PurchaseOrderDetailId))]
        [InverseProperty(nameof(Purchaseorderdetail.Materialreceiptdetails))]
        public virtual Purchaseorderdetail PurchaseOrderDetail { get; set; }
        [InverseProperty(nameof(Purchaseinvoicedetail.MaterialReceiptDetail))]
        public virtual ICollection<Purchaseinvoicedetail> Purchaseinvoicedetails { get; set; }
        [InverseProperty(nameof(Purchasereturndetail.MaterialReceiptDetail))]
        public virtual ICollection<Purchasereturndetail> Purchasereturndetails { get; set; }
    }
}
