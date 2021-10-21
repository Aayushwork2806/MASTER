using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("reportlist")]
    public partial class Reportlist
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string ReportDesc { get; set; }
        [StringLength(50)]
        public string ReportName { get; set; }
        [StringLength(50)]
        public string ReportId { get; set; }
        public bool Deleted { get; set; }
    }
}
