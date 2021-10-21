using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("receiptseries")]
    [Index(nameof(UnitId), Name = "FK_ReceiptSeries_BusinessUnits")]
    public partial class Receiptseries
    {
        public Receiptseries()
        {
            Feereceipts = new HashSet<Feereceipt>();
            Receiptseriesclasses = new HashSet<Receiptseriesclass>();
            Tmpfeereceipts = new HashSet<Tmpfeereceipt>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1)]
        public string RecSeries { get; set; }
        [Required]
        [StringLength(20)]
        public string Heading { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Receiptseries))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Feereceipt.Rseries))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Receiptseriesclass.Series))]
        public virtual ICollection<Receiptseriesclass> Receiptseriesclasses { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.Rseries))]
        public virtual ICollection<Tmpfeereceipt> Tmpfeereceipts { get; set; }
    }
}
