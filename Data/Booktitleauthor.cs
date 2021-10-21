using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("booktitleauthor")]
    [Index(nameof(AuthorId), Name = "FK_BookTitleAuthor_BookAuthor")]
    [Index(nameof(BookId), Name = "FK_BookTitleAuthor_BookTitles")]
    public partial class Booktitleauthor
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty(nameof(Bookauthor.Booktitleauthors))]
        public virtual Bookauthor Author { get; set; }
        [ForeignKey(nameof(BookId))]
        [InverseProperty(nameof(Booktitle.Booktitleauthors))]
        public virtual Booktitle Book { get; set; }
    }
}
