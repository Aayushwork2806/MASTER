using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("materialrequisitiondetail")]
    [Index(nameof(ItemId), Name = "FK_MaterialRequisitionDetail_Items")]
    [Index(nameof(MaterialRequisitionId), Name = "FK_MaterialRequisitionDetail_MaterialRequisition")]
    public partial class Materialrequisitiondetail
    {
        public Materialrequisitiondetail()
        {
            Materialissuedetails = new HashSet<Materialissuedetail>();
        }

        [Key]
        public int Id { get; set; }
        public int MaterialRequisitionId { get; set; }
        public int ItemId { get; set; }
        public decimal RequestedQty { get; set; }
        public decimal? IssuedQty { get; set; }
        public decimal? RejectedQty { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Materialrequisitiondetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(MaterialRequisitionId))]
        [InverseProperty(nameof(Materialrequisition.Materialrequisitiondetails))]
        public virtual Materialrequisition MaterialRequisition { get; set; }
        [InverseProperty(nameof(Materialissuedetail.MaterialRequisitionDetail))]
        public virtual ICollection<Materialissuedetail> Materialissuedetails { get; set; }
    }
}
