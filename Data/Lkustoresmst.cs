using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("lkustoresmst")]
    [Index(nameof(UnitId), Name = "FK_lkuStoresMst_BusinessUnits")]
    public partial class Lkustoresmst
    {
        public Lkustoresmst()
        {
            Lkustorestostaffs = new HashSet<Lkustorestostaff>();
        }

        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Required]
        [StringLength(100)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Location { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string ContactNo { get; set; }
        public bool Active { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Lkustoresmsts))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Lkustorestostaff.Store))]
        public virtual ICollection<Lkustorestostaff> Lkustorestostaffs { get; set; }
    }
}
