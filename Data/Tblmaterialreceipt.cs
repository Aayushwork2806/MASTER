using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tblmaterialreceipt")]
    [Index(nameof(LngSupplierId), Name = "FK_tblMaterialReceipt_Accounts")]
    [Index(nameof(UnitId), Name = "FK_tblMaterialReceipt_BusinessUnits")]
    [Index(nameof(LngDepartmentId), Name = "FK_tblMaterialReceipt_Masters1")]
    [Index(nameof(LngCreatedBy), Name = "FK_tblMaterialReceipt_Users")]
    [Index(nameof(LastUpdatedBy), Name = "FK_tblMaterialReceipt_Users1")]
    public partial class Tblmaterialreceipt
    {
        public Tblmaterialreceipt()
        {
            Tblmaterialreceiptdetails = new HashSet<Tblmaterialreceiptdetail>();
            Tbltransactions = new HashSet<Tbltransaction>();
        }

        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("lngDocStatus")]
        public int? LngDocStatus { get; set; }
        [Column("lngDepartmentId")]
        public int? LngDepartmentId { get; set; }
        [Column("strMRNDocumentNumber")]
        [StringLength(50)]
        public string StrMrndocumentNumber { get; set; }
        [Column("strDocumentNumber")]
        [StringLength(50)]
        public string StrDocumentNumber { get; set; }
        [Column("datDocumentDate")]
        [MaxLength(6)]
        public DateTime? DatDocumentDate { get; set; }
        [Column("strReferenceNumber")]
        [StringLength(50)]
        public string StrReferenceNumber { get; set; }
        [Column("datReferenceDate")]
        [MaxLength(6)]
        public DateTime? DatReferenceDate { get; set; }
        [Column("lngSupplierId")]
        public int? LngSupplierId { get; set; }
        [Column("lngCreatedBy")]
        public int LngCreatedBy { get; set; }
        [Column("datCreatedDate")]
        [MaxLength(6)]
        public DateTime DatCreatedDate { get; set; }
        [Column("strNote")]
        [StringLength(500)]
        public string StrNote { get; set; }
        [Column("blnDeleted")]
        public bool BlnDeleted { get; set; }
        public int UnitId { get; set; }
        [Column("lastUpdatedBy")]
        public int? LastUpdatedBy { get; set; }
        [Column("lastUpdatedDate")]
        [MaxLength(6)]
        public DateTime? LastUpdatedDate { get; set; }

        [ForeignKey(nameof(LastUpdatedBy))]
        [InverseProperty(nameof(User.TblmaterialreceiptLastUpdatedByNavigations))]
        public virtual User LastUpdatedByNavigation { get; set; }
        [ForeignKey(nameof(LngCreatedBy))]
        [InverseProperty(nameof(User.TblmaterialreceiptLngCreatedByNavigations))]
        public virtual User LngCreatedByNavigation { get; set; }
        [ForeignKey(nameof(LngDepartmentId))]
        [InverseProperty(nameof(Master.Tblmaterialreceipts))]
        public virtual Master LngDepartment { get; set; }
        [ForeignKey(nameof(LngSupplierId))]
        [InverseProperty(nameof(Account.Tblmaterialreceipts))]
        public virtual Account LngSupplier { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Tblmaterialreceipts))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Tblmaterialreceiptdetail.LngReceipt))]
        public virtual ICollection<Tblmaterialreceiptdetail> Tblmaterialreceiptdetails { get; set; }
        [InverseProperty(nameof(Tbltransaction.LngReceipt))]
        public virtual ICollection<Tbltransaction> Tbltransactions { get; set; }
    }
}
