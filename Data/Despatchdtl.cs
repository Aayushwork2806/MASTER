using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("despatchdtl")]
    [Index(nameof(DespatchId), Name = "FK_DespatchDtl_Despatch")]
    public partial class Despatchdtl
    {
        [Key]
        public int Id { get; set; }
        public int DespatchId { get; set; }
        [StringLength(100)]
        public string EnclosureTitle { get; set; }
        [StringLength(100)]
        public string EnclosurePath { get; set; }

        [ForeignKey(nameof(DespatchId))]
        [InverseProperty("Despatchdtls")]
        public virtual Despatch Despatch { get; set; }
    }
}
