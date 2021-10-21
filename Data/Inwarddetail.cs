using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("inwarddetail")]
    [Index(nameof(InwardId), Name = "FK_InwardDetail_Inward")]
    public partial class Inwarddetail
    {
        [Key]
        public int Id { get; set; }
        public int InwardId { get; set; }
        [StringLength(100)]
        public string EnclosureTitle { get; set; }
        [StringLength(100)]
        public string EnclosurePath { get; set; }

        [ForeignKey(nameof(InwardId))]
        [InverseProperty("Inwarddetails")]
        public virtual Inward Inward { get; set; }
    }
}
