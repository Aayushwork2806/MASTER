using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("clients")]
    public partial class Client
    {
        [Key]
        [StringLength(128)]
        public string Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Name { get; set; }
        [Required]
        [StringLength(0)]
        public string Secret { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public int? ApplicationType { get; set; }
        public bool Active { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        [StringLength(1000)]
        public string AllowedOrigin { get; set; }
    }
}
