using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tblmaterialreceiptdetail")]
    [Index(nameof(Deletedby), Name = "FK_tblMaterialReceiptDetail_Users1")]
    [Index(nameof(LngItemId), Name = "FK_tblMaterialReceiptDetail_tblMasterItem1")]
    [Index(nameof(LngBatchItemId), Name = "FK_tblMaterialReceiptDetail_tblMasterItemBatchWise")]
    [Index(nameof(LngReceiptId), Name = "FK_tblMaterialReceiptDetail_tblMaterialReceipt")]
    public partial class Tblmaterialreceiptdetail
    {
        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("lngReceiptId")]
        public int? LngReceiptId { get; set; }
        [Column("lngItemId")]
        public int? LngItemId { get; set; }
        [Column("datExpiryDate", TypeName = "date")]
        public DateTime? DatExpiryDate { get; set; }
        [Column("strBatchNumber")]
        [StringLength(100)]
        public string StrBatchNumber { get; set; }
        [Column("lngWorkOrderId")]
        public int? LngWorkOrderId { get; set; }
        [Column("lngReceivedQty")]
        public decimal? LngReceivedQty { get; set; }
        [Column("lngRejectedQty")]
        public decimal? LngRejectedQty { get; set; }
        [Column("lngAcceptedQty")]
        public decimal? LngAcceptedQty { get; set; }
        [Column("strNote")]
        [StringLength(500)]
        public string StrNote { get; set; }
        public int? Deletedby { get; set; }
        [Column("datDeletedDate")]
        [MaxLength(6)]
        public DateTime? DatDeletedDate { get; set; }
        [Column("blnDeleted")]
        public bool? BlnDeleted { get; set; }
        [Column("lngBatchItemId")]
        public int? LngBatchItemId { get; set; }
        [Column("datMFGDate", TypeName = "date")]
        public DateTime? DatMfgdate { get; set; }

        [ForeignKey(nameof(Deletedby))]
        [InverseProperty(nameof(User.Tblmaterialreceiptdetails))]
        public virtual User DeletedbyNavigation { get; set; }
        [ForeignKey(nameof(LngBatchItemId))]
        [InverseProperty(nameof(Tblmasteritembatchwise.Tblmaterialreceiptdetails))]
        public virtual Tblmasteritembatchwise LngBatchItem { get; set; }
        [ForeignKey(nameof(LngItemId))]
        [InverseProperty(nameof(Tblmasteritem.Tblmaterialreceiptdetails))]
        public virtual Tblmasteritem LngItem { get; set; }
        [ForeignKey(nameof(LngReceiptId))]
        [InverseProperty(nameof(Tblmaterialreceipt.Tblmaterialreceiptdetails))]
        public virtual Tblmaterialreceipt LngReceipt { get; set; }
    }
}
