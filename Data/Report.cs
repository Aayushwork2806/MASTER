using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("reports")]
    [Index(nameof(ReportTypeId), Name = "FK_Reports_ReportType")]
    public partial class Report
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string ReportDesc { get; set; }
        [Required]
        [StringLength(50)]
        public string ReportId { get; set; }
        public int ReportTypeId { get; set; }
        public bool Deleted { get; set; }
    }
}
