using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tblmaterialrequisition")]
    [Index(nameof(UnitId), Name = "FK_tblMaterialRequisition_BusinessUnits")]
    [Index(nameof(LngDepartmentId), Name = "FK_tblMaterialRequisition_Masters")]
    [Index(nameof(LngCreatedBy), Name = "FK_tblMaterialRequisition_Users")]
    [Index(nameof(LngApprovedBy), Name = "FK_tblMaterialRequisition_Users1")]
    public partial class Tblmaterialrequisition
    {
        public Tblmaterialrequisition()
        {
            Tblmaterialrequisitiondetails = new HashSet<Tblmaterialrequisitiondetail>();
            Tbltransactions = new HashSet<Tbltransaction>();
        }

        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("lngDocStatus")]
        public int LngDocStatus { get; set; }
        [Column("lngDepartmentId")]
        public int LngDepartmentId { get; set; }
        [Required]
        [Column("strDocumentNumber")]
        [StringLength(50)]
        public string StrDocumentNumber { get; set; }
        [Column("datDocumentDate")]
        [MaxLength(6)]
        public DateTime DatDocumentDate { get; set; }
        [Column("lngCreatedBy")]
        public int LngCreatedBy { get; set; }
        [Column("datCreatedDate")]
        [MaxLength(6)]
        public DateTime DatCreatedDate { get; set; }
        [Column("lngApprovedBy")]
        public int? LngApprovedBy { get; set; }
        [Column("datApprovedDate")]
        [MaxLength(6)]
        public DateTime? DatApprovedDate { get; set; }
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

        [ForeignKey(nameof(LngApprovedBy))]
        [InverseProperty(nameof(User.TblmaterialrequisitionLngApprovedByNavigations))]
        public virtual User LngApprovedByNavigation { get; set; }
        [ForeignKey(nameof(LngCreatedBy))]
        [InverseProperty(nameof(User.TblmaterialrequisitionLngCreatedByNavigations))]
        public virtual User LngCreatedByNavigation { get; set; }
        [ForeignKey(nameof(LngDepartmentId))]
        [InverseProperty(nameof(Master.Tblmaterialrequisitions))]
        public virtual Master LngDepartment { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Tblmaterialrequisitions))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Tblmaterialrequisitiondetail.LngRequisition))]
        public virtual ICollection<Tblmaterialrequisitiondetail> Tblmaterialrequisitiondetails { get; set; }
        [InverseProperty(nameof(Tbltransaction.LngDocument))]
        public virtual ICollection<Tbltransaction> Tbltransactions { get; set; }
    }
}
