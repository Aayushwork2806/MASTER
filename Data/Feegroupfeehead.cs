using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feegroupfeeheads")]
    [Index(nameof(FeeId), Name = "FK_FeeGroupFeeHeads_FeeHeads")]
    [Index(nameof(FeeGroupId), Name = "FK_FeeGroupFeeHeads_Masters")]
    public partial class Feegroupfeehead
    {
        [Key]
        public int Id { get; set; }
        public int FeeId { get; set; }
        public int FeeGroupId { get; set; }

        [ForeignKey(nameof(FeeId))]
        [InverseProperty(nameof(Feehead.Feegroupfeeheads))]
        public virtual Feehead Fee { get; set; }
        [ForeignKey(nameof(FeeGroupId))]
        [InverseProperty(nameof(Master.Feegroupfeeheads))]
        public virtual Master FeeGroup { get; set; }
    }
}
