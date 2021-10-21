using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("refreshtokens")]
    public partial class Refreshtoken
    {
        [Key]
        [StringLength(128)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        [StringLength(50)]
        public string ClientId { get; set; }
        [MaxLength(6)]
        public DateTime? ExpiresUtc { get; set; }
        [MaxLength(6)]
        public DateTime? IssuedUtc { get; set; }
        [Required]
        [StringLength(4000)]
        public string ProtectedTicket { get; set; }
    }
}
