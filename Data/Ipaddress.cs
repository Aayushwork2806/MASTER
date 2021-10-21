using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("ipaddress")]
    public partial class Ipaddress
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("IPAddressDesc")]
        [StringLength(15)]
        public string IpaddressDesc { get; set; }
    }
}
