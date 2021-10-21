using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholaroptfeedtl")]
    [Index(nameof(ScholarOptFeeId), Name = "FK_ScholarOptFeeDtl_ScholarOptFee")]
    [Index(nameof(InstId), Name = "FK_ScholarOptFeeDtl_SessionDtl")]
    public partial class Scholaroptfeedtl
    {
        [Key]
        public int Id { get; set; }
        public int ScholarOptFeeId { get; set; }
        public int InstId { get; set; }
        public double Amount { get; set; }
        public double? RecAmount { get; set; }

        [ForeignKey(nameof(InstId))]
        [InverseProperty(nameof(Sessiondtl.Scholaroptfeedtls))]
        public virtual Sessiondtl Inst { get; set; }
        [ForeignKey(nameof(ScholarOptFeeId))]
        [InverseProperty(nameof(Scholaroptfee.Scholaroptfeedtls))]
        public virtual Scholaroptfee ScholarOptFee { get; set; }
    }
}
