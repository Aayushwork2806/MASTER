using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("otp")]
    public partial class Otp
    {
        [Key]
        public int Id { get; set; }
        [StringLength(12)]
        public string Number { get; set; }
        [StringLength(10)]
        public string OtpNumber { get; set; }
        [MaxLength(6)]
        public DateTime OtpDate { get; set; }
    }
}
