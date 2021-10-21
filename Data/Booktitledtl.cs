using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("booktitledtl")]
    [Index(nameof(BookId), Name = "FK_BookTitleDtl_BookTitles")]
    public partial class Booktitledtl
    {
        public Booktitledtl()
        {
            Bookissuedtls = new HashSet<Bookissuedtl>();
        }

        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CopyNo { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [StringLength(1)]
        public string IssuedTo { get; set; }
        public int? MemberIdNo { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty(nameof(Booktitle.Booktitledtls))]
        public virtual Booktitle Book { get; set; }
        [InverseProperty(nameof(Bookissuedtl.BookCopy))]
        public virtual ICollection<Bookissuedtl> Bookissuedtls { get; set; }
    }
}
