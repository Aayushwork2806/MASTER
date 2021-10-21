using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("teacherdtl")]
    [Index(nameof(TeacherClassId), Name = "FK_TeacherDtl_Class")]
    [Index(nameof(ClassGroupId), Name = "FK_TeacherDtl_ClassGroup")]
    [Index(nameof(TeacherSectionId), Name = "FK_TeacherDtl_Section")]
    [Index(nameof(SessionId), Name = "FK_TeacherDtl_Session")]
    [Index(nameof(TeacherId), Name = "FK_TeacherDtl_Teacher")]
    public partial class Teacherdtl
    {
        [Key]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int? TeacherClassId { get; set; }
        public int? TeacherSectionId { get; set; }
        public int SessionId { get; set; }
        public int? ClassGroupId { get; set; }
        public int? NoOfPeriods { get; set; }

        [ForeignKey(nameof(ClassGroupId))]
        [InverseProperty(nameof(Classgroup.Teacherdtls))]
        public virtual Classgroup ClassGroup { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Teacherdtls")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(TeacherClassId))]
        [InverseProperty(nameof(Class.Teacherdtls))]
        public virtual Class TeacherClass { get; set; }
        [ForeignKey(nameof(TeacherSectionId))]
        [InverseProperty(nameof(Section.Teacherdtls))]
        public virtual Section TeacherSection { get; set; }
    }
}
