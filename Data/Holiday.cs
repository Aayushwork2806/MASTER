using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("holiday")]
    public partial class Holiday
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string HolidayName { get; set; }
        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ToDate { get; set; }
        public bool Deleted { get; set; }
    }
}
