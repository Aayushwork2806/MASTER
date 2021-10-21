using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("examtype")]
    [Index(nameof(Unitid), Name = "FK_ExamType_BusinessUnits")]
    public partial class Examtype
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string ExamTypeName { get; set; }
        [StringLength(20)]
        public string ShortName { get; set; }
        public short Seq { get; set; }
        public bool Deleted { get; set; }
        public int Unitid { get; set; }

        [ForeignKey(nameof(Unitid))]
        [InverseProperty(nameof(Businessunit.Examtypes))]
        public virtual Businessunit Unit { get; set; }
    }
}
