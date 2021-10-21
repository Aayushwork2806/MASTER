using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stockreceivedetail")]
    [Index(nameof(ItemId), Name = "FK_StockReceiveDetail_Items")]
    [Index(nameof(StockReceiveId), Name = "FK_StockReceiveDetail_StockReceive")]
    [Index(nameof(StockTransferDetailId), Name = "FK_StockReceiveDetail_StockTransferDetail")]
    public partial class Stockreceivedetail
    {
        [Key]
        public int Id { get; set; }
        public int StockReceiveId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal Quantity { get; set; }
        public int StockTransferDetailId { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Stockreceivedetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(StockReceiveId))]
        [InverseProperty(nameof(Stockreceive.Stockreceivedetails))]
        public virtual Stockreceive StockReceive { get; set; }
        [ForeignKey(nameof(StockTransferDetailId))]
        [InverseProperty(nameof(Stocktransferdetail.Stockreceivedetails))]
        public virtual Stocktransferdetail StockTransferDetail { get; set; }
    }
}
