using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("docclass")]
    [Index(nameof(ClassId), Name = "FK_DocClass_Class")]
    [Index(nameof(DocsId), Name = "FK_DocClass_Masters")]
    public partial class Docclass
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int DocsId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Docclasses")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(DocsId))]
        [InverseProperty(nameof(Master.Docclasses))]
        public virtual Master Docs { get; set; }
    }
}
