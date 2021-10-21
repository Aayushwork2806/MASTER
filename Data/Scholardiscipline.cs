using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholardiscipline")]
    [Index(nameof(CommentId), Name = "FK_ScholarDiscipline_Masters")]
    [Index(nameof(ScholarId), Name = "FK_ScholarDiscipline_Scholar")]
    [Index(nameof(SessionId), Name = "FK_ScholarDiscipline_Session")]
    public partial class Scholardiscipline
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ScholarId { get; set; }
        [Column(TypeName = "date")]
        public DateTime DocDate { get; set; }
        public int CommentId { get; set; }
        [Required]
        [StringLength(10)]
        public string Priority { get; set; }
        [StringLength(150)]
        public string Remark { get; set; }

        [ForeignKey(nameof(CommentId))]
        [InverseProperty(nameof(Master.Scholardisciplines))]
        public virtual Master Comment { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholardisciplines")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Scholardisciplines")]
        public virtual Session Session { get; set; }
    }
}
