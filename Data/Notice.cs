using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("notice")]
    [Index(nameof(CourseId), Name = "FK_Notice_Class")]
    [Index(nameof(SectionId), Name = "FK_Notice_Section")]
    [Index(nameof(UserId), Name = "FK_Notice_Users")]
    public partial class Notice
    {
        public Notice()
        {
            Noticedtls = new HashSet<Noticedtl>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NoticeDate { get; set; }
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        [StringLength(0)]
        public string Description { get; set; }
        [StringLength(100)]
        public string DocPath { get; set; }
        public int? UserId { get; set; }
        public bool? Deleted { get; set; }
        [StringLength(50)]
        public string NoticeSubject { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(Class.Notices))]
        public virtual Class Course { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Notices")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Notices")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(Noticedtl.Notice))]
        public virtual ICollection<Noticedtl> Noticedtls { get; set; }
    }
}
