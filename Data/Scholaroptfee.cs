using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholaroptfee")]
    [Index(nameof(FeeId), Name = "FK_ScholarOptFee_FeeHeads")]
    [Index(nameof(ScholarId), Name = "FK_ScholarOptFee_Scholar")]
    [Index(nameof(SessId), Name = "FK_ScholarOptFee_Session")]
    public partial class Scholaroptfee
    {
        public Scholaroptfee()
        {
            Scholaroptfeedtls = new HashSet<Scholaroptfeedtl>();
        }

        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int FeeId { get; set; }
        public int SessId { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        public double? Amount { get; set; }
        public double? AppAmount { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ApplDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        public bool? Deleted { get; set; }

        [ForeignKey(nameof(FeeId))]
        [InverseProperty(nameof(Feehead.Scholaroptfees))]
        public virtual Feehead Fee { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholaroptfees")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessId))]
        [InverseProperty(nameof(Session.Scholaroptfees))]
        public virtual Session Sess { get; set; }
        [InverseProperty(nameof(Scholaroptfeedtl.ScholarOptFee))]
        public virtual ICollection<Scholaroptfeedtl> Scholaroptfeedtls { get; set; }
    }
}
