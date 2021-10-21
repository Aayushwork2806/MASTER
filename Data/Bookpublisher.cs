using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bookpublisher")]
    public partial class Bookpublisher
    {
        public Bookpublisher()
        {
            Booktitles = new HashSet<Booktitle>();
            Ebooks = new HashSet<Ebook>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string PublisherName { get; set; }
        [StringLength(50)]
        public string ContactPerson { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(25)]
        public string PhoneNo { get; set; }
        [StringLength(25)]
        public string FaxNo { get; set; }
        [Column("email")]
        [StringLength(20)]
        public string Email { get; set; }
        [Required]
        public bool? IsActive { get; set; }

        [InverseProperty(nameof(Booktitle.Publisher))]
        public virtual ICollection<Booktitle> Booktitles { get; set; }
        [InverseProperty(nameof(Ebook.Publisher))]
        public virtual ICollection<Ebook> Ebooks { get; set; }
    }
}
