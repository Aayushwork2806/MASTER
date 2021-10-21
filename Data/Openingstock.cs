using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("openingstock")]
    [Index(nameof(BusinessUnitId), Name = "FK_OpeningStock_BusinessUnits")]
    [Index(nameof(ItemId), Name = "FK_OpeningStock_Items")]
    [Index(nameof(StoreId), Name = "FK_OpeningStock_Stores")]
    [Index(nameof(AddedBy), Name = "FK_OpeningStock_Users")]
    public partial class Openingstock
    {
        [Key]
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public int StoreId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal? SaleRate { get; set; }
        [Column("MRP")]
        public decimal? Mrp { get; set; }
        [MaxLength(6)]
        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Openingstocks))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Openingstocks))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Openingstocks")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Openingstocks")]
        public virtual Store Store { get; set; }
    }
}
