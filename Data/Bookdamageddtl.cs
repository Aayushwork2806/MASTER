using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bookdamageddtl")]
    [Index(nameof(BookDamagedId), Name = "FK_BookDamagedDtl_BookDamaged")]
    [Index(nameof(BookId), Name = "FK_BookDamagedDtl_BookTitles")]
    public partial class Bookdamageddtl
    {
        [Key]
        public int Id { get; set; }
        public int BookDamagedId { get; set; }
        public int BookId { get; set; }
        public int CopyNo { get; set; }
        public double Price { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty(nameof(Booktitle.Bookdamageddtls))]
        public virtual Booktitle Book { get; set; }
        [ForeignKey(nameof(BookDamagedId))]
        [InverseProperty(nameof(Bookdamaged.Bookdamageddtls))]
        public virtual Bookdamaged BookDamaged { get; set; }
    }
}
