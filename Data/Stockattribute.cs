using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stockattribute")]
    [Index(nameof(BusinessUnitId), Name = "FK_StockAttribute_BusinessUnits")]
    [Index(nameof(ItemId), Name = "FK_StockAttribute_Items")]
    [Index(nameof(TaxId), Name = "FK_StockAttribute_Tax")]
    public partial class Stockattribute
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal? PurchaseRate { get; set; }
        [Column("MRP")]
        public decimal? Mrp { get; set; }
        public decimal? SaleRate { get; set; }
        public int BusinessUnitId { get; set; }
        public int? TaxId { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Stockattributes))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Stockattributes")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(TaxId))]
        [InverseProperty("Stockattributes")]
        public virtual Tax Tax { get; set; }
    }
}
