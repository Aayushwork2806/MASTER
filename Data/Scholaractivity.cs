using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholaractivity")]
    [Index(nameof(ActivityId), Name = "FK_ScholarActivity_Masters")]
    [Index(nameof(ScholarId), Name = "FK_ScholarActivity_Scholar")]
    [Index(nameof(SessId), Name = "FK_ScholarActivity_Session")]
    public partial class Scholaractivity
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int SessId { get; set; }
        public int ActivityId { get; set; }

        [ForeignKey(nameof(ActivityId))]
        [InverseProperty(nameof(Master.Scholaractivities))]
        public virtual Master Activity { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholaractivities")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessId))]
        [InverseProperty(nameof(Session.Scholaractivities))]
        public virtual Session Sess { get; set; }
    }
}
