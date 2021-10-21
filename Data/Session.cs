using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("session")]
    public partial class Session
    {
        public Session()
        {
            Admissionenquiries = new HashSet<Admissionenquiry>();
            Admissionforms = new HashSet<Admissionform>();
            Assessmentcalpolicies = new HashSet<Assessmentcalpolicy>();
            Bedallocations = new HashSet<Bedallocation>();
            Bedshiftings = new HashSet<Bedshifting>();
            Businessunits = new HashSet<Businessunit>();
            Busstopwisefees = new HashSet<Busstopwisefee>();
            Ccedescriptiveindicators = new HashSet<Ccedescriptiveindicator>();
            Ccedescriptiveskills = new HashSet<Ccedescriptiveskill>();
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
            Eventcalendars = new HashSet<Eventcalendar>();
            Feeadjusteds = new HashSet<Feeadjusted>();
            FeecautionmoneyRefundSesses = new HashSet<Feecautionmoney>();
            FeecautionmoneySessions = new HashSet<Feecautionmoney>();
            Feeexceldata = new HashSet<Feeexceldatum>();
            Feepenalties = new HashSet<Feepenalty>();
            Feereceipts = new HashSet<Feereceipt>();
            Feerefunds = new HashSet<Feerefund>();
            Feesessions = new HashSet<Feesession>();
            Grades = new HashSet<Grade>();
            Homeworks = new HashSet<Homework>();
            Hostelexpenses = new HashSet<Hostelexpense>();
            Institutes = new HashSet<Institute>();
            Issuedcertificates = new HashSet<Issuedcertificate>();
            Issuedslcs = new HashSet<Issuedslc>();
            Libraryattendances = new HashSet<Libraryattendance>();
            Marketingdata = new HashSet<Marketingdatum>();
            Markscceskills = new HashSet<Markscceskill>();
            Marksclasswisenonacademics = new HashSet<Marksclasswisenonacademic>();
            Marksclasswiseprimaries = new HashSet<Marksclasswiseprimary>();
            Marksclasswises = new HashSet<Marksclasswise>();
            Marksheetprintpolicies = new HashSet<Marksheetprintpolicy>();
            Parentcommunications = new HashSet<Parentcommunication>();
            Qpapertasks = new HashSet<Qpapertask>();
            Resultcalpolicies = new HashSet<Resultcalpolicy>();
            Results = new HashSet<Result>();
            Scholaractivities = new HashSet<Scholaractivity>();
            Scholarattendances = new HashSet<Scholarattendance>();
            Scholardisciplines = new HashSet<Scholardiscipline>();
            Scholardtls = new HashSet<Scholardtl>();
            Scholarfees = new HashSet<Scholarfee>();
            Scholarhistories = new HashSet<Scholarhistory>();
            Scholaroptfees = new HashSet<Scholaroptfee>();
            Scholarpreviousdues = new HashSet<Scholarpreviousdue>();
            ScholarshipPrevSessions = new HashSet<Scholarship>();
            ScholarshipSessions = new HashSet<Scholarship>();
            Scholarshippolicies = new HashSet<Scholarshippolicy>();
            Scholarsubjects = new HashSet<Scholarsubject>();
            Sessiondtls = new HashSet<Sessiondtl>();
            TblAllotments = new HashSet<TblAllotment>();
            TblCombinedTeacherClassMasters = new HashSet<TblCombinedTeacherClassMaster>();
            TblLabBifurcationMasters = new HashSet<TblLabBifurcationMaster>();
            TblTimetableMasters = new HashSet<TblTimetableMaster>();
            TblTimetables = new HashSet<TblTimetable>();
            Teacherdtls = new HashSet<Teacherdtl>();
            Tmpadmissionforms = new HashSet<Tmpadmissionform>();
            Tmpfeereceipts = new HashSet<Tmpfeereceipt>();
            Users = new HashSet<User>();
            Yearlyattendences = new HashSet<Yearlyattendence>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string SessName { get; set; }
        [Required]
        [StringLength(50)]
        public string SessShortName { get; set; }
        [Column(TypeName = "date")]
        public DateTime SessFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime SessTo { get; set; }
        [Column(TypeName = "date")]
        public DateTime AdmissionFrom { get; set; }
        public int Installments { get; set; }
        public int UnitId { get; set; }

        [InverseProperty(nameof(Admissionenquiry.Session))]
        public virtual ICollection<Admissionenquiry> Admissionenquiries { get; set; }
        [InverseProperty(nameof(Admissionform.Session))]
        public virtual ICollection<Admissionform> Admissionforms { get; set; }
        [InverseProperty(nameof(Assessmentcalpolicy.Session))]
        public virtual ICollection<Assessmentcalpolicy> Assessmentcalpolicies { get; set; }
        [InverseProperty(nameof(Bedallocation.Session))]
        public virtual ICollection<Bedallocation> Bedallocations { get; set; }
        [InverseProperty(nameof(Bedshifting.Session))]
        public virtual ICollection<Bedshifting> Bedshiftings { get; set; }
        [InverseProperty(nameof(Businessunit.DefaultSession))]
        public virtual ICollection<Businessunit> Businessunits { get; set; }
        [InverseProperty(nameof(Busstopwisefee.Session))]
        public virtual ICollection<Busstopwisefee> Busstopwisefees { get; set; }
        [InverseProperty(nameof(Ccedescriptiveindicator.Session))]
        public virtual ICollection<Ccedescriptiveindicator> Ccedescriptiveindicators { get; set; }
        [InverseProperty(nameof(Ccedescriptiveskill.Session))]
        public virtual ICollection<Ccedescriptiveskill> Ccedescriptiveskills { get; set; }
        [InverseProperty(nameof(Classallotment.Session))]
        public virtual ICollection<Classallotment> Classallotments { get; set; }
        [InverseProperty(nameof(Classexam.Session))]
        public virtual ICollection<Classexam> Classexams { get; set; }
        [InverseProperty(nameof(Classfee.Sess))]
        public virtual ICollection<Classfee> Classfees { get; set; }
        [InverseProperty(nameof(Classsubjectmarksprimary.Session))]
        public virtual ICollection<Classsubjectmarksprimary> Classsubjectmarksprimaries { get; set; }
        [InverseProperty(nameof(Classsubjectprimary.Session))]
        public virtual ICollection<Classsubjectprimary> Classsubjectprimaries { get; set; }
        [InverseProperty(nameof(Classsubject.Session))]
        public virtual ICollection<Classsubject> Classsubjects { get; set; }
        [InverseProperty(nameof(Classsubjmark.Session))]
        public virtual ICollection<Classsubjmark> Classsubjmarks { get; set; }
        [InverseProperty(nameof(Classsubwsteacher.Session))]
        public virtual ICollection<Classsubwsteacher> Classsubwsteachers { get; set; }
        [InverseProperty(nameof(Classweekwiseperiod.Session))]
        public virtual ICollection<Classweekwiseperiod> Classweekwiseperiods { get; set; }
        [InverseProperty(nameof(Classwiseadmschedule.Session))]
        public virtual ICollection<Classwiseadmschedule> Classwiseadmschedules { get; set; }
        [InverseProperty(nameof(Classwiseskill.Session))]
        public virtual ICollection<Classwiseskill> Classwiseskills { get; set; }
        [InverseProperty(nameof(Classwork.Session))]
        public virtual ICollection<Classwork> Classworks { get; set; }
        [InverseProperty(nameof(Culturalactivity.Session))]
        public virtual ICollection<Culturalactivity> Culturalactivities { get; set; }
        [InverseProperty(nameof(Daywiseperiod.Session))]
        public virtual ICollection<Daywiseperiod> Daywiseperiods { get; set; }
        [InverseProperty(nameof(Eventcalendar.Session))]
        public virtual ICollection<Eventcalendar> Eventcalendars { get; set; }
        [InverseProperty(nameof(Feeadjusted.Session))]
        public virtual ICollection<Feeadjusted> Feeadjusteds { get; set; }
        [InverseProperty(nameof(Feecautionmoney.RefundSess))]
        public virtual ICollection<Feecautionmoney> FeecautionmoneyRefundSesses { get; set; }
        [InverseProperty(nameof(Feecautionmoney.Session))]
        public virtual ICollection<Feecautionmoney> FeecautionmoneySessions { get; set; }
        [InverseProperty(nameof(Feeexceldatum.Session))]
        public virtual ICollection<Feeexceldatum> Feeexceldata { get; set; }
        [InverseProperty(nameof(Feepenalty.Session))]
        public virtual ICollection<Feepenalty> Feepenalties { get; set; }
        [InverseProperty(nameof(Feereceipt.Session))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Feerefund.Session))]
        public virtual ICollection<Feerefund> Feerefunds { get; set; }
        [InverseProperty(nameof(Feesession.Session))]
        public virtual ICollection<Feesession> Feesessions { get; set; }
        [InverseProperty(nameof(Grade.Session))]
        public virtual ICollection<Grade> Grades { get; set; }
        [InverseProperty(nameof(Homework.Session))]
        public virtual ICollection<Homework> Homeworks { get; set; }
        [InverseProperty(nameof(Hostelexpense.Session))]
        public virtual ICollection<Hostelexpense> Hostelexpenses { get; set; }
        [InverseProperty(nameof(Institute.Session))]
        public virtual ICollection<Institute> Institutes { get; set; }
        [InverseProperty(nameof(Issuedcertificate.Session))]
        public virtual ICollection<Issuedcertificate> Issuedcertificates { get; set; }
        [InverseProperty(nameof(Issuedslc.Session))]
        public virtual ICollection<Issuedslc> Issuedslcs { get; set; }
        [InverseProperty(nameof(Libraryattendance.Session))]
        public virtual ICollection<Libraryattendance> Libraryattendances { get; set; }
        [InverseProperty(nameof(Marketingdatum.Session))]
        public virtual ICollection<Marketingdatum> Marketingdata { get; set; }
        [InverseProperty(nameof(Markscceskill.Session))]
        public virtual ICollection<Markscceskill> Markscceskills { get; set; }
        [InverseProperty(nameof(Marksclasswisenonacademic.Session))]
        public virtual ICollection<Marksclasswisenonacademic> Marksclasswisenonacademics { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimary.Session))]
        public virtual ICollection<Marksclasswiseprimary> Marksclasswiseprimaries { get; set; }
        [InverseProperty(nameof(Marksclasswise.Session))]
        public virtual ICollection<Marksclasswise> Marksclasswises { get; set; }
        [InverseProperty(nameof(Marksheetprintpolicy.Session))]
        public virtual ICollection<Marksheetprintpolicy> Marksheetprintpolicies { get; set; }
        [InverseProperty(nameof(Parentcommunication.Session))]
        public virtual ICollection<Parentcommunication> Parentcommunications { get; set; }
        [InverseProperty(nameof(Qpapertask.Session))]
        public virtual ICollection<Qpapertask> Qpapertasks { get; set; }
        [InverseProperty(nameof(Resultcalpolicy.Session))]
        public virtual ICollection<Resultcalpolicy> Resultcalpolicies { get; set; }
        [InverseProperty(nameof(Result.Session))]
        public virtual ICollection<Result> Results { get; set; }
        [InverseProperty(nameof(Scholaractivity.Sess))]
        public virtual ICollection<Scholaractivity> Scholaractivities { get; set; }
        [InverseProperty(nameof(Scholarattendance.Session))]
        public virtual ICollection<Scholarattendance> Scholarattendances { get; set; }
        [InverseProperty(nameof(Scholardiscipline.Session))]
        public virtual ICollection<Scholardiscipline> Scholardisciplines { get; set; }
        [InverseProperty(nameof(Scholardtl.Session))]
        public virtual ICollection<Scholardtl> Scholardtls { get; set; }
        [InverseProperty(nameof(Scholarfee.Sess))]
        public virtual ICollection<Scholarfee> Scholarfees { get; set; }
        [InverseProperty(nameof(Scholarhistory.Sess))]
        public virtual ICollection<Scholarhistory> Scholarhistories { get; set; }
        [InverseProperty(nameof(Scholaroptfee.Sess))]
        public virtual ICollection<Scholaroptfee> Scholaroptfees { get; set; }
        [InverseProperty(nameof(Scholarpreviousdue.Session))]
        public virtual ICollection<Scholarpreviousdue> Scholarpreviousdues { get; set; }
        [InverseProperty(nameof(Scholarship.PrevSession))]
        public virtual ICollection<Scholarship> ScholarshipPrevSessions { get; set; }
        [InverseProperty(nameof(Scholarship.Session))]
        public virtual ICollection<Scholarship> ScholarshipSessions { get; set; }
        [InverseProperty(nameof(Scholarshippolicy.Session))]
        public virtual ICollection<Scholarshippolicy> Scholarshippolicies { get; set; }
        [InverseProperty(nameof(Scholarsubject.Sess))]
        public virtual ICollection<Scholarsubject> Scholarsubjects { get; set; }
        [InverseProperty(nameof(Sessiondtl.Sess))]
        public virtual ICollection<Sessiondtl> Sessiondtls { get; set; }
        [InverseProperty(nameof(TblAllotment.Session))]
        public virtual ICollection<TblAllotment> TblAllotments { get; set; }
        [InverseProperty(nameof(TblCombinedTeacherClassMaster.Session))]
        public virtual ICollection<TblCombinedTeacherClassMaster> TblCombinedTeacherClassMasters { get; set; }
        [InverseProperty(nameof(TblLabBifurcationMaster.Session))]
        public virtual ICollection<TblLabBifurcationMaster> TblLabBifurcationMasters { get; set; }
        [InverseProperty(nameof(TblTimetableMaster.Session))]
        public virtual ICollection<TblTimetableMaster> TblTimetableMasters { get; set; }
        [InverseProperty(nameof(TblTimetable.Session))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
        [InverseProperty(nameof(Teacherdtl.Session))]
        public virtual ICollection<Teacherdtl> Teacherdtls { get; set; }
        [InverseProperty(nameof(Tmpadmissionform.Session))]
        public virtual ICollection<Tmpadmissionform> Tmpadmissionforms { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.Session))]
        public virtual ICollection<Tmpfeereceipt> Tmpfeereceipts { get; set; }
        [InverseProperty(nameof(User.DefaultSession))]
        public virtual ICollection<User> Users { get; set; }
        [InverseProperty(nameof(Yearlyattendence.Session))]
        public virtual ICollection<Yearlyattendence> Yearlyattendences { get; set; }
    }
}
