using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classexam")]
    [Index(nameof(UnitId), Name = "FK_ClassExam_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassExam_ClassExam")]
    [Index(nameof(ExamId), Name = "FK_ClassExam_Exam")]
    [Index(nameof(SessionId), Name = "FK_ClassExam_Session")]
    public partial class Classexam
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int ExamId { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }
        public int? SessionId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classexams")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(ExamId))]
        [InverseProperty("Classexams")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Classexams")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classexams))]
        public virtual Businessunit Unit { get; set; }
    }
}
