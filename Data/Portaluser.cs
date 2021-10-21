using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("portalusers")]
    public partial class Portaluser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string UserName { get; set; }
        [Required]
        [StringLength(15)]
        public string Password { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [StringLength(1)]
        public string UserType { get; set; }
    }
}
