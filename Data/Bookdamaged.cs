using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bookdamaged")]
    [Index(nameof(UnitId), Name = "FK_BookDamaged_BusinessUnits")]
    public partial class Bookdamaged
    {
        public Bookdamaged()
        {
            Bookdamageddtls = new HashSet<Bookdamageddtl>();
        }

        [Key]
        public int Id { get; set; }
        public int DocNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime DocDate { get; set; }
        [Required]
        [StringLength(100)]
        public string Reason { get; set; }
        [Required]
        [StringLength(1)]
        public string DamagedBy { get; set; }
        public int? MemberId { get; set; }
        public bool FineCollected { get; set; }
        public double FineAmount { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Bookdamageds))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Bookdamageddtl.BookDamaged))]
        public virtual ICollection<Bookdamageddtl> Bookdamageddtls { get; set; }
    }
}
