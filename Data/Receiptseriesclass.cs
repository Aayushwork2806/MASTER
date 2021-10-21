using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("receiptseriesclass")]
    [Index(nameof(ClassId), Name = "FK_ReceiptSeriesClass_Class")]
    [Index(nameof(SeriesId), Name = "FK_ReceiptSeriesClass_ReceiptSeries")]
    public partial class Receiptseriesclass
    {
        [Key]
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public int ClassId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Receiptseriesclasses")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SeriesId))]
        [InverseProperty(nameof(Receiptseries.Receiptseriesclasses))]
        public virtual Receiptseries Series { get; set; }
    }
}
