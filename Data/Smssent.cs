using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("smssent")]
    public partial class Smssent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string CellNo { get; set; }
        [Required]
        [StringLength(1)]
        public string SentTo { get; set; }
        public int? SentId { get; set; }
        [Required]
        [StringLength(320)]
        public string MessageText { get; set; }
        [Required]
        [StringLength(50)]
        public string Purpose { get; set; }
        [MaxLength(6)]
        public DateTime TransDate { get; set; }
        [StringLength(25)]
        public string SmsStatus { get; set; }
        [StringLength(1)]
        public string MsgType { get; set; }
    }
}
