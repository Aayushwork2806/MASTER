using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("itemstoremapping")]
    [Index(nameof(ItemId), Name = "FK_ItemStoreMapping_Items")]
    [Index(nameof(StoreId), Name = "FK_ItemStoreMapping_Stores")]
    public partial class Itemstoremapping
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int StoreId { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Itemstoremappings")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Itemstoremappings")]
        public virtual Store Store { get; set; }
    }
}
