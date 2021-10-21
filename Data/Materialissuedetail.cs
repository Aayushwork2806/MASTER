using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("materialissuedetail")]
    [Index(nameof(ItemId), Name = "FK_MaterialIssueDetail_Items")]
    [Index(nameof(MaterialIssueId), Name = "FK_MaterialIssueDetail_MaterialIssue")]
    [Index(nameof(MaterialRequisitionDetailId), Name = "FK_MaterialIssueDetail_MaterialRequisitionDetail")]
    [Index(nameof(PurchaseIndentDetailId), Name = "FK_MaterialIssueDetail_PurchaseIndentDetail")]
    public partial class Materialissuedetail
    {
        public Materialissuedetail()
        {
            Materialreturndetails = new HashSet<Materialreturndetail>();
        }

        [Key]
        public int Id { get; set; }
        public int MaterialIssueId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal RequestedQty { get; set; }
        public decimal IssuedQty { get; set; }
        public decimal? RejectedQty { get; set; }
        public int? MaterialRequisitionDetailId { get; set; }
        public decimal? ReturnQty { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }
        public decimal? ConsumeQty { get; set; }
        public int? PurchaseIndentDetailId { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Materialissuedetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(MaterialIssueId))]
        [InverseProperty(nameof(Materialissue.Materialissuedetails))]
        public virtual Materialissue MaterialIssue { get; set; }
        [ForeignKey(nameof(MaterialRequisitionDetailId))]
        [InverseProperty(nameof(Materialrequisitiondetail.Materialissuedetails))]
        public virtual Materialrequisitiondetail MaterialRequisitionDetail { get; set; }
        [ForeignKey(nameof(PurchaseIndentDetailId))]
        [InverseProperty(nameof(Purchaseindentdetail.Materialissuedetails))]
        public virtual Purchaseindentdetail PurchaseIndentDetail { get; set; }
        [InverseProperty(nameof(Materialreturndetail.MaterialIssueDetail))]
        public virtual ICollection<Materialreturndetail> Materialreturndetails { get; set; }
    }
}
