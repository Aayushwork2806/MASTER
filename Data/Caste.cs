using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("caste")]
    [Index(nameof(CategoryId), Name = "FK_Caste_Masters")]
    public partial class Caste
    {
        public Caste()
        {
            Admissionforms = new HashSet<Admissionform>();
            Families = new HashSet<Family>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string CasteName { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.Castes))]
        public virtual Master Category { get; set; }
        [InverseProperty(nameof(Admissionform.Caste))]
        public virtual ICollection<Admissionform> Admissionforms { get; set; }
        [InverseProperty(nameof(Family.Caste))]
        public virtual ICollection<Family> Families { get; set; }
    }
}
