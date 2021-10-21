using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("physicalstock")]
    [Index(nameof(BusinessUnitId), Name = "FK_PhysicalStock_BusinessUnits")]
    [Index(nameof(StoreId), Name = "FK_PhysicalStock_Stores")]
    [Index(nameof(AddedBy), Name = "FK_PhysicalStock_Users")]
    public partial class Physicalstock
    {
        public Physicalstock()
        {
            Physicalstockdetails = new HashSet<Physicalstockdetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime PhysicalStockDate { get; set; }
        public int BusinessUnitId { get; set; }
        public int StoreId { get; set; }
        public int AddedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Physicalstocks))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Physicalstocks))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Physicalstocks")]
        public virtual Store Store { get; set; }
        [InverseProperty(nameof(Physicalstockdetail.PhysicalStock))]
        public virtual ICollection<Physicalstockdetail> Physicalstockdetails { get; set; }
    }
}
