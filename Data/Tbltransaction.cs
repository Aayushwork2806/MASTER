using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbltransaction")]
    [Index(nameof(DeletedBy), Name = "FK_tblTransaction_Users")]
    [Index(nameof(LngItemId), Name = "FK_tblTransaction_tblMasterItem")]
    [Index(nameof(LngReceiptId), Name = "FK_tblTransaction_tblMaterialReceipt")]
    [Index(nameof(LngDocumentId), Name = "FK_tblTransaction_tblMaterialRequisition")]
    public partial class Tbltransaction
    {
        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("lngDocumentId")]
        public int? LngDocumentId { get; set; }
        [Column("lngReceiptId")]
        public int? LngReceiptId { get; set; }
        [Column("lngDocType")]
        public int LngDocType { get; set; }
        [Required]
        [Column("strDocumentNumber")]
        [StringLength(50)]
        public string StrDocumentNumber { get; set; }
        [Column("datDocumentDate")]
        [MaxLength(6)]
        public DateTime DatDocumentDate { get; set; }
        [Column("lngItemId")]
        public int LngItemId { get; set; }
        public long Qty { get; set; }
        [Column("lngLocationBinBufferId")]
        public int? LngLocationBinBufferId { get; set; }
        public int? DeletedBy { get; set; }
        [Column("datDeletedDate")]
        [MaxLength(6)]
        public DateTime? DatDeletedDate { get; set; }
        public bool Deleted { get; set; }
        [Column("datMFGDate", TypeName = "date")]
        public DateTime? DatMfgdate { get; set; }
        [Column("datExpiryDate", TypeName = "date")]
        public DateTime? DatExpiryDate { get; set; }
        [Column("strBatchNumber")]
        [StringLength(100)]
        public string StrBatchNumber { get; set; }

        [ForeignKey(nameof(DeletedBy))]
        [InverseProperty(nameof(User.Tbltransactions))]
        public virtual User DeletedByNavigation { get; set; }
        [ForeignKey(nameof(LngDocumentId))]
        [InverseProperty(nameof(Tblmaterialrequisition.Tbltransactions))]
        public virtual Tblmaterialrequisition LngDocument { get; set; }
        [ForeignKey(nameof(LngItemId))]
        [InverseProperty(nameof(Tblmasteritem.Tbltransactions))]
        public virtual Tblmasteritem LngItem { get; set; }
        [ForeignKey(nameof(LngReceiptId))]
        [InverseProperty(nameof(Tblmaterialreceipt.Tbltransactions))]
        public virtual Tblmaterialreceipt LngReceipt { get; set; }
    }
}
