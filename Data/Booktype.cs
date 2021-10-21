using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("booktype")]
    public partial class Booktype
    {
        public Booktype()
        {
            Booktitles = new HashSet<Booktitle>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Type { get; set; }
        [Required]
        public bool? CanIssue { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [StringLength(40)]
        public string TypeCategory { get; set; }

        [InverseProperty(nameof(Booktitle.BookType))]
        public virtual ICollection<Booktitle> Booktitles { get; set; }
    }
}
