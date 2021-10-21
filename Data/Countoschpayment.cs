using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("countoschpayment")]
    [Index(nameof(Ctsid), Name = "FK_CounToSchPayment_CounsToScholar")]
    public partial class Countoschpayment
    {
        [Key]
        public int Id { get; set; }
        [Column("CTSId")]
        public int Ctsid { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        public double PaidAmount { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(Ctsid))]
        [InverseProperty(nameof(Counstoscholar.Countoschpayments))]
        public virtual Counstoscholar Cts { get; set; }
    }
}
