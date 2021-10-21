using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("counstoscholar")]
    [Index(nameof(CounselorId), Name = "FK_CounsToScholar_CounselorMaster")]
    [Index(nameof(ScholarId), Name = "FK_CounsToScholar_Scholar")]
    public partial class Counstoscholar
    {
        public Counstoscholar()
        {
            Countoschpayments = new HashSet<Countoschpayment>();
        }

        [Key]
        public int Id { get; set; }
        public int CounselorId { get; set; }
        public int ScholarId { get; set; }
        public double? IncPercentage { get; set; }
        public double? IncAmount { get; set; }

        [ForeignKey(nameof(CounselorId))]
        [InverseProperty(nameof(Counselormaster.Counstoscholars))]
        public virtual Counselormaster Counselor { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Counstoscholars")]
        public virtual Scholar Scholar { get; set; }
        [InverseProperty(nameof(Countoschpayment.Cts))]
        public virtual ICollection<Countoschpayment> Countoschpayments { get; set; }
    }
}
