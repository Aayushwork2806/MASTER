using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("smsuserinfo")]
    public partial class Smsuserinfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(25)]
        public string Gateway { get; set; }
        [StringLength(50)]
        public string ApiKey { get; set; }
        [StringLength(15)]
        public string SenderId { get; set; }
        [StringLength(200)]
        public string SmsSignature { get; set; }
    }
}
