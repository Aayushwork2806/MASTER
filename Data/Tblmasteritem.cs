using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tblmasteritem")]
    [Index(nameof(UnitId), Name = "FK_tblMasterItem_BusinessUnits")]
    [Index(nameof(ItemCategoryId), Name = "FK_tblMasterItem_Masters")]
    [Index(nameof(Uomid), Name = "FK_tblMasterItem_Masters1")]
    [Index(nameof(AddedBy), Name = "FK_tblMasterItem_Users")]
    [Index(nameof(LastUpBy), Name = "FK_tblMasterItem_Users1")]
    public partial class Tblmasteritem
    {
        public Tblmasteritem()
        {
            Tblmasteritembatchwises = new HashSet<Tblmasteritembatchwise>();
            Tblmaterialreceiptdetails = new HashSet<Tblmaterialreceiptdetail>();
            Tblmaterialrequisitiondetails = new HashSet<Tblmaterialrequisitiondetail>();
            Tbltransactions = new HashSet<Tbltransaction>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Identifier { get; set; }
        [StringLength(50)]
        public string PartNumber { get; set; }
        [StringLength(100)]
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int? ItemCategoryId { get; set; }
        public long? MinStockLevel { get; set; }
        public long? MaxStockLevel { get; set; }
        [Column("UOMId")]
        public int? Uomid { get; set; }
        public decimal? Reprocurement { get; set; }
        public decimal? LeadTime { get; set; }
        [StringLength(50)]
        public string LeadTimeUnit { get; set; }
        public decimal? Buffer { get; set; }
        public int? AddedBy { get; set; }
        [MaxLength(6)]
        public DateTime? AddedOn { get; set; }
        public int? LastUpBy { get; set; }
        [MaxLength(6)]
        public DateTime? LastUpOn { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.TblmasteritemAddedByNavigations))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(ItemCategoryId))]
        [InverseProperty(nameof(Master.TblmasteritemItemCategories))]
        public virtual Master ItemCategory { get; set; }
        [ForeignKey(nameof(LastUpBy))]
        [InverseProperty(nameof(User.TblmasteritemLastUpByNavigations))]
        public virtual User LastUpByNavigation { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Tblmasteritems))]
        public virtual Businessunit Unit { get; set; }
        [ForeignKey(nameof(Uomid))]
        [InverseProperty(nameof(Master.TblmasteritemUoms))]
        public virtual Master Uom { get; set; }
        [InverseProperty(nameof(Tblmasteritembatchwise.LngItem))]
        public virtual ICollection<Tblmasteritembatchwise> Tblmasteritembatchwises { get; set; }
        [InverseProperty(nameof(Tblmaterialreceiptdetail.LngItem))]
        public virtual ICollection<Tblmaterialreceiptdetail> Tblmaterialreceiptdetails { get; set; }
        [InverseProperty(nameof(Tblmaterialrequisitiondetail.LngItem))]
        public virtual ICollection<Tblmaterialrequisitiondetail> Tblmaterialrequisitiondetails { get; set; }
        [InverseProperty(nameof(Tbltransaction.LngItem))]
        public virtual ICollection<Tbltransaction> Tbltransactions { get; set; }
    }
}
