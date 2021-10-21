using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("company")]
    public partial class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyShortName { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
