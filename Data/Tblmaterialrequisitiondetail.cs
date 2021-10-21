using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tblmaterialrequisitiondetail")]
    [Index(nameof(Deletedby), Name = "FK_tblMaterialRequisitionDetail_Users")]
    [Index(nameof(LngItemId), Name = "FK_tblMaterialRequisitionDetail_tblMasterItem")]
    [Index(nameof(LngBatchItemId), Name = "FK_tblMaterialRequisitionDetail_tblMasterItemBatchWise")]
    [Index(nameof(LngRequisitionId), Name = "FK_tblMaterialRequisitionDetail_tblMaterialRequisition")]
    public partial class Tblmaterialrequisitiondetail
    {
        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("lngRequisitionId")]
        public int LngRequisitionId { get; set; }
        [Column("lngItemId")]
        public int LngItemId { get; set; }
        [Column("lngWorkOrderId")]
        public int? LngWorkOrderId { get; set; }
        public decimal Qty { get; set; }
        [Column("strNote")]
        [StringLength(200)]
        public string StrNote { get; set; }
        public int? Deletedby { get; set; }
        [Column("datDeletedDate")]
        [MaxLength(6)]
        public DateTime? DatDeletedDate { get; set; }
        public bool? Deleted { get; set; }
        [Column("datExpiryDate", TypeName = "date")]
        public DateTime? DatExpiryDate { get; set; }
        [Column("strBatchNumber")]
        [StringLength(100)]
        public string StrBatchNumber { get; set; }
        [Column("lngBatchItemId")]
        public int? LngBatchItemId { get; set; }

        [ForeignKey(nameof(Deletedby))]
        [InverseProperty(nameof(User.Tblmaterialrequisitiondetails))]
        public virtual User DeletedbyNavigation { get; set; }
        [ForeignKey(nameof(LngBatchItemId))]
        [InverseProperty(nameof(Tblmasteritembatchwise.Tblmaterialrequisitiondetails))]
        public virtual Tblmasteritembatchwise LngBatchItem { get; set; }
        [ForeignKey(nameof(LngItemId))]
        [InverseProperty(nameof(Tblmasteritem.Tblmaterialrequisitiondetails))]
        public virtual Tblmasteritem LngItem { get; set; }
        [ForeignKey(nameof(LngRequisitionId))]
        [InverseProperty(nameof(Tblmaterialrequisition.Tblmaterialrequisitiondetails))]
        public virtual Tblmaterialrequisition LngRequisition { get; set; }
    }
}
