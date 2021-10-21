using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stocktransferrequestdetail")]
    [Index(nameof(ItemId), Name = "FK_StockTransferRequestDetail_Items")]
    [Index(nameof(StockTransferRequestId), Name = "FK_StockTransferRequestDetail_StockTransferRequest")]
    public partial class Stocktransferrequestdetail
    {
        public Stocktransferrequestdetail()
        {
            Stocktransferdetails = new HashSet<Stocktransferdetail>();
        }

        [Key]
        public int Id { get; set; }
        public int StockTransferRequestId { get; set; }
        public int ItemId { get; set; }
        public decimal RequestedQty { get; set; }
        public decimal? IssuedQty { get; set; }
        public decimal? RejectedQty { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Stocktransferrequestdetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(StockTransferRequestId))]
        [InverseProperty(nameof(Stocktransferrequest.Stocktransferrequestdetails))]
        public virtual Stocktransferrequest StockTransferRequest { get; set; }
        [InverseProperty(nameof(Stocktransferdetail.StockTransferRequestDetail))]
        public virtual ICollection<Stocktransferdetail> Stocktransferdetails { get; set; }
    }
}
