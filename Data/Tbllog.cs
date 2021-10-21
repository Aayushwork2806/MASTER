using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbllog")]
    public partial class Tbllog
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime LogDate { get; set; }
        [Column("PKey")]
        [StringLength(0)]
        public string Pkey { get; set; }
        [Required]
        public bool? Success { get; set; }
    }
}
