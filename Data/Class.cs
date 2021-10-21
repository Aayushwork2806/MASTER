using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("class")]
    [Index(nameof(UnitId), Name = "FK_Class_BusinessUnits")]
    [Index(nameof(ClassGroupId), Name = "FK_Class_ClassGroup")]
    public partial class Class
    {
        public Class()
        {
            AdmissionenquiryClasses = new HashSet<Admissionenquiry>();
            AdmissionenquiryCourseOffereds = new HashSet<Admissionenquiry>();
            Admissionforms = new HashSet<Admissionform>();
            Assessmentcalpolicies = new HashSet<Assessmentcalpolicy>();
            Booktitles = new HashSet<Booktitle>();
            Classallotments = new HashSet<Classallotment>();
            Classexams = new HashSet<Classexam>();
            Classfees = new HashSet<Classfee>();
            Classsubjectmarksprimaries = new HashSet<Classsubjectmarksprimary>();
            Classsubjectprimaries = new HashSet<Classsubjectprimary>();
            Classsubjects = new HashSet<Classsubject>();
            Classsubjmarks = new HashSet<Classsubjmark>();
            Classsubwsteachers = new HashSet<Classsubwsteacher>();
            Classweekwiseperiods = new HashSet<Classweekwiseperiod>();
            Classwiseadmschedules = new HashSet<Classwiseadmschedule>();
            Classwiseskills = new HashSet<Classwiseskill>();
            Classworks = new HashSet<Classwork>();
            Culturalactivities = new HashSet<Culturalactivity>();
            Daywiseperiods = new HashSet<Daywiseperiod>();
            Docclasses = new HashSet<Docclass>();
            Ebooks = new HashSet<Ebook>();
            Employeeapplicationclasses = new HashSet<Employeeapplicationclass>();
            Feecautionmoneys = new HashSet<Feecautionmoney>();
            Feeclasses = new HashSet<Feeclass>();
            Feereceipts = new HashSet<Feereceipt>();
            Homeworks = new HashSet<Homework>();
            IssuedslcLastClassNavigations = new HashSet<Issuedslc>();
            IssuedslcPromotedClasses = new HashSet<Issuedslc>();
            Libraryattendances = new HashSet<Libraryattendance>();
            Markscceskills = new HashSet<Markscceskill>();
            Marksclasswisenonacademics = new HashSet<Marksclasswisenonacademic>();
            Marksclasswiseprimaries = new HashSet<Marksclasswiseprimary>();
            Marksclasswises = new HashSet<Marksclasswise>();
            Marksheets = new HashSet<Marksheet>();
            Notices = new HashSet<Notice>();
            Qpapertasks = new HashSet<Qpapertask>();
            Receiptseriesclasses = new HashSet<Receiptseriesclass>();
            ResultClasses = new HashSet<Result>();
            ResultProClasses = new HashSet<Result>();
            Resultcalpolicies = new HashSet<Resultcalpolicy>();
            Scholardtls = new HashSet<Scholardtl>();
            Scholarhistories = new HashSet<Scholarhistory>();
            Scholars = new HashSet<Scholar>();
            Scholarships = new HashSet<Scholarship>();
            Scholarsubjects = new HashSet<Scholarsubject>();
            SectionsNavigation = new HashSet<Section>();
            Semesters = new HashSet<Semester>();
            Teacherdtls = new HashSet<Teacherdtl>();
            Tmpadmissionforms = new HashSet<Tmpadmissionform>();
            Tmpfeereceipts = new HashSet<Tmpfeereceipt>();
            Yearlyattendences = new HashSet<Yearlyattendence>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        public string ClassCode { get; set; }
        [Required]
        [StringLength(30)]
        public string ClassName { get; set; }
        [StringLength(30)]
        public string ClassInWords { get; set; }
        [StringLength(10)]
        public string ShortDesc { get; set; }
        public short Seq { get; set; }
        public short? Sections { get; set; }
        public int ClassGroupId { get; set; }
        public int? UnitId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(ClassGroupId))]
        [InverseProperty(nameof(Classgroup.Classes))]
        public virtual Classgroup ClassGroup { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classes))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Admissionenquiry.Class))]
        public virtual ICollection<Admissionenquiry> AdmissionenquiryClasses { get; set; }
        [InverseProperty(nameof(Admissionenquiry.CourseOffered))]
        public virtual ICollection<Admissionenquiry> AdmissionenquiryCourseOffereds { get; set; }
        [InverseProperty(nameof(Admissionform.Class))]
        public virtual ICollection<Admissionform> Admissionforms { get; set; }
        [InverseProperty(nameof(Assessmentcalpolicy.Class))]
        public virtual ICollection<Assessmentcalpolicy> Assessmentcalpolicies { get; set; }
        [InverseProperty(nameof(Booktitle.Course))]
        public virtual ICollection<Booktitle> Booktitles { get; set; }
        [InverseProperty(nameof(Classallotment.Class))]
        public virtual ICollection<Classallotment> Classallotments { get; set; }
        [InverseProperty(nameof(Classexam.Class))]
        public virtual ICollection<Classexam> Classexams { get; set; }
        [InverseProperty(nameof(Classfee.Class))]
        public virtual ICollection<Classfee> Classfees { get; set; }
        [InverseProperty(nameof(Classsubjectmarksprimary.Class))]
        public virtual ICollection<Classsubjectmarksprimary> Classsubjectmarksprimaries { get; set; }
        [InverseProperty(nameof(Classsubjectprimary.Class))]
        public virtual ICollection<Classsubjectprimary> Classsubjectprimaries { get; set; }
        [InverseProperty(nameof(Classsubject.Class))]
        public virtual ICollection<Classsubject> Classsubjects { get; set; }
        [InverseProperty(nameof(Classsubjmark.Class))]
        public virtual ICollection<Classsubjmark> Classsubjmarks { get; set; }
        [InverseProperty(nameof(Classsubwsteacher.Class))]
        public virtual ICollection<Classsubwsteacher> Classsubwsteachers { get; set; }
        [InverseProperty(nameof(Classweekwiseperiod.Class))]
        public virtual ICollection<Classweekwiseperiod> Classweekwiseperiods { get; set; }
        [InverseProperty(nameof(Classwiseadmschedule.Class))]
        public virtual ICollection<Classwiseadmschedule> Classwiseadmschedules { get; set; }
        [InverseProperty(nameof(Classwiseskill.Class))]
        public virtual ICollection<Classwiseskill> Classwiseskills { get; set; }
        [InverseProperty(nameof(Classwork.Course))]
        public virtual ICollection<Classwork> Classworks { get; set; }
        [InverseProperty(nameof(Culturalactivity.Course))]
        public virtual ICollection<Culturalactivity> Culturalactivities { get; set; }
        [InverseProperty(nameof(Daywiseperiod.Class))]
        public virtual ICollection<Daywiseperiod> Daywiseperiods { get; set; }
        [InverseProperty(nameof(Docclass.Class))]
        public virtual ICollection<Docclass> Docclasses { get; set; }
        [InverseProperty(nameof(Ebook.Class))]
        public virtual ICollection<Ebook> Ebooks { get; set; }
        [InverseProperty(nameof(Employeeapplicationclass.Class))]
        public virtual ICollection<Employeeapplicationclass> Employeeapplicationclasses { get; set; }
        [InverseProperty(nameof(Feecautionmoney.Class))]
        public virtual ICollection<Feecautionmoney> Feecautionmoneys { get; set; }
        [InverseProperty(nameof(Feeclass.Class))]
        public virtual ICollection<Feeclass> Feeclasses { get; set; }
        [InverseProperty(nameof(Feereceipt.ForClass))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Homework.Course))]
        public virtual ICollection<Homework> Homeworks { get; set; }
        [InverseProperty(nameof(Issuedslc.LastClassNavigation))]
        public virtual ICollection<Issuedslc> IssuedslcLastClassNavigations { get; set; }
        [InverseProperty(nameof(Issuedslc.PromotedClass))]
        public virtual ICollection<Issuedslc> IssuedslcPromotedClasses { get; set; }
        [InverseProperty(nameof(Libraryattendance.Class))]
        public virtual ICollection<Libraryattendance> Libraryattendances { get; set; }
        [InverseProperty(nameof(Markscceskill.Class))]
        public virtual ICollection<Markscceskill> Markscceskills { get; set; }
        [InverseProperty(nameof(Marksclasswisenonacademic.Class))]
        public virtual ICollection<Marksclasswisenonacademic> Marksclasswisenonacademics { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimary.Class))]
        public virtual ICollection<Marksclasswiseprimary> Marksclasswiseprimaries { get; set; }
        [InverseProperty(nameof(Marksclasswise.Class))]
        public virtual ICollection<Marksclasswise> Marksclasswises { get; set; }
        [InverseProperty(nameof(Marksheet.Class))]
        public virtual ICollection<Marksheet> Marksheets { get; set; }
        [InverseProperty(nameof(Notice.Course))]
        public virtual ICollection<Notice> Notices { get; set; }
        [InverseProperty(nameof(Qpapertask.Class))]
        public virtual ICollection<Qpapertask> Qpapertasks { get; set; }
        [InverseProperty(nameof(Receiptseriesclass.Class))]
        public virtual ICollection<Receiptseriesclass> Receiptseriesclasses { get; set; }
        [InverseProperty(nameof(Result.Class))]
        public virtual ICollection<Result> ResultClasses { get; set; }
        [InverseProperty(nameof(Result.ProClass))]
        public virtual ICollection<Result> ResultProClasses { get; set; }
        [InverseProperty(nameof(Resultcalpolicy.Class))]
        public virtual ICollection<Resultcalpolicy> Resultcalpolicies { get; set; }
        [InverseProperty(nameof(Scholardtl.Class))]
        public virtual ICollection<Scholardtl> Scholardtls { get; set; }
        [InverseProperty(nameof(Scholarhistory.Class))]
        public virtual ICollection<Scholarhistory> Scholarhistories { get; set; }
        [InverseProperty(nameof(Scholar.AdmissionClass))]
        public virtual ICollection<Scholar> Scholars { get; set; }
        [InverseProperty(nameof(Scholarship.PrevCourse))]
        public virtual ICollection<Scholarship> Scholarships { get; set; }
        [InverseProperty(nameof(Scholarsubject.Class))]
        public virtual ICollection<Scholarsubject> Scholarsubjects { get; set; }
        [InverseProperty(nameof(Section.Class))]
        public virtual ICollection<Section> SectionsNavigation { get; set; }
        [InverseProperty(nameof(Semester.Class))]
        public virtual ICollection<Semester> Semesters { get; set; }
        [InverseProperty(nameof(Teacherdtl.TeacherClass))]
        public virtual ICollection<Teacherdtl> Teacherdtls { get; set; }
        [InverseProperty(nameof(Tmpadmissionform.Class))]
        public virtual ICollection<Tmpadmissionform> Tmpadmissionforms { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.ForClass))]
        public virtual ICollection<Tmpfeereceipt> Tmpfeereceipts { get; set; }
        [InverseProperty(nameof(Yearlyattendence.Class))]
        public virtual ICollection<Yearlyattendence> Yearlyattendences { get; set; }
    }
}
