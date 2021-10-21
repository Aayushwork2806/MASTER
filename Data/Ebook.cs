using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("ebook")]
    [Index(nameof(UnitId), Name = "FK_EBook_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_EBook_Class")]
    [Index(nameof(SubjectId), Name = "FK_EBook_Subject")]
    [Index(nameof(AuthorId), Name = "FK_e-Books_BookAuthor")]
    [Index(nameof(PublisherId), Name = "FK_e-Books_BookPublisher")]
    [Index(nameof(CategoryId), Name = "FK_e-Books_Masters")]
    public partial class Ebook
    {
        [Key]
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(100)]
        public string PdfBookName { get; set; }
        public int? AuthorId { get; set; }
        public int? PublisherId { get; set; }
        public byte[] BookImage { get; set; }
        public bool? Scholar { get; set; }
        public bool? Faculty { get; set; }
        public bool IsActive { get; set; }
        public int UnitId { get; set; }
        public int? ClassId { get; set; }
        public bool? ClassWiseFilter { get; set; }
        public int? SubjectId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty(nameof(Bookauthor.Ebooks))]
        public virtual Bookauthor Author { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.Ebooks))]
        public virtual Master Category { get; set; }
        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Ebooks")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(PublisherId))]
        [InverseProperty(nameof(Bookpublisher.Ebooks))]
        public virtual Bookpublisher Publisher { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Ebooks")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Ebooks))]
        public virtual Businessunit Unit { get; set; }
    }
}
