using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stocktransferrequest")]
    [Index(nameof(BusinessUnitId), Name = "FK_StockTransferRequest_BusinessUnits")]
    [Index(nameof(FromStoreId), Name = "FK_StockTransferRequest_Stores")]
    [Index(nameof(ToStoreId), Name = "FK_StockTransferRequest_Stores1")]
    [Index(nameof(AddedBy), Name = "FK_StockTransferRequest_Users")]
    public partial class Stocktransferrequest
    {
        public Stocktransferrequest()
        {
            Stocktransferrequestdetails = new HashSet<Stocktransferrequestdetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime StockTransferRequestDate { get; set; }
        public int BusinessUnitId { get; set; }
        public int FromStoreId { get; set; }
        public int ToStoreId { get; set; }
        public int AddedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Stocktransferrequests))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Stocktransferrequests))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(FromStoreId))]
        [InverseProperty(nameof(Store.StocktransferrequestFromStores))]
        public virtual Store FromStore { get; set; }
        [ForeignKey(nameof(ToStoreId))]
        [InverseProperty(nameof(Store.StocktransferrequestToStores))]
        public virtual Store ToStore { get; set; }
        [InverseProperty(nameof(Stocktransferrequestdetail.StockTransferRequest))]
        public virtual ICollection<Stocktransferrequestdetail> Stocktransferrequestdetails { get; set; }
    }
}
