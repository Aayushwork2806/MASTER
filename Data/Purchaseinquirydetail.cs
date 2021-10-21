using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseinquirydetail")]
    [Index(nameof(ItemId), Name = "FK_PurchaseInquiryDetail_Items")]
    [Index(nameof(PurchaseIndentDetailId), Name = "FK_PurchaseInquiryDetail_PurchaseIndentDetail")]
    [Index(nameof(PurchaseInquiryId), Name = "FK_PurchaseInquiryDetail_PurchaseInquiry")]
    public partial class Purchaseinquirydetail
    {
        [Key]
        public int Id { get; set; }
        public int PurchaseInquiryId { get; set; }
        public int ItemId { get; set; }
        public decimal? Quantity { get; set; }
        [MaxLength(6)]
        public DateTime? RequiredDate { get; set; }
        public int? PurchaseIndentDetailId { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Purchaseinquirydetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(PurchaseIndentDetailId))]
        [InverseProperty(nameof(Purchaseindentdetail.Purchaseinquirydetails))]
        public virtual Purchaseindentdetail PurchaseIndentDetail { get; set; }
        [ForeignKey(nameof(PurchaseInquiryId))]
        [InverseProperty(nameof(Purchaseinquiry.Purchaseinquirydetails))]
        public virtual Purchaseinquiry PurchaseInquiry { get; set; }
    }
}
