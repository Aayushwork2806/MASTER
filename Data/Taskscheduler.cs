using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("taskscheduler")]
    [Index(nameof(AssignedById), Name = "FK_TaskSchedular_Users")]
    [Index(nameof(AssignedToId), Name = "FK_TaskSchedular_Users1")]
    [Index(nameof(InwardId), Name = "FK_TaskScheduler_Inward")]
    public partial class Taskscheduler
    {
        public Taskscheduler()
        {
            Taskquerydtls = new HashSet<Taskquerydtl>();
        }

        [Key]
        public int Id { get; set; }
        public int TaskNo { get; set; }
        [MaxLength(6)]
        public DateTime TaskDate { get; set; }
        public int AssignedById { get; set; }
        public int AssignedToId { get; set; }
        [Required]
        [StringLength(50)]
        public string TaskHeading { get; set; }
        [Required]
        [StringLength(250)]
        public string TaskDetail { get; set; }
        [MaxLength(6)]
        public DateTime? ExpectedDate { get; set; }
        [MaxLength(6)]
        public DateTime? CompletionDate { get; set; }
        public bool Status { get; set; }
        [MaxLength(6)]
        public DateTime? ClosedDate { get; set; }
        [StringLength(100)]
        public string ClosedRemark { get; set; }
        [MaxLength(6)]
        public DateTime? SubmitDate { get; set; }
        [StringLength(50)]
        public string SubmitRemark { get; set; }
        public int? TaskPriority { get; set; }
        public int? InwardId { get; set; }
        [StringLength(100)]
        public string DocPath { get; set; }
        [StringLength(25)]
        public string MobileNo { get; set; }

        [ForeignKey(nameof(AssignedById))]
        [InverseProperty(nameof(User.TaskschedulerAssignedBies))]
        public virtual User AssignedBy { get; set; }
        [ForeignKey(nameof(AssignedToId))]
        [InverseProperty(nameof(User.TaskschedulerAssignedTos))]
        public virtual User AssignedTo { get; set; }
        [ForeignKey(nameof(InwardId))]
        [InverseProperty("Taskschedulers")]
        public virtual Inward Inward { get; set; }
        [InverseProperty(nameof(Taskquerydtl.Task))]
        public virtual ICollection<Taskquerydtl> Taskquerydtls { get; set; }
    }
}
