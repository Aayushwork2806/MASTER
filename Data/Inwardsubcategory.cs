using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("inwardsubcategory")]
    [Index(nameof(CategoryId), Name = "FK_InwardSubCategory_Masters")]
    public partial class Inwardsubcategory
    {
        public Inwardsubcategory()
        {
            Despatches = new HashSet<Despatch>();
            Inwards = new HashSet<Inward>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string SubCategory { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.Inwardsubcategories))]
        public virtual Master Category { get; set; }
        [InverseProperty(nameof(Despatch.SubCategory))]
        public virtual ICollection<Despatch> Despatches { get; set; }
        [InverseProperty(nameof(Inward.SubCategory))]
        public virtual ICollection<Inward> Inwards { get; set; }
    }
}
