using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("taskquerydtl")]
    [Index(nameof(TaskId), Name = "FK_TaskQueryDtl_TaskScheduler")]
    [Index(nameof(UserId), Name = "FK_TaskQueryDtl_Users")]
    public partial class Taskquerydtl
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        [MaxLength(6)]
        public DateTime? QueryDate { get; set; }
        [StringLength(250)]
        public string QueryMessage { get; set; }
        public bool Deleted { get; set; }
        public bool IsRead { get; set; }

        [ForeignKey(nameof(TaskId))]
        [InverseProperty(nameof(Taskscheduler.Taskquerydtls))]
        public virtual Taskscheduler Task { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Taskquerydtls")]
        public virtual User User { get; set; }
    }
}
