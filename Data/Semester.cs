using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("semester")]
    [Index(nameof(SemesterId), Name = "FK_Semester_Masters")]
    [Index(nameof(ClassId), Name = "FK_Semester_Semester")]
    public partial class Semester
    {
        public Semester()
        {
            Admissionenquiries = new HashSet<Admissionenquiry>();
            Admissionforms = new HashSet<Admissionform>();
            Scholardtls = new HashSet<Scholardtl>();
        }

        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SemesterId { get; set; }
        public short? Seats { get; set; }
        public int? Seq { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Semesters")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(SemesterId))]
        [InverseProperty(nameof(Master.Semesters))]
        public virtual Master SemesterNavigation { get; set; }
        [InverseProperty(nameof(Admissionenquiry.Semester))]
        public virtual ICollection<Admissionenquiry> Admissionenquiries { get; set; }
        [InverseProperty(nameof(Admissionform.Semester))]
        public virtual ICollection<Admissionform> Admissionforms { get; set; }
        [InverseProperty(nameof(Scholardtl.Semester))]
        public virtual ICollection<Scholardtl> Scholardtls { get; set; }
    }
}
