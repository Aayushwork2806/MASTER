using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchasequotationremark")]
    [Index(nameof(PurchaseQuotationId), Name = "FK_PurchaseQuotationRemark_PurchaseQuotation")]
    public partial class Purchasequotationremark
    {
        [Key]
        public int Id { get; set; }
        public int PurchaseQuotationId { get; set; }
        [Required]
        [StringLength(100)]
        public string Remark { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }

        [ForeignKey(nameof(PurchaseQuotationId))]
        [InverseProperty(nameof(Purchasequotation.Purchasequotationremarks))]
        public virtual Purchasequotation PurchaseQuotation { get; set; }
    }
}
