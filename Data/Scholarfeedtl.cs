using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarfeedtl")]
    [Index(nameof(ScholarFeeId), Name = "FK_ScholarFeeDtl_ScholarFee")]
    [Index(nameof(InstId), Name = "FK_ScholarFeeDtl_SessionDtl")]
    public partial class Scholarfeedtl
    {
        [Key]
        public int Id { get; set; }
        public int ScholarFeeId { get; set; }
        public int InstId { get; set; }
        public double? Amount { get; set; }
        public double? RecAmount { get; set; }
        public double? AppFees { get; set; }

        [ForeignKey(nameof(InstId))]
        [InverseProperty(nameof(Sessiondtl.Scholarfeedtls))]
        public virtual Sessiondtl Inst { get; set; }
        [ForeignKey(nameof(ScholarFeeId))]
        [InverseProperty(nameof(Scholarfee.Scholarfeedtls))]
        public virtual Scholarfee ScholarFee { get; set; }
    }
}
