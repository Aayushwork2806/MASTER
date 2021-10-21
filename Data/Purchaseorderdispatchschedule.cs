using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseorderdispatchschedule")]
    [Index(nameof(PurchaseOrderIdetailId), Name = "FK_PurchaseOrderDispatchSchedule_PurchaseOrderDetail")]
    public partial class Purchaseorderdispatchschedule
    {
        [Key]
        public int Id { get; set; }
        [Column("PurchaseOrderIDetailId")]
        public int PurchaseOrderIdetailId { get; set; }
        public decimal Quantity { get; set; }
        [Column(TypeName = "date")]
        public DateTime ScheduleFromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ScheduleToDate { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(PurchaseOrderIdetailId))]
        [InverseProperty(nameof(Purchaseorderdetail.Purchaseorderdispatchschedules))]
        public virtual Purchaseorderdetail PurchaseOrderIdetail { get; set; }
    }
}
