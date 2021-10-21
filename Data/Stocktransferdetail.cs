using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stocktransferdetail")]
    [Index(nameof(ItemId), Name = "FK_StockTransferDetail_Items")]
    [Index(nameof(StockTransferId), Name = "FK_StockTransferDetail_StockTransfer")]
    [Index(nameof(StockTransferRequestDetailId), Name = "FK_StockTransferDetail_StockTransferRequestDetail")]
    public partial class Stocktransferdetail
    {
        public Stocktransferdetail()
        {
            Stockreceivedetails = new HashSet<Stockreceivedetail>();
        }

        [Key]
        public int Id { get; set; }
        public int StockTransferId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal? RejectedQty { get; set; }
        public int? StockTransferRequestDetailId { get; set; }
        public decimal ReceivedQty { get; set; }
        [Required]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Stocktransferdetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(StockTransferId))]
        [InverseProperty(nameof(Stocktransfer.Stocktransferdetails))]
        public virtual Stocktransfer StockTransfer { get; set; }
        [ForeignKey(nameof(StockTransferRequestDetailId))]
        [InverseProperty(nameof(Stocktransferrequestdetail.Stocktransferdetails))]
        public virtual Stocktransferrequestdetail StockTransferRequestDetail { get; set; }
        [InverseProperty(nameof(Stockreceivedetail.StockTransferDetail))]
        public virtual ICollection<Stockreceivedetail> Stockreceivedetails { get; set; }
    }
}
