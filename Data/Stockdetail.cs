using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stockdetails")]
    [Index(nameof(BusinessUnitId), Name = "FK_StockDetails_BusinessUnits")]
    [Index(nameof(ItemId), Name = "FK_StockDetails_Items")]
    [Index(nameof(StoreId), Name = "FK_StockDetails_Stores")]
    [Index(nameof(AddedBy), Name = "FK_StockDetails_Users")]
    public partial class Stockdetail
    {
        [Key]
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        [Required]
        [StringLength(2)]
        public string StockPostingType { get; set; }
        public int ItemId { get; set; }
        public int StoreId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal? QtyIn { get; set; }
        public decimal? QtyOut { get; set; }
        [StringLength(150)]
        public string Narration { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [MaxLength(6)]
        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Stockdetails))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Stockdetails))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Stockdetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Stockdetails")]
        public virtual Store Store { get; set; }
    }
}
