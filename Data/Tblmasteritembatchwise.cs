using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tblmasteritembatchwise")]
    [Index(nameof(LngDeletedBy), Name = "FK_tblMasterItemBatchWise_Users")]
    [Index(nameof(LngItemId), Name = "FK_tblMasterItemBatchWise_tblMasterItem")]
    public partial class Tblmasteritembatchwise
    {
        public Tblmasteritembatchwise()
        {
            Tblmaterialreceiptdetails = new HashSet<Tblmaterialreceiptdetail>();
            Tblmaterialrequisitiondetails = new HashSet<Tblmaterialrequisitiondetail>();
        }

        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("lngItemId")]
        public int? LngItemId { get; set; }
        [Column("datExpiryDate", TypeName = "date")]
        public DateTime? DatExpiryDate { get; set; }
        [Column("strBatchNumber")]
        [StringLength(100)]
        public string StrBatchNumber { get; set; }
        [Column("decAcceptedQty")]
        public decimal? DecAcceptedQty { get; set; }
        [Column("decAvailableQty")]
        public decimal? DecAvailableQty { get; set; }
        [Column("lngDeletedBy")]
        public int? LngDeletedBy { get; set; }
        [Column("datDeletedDate")]
        [MaxLength(6)]
        public DateTime? DatDeletedDate { get; set; }
        [Column("blnDeleted")]
        public bool? BlnDeleted { get; set; }

        [ForeignKey(nameof(LngDeletedBy))]
        [InverseProperty(nameof(User.Tblmasteritembatchwises))]
        public virtual User LngDeletedByNavigation { get; set; }
        [ForeignKey(nameof(LngItemId))]
        [InverseProperty(nameof(Tblmasteritem.Tblmasteritembatchwises))]
        public virtual Tblmasteritem LngItem { get; set; }
        [InverseProperty(nameof(Tblmaterialreceiptdetail.LngBatchItem))]
        public virtual ICollection<Tblmaterialreceiptdetail> Tblmaterialreceiptdetails { get; set; }
        [InverseProperty(nameof(Tblmaterialrequisitiondetail.LngBatchItem))]
        public virtual ICollection<Tblmaterialrequisitiondetail> Tblmaterialrequisitiondetails { get; set; }
    }
}
