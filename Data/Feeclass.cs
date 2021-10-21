using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feeclass")]
    [Index(nameof(ClassId), Name = "FK_FeeClass_Class")]
    [Index(nameof(FeeId), Name = "FK_FeeClass_FeeHeads")]
    public partial class Feeclass
    {
        [Key]
        public int Id { get; set; }
        public int FeeId { get; set; }
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Feeclasses")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(FeeId))]
        [InverseProperty(nameof(Feehead.Feeclasses))]
        public virtual Feehead Fee { get; set; }
    }
}
