using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classwork")]
    [Index(nameof(CourseId), Name = "FK_ClassWork_Class")]
    [Index(nameof(SectionId), Name = "FK_ClassWork_Section")]
    [Index(nameof(SessionId), Name = "FK_ClassWork_Session")]
    [Index(nameof(SubjectId), Name = "FK_ClassWork_Subject")]
    [Index(nameof(UserId), Name = "FK_ClassWork_Users")]
    public partial class Classwork
    {
        public Classwork()
        {
            Classworkdtls = new HashSet<Classworkdtl>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ActivityDate { get; set; }
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        public int? SubjectId { get; set; }
        [StringLength(0)]
        public string Description { get; set; }
        [StringLength(100)]
        public string DocPath { get; set; }
        public int? UserId { get; set; }
        public bool? Deleted { get; set; }
        [Required]
        [StringLength(10)]
        public string ActivityType { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public int? SessionId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(Class.Classworks))]
        public virtual Class Course { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Classworks")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classworks")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Classworks")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Classworks")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(Classworkdtl.ClassWork))]
        public virtual ICollection<Classworkdtl> Classworkdtls { get; set; }
    }
}
