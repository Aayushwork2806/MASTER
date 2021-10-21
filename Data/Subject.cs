using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("subject")]
    [Index(nameof(GroupId), Name = "FK_Subject_Masters")]
    public partial class Subject
    {
        public Subject()
        {
            Booktitles = new HashSet<Booktitle>();
            Classallotments = new HashSet<Classallotment>();
            Classsubjectmarksprimarydtls = new HashSet<Classsubjectmarksprimarydtl>();
            Classsubjectprimaries = new HashSet<Classsubjectprimary>();
            Classsubjects = new HashSet<Classsubject>();
            Classsubjmarksdtls = new HashSet<Classsubjmarksdtl>();
            Classsubwsteachers = new HashSet<Classsubwsteacher>();
            Classweekwiseperiods = new HashSet<Classweekwiseperiod>();
            Classworks = new HashSet<Classwork>();
            Ebooks = new HashSet<Ebook>();
            Employeeapplicationsubjects = new HashSet<Employeeapplicationsubject>();
            Homeworks = new HashSet<Homework>();
            Marksclasswisedtls = new HashSet<Marksclasswisedtl>();
            Marksclasswisenonacademicdtls = new HashSet<Marksclasswisenonacademicdtl>();
            Marksclasswiseprimarydtls = new HashSet<Marksclasswiseprimarydtl>();
            Marksheetdtls = new HashSet<Marksheetdtl>();
            Parentcommunications = new HashSet<Parentcommunication>();
            Qpapertasks = new HashSet<Qpapertask>();
            Resultsdetails = new HashSet<Resultsdetail>();
            Scholarattendances = new HashSet<Scholarattendance>();
            Scholarsubjects = new HashSet<Scholarsubject>();
            TblAllotments = new HashSet<TblAllotment>();
            TblCombinedTeacherClassDetails = new HashSet<TblCombinedTeacherClassDetail>();
            TblLabBifurcationDetails = new HashSet<TblLabBifurcationDetail>();
            TblTimetables = new HashSet<TblTimetable>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string SubjectName { get; set; }
        [Required]
        [StringLength(1)]
        public string SubjectType { get; set; }
        [StringLength(1)]
        public string Mode { get; set; }
        [StringLength(1)]
        public string Nature { get; set; }
        [StringLength(1)]
        public string Marks { get; set; }
        public bool? IsGroup { get; set; }
        public bool? UseGrading { get; set; }
        [StringLength(50)]
        public string IsAcedemic { get; set; }
        [StringLength(50)]
        public string GroupName { get; set; }
        [StringLength(6)]
        public string BoardCode { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }
        public int? GroupId { get; set; }

        [ForeignKey(nameof(GroupId))]
        [InverseProperty(nameof(Master.Subjects))]
        public virtual Master Group { get; set; }
        [InverseProperty(nameof(Booktitle.Subject))]
        public virtual ICollection<Booktitle> Booktitles { get; set; }
        [InverseProperty(nameof(Classallotment.Subject))]
        public virtual ICollection<Classallotment> Classallotments { get; set; }
        [InverseProperty(nameof(Classsubjectmarksprimarydtl.Subject))]
        public virtual ICollection<Classsubjectmarksprimarydtl> Classsubjectmarksprimarydtls { get; set; }
        [InverseProperty(nameof(Classsubjectprimary.Subject))]
        public virtual ICollection<Classsubjectprimary> Classsubjectprimaries { get; set; }
        [InverseProperty(nameof(Classsubject.Subject))]
        public virtual ICollection<Classsubject> Classsubjects { get; set; }
        [InverseProperty(nameof(Classsubjmarksdtl.Subject))]
        public virtual ICollection<Classsubjmarksdtl> Classsubjmarksdtls { get; set; }
        [InverseProperty(nameof(Classsubwsteacher.Subject))]
        public virtual ICollection<Classsubwsteacher> Classsubwsteachers { get; set; }
        [InverseProperty(nameof(Classweekwiseperiod.Subject))]
        public virtual ICollection<Classweekwiseperiod> Classweekwiseperiods { get; set; }
        [InverseProperty(nameof(Classwork.Subject))]
        public virtual ICollection<Classwork> Classworks { get; set; }
        [InverseProperty(nameof(Ebook.Subject))]
        public virtual ICollection<Ebook> Ebooks { get; set; }
        [InverseProperty(nameof(Employeeapplicationsubject.Subject))]
        public virtual ICollection<Employeeapplicationsubject> Employeeapplicationsubjects { get; set; }
        [InverseProperty(nameof(Homework.Subject))]
        public virtual ICollection<Homework> Homeworks { get; set; }
        [InverseProperty(nameof(Marksclasswisedtl.Subject))]
        public virtual ICollection<Marksclasswisedtl> Marksclasswisedtls { get; set; }
        [InverseProperty(nameof(Marksclasswisenonacademicdtl.Subject))]
        public virtual ICollection<Marksclasswisenonacademicdtl> Marksclasswisenonacademicdtls { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimarydtl.Subject))]
        public virtual ICollection<Marksclasswiseprimarydtl> Marksclasswiseprimarydtls { get; set; }
        [InverseProperty(nameof(Marksheetdtl.Subject))]
        public virtual ICollection<Marksheetdtl> Marksheetdtls { get; set; }
        [InverseProperty(nameof(Parentcommunication.Subject))]
        public virtual ICollection<Parentcommunication> Parentcommunications { get; set; }
        [InverseProperty(nameof(Qpapertask.Subject))]
        public virtual ICollection<Qpapertask> Qpapertasks { get; set; }
        [InverseProperty(nameof(Resultsdetail.Subject))]
        public virtual ICollection<Resultsdetail> Resultsdetails { get; set; }
        [InverseProperty(nameof(Scholarattendance.Subject))]
        public virtual ICollection<Scholarattendance> Scholarattendances { get; set; }
        [InverseProperty(nameof(Scholarsubject.Subject))]
        public virtual ICollection<Scholarsubject> Scholarsubjects { get; set; }
        [InverseProperty(nameof(TblAllotment.Subject))]
        public virtual ICollection<TblAllotment> TblAllotments { get; set; }
        [InverseProperty(nameof(TblCombinedTeacherClassDetail.Subject))]
        public virtual ICollection<TblCombinedTeacherClassDetail> TblCombinedTeacherClassDetails { get; set; }
        [InverseProperty(nameof(TblLabBifurcationDetail.Subject))]
        public virtual ICollection<TblLabBifurcationDetail> TblLabBifurcationDetails { get; set; }
        [InverseProperty(nameof(TblTimetable.Subject))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
    }
}
