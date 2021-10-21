using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("configration")]
    public partial class Configration
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Type { get; set; }
        [StringLength(100)]
        public string ConfigKey { get; set; }
        [StringLength(8000)]
        public string ConfigValue { get; set; }
    }
}
