using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("section")]
    [Index(nameof(ClassId), Name = "FK_Section_Class")]
    [Index(nameof(MsectionId), Name = "FK_Section_Masters")]
    public partial class Section
    {
        public Section()
        {
            Classallotments = new HashSet<Classallotment>();
            Classsubwsteachers = new HashSet<Classsubwsteacher>();
            Classworks = new HashSet<Classwork>();
            Culturalactivities = new HashSet<Culturalactivity>();
            Homeworks = new HashSet<Homework>();
            Libraryattendances = new HashSet<Libraryattendance>();
            Marksclasswisenonacademics = new HashSet<Marksclasswisenonacademic>();
            Marksclasswiseprimaries = new HashSet<Marksclasswiseprimary>();
            Notices = new HashSet<Notice>();
            Qpapertasks = new HashSet<Qpapertask>();
            Results = new HashSet<Result>();
            Scholardtls = new HashSet<Scholardtl>();
            TblAllotments = new HashSet<TblAllotment>();
            TblCombinedTeacherClassDetails = new HashSet<TblCombinedTeacherClassDetail>();
            TblLabBifurcationMasters = new HashSet<TblLabBifurcationMaster>();
            TblTimetables = new HashSet<TblTimetable>();
            Teacherdtls = new HashSet<Teacherdtl>();
            Yearlyattendences = new HashSet<Yearlyattendence>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string SectionName { get; set; }
        [StringLength(10)]
        public string RoomNo { get; set; }
        public short? Seats { get; set; }
        public int ClassId { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }
        [StringLength(5)]
        public string FromTime { get; set; }
        [StringLength(5)]
        public string ToTime { get; set; }
        public int? MsectionId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("SectionsNavigation")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(MsectionId))]
        [InverseProperty(nameof(Master.Sections))]
        public virtual Master Msection { get; set; }
        [InverseProperty(nameof(Classallotment.Section))]
        public virtual ICollection<Classallotment> Classallotments { get; set; }
        [InverseProperty(nameof(Classsubwsteacher.Section))]
        public virtual ICollection<Classsubwsteacher> Classsubwsteachers { get; set; }
        [InverseProperty(nameof(Classwork.Section))]
        public virtual ICollection<Classwork> Classworks { get; set; }
        [InverseProperty(nameof(Culturalactivity.Section))]
        public virtual ICollection<Culturalactivity> Culturalactivities { get; set; }
        [InverseProperty(nameof(Homework.Section))]
        public virtual ICollection<Homework> Homeworks { get; set; }
        [InverseProperty(nameof(Libraryattendance.Section))]
        public virtual ICollection<Libraryattendance> Libraryattendances { get; set; }
        [InverseProperty(nameof(Marksclasswisenonacademic.Section))]
        public virtual ICollection<Marksclasswisenonacademic> Marksclasswisenonacademics { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimary.Section))]
        public virtual ICollection<Marksclasswiseprimary> Marksclasswiseprimaries { get; set; }
        [InverseProperty(nameof(Notice.Section))]
        public virtual ICollection<Notice> Notices { get; set; }
        [InverseProperty(nameof(Qpapertask.Section))]
        public virtual ICollection<Qpapertask> Qpapertasks { get; set; }
        [InverseProperty(nameof(Result.ProSection))]
        public virtual ICollection<Result> Results { get; set; }
        [InverseProperty(nameof(Scholardtl.Section))]
        public virtual ICollection<Scholardtl> Scholardtls { get; set; }
        [InverseProperty(nameof(TblAllotment.Division))]
        public virtual ICollection<TblAllotment> TblAllotments { get; set; }
        [InverseProperty(nameof(TblCombinedTeacherClassDetail.Division))]
        public virtual ICollection<TblCombinedTeacherClassDetail> TblCombinedTeacherClassDetails { get; set; }
        [InverseProperty(nameof(TblLabBifurcationMaster.Division))]
        public virtual ICollection<TblLabBifurcationMaster> TblLabBifurcationMasters { get; set; }
        [InverseProperty(nameof(TblTimetable.Division))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
        [InverseProperty(nameof(Teacherdtl.TeacherSection))]
        public virtual ICollection<Teacherdtl> Teacherdtls { get; set; }
        [InverseProperty(nameof(Yearlyattendence.Section))]
        public virtual ICollection<Yearlyattendence> Yearlyattendences { get; set; }
    }
}
