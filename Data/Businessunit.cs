using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("businessunits")]
    [Index(nameof(DefaultFinYearId), Name = "FK_BusinessUnits_FinancialYear")]
    [Index(nameof(DefaultSessionId), Name = "FK_BusinessUnits_Session")]
    public partial class Businessunit
    {
        public Businessunit()
        {
            Accounts = new HashSet<Account>();
            Admissionenquiries = new HashSet<Admissionenquiry>();
            Admissionforms = new HashSet<Admissionform>();
            Assessmentcalpolicies = new HashSet<Assessmentcalpolicy>();
            Bedallocations = new HashSet<Bedallocation>();
            Beds = new HashSet<Bed>();
            Bedshiftings = new HashSet<Bedshifting>();
            Bonussetups = new HashSet<Bonussetup>();
            Bookdamageds = new HashSet<Bookdamaged>();
            Bookissuepolicies = new HashSet<Bookissuepolicy>();
            Bookissues = new HashSet<Bookissue>();
            Booksuppliers = new HashSet<Booksupplier>();
            Booktitles = new HashSet<Booktitle>();
            Businessunitroles = new HashSet<Businessunitrole>();
            Busstops = new HashSet<Busstop>();
            Ccedescriptiveindicators = new HashSet<Ccedescriptiveindicator>();
            Ccedescriptiveskills = new HashSet<Ccedescriptiveskill>();
            Classallotments = new HashSet<Classallotment>();
            Classes = new HashSet<Class>();
            Classexams = new HashSet<Classexam>();
            Classfees = new HashSet<Classfee>();
            Classgroups = new HashSet<Classgroup>();
            Classsubjectprimaries = new HashSet<Classsubjectprimary>();
            Classsubjects = new HashSet<Classsubject>();
            Classsubjmarks = new HashSet<Classsubjmark>();
            Classsubwsteachers = new HashSet<Classsubwsteacher>();
            Classweekwiseperiods = new HashSet<Classweekwiseperiod>();
            Classwiseadmschedules = new HashSet<Classwiseadmschedule>();
            Classwiseskills = new HashSet<Classwiseskill>();
            Counselormasters = new HashSet<Counselormaster>();
            Daywiseperiods = new HashSet<Daywiseperiod>();
            Departmentconsumptions = new HashSet<Departmentconsumption>();
            Despatches = new HashSet<Despatch>();
            Ebooks = new HashSet<Ebook>();
            Employeeapplications = new HashSet<Employeeapplication>();
            Employees = new HashSet<Employee>();
            Eventcalendars = new HashSet<Eventcalendar>();
            Exams = new HashSet<Exam>();
            Examtypes = new HashSet<Examtype>();
            Feeadjusteds = new HashSet<Feeadjusted>();
            Feecautionmoneys = new HashSet<Feecautionmoney>();
            FeeheadCompanies = new HashSet<Feehead>();
            FeeheadUnits = new HashSet<Feehead>();
            Feepenalties = new HashSet<Feepenalty>();
            Feereceipts = new HashSet<Feereceipt>();
            Feerefunds = new HashSet<Feerefund>();
            Financialunits = new HashSet<Financialunit>();
            Gatepasses = new HashSet<Gatepass>();
            Grades = new HashSet<Grade>();
            Hostalexpenseheads = new HashSet<Hostalexpensehead>();
            Hostelexpenses = new HashSet<Hostelexpense>();
            Institutes = new HashSet<Institute>();
            Inwards = new HashSet<Inward>();
            Issuedcertificates = new HashSet<Issuedcertificate>();
            Issuedslcs = new HashSet<Issuedslc>();
            Libraryattendances = new HashSet<Libraryattendance>();
            Lkustoresmsts = new HashSet<Lkustoresmst>();
            Markscceskills = new HashSet<Markscceskill>();
            Marksclasswisenonacademics = new HashSet<Marksclasswisenonacademic>();
            Marksclasswises = new HashSet<Marksclasswise>();
            Marksheetprintpolicies = new HashSet<Marksheetprintpolicy>();
            Materialissues = new HashSet<Materialissue>();
            Materialreceipts = new HashSet<Materialreceipt>();
            Materialrequisitions = new HashSet<Materialrequisition>();
            Materialreturns = new HashSet<Materialreturn>();
            Openingstocks = new HashSet<Openingstock>();
            Paymentgatewaysettings = new HashSet<Paymentgatewaysetting>();
            Personnelleaves = new HashSet<Personnelleaf>();
            Physicalstocks = new HashSet<Physicalstock>();
            Purchaseindents = new HashSet<Purchaseindent>();
            Purchaseinquiries = new HashSet<Purchaseinquiry>();
            Purchaseinvoices = new HashSet<Purchaseinvoice>();
            Purchaseorders = new HashSet<Purchaseorder>();
            Purchasequotations = new HashSet<Purchasequotation>();
            Purchasereturns = new HashSet<Purchasereturn>();
            Qpapertasks = new HashSet<Qpapertask>();
            Receiptseries = new HashSet<Receiptseries>();
            Resultcalpolicies = new HashSet<Resultcalpolicy>();
            Results = new HashSet<Result>();
            Rooms = new HashSet<Room>();
            Salaryheads = new HashSet<Salaryhead>();
            Scholarattendances = new HashSet<Scholarattendance>();
            Scholarleaveapps = new HashSet<Scholarleaveapp>();
            Scholarpreviousdues = new HashSet<Scholarpreviousdue>();
            Scholars = new HashSet<Scholar>();
            Scholarshippolicies = new HashSet<Scholarshippolicy>();
            Scholarships = new HashSet<Scholarship>();
            Stockattributes = new HashSet<Stockattribute>();
            Stockdetails = new HashSet<Stockdetail>();
            Stockreceives = new HashSet<Stockreceive>();
            Stocktransferrequests = new HashSet<Stocktransferrequest>();
            Stocktransfers = new HashSet<Stocktransfer>();
            Stores = new HashSet<Store>();
            TblAllotments = new HashSet<TblAllotment>();
            TblCombinedTeacherClassMasters = new HashSet<TblCombinedTeacherClassMaster>();
            TblLabBifurcationMasters = new HashSet<TblLabBifurcationMaster>();
            TblTimetableMasters = new HashSet<TblTimetableMaster>();
            TblTimetables = new HashSet<TblTimetable>();
            Tblfavoritemenus = new HashSet<Tblfavoritemenu>();
            Tblmasteritems = new HashSet<Tblmasteritem>();
            Tblmaterialreceipts = new HashSet<Tblmaterialreceipt>();
            Tblmaterialrequisitions = new HashSet<Tblmaterialrequisition>();
            Tmpadmissionforms = new HashSet<Tmpadmissionform>();
            Tmpfeereceipts = new HashSet<Tmpfeereceipt>();
            Users = new HashSet<User>();
            Vouchers = new HashSet<Voucher>();
            Yearlyattendences = new HashSet<Yearlyattendence>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(1)]
        public string UnitType { get; set; }
        [StringLength(100)]
        public string SchoolName { get; set; }
        [StringLength(50)]
        public string Address1 { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }
        [StringLength(25)]
        public string City { get; set; }
        [StringLength(25)]
        public string State { get; set; }
        [StringLength(6)]
        public string Pin { get; set; }
        [StringLength(55)]
        public string Phone { get; set; }
        [StringLength(30)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
        public bool? Deleted { get; set; }
        public bool? AcademicUnit { get; set; }
        public bool? FinanceUnit { get; set; }
        [StringLength(50)]
        public string MerchantKey { get; set; }
        [StringLength(50)]
        public string MerchantSalt { get; set; }
        public int? DefaultSessionId { get; set; }
        public int? DefaultFinYearId { get; set; }
        public byte[] UnitIcon { get; set; }

        [ForeignKey(nameof(DefaultFinYearId))]
        [InverseProperty(nameof(Financialyear.Businessunits))]
        public virtual Financialyear DefaultFinYear { get; set; }
        [ForeignKey(nameof(DefaultSessionId))]
        [InverseProperty(nameof(Session.Businessunits))]
        public virtual Session DefaultSession { get; set; }
        [InverseProperty(nameof(Account.Unit))]
        public virtual ICollection<Account> Accounts { get; set; }
        [InverseProperty(nameof(Admissionenquiry.Unit))]
        public virtual ICollection<Admissionenquiry> Admissionenquiries { get; set; }
        [InverseProperty(nameof(Admissionform.Unit))]
        public virtual ICollection<Admissionform> Admissionforms { get; set; }
        [InverseProperty(nameof(Assessmentcalpolicy.Unit))]
        public virtual ICollection<Assessmentcalpolicy> Assessmentcalpolicies { get; set; }
        [InverseProperty(nameof(Bedallocation.Unit))]
        public virtual ICollection<Bedallocation> Bedallocations { get; set; }
        [InverseProperty(nameof(Bed.Unit))]
        public virtual ICollection<Bed> Beds { get; set; }
        [InverseProperty(nameof(Bedshifting.Unit))]
        public virtual ICollection<Bedshifting> Bedshiftings { get; set; }
        [InverseProperty(nameof(Bonussetup.Unit))]
        public virtual ICollection<Bonussetup> Bonussetups { get; set; }
        [InverseProperty(nameof(Bookdamaged.Unit))]
        public virtual ICollection<Bookdamaged> Bookdamageds { get; set; }
        [InverseProperty(nameof(Bookissuepolicy.Unit))]
        public virtual ICollection<Bookissuepolicy> Bookissuepolicies { get; set; }
        [InverseProperty(nameof(Bookissue.Unit))]
        public virtual ICollection<Bookissue> Bookissues { get; set; }
        [InverseProperty(nameof(Booksupplier.Faunit))]
        public virtual ICollection<Booksupplier> Booksuppliers { get; set; }
        [InverseProperty(nameof(Booktitle.Faunit))]
        public virtual ICollection<Booktitle> Booktitles { get; set; }
        [InverseProperty(nameof(Businessunitrole.BusinessUnit))]
        public virtual ICollection<Businessunitrole> Businessunitroles { get; set; }
        [InverseProperty(nameof(Busstop.Unit))]
        public virtual ICollection<Busstop> Busstops { get; set; }
        [InverseProperty(nameof(Ccedescriptiveindicator.Unit))]
        public virtual ICollection<Ccedescriptiveindicator> Ccedescriptiveindicators { get; set; }
        [InverseProperty(nameof(Ccedescriptiveskill.Unit))]
        public virtual ICollection<Ccedescriptiveskill> Ccedescriptiveskills { get; set; }
        [InverseProperty(nameof(Classallotment.Unit))]
        public virtual ICollection<Classallotment> Classallotments { get; set; }
        [InverseProperty(nameof(Class.Unit))]
        public virtual ICollection<Class> Classes { get; set; }
        [InverseProperty(nameof(Classexam.Unit))]
        public virtual ICollection<Classexam> Classexams { get; set; }
        [InverseProperty(nameof(Classfee.Unit))]
        public virtual ICollection<Classfee> Classfees { get; set; }
        [InverseProperty(nameof(Classgroup.Unit))]
        public virtual ICollection<Classgroup> Classgroups { get; set; }
        [InverseProperty(nameof(Classsubjectprimary.Unit))]
        public virtual ICollection<Classsubjectprimary> Classsubjectprimaries { get; set; }
        [InverseProperty(nameof(Classsubject.Unit))]
        public virtual ICollection<Classsubject> Classsubjects { get; set; }
        [InverseProperty(nameof(Classsubjmark.Unit))]
        public virtual ICollection<Classsubjmark> Classsubjmarks { get; set; }
        [InverseProperty(nameof(Classsubwsteacher.Unit))]
        public virtual ICollection<Classsubwsteacher> Classsubwsteachers { get; set; }
        [InverseProperty(nameof(Classweekwiseperiod.Unit))]
        public virtual ICollection<Classweekwiseperiod> Classweekwiseperiods { get; set; }
        [InverseProperty(nameof(Classwiseadmschedule.Unit))]
        public virtual ICollection<Classwiseadmschedule> Classwiseadmschedules { get; set; }
        [InverseProperty(nameof(Classwiseskill.Unit))]
        public virtual ICollection<Classwiseskill> Classwiseskills { get; set; }
        [InverseProperty(nameof(Counselormaster.Unit))]
        public virtual ICollection<Counselormaster> Counselormasters { get; set; }
        [InverseProperty(nameof(Daywiseperiod.Unit))]
        public virtual ICollection<Daywiseperiod> Daywiseperiods { get; set; }
        [InverseProperty(nameof(Departmentconsumption.BusinessUnit))]
        public virtual ICollection<Departmentconsumption> Departmentconsumptions { get; set; }
        [InverseProperty(nameof(Despatch.Unit))]
        public virtual ICollection<Despatch> Despatches { get; set; }
        [InverseProperty(nameof(Ebook.Unit))]
        public virtual ICollection<Ebook> Ebooks { get; set; }
        [InverseProperty(nameof(Employeeapplication.Company))]
        public virtual ICollection<Employeeapplication> Employeeapplications { get; set; }
        [InverseProperty(nameof(Employee.Company))]
        public virtual ICollection<Employee> Employees { get; set; }
        [InverseProperty(nameof(Eventcalendar.Unit))]
        public virtual ICollection<Eventcalendar> Eventcalendars { get; set; }
        [InverseProperty(nameof(Exam.Unit))]
        public virtual ICollection<Exam> Exams { get; set; }
        [InverseProperty(nameof(Examtype.Unit))]
        public virtual ICollection<Examtype> Examtypes { get; set; }
        [InverseProperty(nameof(Feeadjusted.Unit))]
        public virtual ICollection<Feeadjusted> Feeadjusteds { get; set; }
        [InverseProperty(nameof(Feecautionmoney.Unit))]
        public virtual ICollection<Feecautionmoney> Feecautionmoneys { get; set; }
        [InverseProperty(nameof(Feehead.Company))]
        public virtual ICollection<Feehead> FeeheadCompanies { get; set; }
        [InverseProperty(nameof(Feehead.Unit))]
        public virtual ICollection<Feehead> FeeheadUnits { get; set; }
        [InverseProperty(nameof(Feepenalty.Unit))]
        public virtual ICollection<Feepenalty> Feepenalties { get; set; }
        [InverseProperty(nameof(Feereceipt.Unit))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Feerefund.Unit))]
        public virtual ICollection<Feerefund> Feerefunds { get; set; }
        [InverseProperty(nameof(Financialunit.Unit))]
        public virtual ICollection<Financialunit> Financialunits { get; set; }
        [InverseProperty(nameof(Gatepass.Unit))]
        public virtual ICollection<Gatepass> Gatepasses { get; set; }
        [InverseProperty(nameof(Grade.Unit))]
        public virtual ICollection<Grade> Grades { get; set; }
        [InverseProperty(nameof(Hostalexpensehead.Unit))]
        public virtual ICollection<Hostalexpensehead> Hostalexpenseheads { get; set; }
        [InverseProperty(nameof(Hostelexpense.Unit))]
        public virtual ICollection<Hostelexpense> Hostelexpenses { get; set; }
        [InverseProperty(nameof(Institute.Unit))]
        public virtual ICollection<Institute> Institutes { get; set; }
        [InverseProperty(nameof(Inward.Unit))]
        public virtual ICollection<Inward> Inwards { get; set; }
        [InverseProperty(nameof(Issuedcertificate.Unit))]
        public virtual ICollection<Issuedcertificate> Issuedcertificates { get; set; }
        [InverseProperty(nameof(Issuedslc.Unit))]
        public virtual ICollection<Issuedslc> Issuedslcs { get; set; }
        [InverseProperty(nameof(Libraryattendance.Unit))]
        public virtual ICollection<Libraryattendance> Libraryattendances { get; set; }
        [InverseProperty(nameof(Lkustoresmst.Unit))]
        public virtual ICollection<Lkustoresmst> Lkustoresmsts { get; set; }
        [InverseProperty(nameof(Markscceskill.Unit))]
        public virtual ICollection<Markscceskill> Markscceskills { get; set; }
        [InverseProperty(nameof(Marksclasswisenonacademic.Unit))]
        public virtual ICollection<Marksclasswisenonacademic> Marksclasswisenonacademics { get; set; }
        [InverseProperty(nameof(Marksclasswise.Unit))]
        public virtual ICollection<Marksclasswise> Marksclasswises { get; set; }
        [InverseProperty(nameof(Marksheetprintpolicy.Unit))]
        public virtual ICollection<Marksheetprintpolicy> Marksheetprintpolicies { get; set; }
        [InverseProperty(nameof(Materialissue.BusinessUnit))]
        public virtual ICollection<Materialissue> Materialissues { get; set; }
        [InverseProperty(nameof(Materialreceipt.BusinessUnit))]
        public virtual ICollection<Materialreceipt> Materialreceipts { get; set; }
        [InverseProperty(nameof(Materialrequisition.BusinessUnit))]
        public virtual ICollection<Materialrequisition> Materialrequisitions { get; set; }
        [InverseProperty(nameof(Materialreturn.BusinessUnit))]
        public virtual ICollection<Materialreturn> Materialreturns { get; set; }
        [InverseProperty(nameof(Openingstock.BusinessUnit))]
        public virtual ICollection<Openingstock> Openingstocks { get; set; }
        [InverseProperty(nameof(Paymentgatewaysetting.Unit))]
        public virtual ICollection<Paymentgatewaysetting> Paymentgatewaysettings { get; set; }
        [InverseProperty(nameof(Personnelleaf.Company))]
        public virtual ICollection<Personnelleaf> Personnelleaves { get; set; }
        [InverseProperty(nameof(Physicalstock.BusinessUnit))]
        public virtual ICollection<Physicalstock> Physicalstocks { get; set; }
        [InverseProperty(nameof(Purchaseindent.BusinessUnit))]
        public virtual ICollection<Purchaseindent> Purchaseindents { get; set; }
        [InverseProperty(nameof(Purchaseinquiry.BusinessUnit))]
        public virtual ICollection<Purchaseinquiry> Purchaseinquiries { get; set; }
        [InverseProperty(nameof(Purchaseinvoice.BusinessUnit))]
        public virtual ICollection<Purchaseinvoice> Purchaseinvoices { get; set; }
        [InverseProperty(nameof(Purchaseorder.BusinessUnit))]
        public virtual ICollection<Purchaseorder> Purchaseorders { get; set; }
        [InverseProperty(nameof(Purchasequotation.BusinessUnit))]
        public virtual ICollection<Purchasequotation> Purchasequotations { get; set; }
        [InverseProperty(nameof(Purchasereturn.BusinessUnit))]
        public virtual ICollection<Purchasereturn> Purchasereturns { get; set; }
        [InverseProperty(nameof(Qpapertask.Unit))]
        public virtual ICollection<Qpapertask> Qpapertasks { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<Receiptseries> Receiptseries { get; set; }
        [InverseProperty(nameof(Resultcalpolicy.Unit))]
        public virtual ICollection<Resultcalpolicy> Resultcalpolicies { get; set; }
        [InverseProperty(nameof(Result.Unit))]
        public virtual ICollection<Result> Results { get; set; }
        [InverseProperty(nameof(Room.Unit))]
        public virtual ICollection<Room> Rooms { get; set; }
        [InverseProperty(nameof(Salaryhead.Company))]
        public virtual ICollection<Salaryhead> Salaryheads { get; set; }
        [InverseProperty(nameof(Scholarattendance.Unit))]
        public virtual ICollection<Scholarattendance> Scholarattendances { get; set; }
        [InverseProperty(nameof(Scholarleaveapp.Unit))]
        public virtual ICollection<Scholarleaveapp> Scholarleaveapps { get; set; }
        [InverseProperty(nameof(Scholarpreviousdue.Unit))]
        public virtual ICollection<Scholarpreviousdue> Scholarpreviousdues { get; set; }
        [InverseProperty(nameof(Scholar.Unit))]
        public virtual ICollection<Scholar> Scholars { get; set; }
        [InverseProperty(nameof(Scholarshippolicy.Unit))]
        public virtual ICollection<Scholarshippolicy> Scholarshippolicies { get; set; }
        [InverseProperty(nameof(Scholarship.Unit))]
        public virtual ICollection<Scholarship> Scholarships { get; set; }
        [InverseProperty(nameof(Stockattribute.BusinessUnit))]
        public virtual ICollection<Stockattribute> Stockattributes { get; set; }
        [InverseProperty(nameof(Stockdetail.BusinessUnit))]
        public virtual ICollection<Stockdetail> Stockdetails { get; set; }
        [InverseProperty(nameof(Stockreceive.BusinessUnit))]
        public virtual ICollection<Stockreceive> Stockreceives { get; set; }
        [InverseProperty(nameof(Stocktransferrequest.BusinessUnit))]
        public virtual ICollection<Stocktransferrequest> Stocktransferrequests { get; set; }
        [InverseProperty(nameof(Stocktransfer.BusinessUnit))]
        public virtual ICollection<Stocktransfer> Stocktransfers { get; set; }
        [InverseProperty(nameof(Store.BusinessUnit))]
        public virtual ICollection<Store> Stores { get; set; }
        [InverseProperty(nameof(TblAllotment.Unit))]
        public virtual ICollection<TblAllotment> TblAllotments { get; set; }
        [InverseProperty(nameof(TblCombinedTeacherClassMaster.Unit))]
        public virtual ICollection<TblCombinedTeacherClassMaster> TblCombinedTeacherClassMasters { get; set; }
        [InverseProperty(nameof(TblLabBifurcationMaster.Unit))]
        public virtual ICollection<TblLabBifurcationMaster> TblLabBifurcationMasters { get; set; }
        [InverseProperty(nameof(TblTimetableMaster.Unit))]
        public virtual ICollection<TblTimetableMaster> TblTimetableMasters { get; set; }
        [InverseProperty(nameof(TblTimetable.Unit))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
        [InverseProperty(nameof(Tblfavoritemenu.LngUnit))]
        public virtual ICollection<Tblfavoritemenu> Tblfavoritemenus { get; set; }
        [InverseProperty(nameof(Tblmasteritem.Unit))]
        public virtual ICollection<Tblmasteritem> Tblmasteritems { get; set; }
        [InverseProperty(nameof(Tblmaterialreceipt.Unit))]
        public virtual ICollection<Tblmaterialreceipt> Tblmaterialreceipts { get; set; }
        [InverseProperty(nameof(Tblmaterialrequisition.Unit))]
        public virtual ICollection<Tblmaterialrequisition> Tblmaterialrequisitions { get; set; }
        [InverseProperty(nameof(Tmpadmissionform.Unit))]
        public virtual ICollection<Tmpadmissionform> Tmpadmissionforms { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.Unit))]
        public virtual ICollection<Tmpfeereceipt> Tmpfeereceipts { get; set; }
        [InverseProperty(nameof(User.DefaultBusinessUnit))]
        public virtual ICollection<User> Users { get; set; }
        [InverseProperty(nameof(Voucher.Company))]
        public virtual ICollection<Voucher> Vouchers { get; set; }
        [InverseProperty(nameof(Yearlyattendence.Unit))]
        public virtual ICollection<Yearlyattendence> Yearlyattendences { get; set; }
    }
}
