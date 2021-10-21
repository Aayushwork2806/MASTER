using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseindentdetail")]
    [Index(nameof(ItemId), Name = "FK_PurchaseIndentDetail_Items")]
    [Index(nameof(PurchaseIndentId), Name = "FK_PurchaseIndentDetail_PurchaseIndent")]
    [Index(nameof(OrderId), Name = "FK_PurchaseIndentDetail_PurchaseOrder")]
    public partial class Purchaseindentdetail
    {
        public Purchaseindentdetail()
        {
            Materialissuedetails = new HashSet<Materialissuedetail>();
            Purchaseinquirydetails = new HashSet<Purchaseinquirydetail>();
        }

        [Key]
        public int Id { get; set; }
        public int PurchaseIndentId { get; set; }
        public int ItemId { get; set; }
        public decimal? Quantity { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpectedBy { get; set; }
        [StringLength(50)]
        public string Remarks { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }
        public bool? OrderGenerated { get; set; }
        public int? OrderId { get; set; }
        public decimal? QtyReceived { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Purchaseindentdetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty(nameof(Purchaseorder.Purchaseindentdetails))]
        public virtual Purchaseorder Order { get; set; }
        [ForeignKey(nameof(PurchaseIndentId))]
        [InverseProperty(nameof(Purchaseindent.Purchaseindentdetails))]
        public virtual Purchaseindent PurchaseIndent { get; set; }
        [InverseProperty(nameof(Materialissuedetail.PurchaseIndentDetail))]
        public virtual ICollection<Materialissuedetail> Materialissuedetails { get; set; }
        [InverseProperty(nameof(Purchaseinquirydetail.PurchaseIndentDetail))]
        public virtual ICollection<Purchaseinquirydetail> Purchaseinquirydetails { get; set; }
    }
}
