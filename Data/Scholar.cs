using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholar")]
    [Index(nameof(UnitId), Name = "FK_Scholar_BusinessUnits")]
    [Index(nameof(AdmissionClassId), Name = "FK_Scholar_Class")]
    [Index(nameof(FamilyId), Name = "FK_Scholar_Family")]
    [Index(nameof(BloodGroupId), Name = "FK_Scholar_Masters")]
    [Index(nameof(PresentAreaId), Name = "FK_Scholar_Masters13")]
    [Index(nameof(DisabilityId), Name = "FK_Scholar_Masters18")]
    [Index(nameof(EnrolStatusId), Name = "FK_Scholar_Masters19")]
    [Index(nameof(MediumId), Name = "FK_Scholar_Masters6")]
    public partial class Scholar
    {
        public Scholar()
        {
            Admissionenquiries = new HashSet<Admissionenquiry>();
            Bedallocations = new HashSet<Bedallocation>();
            Bookbookings = new HashSet<Bookbooking>();
            Bookissues = new HashSet<Bookissue>();
            Classworkdtls = new HashSet<Classworkdtl>();
            Counstoscholars = new HashSet<Counstoscholar>();
            Feeadjusteds = new HashSet<Feeadjusted>();
            Feecautionmoneys = new HashSet<Feecautionmoney>();
            Feeexceldata = new HashSet<Feeexceldatum>();
            Feepenalties = new HashSet<Feepenalty>();
            Feereceipts = new HashSet<Feereceipt>();
            Feerefunds = new HashSet<Feerefund>();
            Gatepasses = new HashSet<Gatepass>();
            Homeworkdtls = new HashSet<Homeworkdtl>();
            Hostelexpenses = new HashSet<Hostelexpense>();
            Issuedcertificates = new HashSet<Issuedcertificate>();
            Issuedslcs = new HashSet<Issuedslc>();
            Libraryattendances = new HashSet<Libraryattendance>();
            Markscceskills = new HashSet<Markscceskill>();
            Marksclasswisenonacademics = new HashSet<Marksclasswisenonacademic>();
            Marksclasswiseprimaries = new HashSet<Marksclasswiseprimary>();
            Marksclasswises = new HashSet<Marksclasswise>();
            Marksheets = new HashSet<Marksheet>();
            Noticedtls = new HashSet<Noticedtl>();
            Parentcommunications = new HashSet<Parentcommunication>();
            Results = new HashSet<Result>();
            Scholaractivities = new HashSet<Scholaractivity>();
            Scholaractivityachievements = new HashSet<Scholaractivityachievement>();
            Scholarattendances = new HashSet<Scholarattendance>();
            Scholardisciplines = new HashSet<Scholardiscipline>();
            Scholardocuments = new HashSet<Scholardocument>();
            Scholardtls = new HashSet<Scholardtl>();
            Scholarfees = new HashSet<Scholarfee>();
            Scholarhistories = new HashSet<Scholarhistory>();
            Scholarhosteldtls = new HashSet<Scholarhosteldtl>();
            Scholarleaveapps = new HashSet<Scholarleaveapp>();
            Scholaroptfees = new HashSet<Scholaroptfee>();
            Scholarpreviousdues = new HashSet<Scholarpreviousdue>();
            Scholarships = new HashSet<Scholarship>();
            Scholarsubjects = new HashSet<Scholarsubject>();
            Tmpfeereceipts = new HashSet<Tmpfeereceipt>();
            Yearlyattendences = new HashSet<Yearlyattendence>();
        }

        [Key]
        public int Id { get; set; }
        public int AdmissionNo { get; set; }
        public int? AdmFormId { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string MiddleName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [Column("DOA", TypeName = "date")]
        public DateTime Doa { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("DOL", TypeName = "date")]
        public DateTime? Dol { get; set; }
        [Required]
        [StringLength(12)]
        public string Status { get; set; }
        [StringLength(100)]
        public string ExReason { get; set; }
        public int CurrentCourseId { get; set; }
        [StringLength(7)]
        public string Gender { get; set; }
        [StringLength(25)]
        public string MobileNo { get; set; }
        [StringLength(60)]
        public string Email { get; set; }
        [StringLength(20)]
        public string BirthPlace { get; set; }
        public int? BloodGroupId { get; set; }
        [StringLength(50)]
        public string CasteCertificateNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CasteCertifDate { get; set; }
        [StringLength(30)]
        public string CasteCertifIssuedFrom { get; set; }
        [StringLength(16)]
        public string AadharNo { get; set; }
        [StringLength(20)]
        public string BiometricId { get; set; }
        public int? MediumId { get; set; }
        public int? ScholarNo { get; set; }
        public bool? StaffWard { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StaffWardDate { get; set; }
        public bool? SiblingsInSchool { get; set; }
        public int? SblScholar1Id { get; set; }
        public int? SblScholar2Id { get; set; }
        public int? SblScholar3Id { get; set; }
        public bool? ThisChildElder { get; set; }
        public bool? SiblingDiscount { get; set; }
        public double? SiblingDiscPer { get; set; }
        public bool? Discount { get; set; }
        public double? DiscountPercent { get; set; }
        [StringLength(50)]
        public string DiscountReason { get; set; }
        public bool? Hostler { get; set; }
        [Column("RTEScholar")]
        public bool? Rtescholar { get; set; }
        public bool? OnlyGirlChild { get; set; }
        public bool? BusOpted { get; set; }
        public bool? SendFeeReminder { get; set; }
        public bool? SmsAlerts { get; set; }
        public bool? EmailAlerts { get; set; }
        public short? BlackList { get; set; }
        public int? PresentAreaId { get; set; }
        [StringLength(25)]
        public string FatherName { get; set; }
        [StringLength(25)]
        public string FatherLastName { get; set; }
        [StringLength(25)]
        public string MotherName { get; set; }
        [StringLength(25)]
        public string MotherLastName { get; set; }
        [Column("G1Phone")]
        [StringLength(25)]
        public string G1phone { get; set; }
        [Column("G2Phone")]
        [StringLength(25)]
        public string G2phone { get; set; }
        [StringLength(50)]
        public string HomePerson { get; set; }
        [StringLength(10)]
        public string FamilyType { get; set; }
        public short? Brothers { get; set; }
        public short? Sisters { get; set; }
        public int? AdmissionClassId { get; set; }
        [StringLength(10)]
        public string AdmissionSection { get; set; }
        [StringLength(50)]
        public string AdmissionSession { get; set; }
        [StringLength(50)]
        public string AdmissionRemark { get; set; }
        [StringLength(70)]
        public string LastClass { get; set; }
        [StringLength(100)]
        public string LastSchool { get; set; }
        [StringLength(25)]
        public string LastBoard { get; set; }
        [Column("LReason")]
        [StringLength(50)]
        public string Lreason { get; set; }
        [Column("LSchAddress")]
        [StringLength(100)]
        public string LschAddress { get; set; }
        [Column("LSchPhone")]
        [StringLength(30)]
        public string LschPhone { get; set; }
        [Column("LSchPrincipal")]
        [StringLength(30)]
        public string LschPrincipal { get; set; }
        [Column("LSchCity")]
        [StringLength(30)]
        public string LschCity { get; set; }
        [StringLength(15)]
        public string EnrollmentNo { get; set; }
        [StringLength(25)]
        public string EnrollmentStatus { get; set; }
        [StringLength(15)]
        public string NominalNo { get; set; }
        [StringLength(10)]
        public string FolioNo { get; set; }
        [StringLength(10)]
        public string RollNo8th { get; set; }
        [StringLength(10)]
        public string RollNo10th { get; set; }
        [StringLength(10)]
        public string RollNo12th { get; set; }
        [StringLength(10)]
        public string CmRno { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CmRecDate { get; set; }
        public int? CmAmount { get; set; }
        public int UnitId { get; set; }
        [Column("SSSId")]
        [StringLength(15)]
        public string Sssid { get; set; }
        [StringLength(25)]
        public string EmergencyNo { get; set; }
        public byte[] PhotoPath { get; set; }
        public bool TcIssued { get; set; }
        [StringLength(20)]
        public string MigrationNo { get; set; }
        [StringLength(50)]
        public string BankAcNo { get; set; }
        [Column("IFSCNo")]
        [StringLength(50)]
        public string Ifscno { get; set; }
        public bool? OnlyChild { get; set; }
        [StringLength(80)]
        public string BankName { get; set; }
        public string SchBarCode { get; set; }
        public int? FamilyId { get; set; }
        public int? AppId { get; set; }
        [Column("SISPassword")]
        [StringLength(25)]
        public string Sispassword { get; set; }
        [Column("DOHL", TypeName = "date")]
        public DateTime? Dohl { get; set; }
        [StringLength(250)]
        public string HostelRemark { get; set; }
        public bool? DisplayPortalMarks { get; set; }
        public bool? Disability { get; set; }
        public int? DisabilityId { get; set; }
        public int? EnrolStatusId { get; set; }
        public double? DisabPercentage { get; set; }
        [StringLength(30)]
        public string AdmNo { get; set; }
        [StringLength(30)]
        public string StateRegistrationNumber { get; set; }
        [Column("Highest_Qualification")]
        [StringLength(30)]
        public string HighestQualification { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public bool? IsSpectacles { get; set; }
        public bool? IsMaritalStatus { get; set; }
        [StringLength(70)]
        public string SpouseName { get; set; }
        [StringLength(70)]
        public string SpouseOccupation { get; set; }

        [ForeignKey(nameof(AdmissionClassId))]
        [InverseProperty(nameof(Class.Scholars))]
        public virtual Class AdmissionClass { get; set; }
        [ForeignKey(nameof(BloodGroupId))]
        [InverseProperty(nameof(Master.ScholarBloodGroups))]
        public virtual Master BloodGroup { get; set; }
        [ForeignKey(nameof(DisabilityId))]
        [InverseProperty(nameof(Master.ScholarDisabilityNavigations))]
        public virtual Master DisabilityNavigation { get; set; }
        [ForeignKey(nameof(EnrolStatusId))]
        [InverseProperty(nameof(Master.ScholarEnrolStatuses))]
        public virtual Master EnrolStatus { get; set; }
        [ForeignKey(nameof(FamilyId))]
        [InverseProperty("Scholars")]
        public virtual Family Family { get; set; }
        [ForeignKey(nameof(MediumId))]
        [InverseProperty(nameof(Master.ScholarMedia))]
        public virtual Master Medium { get; set; }
        [ForeignKey(nameof(PresentAreaId))]
        [InverseProperty(nameof(Master.ScholarPresentAreas))]
        public virtual Master PresentArea { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Scholars))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Admissionenquiry.Scholar))]
        public virtual ICollection<Admissionenquiry> Admissionenquiries { get; set; }
        [InverseProperty(nameof(Bedallocation.Scholar))]
        public virtual ICollection<Bedallocation> Bedallocations { get; set; }
        [InverseProperty(nameof(Bookbooking.Scholar))]
        public virtual ICollection<Bookbooking> Bookbookings { get; set; }
        [InverseProperty(nameof(Bookissue.Scholar))]
        public virtual ICollection<Bookissue> Bookissues { get; set; }
        [InverseProperty(nameof(Classworkdtl.Scholar))]
        public virtual ICollection<Classworkdtl> Classworkdtls { get; set; }
        [InverseProperty(nameof(Counstoscholar.Scholar))]
        public virtual ICollection<Counstoscholar> Counstoscholars { get; set; }
        [InverseProperty(nameof(Feeadjusted.Scholar))]
        public virtual ICollection<Feeadjusted> Feeadjusteds { get; set; }
        [InverseProperty(nameof(Feecautionmoney.Scholar))]
        public virtual ICollection<Feecautionmoney> Feecautionmoneys { get; set; }
        [InverseProperty(nameof(Feeexceldatum.Scholar))]
        public virtual ICollection<Feeexceldatum> Feeexceldata { get; set; }
        [InverseProperty(nameof(Feepenalty.Scholar))]
        public virtual ICollection<Feepenalty> Feepenalties { get; set; }
        [InverseProperty(nameof(Feereceipt.Scholar))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Feerefund.Scholar))]
        public virtual ICollection<Feerefund> Feerefunds { get; set; }
        [InverseProperty(nameof(Gatepass.Scholar))]
        public virtual ICollection<Gatepass> Gatepasses { get; set; }
        [InverseProperty(nameof(Homeworkdtl.Scholar))]
        public virtual ICollection<Homeworkdtl> Homeworkdtls { get; set; }
        [InverseProperty(nameof(Hostelexpense.Scholar))]
        public virtual ICollection<Hostelexpense> Hostelexpenses { get; set; }
        [InverseProperty(nameof(Issuedcertificate.Scholar))]
        public virtual ICollection<Issuedcertificate> Issuedcertificates { get; set; }
        [InverseProperty(nameof(Issuedslc.Scholar))]
        public virtual ICollection<Issuedslc> Issuedslcs { get; set; }
        [InverseProperty(nameof(Libraryattendance.Scholar))]
        public virtual ICollection<Libraryattendance> Libraryattendances { get; set; }
        [InverseProperty(nameof(Markscceskill.Scholar))]
        public virtual ICollection<Markscceskill> Markscceskills { get; set; }
        [InverseProperty(nameof(Marksclasswisenonacademic.Scholar))]
        public virtual ICollection<Marksclasswisenonacademic> Marksclasswisenonacademics { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimary.Scholar))]
        public virtual ICollection<Marksclasswiseprimary> Marksclasswiseprimaries { get; set; }
        [InverseProperty(nameof(Marksclasswise.Scholar))]
        public virtual ICollection<Marksclasswise> Marksclasswises { get; set; }
        [InverseProperty(nameof(Marksheet.Scholar))]
        public virtual ICollection<Marksheet> Marksheets { get; set; }
        [InverseProperty(nameof(Noticedtl.Scholar))]
        public virtual ICollection<Noticedtl> Noticedtls { get; set; }
        [InverseProperty(nameof(Parentcommunication.Scholar))]
        public virtual ICollection<Parentcommunication> Parentcommunications { get; set; }
        [InverseProperty(nameof(Result.Scholar))]
        public virtual ICollection<Result> Results { get; set; }
        [InverseProperty(nameof(Scholaractivity.Scholar))]
        public virtual ICollection<Scholaractivity> Scholaractivities { get; set; }
        [InverseProperty(nameof(Scholaractivityachievement.Scholar))]
        public virtual ICollection<Scholaractivityachievement> Scholaractivityachievements { get; set; }
        [InverseProperty(nameof(Scholarattendance.Scholar))]
        public virtual ICollection<Scholarattendance> Scholarattendances { get; set; }
        [InverseProperty(nameof(Scholardiscipline.Scholar))]
        public virtual ICollection<Scholardiscipline> Scholardisciplines { get; set; }
        [InverseProperty(nameof(Scholardocument.Scholar))]
        public virtual ICollection<Scholardocument> Scholardocuments { get; set; }
        [InverseProperty(nameof(Scholardtl.Scholar))]
        public virtual ICollection<Scholardtl> Scholardtls { get; set; }
        [InverseProperty(nameof(Scholarfee.Scholar))]
        public virtual ICollection<Scholarfee> Scholarfees { get; set; }
        [InverseProperty(nameof(Scholarhistory.Scholar))]
        public virtual ICollection<Scholarhistory> Scholarhistories { get; set; }
        [InverseProperty(nameof(Scholarhosteldtl.Scholar))]
        public virtual ICollection<Scholarhosteldtl> Scholarhosteldtls { get; set; }
        [InverseProperty(nameof(Scholarleaveapp.Scholar))]
        public virtual ICollection<Scholarleaveapp> Scholarleaveapps { get; set; }
        [InverseProperty(nameof(Scholaroptfee.Scholar))]
        public virtual ICollection<Scholaroptfee> Scholaroptfees { get; set; }
        [InverseProperty(nameof(Scholarpreviousdue.Scholar))]
        public virtual ICollection<Scholarpreviousdue> Scholarpreviousdues { get; set; }
        [InverseProperty(nameof(Scholarship.Scholar))]
        public virtual ICollection<Scholarship> Scholarships { get; set; }
        [InverseProperty(nameof(Scholarsubject.Scholar))]
        public virtual ICollection<Scholarsubject> Scholarsubjects { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.Scholar))]
        public virtual ICollection<Tmpfeereceipt> Tmpfeereceipts { get; set; }
        [InverseProperty(nameof(Yearlyattendence.Scholar))]
        public virtual ICollection<Yearlyattendence> Yearlyattendences { get; set; }
    }
}
