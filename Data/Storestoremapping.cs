using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("storestoremapping")]
    [Index(nameof(StoreId1), Name = "FK_StoreStoreMapping_Stores")]
    [Index(nameof(StoreId2), Name = "FK_StoreStoreMapping_Stores1")]
    public partial class Storestoremapping
    {
        [Key]
        public int Id { get; set; }
        public int StoreId1 { get; set; }
        public int StoreId2 { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(StoreId1))]
        [InverseProperty(nameof(Store.StorestoremappingStoreId1Navigations))]
        public virtual Store StoreId1Navigation { get; set; }
        [ForeignKey(nameof(StoreId2))]
        [InverseProperty(nameof(Store.StorestoremappingStoreId2Navigations))]
        public virtual Store StoreId2Navigation { get; set; }
    }
}
