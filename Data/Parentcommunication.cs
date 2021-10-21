using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("parentcommunications")]
    [Index(nameof(DepartmentId), Name = "FK_ParentCommunications_Masters")]
    [Index(nameof(ScholarId), Name = "FK_ParentCommunications_Scholar")]
    [Index(nameof(SessionId), Name = "FK_ParentCommunications_Session")]
    [Index(nameof(SubjectId), Name = "FK_ParentCommunications_Subject")]
    [Index(nameof(UserId), Name = "FK_ParentCommunications_Users")]
    public partial class Parentcommunication
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime EntryDate { get; set; }
        public int ScholarId { get; set; }
        public int? SubjectId { get; set; }
        public int? DepartmentId { get; set; }
        public int? UserId { get; set; }
        public int SessionId { get; set; }
        [Required]
        [StringLength(30)]
        public string PortalUser { get; set; }
        [Required]
        [StringLength(0)]
        public string Comment { get; set; }
        [StringLength(50)]
        public string StaffName { get; set; }
        [StringLength(0)]
        public string Reply { get; set; }
        public int? ReplyBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReplyDate { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Master.Parentcommunications))]
        public virtual Master Department { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Parentcommunications")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Parentcommunications")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Parentcommunications")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Parentcommunications")]
        public virtual User User { get; set; }
    }
}
