using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classfeedtl")]
    [Index(nameof(ClassFeeId), Name = "FK_ClassFeeDtl_ClassFee")]
    [Index(nameof(InstId), Name = "FK_ClassFeeDtl_SessionDtl")]
    public partial class Classfeedtl
    {
        [Key]
        public int Id { get; set; }
        public int ClassFeeId { get; set; }
        public int InstId { get; set; }
        public double? Amount { get; set; }

        [ForeignKey(nameof(ClassFeeId))]
        [InverseProperty(nameof(Classfee.Classfeedtls))]
        public virtual Classfee ClassFee { get; set; }
        [ForeignKey(nameof(InstId))]
        [InverseProperty(nameof(Sessiondtl.Classfeedtls))]
        public virtual Sessiondtl Inst { get; set; }
    }
}
