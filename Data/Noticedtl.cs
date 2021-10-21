using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("noticedtl")]
    [Index(nameof(NoticeId), Name = "FK_NoticeDtl_Notice")]
    [Index(nameof(ScholarId), Name = "FK_NoticeDtl_Scholar")]
    public partial class Noticedtl
    {
        [Key]
        public int Id { get; set; }
        public int NoticeId { get; set; }
        public int? ScholarId { get; set; }

        [ForeignKey(nameof(NoticeId))]
        [InverseProperty("Noticedtls")]
        public virtual Notice Notice { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Noticedtls")]
        public virtual Scholar Scholar { get; set; }
    }
}
