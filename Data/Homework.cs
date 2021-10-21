using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("homework")]
    [Index(nameof(CourseId), Name = "FK_HomeWork_Class")]
    [Index(nameof(CategorySrcId), Name = "FK_HomeWork_Masters")]
    [Index(nameof(SectionId), Name = "FK_HomeWork_Section")]
    [Index(nameof(SessionId), Name = "FK_HomeWork_Session")]
    [Index(nameof(SubjectId), Name = "FK_HomeWork_Subject")]
    [Index(nameof(UserId), Name = "FK_HomeWork_Users")]
    public partial class Homework
    {
        public Homework()
        {
            Homeworkdtls = new HashSet<Homeworkdtl>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? HomeworkDate { get; set; }
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        public int? SubjectId { get; set; }
        [StringLength(0)]
        public string Description { get; set; }
        [StringLength(100)]
        public string DocPath { get; set; }
        public int? UserId { get; set; }
        public int? CategorySrcId { get; set; }
        public bool? Deleted { get; set; }
        [StringLength(50)]
        public string HomeWorkSubject { get; set; }
        public int? SessionId { get; set; }
        [StringLength(2)]
        public string Type { get; set; }

        [ForeignKey(nameof(CategorySrcId))]
        [InverseProperty(nameof(Master.Homeworks))]
        public virtual Master CategorySrc { get; set; }
        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(Class.Homeworks))]
        public virtual Class Course { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Homeworks")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Homeworks")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Homeworks")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Homeworks")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(Homeworkdtl.HomeWork))]
        public virtual ICollection<Homeworkdtl> Homeworkdtls { get; set; }
    }
}
