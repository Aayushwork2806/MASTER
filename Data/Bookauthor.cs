using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bookauthor")]
    public partial class Bookauthor
    {
        public Bookauthor()
        {
            Booktitleauthors = new HashSet<Booktitleauthor>();
            Ebooks = new HashSet<Ebook>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string AuthorName { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(25)]
        public string PhoneNo { get; set; }
        [Column("email")]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        public bool? IsActive { get; set; }

        [InverseProperty(nameof(Booktitleauthor.Author))]
        public virtual ICollection<Booktitleauthor> Booktitleauthors { get; set; }
        [InverseProperty(nameof(Ebook.Author))]
        public virtual ICollection<Ebook> Ebooks { get; set; }
    }
}
