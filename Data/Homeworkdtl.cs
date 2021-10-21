using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("homeworkdtl")]
    [Index(nameof(HomeWorkId), Name = "FK_HomeWorkDtl_HomeWorkDtl")]
    [Index(nameof(ScholarId), Name = "FK_HomeWorkDtl_Scholar")]
    public partial class Homeworkdtl
    {
        [Key]
        public int Id { get; set; }
        public int HomeWorkId { get; set; }
        public int? ScholarId { get; set; }

        [ForeignKey(nameof(HomeWorkId))]
        [InverseProperty(nameof(Homework.Homeworkdtls))]
        public virtual Homework HomeWork { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Homeworkdtls")]
        public virtual Scholar Scholar { get; set; }
    }
}
