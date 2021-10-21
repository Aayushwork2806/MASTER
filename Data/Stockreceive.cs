using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stockreceive")]
    [Index(nameof(BusinessUnitId), Name = "FK_StockReceive_BusinessUnits")]
    [Index(nameof(FromStoreId), Name = "FK_StockReceive_Stores")]
    [Index(nameof(ToStoreId), Name = "FK_StockReceive_Stores1")]
    [Index(nameof(AddedBy), Name = "FK_StockReceive_Users")]
    public partial class Stockreceive
    {
        public Stockreceive()
        {
            Stockreceivedetails = new HashSet<Stockreceivedetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime StockReceiveDate { get; set; }
        public int BusinessUnitId { get; set; }
        public int FromStoreId { get; set; }
        public int ToStoreId { get; set; }
        public int AddedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Stockreceives))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Stockreceives))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(FromStoreId))]
        [InverseProperty(nameof(Store.StockreceiveFromStores))]
        public virtual Store FromStore { get; set; }
        [ForeignKey(nameof(ToStoreId))]
        [InverseProperty(nameof(Store.StockreceiveToStores))]
        public virtual Store ToStore { get; set; }
        [InverseProperty(nameof(Stockreceivedetail.StockReceive))]
        public virtual ICollection<Stockreceivedetail> Stockreceivedetails { get; set; }
    }
}
