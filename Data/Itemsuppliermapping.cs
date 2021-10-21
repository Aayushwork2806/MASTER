using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("itemsuppliermapping")]
    [Index(nameof(SupplierId), Name = "FK_ItemSupplierMapping_Accounts")]
    [Index(nameof(ItemId), Name = "FK_ItemSupplierMapping_Items")]
    public partial class Itemsuppliermapping
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int SupplierId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Itemsuppliermappings")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(SupplierId))]
        [InverseProperty(nameof(Account.Itemsuppliermappings))]
        public virtual Account Supplier { get; set; }
    }
}
