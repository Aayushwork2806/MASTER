using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseorderremark")]
    [Index(nameof(PurchaseOrderId), Name = "FK_PurchaseOrderRemark_PurchaseOrder")]
    public partial class Purchaseorderremark
    {
        [Key]
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        [Required]
        [StringLength(100)]
        public string Remark { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }

        [ForeignKey(nameof(PurchaseOrderId))]
        [InverseProperty(nameof(Purchaseorder.Purchaseorderremarks))]
        public virtual Purchaseorder PurchaseOrder { get; set; }
    }
}
