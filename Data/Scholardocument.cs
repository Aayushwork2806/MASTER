using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholardocuments")]
    [Index(nameof(DocsId), Name = "FK_ScholarDocuments_Masters")]
    [Index(nameof(ScholarId), Name = "FK_ScholarDocuments_Scholar")]
    public partial class Scholardocument
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int DocsId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SubmitDate { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        [StringLength(100)]
        public string DocPath { get; set; }

        [ForeignKey(nameof(DocsId))]
        [InverseProperty(nameof(Master.Scholardocuments))]
        public virtual Master Docs { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholardocuments")]
        public virtual Scholar Scholar { get; set; }
    }
}
