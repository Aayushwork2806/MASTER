using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feerefund")]
    [Index(nameof(UnitId), Name = "FK_FeeRefund_BusinessUnits")]
    [Index(nameof(ScholarId), Name = "FK_FeeRefund_Scholar")]
    [Index(nameof(SessionId), Name = "FK_FeeRefund_Session")]
    public partial class Feerefund
    {
        public Feerefund()
        {
            Feerefunddtls = new HashSet<Feerefunddtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int RecNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime RecDate { get; set; }
        public int ScholarId { get; set; }
        [StringLength(7)]
        public string PayMode { get; set; }
        [StringLength(8)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(40)]
        public string ChqBank { get; set; }
        public long? Amount { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Feerefunds")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Feerefunds")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Feerefunds))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Feerefunddtl.Refund))]
        public virtual ICollection<Feerefunddtl> Feerefunddtls { get; set; }
    }
}
