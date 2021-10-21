using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarfee")]
    [Index(nameof(FeeId), Name = "FK_ScholarFee_FeeHeads")]
    [Index(nameof(ScholarId), Name = "FK_ScholarFee_Scholar")]
    [Index(nameof(SessId), Name = "FK_ScholarFee_Session")]
    public partial class Scholarfee
    {
        public Scholarfee()
        {
            Scholarfeedtls = new HashSet<Scholarfeedtl>();
        }

        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int SessId { get; set; }
        public int FeeId { get; set; }
        public double? Amount { get; set; }
        public double? AppAmount { get; set; }
        [StringLength(30)]
        public string Remark { get; set; }

        [ForeignKey(nameof(FeeId))]
        [InverseProperty(nameof(Feehead.Scholarfees))]
        public virtual Feehead Fee { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholarfees")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessId))]
        [InverseProperty(nameof(Session.Scholarfees))]
        public virtual Session Sess { get; set; }
        [InverseProperty(nameof(Scholarfeedtl.ScholarFee))]
        public virtual ICollection<Scholarfeedtl> Scholarfeedtls { get; set; }
    }
}
