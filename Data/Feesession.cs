using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feesession")]
    [Index(nameof(FeeId), Name = "FK_FeeSession_FeeHeads")]
    [Index(nameof(SessionId), Name = "FK_FeeSession_Session")]
    public partial class Feesession
    {
        [Key]
        public int Id { get; set; }
        public int FeeId { get; set; }
        public int SessionId { get; set; }

        [ForeignKey(nameof(FeeId))]
        [InverseProperty(nameof(Feehead.Feesessions))]
        public virtual Feehead Fee { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Feesessions")]
        public virtual Session Session { get; set; }
    }
}
