using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("mastertype")]
    public partial class Mastertype
    {
        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("lngTypeId")]
        public int LngTypeId { get; set; }
        [Required]
        [Column("strName")]
        [StringLength(50)]
        public string StrName { get; set; }
    }
}
