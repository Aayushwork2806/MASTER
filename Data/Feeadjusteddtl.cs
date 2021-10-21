using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feeadjusteddtl")]
    [Index(nameof(FeeAdjustedId), Name = "FK_FeeAdjustedDtl_FeeAdjusted")]
    [Index(nameof(FeeHeadId), Name = "FK_FeeAdjustedDtl_FeeHeads")]
    public partial class Feeadjusteddtl
    {
        [Key]
        public int Id { get; set; }
        public int FeeAdjustedId { get; set; }
        public int FeeHeadId { get; set; }
        public long Amount { get; set; }

        [ForeignKey(nameof(FeeAdjustedId))]
        [InverseProperty(nameof(Feeadjusted.Feeadjusteddtls))]
        public virtual Feeadjusted FeeAdjusted { get; set; }
        [ForeignKey(nameof(FeeHeadId))]
        [InverseProperty(nameof(Feehead.Feeadjusteddtls))]
        public virtual Feehead FeeHead { get; set; }
    }
}
