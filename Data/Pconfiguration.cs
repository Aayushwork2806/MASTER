using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("pconfiguration")]
    public partial class Pconfiguration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("PKey")]
        [StringLength(4000)]
        public string Pkey { get; set; }
        [StringLength(0)]
        public string Value { get; set; }
        [Column("blnDeleted")]
        public bool BlnDeleted { get; set; }
        [Column("datDeleted", TypeName = "datetime")]
        public DateTime? DatDeleted { get; set; }
    }
}
