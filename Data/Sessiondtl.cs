using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("sessiondtl")]
    [Index(nameof(SessId), Name = "FK_SessionDtl_Session")]
    public partial class Sessiondtl
    {
        public Sessiondtl()
        {
            Busstopwisefeedtls = new HashSet<Busstopwisefeedtl>();
            Classfeedtls = new HashSet<Classfeedtl>();
            Feereceipts = new HashSet<Feereceipt>();
            Scholardtls = new HashSet<Scholardtl>();
            Scholarfeedtls = new HashSet<Scholarfeedtl>();
            Scholaroptfeedtls = new HashSet<Scholaroptfeedtl>();
            Scholarpreviousdues = new HashSet<Scholarpreviousdue>();
            Tmpfeereceipts = new HashSet<Tmpfeereceipt>();
        }

        [Key]
        public int Id { get; set; }
        public int SessId { get; set; }
        public int InstNo { get; set; }
        [Required]
        [StringLength(30)]
        public string InstName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LateFeeDate { get; set; }

        [ForeignKey(nameof(SessId))]
        [InverseProperty(nameof(Session.Sessiondtls))]
        public virtual Session Sess { get; set; }
        [InverseProperty(nameof(Busstopwisefeedtl.Inst))]
        public virtual ICollection<Busstopwisefeedtl> Busstopwisefeedtls { get; set; }
        [InverseProperty(nameof(Classfeedtl.Inst))]
        public virtual ICollection<Classfeedtl> Classfeedtls { get; set; }
        [InverseProperty(nameof(Feereceipt.Installment))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Scholardtl.FeePaidMonth))]
        public virtual ICollection<Scholardtl> Scholardtls { get; set; }
        [InverseProperty(nameof(Scholarfeedtl.Inst))]
        public virtual ICollection<Scholarfeedtl> Scholarfeedtls { get; set; }
        [InverseProperty(nameof(Scholaroptfeedtl.Inst))]
        public virtual ICollection<Scholaroptfeedtl> Scholaroptfeedtls { get; set; }
        [InverseProperty(nameof(Scholarpreviousdue.Installment))]
        public virtual ICollection<Scholarpreviousdue> Scholarpreviousdues { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.Installment))]
        public virtual ICollection<Tmpfeereceipt> Tmpfeereceipts { get; set; }
    }
}
