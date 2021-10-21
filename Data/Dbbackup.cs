using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("dbbackup")]
    public partial class Dbbackup
    {
        [Key]
        public int Id { get; set; }
        [StringLength(0)]
        public string BackupPath { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BackupDate { get; set; }
        [Column("DBName")]
        [StringLength(0)]
        public string Dbname { get; set; }
    }
}
