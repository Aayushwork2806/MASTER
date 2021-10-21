using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("physicalstockdetail")]
    [Index(nameof(ItemId), Name = "FK_PhysicalStockDetail_Items")]
    [Index(nameof(PhysicalStockId), Name = "FK_PhysicalStockDetail_PhysicalStock")]
    public partial class Physicalstockdetail
    {
        [Key]
        public int Id { get; set; }
        public int PhysicalStockId { get; set; }
        public int ItemId { get; set; }
        public decimal Quantity { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Physicalstockdetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(PhysicalStockId))]
        [InverseProperty(nameof(Physicalstock.Physicalstockdetails))]
        public virtual Physicalstock PhysicalStock { get; set; }
    }
}
