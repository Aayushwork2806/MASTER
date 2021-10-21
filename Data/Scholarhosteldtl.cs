using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarhosteldtl")]
    [Index(nameof(HostelId), Name = "FK_ScholarHostelDtl_Masters")]
    [Index(nameof(ScholarId), Name = "FK_ScholarHostelDtl_Scholar")]
    public partial class Scholarhosteldtl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string College { get; set; }
        [StringLength(25)]
        public string Mobile { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public byte[] Photo { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        public int ScholarId { get; set; }
        public int HostelId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(HostelId))]
        [InverseProperty(nameof(Master.Scholarhosteldtls))]
        public virtual Master Hostel { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholarhosteldtls")]
        public virtual Scholar Scholar { get; set; }
    }
}
