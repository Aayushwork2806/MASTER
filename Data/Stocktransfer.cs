using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stocktransfer")]
    [Index(nameof(BusinessUnitId), Name = "FK_StockTransfer_BusinessUnits")]
    [Index(nameof(FromStoreId), Name = "FK_StockTransfer_Stores")]
    [Index(nameof(ToStoreId), Name = "FK_StockTransfer_Stores1")]
    [Index(nameof(AddedBy), Name = "FK_StockTransfer_Users")]
    public partial class Stocktransfer
    {
        public Stocktransfer()
        {
            Stocktransferdetails = new HashSet<Stocktransferdetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime StockTransferDate { get; set; }
        public int BusinessUnitId { get; set; }
        public int FromStoreId { get; set; }
        public int ToStoreId { get; set; }
        public int AddedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Stocktransfers))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Stocktransfers))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(FromStoreId))]
        [InverseProperty(nameof(Store.StocktransferFromStores))]
        public virtual Store FromStore { get; set; }
        [ForeignKey(nameof(ToStoreId))]
        [InverseProperty(nameof(Store.StocktransferToStores))]
        public virtual Store ToStore { get; set; }
        [InverseProperty(nameof(Stocktransferdetail.StockTransfer))]
        public virtual ICollection<Stocktransferdetail> Stocktransferdetails { get; set; }
    }
}
