using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classworkdtl")]
    [Index(nameof(ClassWorkId), Name = "FK_ClassWorkDtl_ClassWork")]
    [Index(nameof(ScholarId), Name = "FK_ClassWorkDtl_Scholar")]
    public partial class Classworkdtl
    {
        [Key]
        public int Id { get; set; }
        public int ClassWorkId { get; set; }
        public int? ScholarId { get; set; }

        [ForeignKey(nameof(ClassWorkId))]
        [InverseProperty(nameof(Classwork.Classworkdtls))]
        public virtual Classwork ClassWork { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Classworkdtls")]
        public virtual Scholar Scholar { get; set; }
    }
}
