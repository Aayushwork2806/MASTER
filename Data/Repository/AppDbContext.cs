using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using YashCampus.Data;

#nullable disable

namespace YashCampus.Data.Repository
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Accountscompany> Accountscompanies { get; set; }
        public virtual DbSet<Accountsdtl> Accountsdtls { get; set; }
        public virtual DbSet<Accountsgroup> Accountsgroups { get; set; }
        public virtual DbSet<Admissiondocument> Admissiondocuments { get; set; }
        public virtual DbSet<Admissionenquiry> Admissionenquiries { get; set; }
        public virtual DbSet<Admissionform> Admissionforms { get; set; }
        public virtual DbSet<Aspnetrole> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetroleclaim> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetuser> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetuserclaim> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogin> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserrole> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusertoken> Aspnetusertokens { get; set; }
        public virtual DbSet<Assessmentcalpolicy> Assessmentcalpolicies { get; set; }
        public virtual DbSet<Assessmentcalpolicydtl> Assessmentcalpolicydtls { get; set; }
        public virtual DbSet<Bed> Beds { get; set; }
        public virtual DbSet<Bedallocation> Bedallocations { get; set; }
        public virtual DbSet<Bedshifting> Bedshiftings { get; set; }
        public virtual DbSet<Bonussetup> Bonussetups { get; set; }
        public virtual DbSet<Bookauthor> Bookauthors { get; set; }
        public virtual DbSet<Bookbooking> Bookbookings { get; set; }
        public virtual DbSet<Bookdamaged> Bookdamageds { get; set; }
        public virtual DbSet<Bookdamageddtl> Bookdamageddtls { get; set; }
        public virtual DbSet<Bookissue> Bookissues { get; set; }
        public virtual DbSet<Bookissuedtl> Bookissuedtls { get; set; }
        public virtual DbSet<Bookissuepolicy> Bookissuepolicies { get; set; }
        public virtual DbSet<Bookpublisher> Bookpublishers { get; set; }
        public virtual DbSet<Booksupplier> Booksuppliers { get; set; }
        public virtual DbSet<Booktitle> Booktitles { get; set; }
        public virtual DbSet<Booktitleauthor> Booktitleauthors { get; set; }
        public virtual DbSet<Booktitledtl> Booktitledtls { get; set; }
        public virtual DbSet<Booktype> Booktypes { get; set; }
        public virtual DbSet<Businessunit> Businessunits { get; set; }
        public virtual DbSet<Businessunitrole> Businessunitroles { get; set; }
        public virtual DbSet<Businessunitrolesmenu> Businessunitrolesmenus { get; set; }
        public virtual DbSet<Busstop> Busstops { get; set; }
        public virtual DbSet<Busstopwisefee> Busstopwisefees { get; set; }
        public virtual DbSet<Busstopwisefeedtl> Busstopwisefeedtls { get; set; }
        public virtual DbSet<Caste> Castes { get; set; }
        public virtual DbSet<Ccedescriptiveindicator> Ccedescriptiveindicators { get; set; }
        public virtual DbSet<Ccedescriptiveskill> Ccedescriptiveskills { get; set; }
        public virtual DbSet<Cceskillsgroup> Cceskillsgroups { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Classallotment> Classallotments { get; set; }
        public virtual DbSet<Classexam> Classexams { get; set; }
        public virtual DbSet<Classfee> Classfees { get; set; }
        public virtual DbSet<Classfeedtl> Classfeedtls { get; set; }
        public virtual DbSet<Classgroup> Classgroups { get; set; }
        public virtual DbSet<Classsubject> Classsubjects { get; set; }
        public virtual DbSet<Classsubjectmarksprimary> Classsubjectmarksprimaries { get; set; }
        public virtual DbSet<Classsubjectmarksprimarydtl> Classsubjectmarksprimarydtls { get; set; }
        public virtual DbSet<Classsubjectprimary> Classsubjectprimaries { get; set; }
        public virtual DbSet<Classsubjmark> Classsubjmarks { get; set; }
        public virtual DbSet<Classsubjmarksdtl> Classsubjmarksdtls { get; set; }
        public virtual DbSet<Classsubwsteacher> Classsubwsteachers { get; set; }
        public virtual DbSet<Classweekwiseperiod> Classweekwiseperiods { get; set; }
        public virtual DbSet<Classwiseadmschedule> Classwiseadmschedules { get; set; }
        public virtual DbSet<Classwiseskill> Classwiseskills { get; set; }
        public virtual DbSet<Classwork> Classworks { get; set; }
        public virtual DbSet<Classworkdtl> Classworkdtls { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Configration> Configrations { get; set; }
        public virtual DbSet<Counselormaster> Counselormasters { get; set; }
        public virtual DbSet<Counstoscholar> Counstoscholars { get; set; }
        public virtual DbSet<Countoschpayment> Countoschpayments { get; set; }
        public virtual DbSet<Culturalactivity> Culturalactivities { get; set; }
        public virtual DbSet<Dashboardtemplate> Dashboardtemplates { get; set; }
        public virtual DbSet<Daywiseperiod> Daywiseperiods { get; set; }
        public virtual DbSet<Dbbackup> Dbbackups { get; set; }
        public virtual DbSet<Departmentconsumption> Departmentconsumptions { get; set; }
        public virtual DbSet<Despatch> Despatches { get; set; }
        public virtual DbSet<Despatchdtl> Despatchdtls { get; set; }
        public virtual DbSet<Devicecode> Devicecodes { get; set; }
        public virtual DbSet<Docclass> Docclasses { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Ebook> Ebooks { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeeadvance> Employeeadvances { get; set; }
        public virtual DbSet<Employeeapplication> Employeeapplications { get; set; }
        public virtual DbSet<Employeeapplicationclass> Employeeapplicationclasses { get; set; }
        public virtual DbSet<Employeeapplicationsubject> Employeeapplicationsubjects { get; set; }
        public virtual DbSet<Employeebonu> Employeebonus { get; set; }
        public virtual DbSet<Employeedailyattendance> Employeedailyattendances { get; set; }
        public virtual DbSet<Employeedocument> Employeedocuments { get; set; }
        public virtual DbSet<Employeeeducationdtl> Employeeeducationdtls { get; set; }
        public virtual DbSet<Employeeleaf> Employeeleaves { get; set; }
        public virtual DbSet<Employeeleaveapp> Employeeleaveapps { get; set; }
        public virtual DbSet<Employeeloan> Employeeloans { get; set; }
        public virtual DbSet<Employeemonthlyattendance> Employeemonthlyattendances { get; set; }
        public virtual DbSet<Employeesalary> Employeesalaries { get; set; }
        public virtual DbSet<Employeesalarydtl> Employeesalarydtls { get; set; }
        public virtual DbSet<Employeesalarystructure> Employeesalarystructures { get; set; }
        public virtual DbSet<Employeeshift> Employeeshifts { get; set; }
        public virtual DbSet<Eventcalendar> Eventcalendars { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Examtype> Examtypes { get; set; }
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<Familydtl> Familydtls { get; set; }
        public virtual DbSet<Feeadjusted> Feeadjusteds { get; set; }
        public virtual DbSet<Feeadjusteddtl> Feeadjusteddtls { get; set; }
        public virtual DbSet<Feecautionmoney> Feecautionmoneys { get; set; }
        public virtual DbSet<Feeclass> Feeclasses { get; set; }
        public virtual DbSet<Feeexceldatum> Feeexceldata { get; set; }
        public virtual DbSet<Feegroupfeehead> Feegroupfeeheads { get; set; }
        public virtual DbSet<Feehead> Feeheads { get; set; }
        public virtual DbSet<Feepenalty> Feepenalties { get; set; }
        public virtual DbSet<Feereceipt> Feereceipts { get; set; }
        public virtual DbSet<Feereceiptdtl> Feereceiptdtls { get; set; }
        public virtual DbSet<Feerefund> Feerefunds { get; set; }
        public virtual DbSet<Feerefunddtl> Feerefunddtls { get; set; }
        public virtual DbSet<Feesession> Feesessions { get; set; }
        public virtual DbSet<Financialunit> Financialunits { get; set; }
        public virtual DbSet<Financialyear> Financialyears { get; set; }
        public virtual DbSet<Gatepass> Gatepasses { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Gradedtl> Gradedtls { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Homework> Homeworks { get; set; }
        public virtual DbSet<Homeworkdtl> Homeworkdtls { get; set; }
        public virtual DbSet<Hostalexpensehead> Hostalexpenseheads { get; set; }
        public virtual DbSet<Hostelexpense> Hostelexpenses { get; set; }
        public virtual DbSet<Hostelexpensesdtl> Hostelexpensesdtls { get; set; }
        public virtual DbSet<Institute> Institutes { get; set; }
        public virtual DbSet<Inward> Inwards { get; set; }
        public virtual DbSet<Inwarddetail> Inwarddetails { get; set; }
        public virtual DbSet<Inwardsubcategory> Inwardsubcategories { get; set; }
        public virtual DbSet<Ipaddress> Ipaddresses { get; set; }
        public virtual DbSet<Issuedcertificate> Issuedcertificates { get; set; }
        public virtual DbSet<Issuedslc> Issuedslcs { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Itemstoremapping> Itemstoremappings { get; set; }
        public virtual DbSet<Itemsuppliermapping> Itemsuppliermappings { get; set; }
        public virtual DbSet<Leaveyear> Leaveyears { get; set; }
        public virtual DbSet<Libraryattendance> Libraryattendances { get; set; }
        public virtual DbSet<Lkustoresmst> Lkustoresmsts { get; set; }
        public virtual DbSet<Lkustorestostaff> Lkustorestostaffs { get; set; }
        public virtual DbSet<Marketingdataallocation> Marketingdataallocations { get; set; }
        public virtual DbSet<Marketingdatum> Marketingdata { get; set; }
        public virtual DbSet<Markscceskill> Markscceskills { get; set; }
        public virtual DbSet<Markscceskillsdtl> Markscceskillsdtls { get; set; }
        public virtual DbSet<Marksclasswise> Marksclasswises { get; set; }
        public virtual DbSet<Marksclasswisedtl> Marksclasswisedtls { get; set; }
        public virtual DbSet<Marksclasswisenonacademic> Marksclasswisenonacademics { get; set; }
        public virtual DbSet<Marksclasswisenonacademicdtl> Marksclasswisenonacademicdtls { get; set; }
        public virtual DbSet<Marksclasswiseprimary> Marksclasswiseprimaries { get; set; }
        public virtual DbSet<Marksclasswiseprimarydtl> Marksclasswiseprimarydtls { get; set; }
        public virtual DbSet<Marksheet> Marksheets { get; set; }
        public virtual DbSet<Marksheetdtl> Marksheetdtls { get; set; }
        public virtual DbSet<Marksheetprintpolicy> Marksheetprintpolicies { get; set; }
        public virtual DbSet<Marksheetprintpolicydtl> Marksheetprintpolicydtls { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<Mastertype> Mastertypes { get; set; }
        public virtual DbSet<Materialissue> Materialissues { get; set; }
        public virtual DbSet<Materialissuedetail> Materialissuedetails { get; set; }
        public virtual DbSet<Materialreceipt> Materialreceipts { get; set; }
        public virtual DbSet<Materialreceiptdetail> Materialreceiptdetails { get; set; }
        public virtual DbSet<Materialrequisition> Materialrequisitions { get; set; }
        public virtual DbSet<Materialrequisitiondetail> Materialrequisitiondetails { get; set; }
        public virtual DbSet<Materialreturn> Materialreturns { get; set; }
        public virtual DbSet<Materialreturndetail> Materialreturndetails { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<Noticedtl> Noticedtls { get; set; }
        public virtual DbSet<Openingbalance> Openingbalances { get; set; }
        public virtual DbSet<Openingstock> Openingstocks { get; set; }
        public virtual DbSet<Otp> Otps { get; set; }
        public virtual DbSet<Parentcommunication> Parentcommunications { get; set; }
        public virtual DbSet<Paymentgatewaysetting> Paymentgatewaysettings { get; set; }
        public virtual DbSet<Pconfiguration> Pconfigurations { get; set; }
        public virtual DbSet<Persistedgrant> Persistedgrants { get; set; }
        public virtual DbSet<Personnelleaf> Personnelleaves { get; set; }
        public virtual DbSet<Physicalstock> Physicalstocks { get; set; }
        public virtual DbSet<Physicalstockdetail> Physicalstockdetails { get; set; }
        public virtual DbSet<Portaluser> Portalusers { get; set; }
        public virtual DbSet<Professionaltaxslab> Professionaltaxslabs { get; set; }
        public virtual DbSet<Purchaseindent> Purchaseindents { get; set; }
        public virtual DbSet<Purchaseindentdetail> Purchaseindentdetails { get; set; }
        public virtual DbSet<Purchaseinquiry> Purchaseinquiries { get; set; }
        public virtual DbSet<Purchaseinquirydetail> Purchaseinquirydetails { get; set; }
        public virtual DbSet<Purchaseinvoice> Purchaseinvoices { get; set; }
        public virtual DbSet<Purchaseinvoicedetail> Purchaseinvoicedetails { get; set; }
        public virtual DbSet<Purchaseinvoicetaxdetail> Purchaseinvoicetaxdetails { get; set; }
        public virtual DbSet<Purchaseorder> Purchaseorders { get; set; }
        public virtual DbSet<Purchaseorderdetail> Purchaseorderdetails { get; set; }
        public virtual DbSet<Purchaseorderdispatchschedule> Purchaseorderdispatchschedules { get; set; }
        public virtual DbSet<Purchaseorderremark> Purchaseorderremarks { get; set; }
        public virtual DbSet<Purchaseordertaxdetail> Purchaseordertaxdetails { get; set; }
        public virtual DbSet<Purchasequotation> Purchasequotations { get; set; }
        public virtual DbSet<Purchasequotationdetail> Purchasequotationdetails { get; set; }
        public virtual DbSet<Purchasequotationremark> Purchasequotationremarks { get; set; }
        public virtual DbSet<Purchasequotationtaxdetail> Purchasequotationtaxdetails { get; set; }
        public virtual DbSet<Purchasereturn> Purchasereturns { get; set; }
        public virtual DbSet<Purchasereturndetail> Purchasereturndetails { get; set; }
        public virtual DbSet<Purchasereturntaxdetail> Purchasereturntaxdetails { get; set; }
        public virtual DbSet<Qpapertask> Qpapertasks { get; set; }
        public virtual DbSet<Receiptseries> Receiptseries { get; set; }
        public virtual DbSet<Receiptseriesclass> Receiptseriesclasses { get; set; }
        public virtual DbSet<Refreshtoken> Refreshtokens { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Reportlist> Reportlists { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Resultcalpolicy> Resultcalpolicies { get; set; }
        public virtual DbSet<Resultsdetail> Resultsdetails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Salaryhead> Salaryheads { get; set; }
        public virtual DbSet<Scholar> Scholars { get; set; }
        public virtual DbSet<Scholaractivity> Scholaractivities { get; set; }
        public virtual DbSet<Scholaractivityachievement> Scholaractivityachievements { get; set; }
        public virtual DbSet<Scholarattendance> Scholarattendances { get; set; }
        public virtual DbSet<Scholardiscipline> Scholardisciplines { get; set; }
        public virtual DbSet<Scholardocument> Scholardocuments { get; set; }
        public virtual DbSet<Scholardtl> Scholardtls { get; set; }
        public virtual DbSet<Scholarfee> Scholarfees { get; set; }
        public virtual DbSet<Scholarfeedtl> Scholarfeedtls { get; set; }
        public virtual DbSet<Scholarhistory> Scholarhistories { get; set; }
        public virtual DbSet<Scholarhosteldtl> Scholarhosteldtls { get; set; }
        public virtual DbSet<Scholarleaveapp> Scholarleaveapps { get; set; }
        public virtual DbSet<Scholaroptfee> Scholaroptfees { get; set; }
        public virtual DbSet<Scholaroptfeedtl> Scholaroptfeedtls { get; set; }
        public virtual DbSet<Scholarpreviousdue> Scholarpreviousdues { get; set; }
        public virtual DbSet<Scholarship> Scholarships { get; set; }
        public virtual DbSet<Scholarshippolicy> Scholarshippolicies { get; set; }
        public virtual DbSet<Scholarsubject> Scholarsubjects { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Sessiondtl> Sessiondtls { get; set; }
        public virtual DbSet<Smscontact> Smscontacts { get; set; }
        public virtual DbSet<Smssent> Smssents { get; set; }
        public virtual DbSet<Smsuserinfo> Smsuserinfos { get; set; }
        public virtual DbSet<Stockattribute> Stockattributes { get; set; }
        public virtual DbSet<Stockdetail> Stockdetails { get; set; }
        public virtual DbSet<Stockreceive> Stockreceives { get; set; }
        public virtual DbSet<Stockreceivedetail> Stockreceivedetails { get; set; }
        public virtual DbSet<Stocktransfer> Stocktransfers { get; set; }
        public virtual DbSet<Stocktransferdetail> Stocktransferdetails { get; set; }
        public virtual DbSet<Stocktransferrequest> Stocktransferrequests { get; set; }
        public virtual DbSet<Stocktransferrequestdetail> Stocktransferrequestdetails { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Storestoremapping> Storestoremappings { get; set; }
        public virtual DbSet<Subdepartmentstoresmapping> Subdepartmentstoresmappings { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Taskquerydtl> Taskquerydtls { get; set; }
        public virtual DbSet<Taskscheduler> Taskschedulers { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<TblAllotment> TblAllotments { get; set; }
        public virtual DbSet<TblCombinedTeacherClassDetail> TblCombinedTeacherClassDetails { get; set; }
        public virtual DbSet<TblCombinedTeacherClassMaster> TblCombinedTeacherClassMasters { get; set; }
        public virtual DbSet<TblLabBifurcationDetail> TblLabBifurcationDetails { get; set; }
        public virtual DbSet<TblLabBifurcationMaster> TblLabBifurcationMasters { get; set; }
        public virtual DbSet<TblTimetable> TblTimetables { get; set; }
        public virtual DbSet<TblTimetableMaster> TblTimetableMasters { get; set; }
        public virtual DbSet<Tblfavoritemenu> Tblfavoritemenus { get; set; }
        public virtual DbSet<Tbllog> Tbllogs { get; set; }
        public virtual DbSet<Tblmasteritem> Tblmasteritems { get; set; }
        public virtual DbSet<Tblmasteritembatchwise> Tblmasteritembatchwises { get; set; }
        public virtual DbSet<Tblmaterialreceipt> Tblmaterialreceipts { get; set; }
        public virtual DbSet<Tblmaterialreceiptdetail> Tblmaterialreceiptdetails { get; set; }
        public virtual DbSet<Tblmaterialrequisition> Tblmaterialrequisitions { get; set; }
        public virtual DbSet<Tblmaterialrequisitiondetail> Tblmaterialrequisitiondetails { get; set; }
        public virtual DbSet<Tblsetupchangelog> Tblsetupchangelogs { get; set; }
        public virtual DbSet<Tbltransaction> Tbltransactions { get; set; }
        public virtual DbSet<Tdsslab> Tdsslabs { get; set; }
        public virtual DbSet<Teacherdtl> Teacherdtls { get; set; }
        public virtual DbSet<Temptran> Temptrans { get; set; }
        public virtual DbSet<Tmpadmissionform> Tmpadmissionforms { get; set; }
        public virtual DbSet<Tmpfeereceipt> Tmpfeereceipts { get; set; }
        public virtual DbSet<Tmpfeereceiptdtl> Tmpfeereceiptdtls { get; set; }
        public virtual DbSet<Updatecolumn> Updatecolumns { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Userbusinessunitrole> Userbusinessunitroles { get; set; }
        public virtual DbSet<Userdashboard> Userdashboards { get; set; }
        public virtual DbSet<Userroledashboard> Userroledashboards { get; set; }
        public virtual DbSet<Userstoremapping> Userstoremappings { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Vehicleaccessory> Vehicleaccessories { get; set; }
        public virtual DbSet<Vehiclemaintenance> Vehiclemaintenances { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<Voucherdtl> Voucherdtls { get; set; }
        public virtual DbSet<Yearlyattendence> Yearlyattendences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=sisdeved;port=3306", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.26-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mst_Accounts_Mst_AcGroup");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Accounts_BusinessUnits");
            });

            modelBuilder.Entity<Accountscompany>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

                entity.Property(e => e.SalaryCalDays).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Cesihead)
                    .WithMany(p => p.AccountscompanyCesiheads)
                    .HasForeignKey(d => d.CesiheadId)
                    .HasConstraintName("FK_AccountsCompany_SalaryHeads6");

                entity.HasOne(d => d.Cpfhead)
                    .WithMany(p => p.AccountscompanyCpfheads)
                    .HasForeignKey(d => d.CpfheadId)
                    .HasConstraintName("FK_AccountsCompany_SalaryHeads5");

                entity.HasOne(d => d.Dahead)
                    .WithMany(p => p.AccountscompanyDaheads)
                    .HasForeignKey(d => d.DaheadId)
                    .HasConstraintName("FK_AccountsCompany_SalaryHeads");

                entity.HasOne(d => d.Esihead)
                    .WithMany(p => p.AccountscompanyEsiheads)
                    .HasForeignKey(d => d.EsiheadId)
                    .HasConstraintName("FK_AccountsCompany_SalaryHeads2");

                entity.HasOne(d => d.Pfhead)
                    .WithMany(p => p.AccountscompanyPfheads)
                    .HasForeignKey(d => d.PfheadId)
                    .HasConstraintName("FK_AccountsCompany_SalaryHeads1");

                entity.HasOne(d => d.PtaxHead)
                    .WithMany(p => p.AccountscompanyPtaxHeads)
                    .HasForeignKey(d => d.PtaxHeadId)
                    .HasConstraintName("FK_AccountsCompany_SalaryHeads3");

                entity.HasOne(d => d.Tdshead)
                    .WithMany(p => p.AccountscompanyTdsheads)
                    .HasForeignKey(d => d.TdsheadId)
                    .HasConstraintName("FK_AccountsCompany_SalaryHeads4");
            });

            modelBuilder.Entity<Accountsdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Accounts)
                    .WithMany(p => p.Accountsdtls)
                    .HasForeignKey(d => d.AccountsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountsDtl_Accounts");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AccountsdtlCities)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_AccountsDtl_Masters");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.AccountsdtlStates)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_AccountsDtl_Masters1");
            });

            modelBuilder.Entity<Accountsgroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Admissiondocument>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AdmForm)
                    .WithMany(p => p.Admissiondocuments)
                    .HasForeignKey(d => d.AdmFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionDocuments_AdmissionForm");
            });

            modelBuilder.Entity<Admissionenquiry>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Advertisment).HasDefaultValueSql("'0'");

                entity.Property(e => e.Closed).HasDefaultValueSql("'0'");

                entity.Property(e => e.FormIssued).HasDefaultValueSql("'0'");

                entity.Property(e => e.Friend).HasDefaultValueSql("'0'");

                entity.Property(e => e.Hoarding).HasDefaultValueSql("'0'");

                entity.Property(e => e.IsMaritalStatus).HasDefaultValueSql("'0'");

                entity.Property(e => e.IsSpectacles).HasDefaultValueSql("'0'");

                entity.Property(e => e.Newspaper).HasDefaultValueSql("'0'");

                entity.Property(e => e.Radio).HasDefaultValueSql("'0'");

                entity.Property(e => e.Seminar).HasDefaultValueSql("'0'");

                entity.Property(e => e.Teacher).HasDefaultValueSql("'0'");

                entity.Property(e => e.Workshop).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AdmissionenquiryClasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionEnquiry_Class");

                entity.HasOne(d => d.Counsellor)
                    .WithMany(p => p.Admissionenquiries)
                    .HasForeignKey(d => d.CounsellorId)
                    .HasConstraintName("FK_AdmissionEnquiry_Employee");

                entity.HasOne(d => d.CourseOffered)
                    .WithMany(p => p.AdmissionenquiryCourseOffereds)
                    .HasForeignKey(d => d.CourseOfferedId)
                    .HasConstraintName("FK_AdmissionEnquiry_SClass1");

                entity.HasOne(d => d.FormNo)
                    .WithMany(p => p.Admissionenquiries)
                    .HasForeignKey(d => d.FormNoId)
                    .HasConstraintName("FK_AdmissionEnquiry_AdmissionForm");

                entity.HasOne(d => d.Medium)
                    .WithMany(p => p.Admissionenquiries)
                    .HasForeignKey(d => d.MediumId)
                    .HasConstraintName("FK_AdmissionEnquiry_Masters");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Admissionenquiries)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_AdmissionEnquiry_Scholar");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Admissionenquiries)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_AdmissionEnquiry_Semester");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Admissionenquiries)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionEnquiry_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Admissionenquiries)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_AdmissionEnquiry_BusinessUnits");
            });

            modelBuilder.Entity<Admissionform>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasDefaultValueSql("'0'");

                entity.Property(e => e.Registration).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.BloodGroup)
                    .WithMany(p => p.AdmissionformBloodGroups)
                    .HasForeignKey(d => d.BloodGroupId)
                    .HasConstraintName("FK_AdmissionForm_Masters3");

                entity.HasOne(d => d.Caste)
                    .WithMany(p => p.Admissionforms)
                    .HasForeignKey(d => d.CasteId)
                    .HasConstraintName("FK_AdmissionForm_Caste");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AdmissionformCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_AdmissionForm_Master5");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AdmissionformCities)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_AdmissionForm_Masters1");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Admissionforms)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_AdmissionForm_Class");

                entity.HasOne(d => d.FatherOccupation)
                    .WithMany(p => p.AdmissionformFatherOccupations)
                    .HasForeignKey(d => d.FatherOccupationId)
                    .HasConstraintName("FK_AdmissionForm_Master7");

                entity.HasOne(d => d.Medium)
                    .WithMany(p => p.AdmissionformMedia)
                    .HasForeignKey(d => d.MediumId)
                    .HasConstraintName("FK_AdmissionForm_Masters");

                entity.HasOne(d => d.MotherOccupation)
                    .WithMany(p => p.AdmissionformMotherOccupations)
                    .HasForeignKey(d => d.MotherOccupationId)
                    .HasConstraintName("FK_AdmissionForm_Master8");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.AdmissionformReligions)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_AdmissionForm_Master6");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Admissionforms)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_AdmissionForm_Semester");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Admissionforms)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionForm_Session");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.AdmissionformStates)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_AdmissionForm_Masters2");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Admissionforms)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_AdmissionForm_BusinessUnits");
            });

            modelBuilder.Entity<Aspnetroleclaim>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetuserclaim>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserrole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusertoken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Assessmentcalpolicy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AssesExam)
                    .WithMany(p => p.Assessmentcalpolicies)
                    .HasForeignKey(d => d.AssesExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCalPolicy_Exam");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Assessmentcalpolicies)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCalPolicy_Class");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Assessmentcalpolicies)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCalPolicy_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Assessmentcalpolicies)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCalPolicy_BusinessUnits");
            });

            modelBuilder.Entity<Assessmentcalpolicydtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AssessmentCalPolicy)
                    .WithMany(p => p.Assessmentcalpolicydtls)
                    .HasForeignKey(d => d.AssessmentCalPolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCalPolicyDtl_AssessmentCalPolicy");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Assessmentcalpolicydtls)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCalPolicyDtl_Exam");
            });

            modelBuilder.Entity<Bed>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Beds)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beds_Rooms");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Beds)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beds_BusinessUnits");
            });

            modelBuilder.Entity<Bedallocation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Bed)
                    .WithMany(p => p.Bedallocations)
                    .HasForeignKey(d => d.BedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BedAllocation_Beds");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Bedallocations)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BedAllocation_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Bedallocations)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BedAllocation_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Bedallocations)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BedAllocation_BusinessUnits");
            });

            modelBuilder.Entity<Bedshifting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FromBed)
                    .WithMany(p => p.BedshiftingFromBeds)
                    .HasForeignKey(d => d.FromBedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BedShifting_Beds");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Bedshiftings)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BedShifting_Session");

                entity.HasOne(d => d.ToBed)
                    .WithMany(p => p.BedshiftingToBeds)
                    .HasForeignKey(d => d.ToBedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BedShifting_Beds1");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Bedshiftings)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BedShifting_BusinessUnits");
            });

            modelBuilder.Entity<Bonussetup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.CreateByUser)
                    .WithMany(p => p.BonussetupCreateByUsers)
                    .HasForeignKey(d => d.CreateByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BonusSetup_Usersbyuser");

                entity.HasOne(d => d.FinYear)
                    .WithMany(p => p.Bonussetups)
                    .HasForeignKey(d => d.FinYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BonusSetup_FinancialYear");

                entity.HasOne(d => d.LastUpdatedByUser)
                    .WithMany(p => p.BonussetupLastUpdatedByUsers)
                    .HasForeignKey(d => d.LastUpdatedByUserId)
                    .HasConstraintName("FK_BonusSetup_Users");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Bonussetups)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BonusSetup_BusinessUnits");
            });

            modelBuilder.Entity<Bookauthor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Bookbooking>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Bookbookings)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookBookings_BookTitles");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Bookbookings)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_BookBookings_Scholar");
            });

            modelBuilder.Entity<Bookdamaged>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Bookdamageds)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_BookDamaged_BusinessUnits");
            });

            modelBuilder.Entity<Bookdamageddtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.BookDamaged)
                    .WithMany(p => p.Bookdamageddtls)
                    .HasForeignKey(d => d.BookDamagedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookDamagedDtl_BookDamaged");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Bookdamageddtls)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookDamagedDtl_BookTitles");
            });

            modelBuilder.Entity<Bookissue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Bookissues)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_BookIssue_Scholar");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Bookissues)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookIssue_BusinessUnits");
            });

            modelBuilder.Entity<Bookissuedtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.BookCopy)
                    .WithMany(p => p.Bookissuedtls)
                    .HasForeignKey(d => d.BookCopyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookIssueDtl_BookTitleDtl");

                entity.HasOne(d => d.BookIssue)
                    .WithMany(p => p.Bookissuedtls)
                    .HasForeignKey(d => d.BookIssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookIssueDtl_BookIssue");
            });

            modelBuilder.Entity<Bookissuepolicy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeHead)
                    .WithMany(p => p.Bookissuepolicies)
                    .HasForeignKey(d => d.FeeHeadId)
                    .HasConstraintName("FK_BookIssuePolicy_FeeHeads");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Bookissuepolicies)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_BookIssuePolicy_BusinessUnits");
            });

            modelBuilder.Entity<Bookpublisher>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Booksupplier>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Booksuppliers)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_BookSupplier_Accounts");

                entity.HasOne(d => d.Faunit)
                    .WithMany(p => p.Booksuppliers)
                    .HasForeignKey(d => d.FaunitId)
                    .HasConstraintName("FK_BookSupplier_BusinessUnits");
            });

            modelBuilder.Entity<Booktitle>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

                entity.Property(e => e.Units).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.BookSeries)
                    .WithMany(p => p.BooktitleBookSeries)
                    .HasForeignKey(d => d.BookSeriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookTitles_Masters");

                entity.HasOne(d => d.BookType)
                    .WithMany(p => p.Booktitles)
                    .HasForeignKey(d => d.BookTypeId)
                    .HasConstraintName("FK_BookTitles_BookType");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.BooktitleCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_BookTitles_Masters1");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Booktitles)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_BookTitles_Class");

                entity.HasOne(d => d.Faunit)
                    .WithMany(p => p.Booktitles)
                    .HasForeignKey(d => d.FaunitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookTitles_BusinessUnits");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.BooktitleLocations)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_BookTitles_Masters2");

                entity.HasOne(d => d.Medium)
                    .WithMany(p => p.BooktitleMedia)
                    .HasForeignKey(d => d.MediumId)
                    .HasConstraintName("FK_BookTitles_Masters3");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Booktitles)
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookTitles_BookPublisher");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Booktitles)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_BookTitles_Subject");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Booktitles)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_BookTitles_BookSupplier");
            });

            modelBuilder.Entity<Booktitleauthor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Booktitleauthors)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookTitleAuthor_BookAuthor");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Booktitleauthors)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookTitleAuthor_BookTitles");
            });

            modelBuilder.Entity<Booktitledtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Booktitledtls)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookTitleDtl_BookTitles");
            });

            modelBuilder.Entity<Booktype>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CanIssue).HasDefaultValueSql("'1'");

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Businessunit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AcademicUnit).HasDefaultValueSql("'0'");

                entity.Property(e => e.FinanceUnit).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.DefaultFinYear)
                    .WithMany(p => p.Businessunits)
                    .HasForeignKey(d => d.DefaultFinYearId)
                    .HasConstraintName("FK_BusinessUnits_FinancialYear");

                entity.HasOne(d => d.DefaultSession)
                    .WithMany(p => p.Businessunits)
                    .HasForeignKey(d => d.DefaultSessionId)
                    .HasConstraintName("FK_BusinessUnits_Session");
            });

            modelBuilder.Entity<Businessunitrole>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Businessunitroles)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessUnitRoles_BusinessUnits");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Businessunitroles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessUnitRoles_Role");
            });

            modelBuilder.Entity<Businessunitrolesmenu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.BusinessUnitRoles)
                    .WithMany(p => p.Businessunitrolesmenus)
                    .HasForeignKey(d => d.BusinessUnitRolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessUnitRolesMenu_BusinessUnitRoles");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Businessunitrolesmenus)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessUnitRolesMenu_Menus");
            });

            modelBuilder.Entity<Busstop>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Busstops)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_BusStop_Masters");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Busstops)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessUnits_BusStop");
            });

            modelBuilder.Entity<Busstopwisefee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.BusStop)
                    .WithMany(p => p.Busstopwisefees)
                    .HasForeignKey(d => d.BusStopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusStopWiseFee_BusStop");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Busstopwisefees)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusStopWiseFee_Session");
            });

            modelBuilder.Entity<Busstopwisefeedtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.BusStopFee)
                    .WithMany(p => p.Busstopwisefeedtls)
                    .HasForeignKey(d => d.BusStopFeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusStopWiseFeeDtl_BusStopWiseFee");

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.Busstopwisefeedtls)
                    .HasForeignKey(d => d.InstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusStopWiseFeeDtl_SessionDtl");
            });

            modelBuilder.Entity<Caste>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Castes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Caste_Masters");
            });

            modelBuilder.Entity<Ccedescriptiveindicator>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Grade).IsFixedLength(true);

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Ccedescriptiveindicators)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCEDescriptiveIndicator_Session");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Ccedescriptiveindicators)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCEDescriptiveIndicator_CCEDescriptiveSkills");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Ccedescriptiveindicators)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCEDescriptiveIndicator_BusinessUnits");
            });

            modelBuilder.Entity<Ccedescriptiveskill>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Ccedescriptiveskills)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCEDescriptiveSkills_Session");

                entity.HasOne(d => d.SkillGroup)
                    .WithMany(p => p.Ccedescriptiveskills)
                    .HasForeignKey(d => d.SkillGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCEDescriptiveSkills_CCESkillsGroup");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Ccedescriptiveskills)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCEDescriptiveSkills_BusinessUnits");
            });

            modelBuilder.Entity<Cceskillsgroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClassGroup)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.ClassGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Class_ClassGroup");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Class_BusinessUnits");
            });

            modelBuilder.Entity<Classallotment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classallotments)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassAllotment_Class");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Classallotments)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassAllotment_Masters");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Classallotments)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassAllotment_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classallotments)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassAllotment_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classallotments)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassAllotment_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classallotments)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassAllotment_BusinessUnits");
            });

            modelBuilder.Entity<Classexam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classexams)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassExam_ClassExam");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Classexams)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassExam_Exam");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classexams)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_ClassExam_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classexams)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassExam_BusinessUnits");
            });

            modelBuilder.Entity<Classfee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classfees)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassFee_Class");

                entity.HasOne(d => d.FeeGroup)
                    .WithMany(p => p.Classfees)
                    .HasForeignKey(d => d.FeeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassFee_Masters");

                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.Classfees)
                    .HasForeignKey(d => d.FeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassFee_FeeHeads");

                entity.HasOne(d => d.Sess)
                    .WithMany(p => p.Classfees)
                    .HasForeignKey(d => d.SessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassFee_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classfees)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_ClassFee_BusinessUnits");
            });

            modelBuilder.Entity<Classfeedtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClassFee)
                    .WithMany(p => p.Classfeedtls)
                    .HasForeignKey(d => d.ClassFeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassFeeDtl_ClassFee");

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.Classfeedtls)
                    .HasForeignKey(d => d.InstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassFeeDtl_SessionDtl");
            });

            modelBuilder.Entity<Classgroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classgroups)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassGroup_BusinessUnits");
            });

            modelBuilder.Entity<Classsubject>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasDefaultValueSql("'0'");

                entity.Property(e => e.SessionId).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classsubjects)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubject_Class");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classsubjects)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_ClassSubject_Session");

                entity.HasOne(d => d.SubjectGroup)
                    .WithMany(p => p.Classsubjects)
                    .HasForeignKey(d => d.SubjectGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubject_Masters");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classsubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubject_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classsubjects)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubject_BusinessUnits");
            });

            modelBuilder.Entity<Classsubjectmarksprimary>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classsubjectmarksprimaries)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectMarksPrimary_Class");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Classsubjectmarksprimaries)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectMarksPrimary_Exam");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classsubjectmarksprimaries)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectMarksPrimary_Session");

                entity.HasOne(d => d.SubjectGroup)
                    .WithMany(p => p.Classsubjectmarksprimaries)
                    .HasForeignKey(d => d.SubjectGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectMarksPrimary_Masters");
            });

            modelBuilder.Entity<Classsubjectmarksprimarydtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsAdd).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.ClassSubMarksPrimary)
                    .WithMany(p => p.Classsubjectmarksprimarydtls)
                    .HasForeignKey(d => d.ClassSubMarksPrimaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectMarksPrimaryDtl_ClassSubjectMarksPrimary");

                entity.HasOne(d => d.SubType)
                    .WithMany(p => p.Classsubjectmarksprimarydtls)
                    .HasForeignKey(d => d.SubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectMarksPrimaryDtl_Masters");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classsubjectmarksprimarydtls)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectMarksPrimaryDtl_Subject");
            });

            modelBuilder.Entity<Classsubjectprimary>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classsubjectprimaries)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectPrimary_Class");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classsubjectprimaries)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_ClassSubjectPrimary_Session");

                entity.HasOne(d => d.SubType)
                    .WithMany(p => p.Classsubjectprimaries)
                    .HasForeignKey(d => d.SubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectPrimary_Masters");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classsubjectprimaries)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectPrimary_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classsubjectprimaries)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjectPrimary_BusinessUnits");
            });

            modelBuilder.Entity<Classsubjmark>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classsubjmarks)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjMarks_Class");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Classsubjmarks)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjMarks_Exam");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classsubjmarks)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjMarks_Session");

                entity.HasOne(d => d.SubjectGroup)
                    .WithMany(p => p.Classsubjmarks)
                    .HasForeignKey(d => d.SubjectGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjMarks_Masters");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classsubjmarks)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjMarks_BusinessUnits");
            });

            modelBuilder.Entity<Classsubjmarksdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsAdd).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.ClassSubMarks)
                    .WithMany(p => p.Classsubjmarksdtls)
                    .HasForeignKey(d => d.ClassSubMarksId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjMarksDtl_ClassSubjMarks");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classsubjmarksdtls)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubjMarksDtl_Subject");
            });

            modelBuilder.Entity<Classsubwsteacher>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classsubwsteachers)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubWsTeacher_Class");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Classsubwsteachers)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubWsTeacher_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classsubwsteachers)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubWsTeacher_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classsubwsteachers)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubWsTeacher_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classsubwsteachers)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassSubWsTeacher_BusinessUnits");
            });

            modelBuilder.Entity<Classweekwiseperiod>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Priority).IsFixedLength(true);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classweekwiseperiods)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWeekWisePeriod_Class");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classweekwiseperiods)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWeekWisePeriod_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classweekwiseperiods)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWeekWisePeriod_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classweekwiseperiods)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWeekWisePeriod_BusinessUnits");
            });

            modelBuilder.Entity<Classwiseadmschedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classwiseadmschedules)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWiseAdmSchedule_Class");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classwiseadmschedules)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWiseAdmSchedule_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classwiseadmschedules)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWiseAdmSchedule_BusinessUnits");
            });

            modelBuilder.Entity<Classwiseskill>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Classwiseskills)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWiseSkills_Class");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classwiseskills)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWiseSkills_Session");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Classwiseskills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWiseSkills_CCEDescriptiveSkills");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Classwiseskills)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWiseSkills_BusinessUnits");
            });

            modelBuilder.Entity<Classwork>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Classworks)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWork_Class");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Classworks)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWork_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Classworks)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_ClassWork_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classworks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_ClassWork_Subject");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Classworks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ClassWork_Users");
            });

            modelBuilder.Entity<Classworkdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClassWork)
                    .WithMany(p => p.Classworkdtls)
                    .HasForeignKey(d => d.ClassWorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassWorkDtl_ClassWork");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Classworkdtls)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_ClassWorkDtl_Scholar");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Configration>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Counselormaster>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Counselormasters)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CounselorMaster_BusinessUnits");
            });

            modelBuilder.Entity<Counstoscholar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Counselor)
                    .WithMany(p => p.Counstoscholars)
                    .HasForeignKey(d => d.CounselorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CounsToScholar_CounselorMaster");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Counstoscholars)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CounsToScholar_Scholar");
            });

            modelBuilder.Entity<Countoschpayment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Cts)
                    .WithMany(p => p.Countoschpayments)
                    .HasForeignKey(d => d.Ctsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CounToSchPayment_CounsToScholar");
            });

            modelBuilder.Entity<Culturalactivity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Culturalactivities)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CulturalActivity_Class");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Culturalactivities)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CulturalActivity_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Culturalactivities)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_CulturalActivity_Session");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Culturalactivities)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CulturalActivity_Users");
            });

            modelBuilder.Entity<Dashboardtemplate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Daywiseperiod>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Daywiseperiods)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DayWisePeriod_Class");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Daywiseperiods)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DayWisePeriod_Masters");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Daywiseperiods)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DayWisePeriod_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Daywiseperiods)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DayWisePeriod_BusinessUnits");
            });

            modelBuilder.Entity<Dbbackup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Departmentconsumption>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConsumedQty).HasPrecision(15, 3);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Departmentconsumptions)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentConsumption_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Departmentconsumptions)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentConsumption_BusinessUnits");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Departmentconsumptions)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentConsumption_Items");

                entity.HasOne(d => d.SubDepartment)
                    .WithMany(p => p.Departmentconsumptions)
                    .HasForeignKey(d => d.SubDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentConsumption_Masters");
            });

            modelBuilder.Entity<Despatch>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Despatches)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Despatch_Accounts");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Despatches)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Despatch_Masters");

                entity.HasOne(d => d.FinYear)
                    .WithMany(p => p.Despatches)
                    .HasForeignKey(d => d.FinYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Despatch_FinancialYear");

                entity.HasOne(d => d.Inward)
                    .WithMany(p => p.Despatches)
                    .HasForeignKey(d => d.InwardId)
                    .HasConstraintName("FK_Despatch_Inward");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Despatches)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Despatch_InwardSubCategory");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Despatches)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Despatch_BusinessUnits");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.Despatches)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_Despatch_Voucher");
            });

            modelBuilder.Entity<Despatchdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Despatch)
                    .WithMany(p => p.Despatchdtls)
                    .HasForeignKey(d => d.DespatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DespatchDtl_Despatch");
            });

            modelBuilder.Entity<Devicecode>(entity =>
            {
                entity.HasKey(e => e.UserCode)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Docclass>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Docclasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocClass_Class");

                entity.HasOne(d => d.Docs)
                    .WithMany(p => p.Docclasses)
                    .HasForeignKey(d => d.DocsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocClass_Masters");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Fhname).IsFixedLength(true);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Driver_Employee");
            });

            modelBuilder.Entity<Ebook>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClassWiseFilter).HasDefaultValueSql("'0'");

                entity.Property(e => e.Faculty).HasDefaultValueSql("'0'");

                entity.Property(e => e.Scholar).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Ebooks)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_e-Books_BookAuthor");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Ebooks)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_e-Books_Masters");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Ebooks)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_EBook_Class");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Ebooks)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK_e-Books_BookPublisher");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Ebooks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_EBook_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Ebooks)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBook_BusinessUnits");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Initials).IsFixedLength(true);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_BusinessUnits");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Masters");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.EmployeeDesignations)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Masters1");

                entity.HasOne(d => d.EmpCategory)
                    .WithMany(p => p.EmployeeEmpCategories)
                    .HasForeignKey(d => d.EmpCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Masters2");

                entity.HasOne(d => d.EmployementStatus)
                    .WithMany(p => p.EmployeeEmployementStatuses)
                    .HasForeignKey(d => d.EmployementStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Masters3");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK_Employee_EmployeeShift");

                entity.HasOne(d => d.Tdscategory)
                    .WithMany(p => p.EmployeeTdscategories)
                    .HasForeignKey(d => d.TdscategoryId)
                    .HasConstraintName("FK_Employee_Masters4");
            });

            modelBuilder.Entity<Employeeadvance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeeadvances)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAdvance_Employee");
            });

            modelBuilder.Entity<Employeeapplication>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Initials).IsFixedLength(true);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Employeeapplications)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeApplication_BusinessUnit");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.EmployeeapplicationDesignations)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_EmployeeApplication_Masters1");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeeapplications)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeApplication_Employee");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.EmployeeapplicationQualifications)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_EmployeeApplication_Masters");
            });

            modelBuilder.Entity<Employeeapplicationclass>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Employeeapplicationclasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeApplicationClass_Class");

                entity.HasOne(d => d.EmployeeApplication)
                    .WithMany(p => p.Employeeapplicationclasses)
                    .HasForeignKey(d => d.EmployeeApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeApplicationClass_EmployeeApplication");
            });

            modelBuilder.Entity<Employeeapplicationsubject>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.EmployeeApplication)
                    .WithMany(p => p.Employeeapplicationsubjects)
                    .HasForeignKey(d => d.EmployeeApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpSubjectList_EmployeeApplication");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Employeeapplicationsubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpSubjectList_Subject");
            });

            modelBuilder.Entity<Employeebonu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.BonusSetup)
                    .WithMany(p => p.Employeebonus)
                    .HasForeignKey(d => d.BonusSetupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeBonus_BusinessUnits");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeebonus)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeBonus_Employee");

                entity.HasOne(d => d.FinYear)
                    .WithMany(p => p.Employeebonus)
                    .HasForeignKey(d => d.FinYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeBonus_FinancialYear");
            });

            modelBuilder.Entity<Employeedailyattendance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeedailyattendances)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDailyAttendance_Employee");

                entity.HasOne(d => d.Leave)
                    .WithMany(p => p.Employeedailyattendances)
                    .HasForeignKey(d => d.LeaveId)
                    .HasConstraintName("FK_EmployeeDailyAttendance_PersonnelLeaves");
            });

            modelBuilder.Entity<Employeedocument>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.Employeedocuments)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDocument_Masters");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeedocuments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDocument_Employee");
            });

            modelBuilder.Entity<Employeeeducationdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeeeducationdtls)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeEducationDtl_Employee");
            });

            modelBuilder.Entity<Employeeleaf>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeeleaves)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaves_Employee");

                entity.HasOne(d => d.Leave)
                    .WithMany(p => p.Employeeleaves)
                    .HasForeignKey(d => d.LeaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaves_PersonnelLeaves");

                entity.HasOne(d => d.LeaveYear)
                    .WithMany(p => p.Employeeleaves)
                    .HasForeignKey(d => d.LeaveYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaves_LeaveYear");
            });

            modelBuilder.Entity<Employeeleaveapp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Reason).IsFixedLength(true);

                entity.Property(e => e.SanctionBy).IsFixedLength(true);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeeleaveapps)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaveApps_Employee");

                entity.HasOne(d => d.Leave)
                    .WithMany(p => p.Employeeleaveapps)
                    .HasForeignKey(d => d.LeaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaveApps_PersonnelLeaves");
            });

            modelBuilder.Entity<Employeeloan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LoanPaid).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeeloans)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLoan_Employee");
            });

            modelBuilder.Entity<Employeemonthlyattendance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeemonthlyattendances)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeMonthlyAttendance_Employee");

                entity.HasOne(d => d.Leave)
                    .WithMany(p => p.Employeemonthlyattendances)
                    .HasForeignKey(d => d.LeaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeMonthlyAttendance_PersonnelLeaves");
            });

            modelBuilder.Entity<Employeesalary>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SalDrawn).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.EmployeesalaryBanks)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_EmployeeSalary_Masters1");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.EmployeesalaryCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_EmployeeSalary_Masters");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeesalaries)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSalary_Employee");
            });

            modelBuilder.Entity<Employeesalarydtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.EmployeeSalary)
                    .WithMany(p => p.Employeesalarydtls)
                    .HasForeignKey(d => d.EmployeeSalaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSalaryDtl_EmployeeSalary");

                entity.HasOne(d => d.SalaryHead)
                    .WithMany(p => p.Employeesalarydtls)
                    .HasForeignKey(d => d.SalaryHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSalaryDtl_SalaryHeads");
            });

            modelBuilder.Entity<Employeesalarystructure>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeesalarystructures)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSalaryStructure_Employee");

                entity.HasOne(d => d.SalHead)
                    .WithMany(p => p.Employeesalarystructures)
                    .HasForeignKey(d => d.SalHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSalaryStructure_SalaryHeads");
            });

            modelBuilder.Entity<Employeeshift>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Eventcalendar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Eventcalendars)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventCalendar_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Eventcalendars)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventCalendar_BusinessUnits");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_BusinessUnits");
            });

            modelBuilder.Entity<Examtype>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Examtypes)
                    .HasForeignKey(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamType_BusinessUnits");
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Caste)
                    .WithMany(p => p.Families)
                    .HasForeignKey(d => d.CasteId)
                    .HasConstraintName("FK_Family_Caste");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.FamilyCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Family_Masters5");

                entity.HasOne(d => d.Mtongue)
                    .WithMany(p => p.FamilyMtongues)
                    .HasForeignKey(d => d.MtongueId)
                    .HasConstraintName("FK_Family_Masters7");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.FamilyNationalities)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_Family_Masters2");

                entity.HasOne(d => d.PermanentCity)
                    .WithMany(p => p.FamilyPermanentCities)
                    .HasForeignKey(d => d.PermanentCityId)
                    .HasConstraintName("FK_Family_Masters3");

                entity.HasOne(d => d.PermanentState)
                    .WithMany(p => p.FamilyPermanentStates)
                    .HasForeignKey(d => d.PermanentStateId)
                    .HasConstraintName("FK_Family_Masters4");

                entity.HasOne(d => d.PresentCity)
                    .WithMany(p => p.FamilyPresentCities)
                    .HasForeignKey(d => d.PresentCityId)
                    .HasConstraintName("FK_Family_Masters");

                entity.HasOne(d => d.PresentState)
                    .WithMany(p => p.FamilyPresentStates)
                    .HasForeignKey(d => d.PresentStateId)
                    .HasConstraintName("FK_Family_Masters1");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.FamilyReligions)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_Family_Masters6");
            });

            modelBuilder.Entity<Familydtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.Familydtls)
                    .HasForeignKey(d => d.FamilyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamilyDtl_Family");

                entity.HasOne(d => d.Occupation)
                    .WithMany(p => p.FamilydtlOccupations)
                    .HasForeignKey(d => d.OccupationId)
                    .HasConstraintName("FK_FamilyDtl_Masters1");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.FamilydtlQualifications)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_FamilyDtl_Masters");
            });

            modelBuilder.Entity<Feeadjusted>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeHead)
                    .WithMany(p => p.Feeadjusteds)
                    .HasForeignKey(d => d.FeeHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeAdjusted_FeeHeads");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Feeadjusteds)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeAdjusted_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Feeadjusteds)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeAdjusted_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Feeadjusteds)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeAdjusted_BusinessUnits");
            });

            modelBuilder.Entity<Feeadjusteddtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeAdjusted)
                    .WithMany(p => p.Feeadjusteddtls)
                    .HasForeignKey(d => d.FeeAdjustedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeAdjustedDtl_FeeAdjusted");

                entity.HasOne(d => d.FeeHead)
                    .WithMany(p => p.Feeadjusteddtls)
                    .HasForeignKey(d => d.FeeHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeAdjustedDtl_FeeHeads");
            });

            modelBuilder.Entity<Feecautionmoney>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Feecautionmoneys)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeCautionMoney_Class");

                entity.HasOne(d => d.RefundSess)
                    .WithMany(p => p.FeecautionmoneyRefundSesses)
                    .HasForeignKey(d => d.RefundSessId)
                    .HasConstraintName("FK_FeeCautionMoney_Session1");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Feecautionmoneys)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeCautionMoney_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.FeecautionmoneySessions)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeCautionMoney_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Feecautionmoneys)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeCautionMoney_BusinessUnits");
            });

            modelBuilder.Entity<Feeclass>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Feeclasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeClass_Class");

                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.Feeclasses)
                    .HasForeignKey(d => d.FeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeClass_FeeHeads");
            });

            modelBuilder.Entity<Feeexceldatum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Feeexceldata)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_FeeExcelData_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Feeexceldata)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_FeeExcelData_Session");
            });

            modelBuilder.Entity<Feegroupfeehead>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeGroup)
                    .WithMany(p => p.Feegroupfeeheads)
                    .HasForeignKey(d => d.FeeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeGroupFeeHeads_Masters");

                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.Feegroupfeeheads)
                    .HasForeignKey(d => d.FeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeGroupFeeHeads_FeeHeads");
            });

            modelBuilder.Entity<Feehead>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PocketMoney).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Feeheads)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_FeeHeads_Accounts");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Feeheads)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_FeeHeads_Masters");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.FeeheadCompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_FeeHeads_BusinessUnits1");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.FeeheadUnits)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeHeads_BusinessUnits");
            });

            modelBuilder.Entity<Feepenalty>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeHead)
                    .WithMany(p => p.Feepenalties)
                    .HasForeignKey(d => d.FeeHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeePenalty_FeeHeads");

                entity.HasOne(d => d.FeeReceipt)
                    .WithMany(p => p.Feepenalties)
                    .HasForeignKey(d => d.FeeReceiptId)
                    .HasConstraintName("FK_FeePenalty_FeeReceipt");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Feepenalties)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeePenalty_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Feepenalties)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeePenalty_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Feepenalties)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeePenalty_BusinessUnits");
            });

            modelBuilder.Entity<Feereceipt>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BankId).HasDefaultValueSql("'0'");

                entity.Property(e => e.CashAmount).HasDefaultValueSql("'0'");

                entity.Property(e => e.ChequeAmount).HasDefaultValueSql("'0'");

                entity.Property(e => e.ChequeBranch).HasDefaultValueSql("'0'");

                entity.Property(e => e.ChequeNo).HasDefaultValueSql("'0'");

                entity.Property(e => e.InstallmentId).HasDefaultValueSql("'0'");

                entity.Property(e => e.ReceiptTotal).HasDefaultValueSql("'0'");

                entity.Property(e => e.ScholarId).HasDefaultValueSql("'0'");

                entity.Property(e => e.Status).HasDefaultValueSql("'0'");

                entity.Property(e => e.SubTotal).HasDefaultValueSql("'0'");

                entity.Property(e => e.Submitted).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_FeeReceipt_Accounts");

                entity.HasOne(d => d.AdmForm)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.AdmFormId)
                    .HasConstraintName("FK_FeeReceipt_AdmissionForm");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.FeereceiptBanks)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_FeeReceipt_Masters1");

                entity.HasOne(d => d.ForClass)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.ForClassId)
                    .HasConstraintName("FK_FeeReceipt_Class");

                entity.HasOne(d => d.ForFeeGroup)
                    .WithMany(p => p.FeereceiptForFeeGroups)
                    .HasForeignKey(d => d.ForFeeGroupId)
                    .HasConstraintName("FK_FeeReceipt_Masters2");

                entity.HasOne(d => d.Installment)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.InstallmentId)
                    .HasConstraintName("FK_FeeReceipt_SessionDtl");

                entity.HasOne(d => d.Rseries)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.RseriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeReceipt_ReceiptSeries");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_FeeReceipt_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeReceipt_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeReceipt_BusinessUnits");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_FeeReceipt_Users");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.Feereceipts)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_FeeReceipt_Voucher");
            });

            modelBuilder.Entity<Feereceiptdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeHead)
                    .WithMany(p => p.Feereceiptdtls)
                    .HasForeignKey(d => d.FeeHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeReceiptDtl_FeeHeads");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.Feereceiptdtls)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeReceiptDtl_FeeReceipt");
            });

            modelBuilder.Entity<Feerefund>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Feerefunds)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeRefund_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Feerefunds)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeRefund_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Feerefunds)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeRefund_BusinessUnits");
            });

            modelBuilder.Entity<Feerefunddtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeHead)
                    .WithMany(p => p.Feerefunddtls)
                    .HasForeignKey(d => d.FeeHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeRefundDtl_FeeHeads");

                entity.HasOne(d => d.Refund)
                    .WithMany(p => p.Feerefunddtls)
                    .HasForeignKey(d => d.RefundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeRefundDtl_FeeRefund");
            });

            modelBuilder.Entity<Feesession>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.Feesessions)
                    .HasForeignKey(d => d.FeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeSession_FeeHeads");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Feesessions)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeSession_Session");
            });

            modelBuilder.Entity<Financialunit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddEmpPfesi).HasDefaultValueSql("'0'");

                entity.Property(e => e.AttendanceMode).IsFixedLength(true);

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

                entity.Property(e => e.SalaryCalDays).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Cesihead)
                    .WithMany(p => p.FinancialunitCesiheads)
                    .HasForeignKey(d => d.CesiheadId)
                    .HasConstraintName("FK_FinancialUnits_SalaryHeads");

                entity.HasOne(d => d.Cpfhead)
                    .WithMany(p => p.FinancialunitCpfheads)
                    .HasForeignKey(d => d.CpfheadId)
                    .HasConstraintName("FK_FinancialUnits_SalaryHeads1");

                entity.HasOne(d => d.Dahead)
                    .WithMany(p => p.FinancialunitDaheads)
                    .HasForeignKey(d => d.DaheadId)
                    .HasConstraintName("FK_FinancialUnits_SalaryHeads2");

                entity.HasOne(d => d.Esihead)
                    .WithMany(p => p.FinancialunitEsiheads)
                    .HasForeignKey(d => d.EsiheadId)
                    .HasConstraintName("FK_FinancialUnits_SalaryHeads3");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.Financialunits)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK_FinancialUnits_PersonnelLeaves");

                entity.HasOne(d => d.LeaveYear)
                    .WithMany(p => p.Financialunits)
                    .HasForeignKey(d => d.LeaveYearId)
                    .HasConstraintName("FK_FinancialUnits_LeaveYear");

                entity.HasOne(d => d.Pfhead)
                    .WithMany(p => p.FinancialunitPfheads)
                    .HasForeignKey(d => d.PfheadId)
                    .HasConstraintName("FK_FinancialUnits_SalaryHeads4");

                entity.HasOne(d => d.PtaxHead)
                    .WithMany(p => p.FinancialunitPtaxHeads)
                    .HasForeignKey(d => d.PtaxHeadId)
                    .HasConstraintName("FK_FinancialUnits_SalaryHeads5");

                entity.HasOne(d => d.PurchaseDiscountAccount)
                    .WithMany(p => p.Financialunits)
                    .HasForeignKey(d => d.PurchaseDiscountAccountId)
                    .HasConstraintName("FK_FinancialUnits_Accounts");

                entity.HasOne(d => d.Tdshead)
                    .WithMany(p => p.FinancialunitTdsheads)
                    .HasForeignKey(d => d.TdsheadId)
                    .HasConstraintName("FK_FinancialUnits_SalaryHeads6");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Financialunits)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FinancialUnits_BusinessUnits");
            });

            modelBuilder.Entity<Financialyear>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Gatepass>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Gatepasses)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_GatePass_Scholar");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Gatepasses)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_GatePass_BusinessUnits");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClassGroup)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.ClassGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grade_ClassGroup");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grade_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grade_BusinessUnits");
            });

            modelBuilder.Entity<Gradedtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.GradeNavigation)
                    .WithMany(p => p.Gradedtls)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradeDtl_Grade");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.CategorySrc)
                    .WithMany(p => p.Homeworks)
                    .HasForeignKey(d => d.CategorySrcId)
                    .HasConstraintName("FK_HomeWork_Masters");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Homeworks)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HomeWork_Class");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Homeworks)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HomeWork_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Homeworks)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_HomeWork_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Homeworks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_HomeWork_Subject");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Homeworks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_HomeWork_Users");
            });

            modelBuilder.Entity<Homeworkdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.HomeWork)
                    .WithMany(p => p.Homeworkdtls)
                    .HasForeignKey(d => d.HomeWorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HomeWorkDtl_HomeWorkDtl");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Homeworkdtls)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_HomeWorkDtl_Scholar");
            });

            modelBuilder.Entity<Hostalexpensehead>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Hostalexpenseheads)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseHead_BusinessUnits");
            });

            modelBuilder.Entity<Hostelexpense>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Hostelexpenses)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HostelExpenses_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Hostelexpenses)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HostelExpenses_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Hostelexpenses)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HostelExpenses_BusinessUnits");
            });

            modelBuilder.Entity<Hostelexpensesdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.HostelExpenses)
                    .WithMany(p => p.Hostelexpensesdtls)
                    .HasForeignKey(d => d.HostelExpensesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HostelExpensesDtl_HostelExpenses");

                entity.HasOne(d => d.HostelHead)
                    .WithMany(p => p.Hostelexpensesdtls)
                    .HasForeignKey(d => d.HostelHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HostelExpensesDtl_HostalExpenseHead");
            });

            modelBuilder.Entity<Institute>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BatchWiseStock).HasDefaultValueSql("'0'");

                entity.Property(e => e.DcardPer).HasDefaultValueSql("'0'");

                entity.Property(e => e.FeePosting).IsFixedLength(true);

                entity.Property(e => e.IsSameLibrary).HasDefaultValueSql("'1'");

                entity.Property(e => e.Otp).HasDefaultValueSql("'0'");

                entity.Property(e => e.ReportDays).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.BusFee)
                    .WithMany(p => p.InstituteBusFees)
                    .HasForeignKey(d => d.BusFeeId)
                    .HasConstraintName("FK_Institutes_FeeHeads");

                entity.HasOne(d => d.LateFee)
                    .WithMany(p => p.InstituteLateFees)
                    .HasForeignKey(d => d.LateFeeId)
                    .HasConstraintName("FK_Institutes_FeeHeads1");

                entity.HasOne(d => d.LngUpdatedByNavigation)
                    .WithMany(p => p.Institutes)
                    .HasForeignKey(d => d.LngUpdatedBy)
                    .HasConstraintName("FK_Institutes_Users");

                entity.HasOne(d => d.Penalty)
                    .WithMany(p => p.InstitutePenalties)
                    .HasForeignKey(d => d.PenaltyId)
                    .HasConstraintName("FK_Institutes_FeeHeads4");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Institutes)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_Institutes_Session");

                entity.HasOne(d => d.SiblingDiscFee)
                    .WithMany(p => p.InstituteSiblingDiscFees)
                    .HasForeignKey(d => d.SiblingDiscFeeId)
                    .HasConstraintName("FK_Institutes_FeeHeads2");

                entity.HasOne(d => d.StaffDiscFee)
                    .WithMany(p => p.InstituteStaffDiscFees)
                    .HasForeignKey(d => d.StaffDiscFeeId)
                    .HasConstraintName("FK_Institutes_FeeHeads3");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Institutes)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Institutes_BusinessUnits");
            });

            modelBuilder.Entity<Inward>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inward_Masters");

                entity.HasOne(d => d.FinYear)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.FinYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inward_FinancialYear");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inward_InwardSubCategory");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Inward_Accounts");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inward_BusinessUnits");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_Inward_Voucher");
            });

            modelBuilder.Entity<Inwarddetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Inward)
                    .WithMany(p => p.Inwarddetails)
                    .HasForeignKey(d => d.InwardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InwardDetail_Inward");
            });

            modelBuilder.Entity<Inwardsubcategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Inwardsubcategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InwardSubCategory_Masters");
            });

            modelBuilder.Entity<Ipaddress>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Issuedcertificate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.Issuedcertificates)
                    .HasForeignKey(d => d.CertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuedCertificates_Certificate");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Issuedcertificates)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuedCertificates_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Issuedcertificates)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuedCertificates_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Issuedcertificates)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuedCertificates_BusinessUnits");
            });

            modelBuilder.Entity<Issuedslc>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ScSt).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.LastClassNavigation)
                    .WithMany(p => p.IssuedslcLastClassNavigations)
                    .HasForeignKey(d => d.LastClassId)
                    .HasConstraintName("FK_IssuedSLC_Class1");

                entity.HasOne(d => d.PromotedClass)
                    .WithMany(p => p.IssuedslcPromotedClasses)
                    .HasForeignKey(d => d.PromotedClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuedSLC_Class");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Issuedslcs)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuedSLC_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Issuedslcs)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuedSLC_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Issuedslcs)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuedSLC_BusinessUnits");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaxQty).HasPrecision(12, 3);

                entity.Property(e => e.MinQty).HasPrecision(12, 3);

                entity.Property(e => e.Mrp).HasPrecision(15, 2);

                entity.Property(e => e.PurchaseRate).HasPrecision(15, 2);

                entity.Property(e => e.ReOrderLevel).HasPrecision(12, 3);

                entity.Property(e => e.SaleRate).HasPrecision(15, 2);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ItemAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Items_Accounts");

                entity.HasOne(d => d.DrugCategory)
                    .WithMany(p => p.ItemDrugCategories)
                    .HasForeignKey(d => d.DrugCategoryId)
                    .HasConstraintName("FK_Items_Masters4");

                entity.HasOne(d => d.DrugGroup)
                    .WithMany(p => p.ItemDrugGroups)
                    .HasForeignKey(d => d.DrugGroupId)
                    .HasConstraintName("FK_Items_Masters5");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.ItemItemCategories)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Masters");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.ItemManufacturers)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_Items_Masters3");

                entity.HasOne(d => d.PurchaseAccount)
                    .WithMany(p => p.ItemPurchaseAccounts)
                    .HasForeignKey(d => d.PurchaseAccountId)
                    .HasConstraintName("FK_Items_Account");

                entity.HasOne(d => d.PurchaseTax)
                    .WithMany(p => p.ItemPurchaseTaxes)
                    .HasForeignKey(d => d.PurchaseTaxId)
                    .HasConstraintName("FK_Items_Tax1");

                entity.HasOne(d => d.SaleTax)
                    .WithMany(p => p.ItemSaleTaxes)
                    .HasForeignKey(d => d.SaleTaxId)
                    .HasConstraintName("FK_Items_Tax");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.ItemSubCategories)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_Items_Masters6");

                entity.HasOne(d => d.Uom1)
                    .WithMany(p => p.ItemUom1s)
                    .HasForeignKey(d => d.Uom1id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Masters1");

                entity.HasOne(d => d.Uom2)
                    .WithMany(p => p.ItemUom2s)
                    .HasForeignKey(d => d.Uom2id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Masters2");
            });

            modelBuilder.Entity<Itemstoremapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Itemstoremappings)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemStoreMapping_Items");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Itemstoremappings)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemStoreMapping_Stores");
            });

            modelBuilder.Entity<Itemsuppliermapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Itemsuppliermappings)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemSupplierMapping_Items");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Itemsuppliermappings)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemSupplierMapping_Accounts");
            });

            modelBuilder.Entity<Leaveyear>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Libraryattendance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Libraryattendances)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibraryAttendance_Class");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Libraryattendances)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibraryAttendance_Scholar");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Libraryattendances)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibraryAttendance_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Libraryattendances)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibraryAttendance_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Libraryattendances)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibraryAttendance_BusinessUnits");
            });

            modelBuilder.Entity<Lkustoresmst>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Lkustoresmsts)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_lkuStoresMst_BusinessUnits");
            });

            modelBuilder.Entity<Lkustorestostaff>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Lkustorestostaffs)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("FK_lkuStorestoStaff_Employee");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Lkustorestostaffs)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_lkuStorestoStaff_lkuStorestoStaff");
            });

            modelBuilder.Entity<Marketingdataallocation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Closed).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.MarketingData)
                    .WithMany(p => p.Marketingdataallocations)
                    .HasForeignKey(d => d.MarketingDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketingDataAllocation_MarketingData");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Marketingdataallocations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MarketingDataAllocation_Users");
            });

            modelBuilder.Entity<Marketingdatum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Allocated).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Enquiry)
                    .WithMany(p => p.Marketingdata)
                    .HasForeignKey(d => d.EnquiryId)
                    .HasConstraintName("FK_MarketingData_AdmissionEnquiry");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Marketingdata)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_MarketingData_Session");
            });

            modelBuilder.Entity<Markscceskill>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Markscceskills)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkills_Class");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Markscceskills)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkills_Exam");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Markscceskills)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkills_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Markscceskills)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkills_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Markscceskills)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkills_BusinessUnits");
            });

            modelBuilder.Entity<Markscceskillsdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Cceskills)
                    .WithMany(p => p.Markscceskillsdtls)
                    .HasForeignKey(d => d.CceskillsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkillsDtl_MarksCCESkills");

                entity.HasOne(d => d.Indicator)
                    .WithMany(p => p.Markscceskillsdtls)
                    .HasForeignKey(d => d.IndicatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkillsDtl_CCEDescriptiveIndicator");

                entity.HasOne(d => d.SkillGroup)
                    .WithMany(p => p.Markscceskillsdtls)
                    .HasForeignKey(d => d.SkillGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkillsDtl_CCESkillsGroup");

                entity.HasOne(d => d.SkillSubGroup)
                    .WithMany(p => p.Markscceskillsdtls)
                    .HasForeignKey(d => d.SkillSubGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksCCESkillsDtl_CCEDescriptiveSkills");
            });

            modelBuilder.Entity<Marksclasswise>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Marksclasswises)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWise_Class");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Marksclasswises)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWise_Exam");

                entity.HasOne(d => d.RemarkId1Navigation)
                    .WithMany(p => p.MarksclasswiseRemarkId1Navigations)
                    .HasForeignKey(d => d.RemarkId1)
                    .HasConstraintName("FK_MarksClassWise_Masters1");

                entity.HasOne(d => d.RemarkId2Navigation)
                    .WithMany(p => p.MarksclasswiseRemarkId2Navigations)
                    .HasForeignKey(d => d.RemarkId2)
                    .HasConstraintName("FK_MarksClassWise_Masters2");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Marksclasswises)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWise_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Marksclasswises)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWise_Session");

                entity.HasOne(d => d.SubjectGroup)
                    .WithMany(p => p.MarksclasswiseSubjectGroups)
                    .HasForeignKey(d => d.SubjectGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWise_Masters");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Marksclasswises)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWise_BusinessUnits");
            });

            modelBuilder.Entity<Marksclasswisedtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Submitted).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.MarksClass)
                    .WithMany(p => p.Marksclasswisedtls)
                    .HasForeignKey(d => d.MarksClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseDtl_MarksClassWise");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Marksclasswisedtls)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseDtl_Subject");
            });

            modelBuilder.Entity<Marksclasswisenonacademic>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Marksclasswisenonacademics)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseNonAcademic_Class");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Marksclasswisenonacademics)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseNonAcademic_Exam");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Marksclasswisenonacademics)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseNonAcademic_Scholar");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Marksclasswisenonacademics)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseNonAcademic_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Marksclasswisenonacademics)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseNonAcademic_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Marksclasswisenonacademics)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseNonAcademic_BusinessUnits");
            });

            modelBuilder.Entity<Marksclasswisenonacademicdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.MarksNonAcademicClass)
                    .WithMany(p => p.Marksclasswisenonacademicdtls)
                    .HasForeignKey(d => d.MarksNonAcademicClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseNonAcademicDtl_MarksClassWiseNonAcademic");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Marksclasswisenonacademicdtls)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWiseNonAcademicDtl_Subject");
            });

            modelBuilder.Entity<Marksclasswiseprimary>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Marksclasswiseprimaries)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWisePrimary_Class");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Marksclasswiseprimaries)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWisePrimary_Exam");

                entity.HasOne(d => d.RemarkId1Navigation)
                    .WithMany(p => p.MarksclasswiseprimaryRemarkId1Navigations)
                    .HasForeignKey(d => d.RemarkId1)
                    .HasConstraintName("FK_MarksClassWisePrimary_Masters1");

                entity.HasOne(d => d.RemarkId2Navigation)
                    .WithMany(p => p.MarksclasswiseprimaryRemarkId2Navigations)
                    .HasForeignKey(d => d.RemarkId2)
                    .HasConstraintName("FK_MarksClassWisePrimary_Masters2");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Marksclasswiseprimaries)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWisePrimary_Scholar");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Marksclasswiseprimaries)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWisePrimary_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Marksclasswiseprimaries)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWisePrimary_Session");
            });

            modelBuilder.Entity<Marksclasswiseprimarydtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Distinction).HasDefaultValueSql("'0'");

                entity.Property(e => e.Grace).HasDefaultValueSql("'0'");

                entity.Property(e => e.Submitted).HasDefaultValueSql("'0'");

                entity.Property(e => e.Supplementary).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.MarksClassWisePrimary)
                    .WithMany(p => p.Marksclasswiseprimarydtls)
                    .HasForeignKey(d => d.MarksClassWisePrimaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWisePrimaryDtl_MarksClassWisePrimary");

                entity.HasOne(d => d.SubType)
                    .WithMany(p => p.Marksclasswiseprimarydtls)
                    .HasForeignKey(d => d.SubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWisePrimaryDtl_Masters");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Marksclasswiseprimarydtls)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksClassWisePrimaryDtl_Subject");
            });

            modelBuilder.Entity<Marksheet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Marksheets)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarkSheet_Class");

                entity.HasOne(d => d.PrintPolicy)
                    .WithMany(p => p.Marksheets)
                    .HasForeignKey(d => d.PrintPolicyId)
                    .HasConstraintName("FK_MarkSheet_MarksheetPrintPolicy");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Marksheets)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarkSheet_Scholar");
            });

            modelBuilder.Entity<Marksheetdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttendanceStatus1).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus10).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus11).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus12).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus2).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus3).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus4).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus5).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus6).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus7).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus8).IsFixedLength(true);

                entity.Property(e => e.AttendanceStatus9).IsFixedLength(true);

                entity.HasOne(d => d.ExamId1Navigation)
                    .WithMany(p => p.MarksheetdtlExamId1Navigations)
                    .HasForeignKey(d => d.ExamId1)
                    .HasConstraintName("FK_MarkSheetDtl_Exam");

                entity.HasOne(d => d.ExamId10Navigation)
                    .WithMany(p => p.MarksheetdtlExamId10Navigations)
                    .HasForeignKey(d => d.ExamId10)
                    .HasConstraintName("FK_MarkSheetDtl_Exam9");

                entity.HasOne(d => d.ExamId11Navigation)
                    .WithMany(p => p.MarksheetdtlExamId11Navigations)
                    .HasForeignKey(d => d.ExamId11)
                    .HasConstraintName("FK_MarkSheetDtl_Exam10");

                entity.HasOne(d => d.ExamId12Navigation)
                    .WithMany(p => p.MarksheetdtlExamId12Navigations)
                    .HasForeignKey(d => d.ExamId12)
                    .HasConstraintName("FK_MarkSheetDtl_Exam11");

                entity.HasOne(d => d.ExamId2Navigation)
                    .WithMany(p => p.MarksheetdtlExamId2Navigations)
                    .HasForeignKey(d => d.ExamId2)
                    .HasConstraintName("FK_MarkSheetDtl_Exam1");

                entity.HasOne(d => d.ExamId3Navigation)
                    .WithMany(p => p.MarksheetdtlExamId3Navigations)
                    .HasForeignKey(d => d.ExamId3)
                    .HasConstraintName("FK_MarkSheetDtl_Exam2");

                entity.HasOne(d => d.ExamId4Navigation)
                    .WithMany(p => p.MarksheetdtlExamId4Navigations)
                    .HasForeignKey(d => d.ExamId4)
                    .HasConstraintName("FK_MarkSheetDtl_Exam3");

                entity.HasOne(d => d.ExamId5Navigation)
                    .WithMany(p => p.MarksheetdtlExamId5Navigations)
                    .HasForeignKey(d => d.ExamId5)
                    .HasConstraintName("FK_MarkSheetDtl_Exam4");

                entity.HasOne(d => d.ExamId6Navigation)
                    .WithMany(p => p.MarksheetdtlExamId6Navigations)
                    .HasForeignKey(d => d.ExamId6)
                    .HasConstraintName("FK_MarkSheetDtl_Exam5");

                entity.HasOne(d => d.ExamId7Navigation)
                    .WithMany(p => p.MarksheetdtlExamId7Navigations)
                    .HasForeignKey(d => d.ExamId7)
                    .HasConstraintName("FK_MarkSheetDtl_Exam6");

                entity.HasOne(d => d.ExamId8Navigation)
                    .WithMany(p => p.MarksheetdtlExamId8Navigations)
                    .HasForeignKey(d => d.ExamId8)
                    .HasConstraintName("FK_MarkSheetDtl_Exam7");

                entity.HasOne(d => d.ExamId9Navigation)
                    .WithMany(p => p.MarksheetdtlExamId9Navigations)
                    .HasForeignKey(d => d.ExamId9)
                    .HasConstraintName("FK_MarkSheetDtl_Exam8");

                entity.HasOne(d => d.MarkSheet)
                    .WithMany(p => p.Marksheetdtls)
                    .HasForeignKey(d => d.MarkSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarkSheetDtl_MarkSheet");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Marksheetdtls)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarkSheetDtl_Subject");
            });

            modelBuilder.Entity<Marksheetprintpolicy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Marksheetprintpolicies)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksheetPrintPolicy_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Marksheetprintpolicies)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksheetPrintPolicy_BusinessUnits");
            });

            modelBuilder.Entity<Marksheetprintpolicydtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Marksheetprintpolicydtls)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksheetPrintPolicyDtl_Exam");

                entity.HasOne(d => d.MarkSheetPolicy)
                    .WithMany(p => p.Marksheetprintpolicydtls)
                    .HasForeignKey(d => d.MarkSheetPolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarksheetPrintPolicyDtl_MarksheetPrintPolicy");
            });

            modelBuilder.Entity<Master>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UnitId).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Mastertype>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Materialissue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Materialissues)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialIssue_BusinessUnits");

                entity.HasOne(d => d.FromStore)
                    .WithMany(p => p.Materialissues)
                    .HasForeignKey(d => d.FromStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialIssue_Stores");

                entity.HasOne(d => d.ToSubDepartment)
                    .WithMany(p => p.Materialissues)
                    .HasForeignKey(d => d.ToSubDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialIssue_SubDepartment");
            });

            modelBuilder.Entity<Materialissuedetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConsumeQty).HasPrecision(15, 3);

                entity.Property(e => e.IssuedQty).HasPrecision(15, 3);

                entity.Property(e => e.RejectedQty).HasPrecision(15, 3);

                entity.Property(e => e.RequestedQty).HasPrecision(15, 3);

                entity.Property(e => e.ReturnQty).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Materialissuedetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialIssueDetail_Items");

                entity.HasOne(d => d.MaterialIssue)
                    .WithMany(p => p.Materialissuedetails)
                    .HasForeignKey(d => d.MaterialIssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialIssueDetail_MaterialIssue");

                entity.HasOne(d => d.MaterialRequisitionDetail)
                    .WithMany(p => p.Materialissuedetails)
                    .HasForeignKey(d => d.MaterialRequisitionDetailId)
                    .HasConstraintName("FK_MaterialIssueDetail_MaterialRequisitionDetail");

                entity.HasOne(d => d.PurchaseIndentDetail)
                    .WithMany(p => p.Materialissuedetails)
                    .HasForeignKey(d => d.PurchaseIndentDetailId)
                    .HasConstraintName("FK_MaterialIssueDetail_PurchaseIndentDetail");
            });

            modelBuilder.Entity<Materialreceipt>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Materialreceipts)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReceipt_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Materialreceipts)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReceipt_BusinessUnits");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Materialreceipts)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReceipt_Stores");

                entity.HasOne(d => d.SupplierAcc)
                    .WithMany(p => p.Materialreceipts)
                    .HasForeignKey(d => d.SupplierAccId)
                    .HasConstraintName("FK_MaterialReceipt_Accounts");
            });

            modelBuilder.Entity<Materialreceiptdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApprovedQty).HasPrecision(15, 3);

                entity.Property(e => e.BilledQty).HasPrecision(15, 3);

                entity.Property(e => e.ChallanQty).HasPrecision(15, 3);

                entity.Property(e => e.ExcessQty).HasPrecision(15, 3);

                entity.Property(e => e.FreeQty).HasPrecision(15, 3);

                entity.Property(e => e.PurchaseReturnQty).HasPrecision(15, 3);

                entity.Property(e => e.QtyUnderQc).HasPrecision(15, 3);

                entity.Property(e => e.ReceivedQty).HasPrecision(15, 3);

                entity.Property(e => e.RejectedQty).HasPrecision(15, 3);

                entity.Property(e => e.ReturnQty).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.Property(e => e.ShortageQty).HasPrecision(15, 3);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Materialreceiptdetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReceiptDetail_Items");

                entity.HasOne(d => d.MaterialReceipt)
                    .WithMany(p => p.Materialreceiptdetails)
                    .HasForeignKey(d => d.MaterialReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReceiptDetail_MaterialReceipt");

                entity.HasOne(d => d.PurchaseOrderDetail)
                    .WithMany(p => p.Materialreceiptdetails)
                    .HasForeignKey(d => d.PurchaseOrderDetailId)
                    .HasConstraintName("FK_MaterialReceiptDetail_PurchaseOrderDetail");
            });

            modelBuilder.Entity<Materialrequisition>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Materialrequisitions)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialRequisition_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Materialrequisitions)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialRequisition_BusinessUnits");

                entity.HasOne(d => d.FromSubDepartment)
                    .WithMany(p => p.Materialrequisitions)
                    .HasForeignKey(d => d.FromSubDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialRequisition_Masters");

                entity.HasOne(d => d.ToStore)
                    .WithMany(p => p.Materialrequisitions)
                    .HasForeignKey(d => d.ToStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialRequisition_Stores");
            });

            modelBuilder.Entity<Materialrequisitiondetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IssuedQty).HasPrecision(15, 3);

                entity.Property(e => e.RejectedQty).HasPrecision(15, 3);

                entity.Property(e => e.RequestedQty).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Materialrequisitiondetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialRequisitionDetail_Items");

                entity.HasOne(d => d.MaterialRequisition)
                    .WithMany(p => p.Materialrequisitiondetails)
                    .HasForeignKey(d => d.MaterialRequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialRequisitionDetail_MaterialRequisition");
            });

            modelBuilder.Entity<Materialreturn>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Materialreturns)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReturn_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Materialreturns)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReturn_BusinessUnits");

                entity.HasOne(d => d.FromSubDepartment)
                    .WithMany(p => p.Materialreturns)
                    .HasForeignKey(d => d.FromSubDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReturn_SubDepartment");

                entity.HasOne(d => d.ToStore)
                    .WithMany(p => p.Materialreturns)
                    .HasForeignKey(d => d.ToStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialReturn_Stores");
            });

            modelBuilder.Entity<Materialreturndetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.QtyReturned).HasPrecision(15, 3);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Materialreturndetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MateialReturnDetail_Items");

                entity.HasOne(d => d.MaterialIssueDetail)
                    .WithMany(p => p.Materialreturndetails)
                    .HasForeignKey(d => d.MaterialIssueDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MateialReturnDetail_MaterialIssueDetail");

                entity.HasOne(d => d.MaterialReturn)
                    .WithMany(p => p.Materialreturndetails)
                    .HasForeignKey(d => d.MaterialReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MateialReturnDetail_MaterialReturn");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsShow).HasDefaultValueSql("'1'");

                entity.Property(e => e.MenuCode)
                    .HasDefaultValueSql("'1'")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Notice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notice_Class");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notice_Section");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Notice_Users");
            });

            modelBuilder.Entity<Noticedtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Notice)
                    .WithMany(p => p.Noticedtls)
                    .HasForeignKey(d => d.NoticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NoticeDtl_Notice");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Noticedtls)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_NoticeDtl_Scholar");
            });

            modelBuilder.Entity<Openingbalance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Openingbalances)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpeningBalance_Accounts");

                entity.HasOne(d => d.FinYear)
                    .WithMany(p => p.Openingbalances)
                    .HasForeignKey(d => d.FinYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpeningBalance_FinancialYear");
            });

            modelBuilder.Entity<Openingstock>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Mrp).HasPrecision(15, 2);

                entity.Property(e => e.PurchaseRate).HasPrecision(15, 2);

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.Property(e => e.SaleRate).HasPrecision(15, 2);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Openingstocks)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpeningStock_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Openingstocks)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpeningStock_BusinessUnits");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Openingstocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpeningStock_Items");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Openingstocks)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpeningStock_Stores");
            });

            modelBuilder.Entity<Otp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Parentcommunication>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Parentcommunications)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_ParentCommunications_Masters");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Parentcommunications)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParentCommunications_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Parentcommunications)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParentCommunications_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Parentcommunications)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_ParentCommunications_Subject");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Parentcommunications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ParentCommunications_Users");
            });

            modelBuilder.Entity<Paymentgatewaysetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Paymentgatewaysettings)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentGateWaySettings_BusinessUnits");
            });

            modelBuilder.Entity<Pconfiguration>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Persistedgrant>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Personnelleaf>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Personnelleaves)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelLeaves_BusinessUnits");
            });

            modelBuilder.Entity<Physicalstock>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Physicalstocks)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhysicalStock_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Physicalstocks)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhysicalStock_BusinessUnits");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Physicalstocks)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhysicalStock_Stores");
            });

            modelBuilder.Entity<Physicalstockdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Physicalstockdetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhysicalStockDetail_Items");

                entity.HasOne(d => d.PhysicalStock)
                    .WithMany(p => p.Physicalstockdetails)
                    .HasForeignKey(d => d.PhysicalStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhysicalStockDetail_PhysicalStock");
            });

            modelBuilder.Entity<Portaluser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Professionaltaxslab>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AssmentYear)
                    .WithMany(p => p.Professionaltaxslabs)
                    .HasForeignKey(d => d.AssmentYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfessionalTaxSlab_FinancialYear");
            });

            modelBuilder.Entity<Purchaseindent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.PurchaseindentAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseIndent_Users");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.PurchaseindentApprovedByNavigations)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK_PurchaseIndent_Users1");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Purchaseindents)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseIndent_BusinessUnits");

                entity.HasOne(d => d.Stores)
                    .WithMany(p => p.Purchaseindents)
                    .HasForeignKey(d => d.StoresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseIndent_Stores");

                entity.HasOne(d => d.SubDepartment)
                    .WithMany(p => p.Purchaseindents)
                    .HasForeignKey(d => d.SubDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseIndent_Masters");
            });

            modelBuilder.Entity<Purchaseindentdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.OrderGenerated).HasDefaultValueSql("'0'");

                entity.Property(e => e.QtyReceived).HasPrecision(15, 3);

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Purchaseindentdetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseIndentDetail_Items");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Purchaseindentdetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_PurchaseIndentDetail_PurchaseOrder");

                entity.HasOne(d => d.PurchaseIndent)
                    .WithMany(p => p.Purchaseindentdetails)
                    .HasForeignKey(d => d.PurchaseIndentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseIndentDetail_PurchaseIndent");
            });

            modelBuilder.Entity<Purchaseinquiry>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SourceDoc).IsFixedLength(true);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Purchaseinquiries)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInquiry_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Purchaseinquiries)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInquiry_BusinessUnits");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Purchaseinquiries)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInquiry_Stores");

                entity.HasOne(d => d.SupplierAcc)
                    .WithMany(p => p.Purchaseinquiries)
                    .HasForeignKey(d => d.SupplierAccId)
                    .HasConstraintName("FK_PurchaseInquiry_Accounts");
            });

            modelBuilder.Entity<Purchaseinquirydetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Purchaseinquirydetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInquiryDetail_Items");

                entity.HasOne(d => d.PurchaseIndentDetail)
                    .WithMany(p => p.Purchaseinquirydetails)
                    .HasForeignKey(d => d.PurchaseIndentDetailId)
                    .HasConstraintName("FK_PurchaseInquiryDetail_PurchaseIndentDetail");

                entity.HasOne(d => d.PurchaseInquiry)
                    .WithMany(p => p.Purchaseinquirydetails)
                    .HasForeignKey(d => d.PurchaseInquiryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInquiryDetail_PurchaseInquiry");
            });

            modelBuilder.Entity<Purchaseinvoice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjAmt).HasPrecision(15, 2);

                entity.Property(e => e.BilledAmount).HasPrecision(15, 2);

                entity.Property(e => e.BilledBasicAmount).HasPrecision(15, 2);

                entity.Property(e => e.BilledTaxAmount).HasPrecision(15, 2);

                entity.Property(e => e.DiscountAmount).HasPrecision(15, 2);

                entity.Property(e => e.DiscountPer).HasPrecision(5, 2);

                entity.Property(e => e.PassedAmount).HasPrecision(15, 2);

                entity.Property(e => e.PassedBasicAmount).HasPrecision(15, 2);

                entity.Property(e => e.PassedTaxAmount).HasPrecision(15, 2);

                entity.Property(e => e.ReturnAmount).HasPrecision(15, 2);

                entity.Property(e => e.ReturnBasicAmount).HasPrecision(15, 2);

                entity.Property(e => e.ReturnTaxAmount).HasPrecision(15, 2);

                entity.Property(e => e.RoundOff).HasPrecision(15, 2);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Purchaseinvoices)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInvoice_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Purchaseinvoices)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInvoice_BusinessUnits");

                entity.HasOne(d => d.ReturnVoucher)
                    .WithMany(p => p.PurchaseinvoiceReturnVouchers)
                    .HasForeignKey(d => d.ReturnVoucherId)
                    .HasConstraintName("FK_PurchaseInvoice_Voucher1");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Purchaseinvoices)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInvoice_Stores");

                entity.HasOne(d => d.SupplierAcc)
                    .WithMany(p => p.Purchaseinvoices)
                    .HasForeignKey(d => d.SupplierAccId)
                    .HasConstraintName("FK_PurchaseInvoice_Accounts");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.PurchaseinvoiceVouchers)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_PurchaseInvoice_Voucher");
            });

            modelBuilder.Entity<Purchaseinvoicedetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BillDiscount).HasPrecision(15, 2);

                entity.Property(e => e.BilledAmount).HasPrecision(15, 2);

                entity.Property(e => e.BilledQty).HasPrecision(15, 3);

                entity.Property(e => e.DiscountAmount).HasPrecision(15, 2);

                entity.Property(e => e.DiscountPer).HasPrecision(5, 2);

                entity.Property(e => e.FreeQty).HasPrecision(15, 3);

                entity.Property(e => e.PassedAmount).HasPrecision(15, 2);

                entity.Property(e => e.PassedQty).HasPrecision(15, 3);

                entity.Property(e => e.PurchaseRate).HasPrecision(15, 2);

                entity.Property(e => e.PurchaseRateAfterTax).HasPrecision(15, 2);

                entity.Property(e => e.PurchaseRateBeforeTax).HasPrecision(15, 2);

                entity.Property(e => e.PurchaseReturnQty).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Purchaseinvoicedetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInvoiceDetail_Items");

                entity.HasOne(d => d.MaterialReceiptDetail)
                    .WithMany(p => p.Purchaseinvoicedetails)
                    .HasForeignKey(d => d.MaterialReceiptDetailId)
                    .HasConstraintName("FK_PurchaseInvoiceDetail_MaterialReceiptDetail");

                entity.HasOne(d => d.PurchaseInvoice)
                    .WithMany(p => p.Purchaseinvoicedetails)
                    .HasForeignKey(d => d.PurchaseInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInvoiceDetail_PurchaseInvoice");

                entity.HasOne(d => d.TaxScheme)
                    .WithMany(p => p.Purchaseinvoicedetails)
                    .HasForeignKey(d => d.TaxSchemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInvoiceDetail_Tax");
            });

            modelBuilder.Entity<Purchaseinvoicetaxdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BilledTaxAmount).HasPrecision(15, 2);

                entity.Property(e => e.PassedTaxAmount).HasPrecision(15, 2);

                entity.Property(e => e.TaxPer).HasPrecision(6, 2);

                entity.HasOne(d => d.PurchaseInvoiceDetail)
                    .WithMany(p => p.Purchaseinvoicetaxdetails)
                    .HasForeignKey(d => d.PurchaseInvoiceDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInvoiceTaxDetail_PurchaseInvoiceDetail");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.Purchaseinvoicetaxdetails)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseInvoiceTaxDetail_Tax");
            });

            modelBuilder.Entity<Purchaseorder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AmountAfterDiscount).HasPrecision(15, 2);

                entity.Property(e => e.AmountAfterTax).HasPrecision(15, 2);

                entity.Property(e => e.BasicAmount).HasPrecision(15, 2);

                entity.Property(e => e.BillDiscount).HasPrecision(12, 2);

                entity.Property(e => e.BillDiscountPer).HasPrecision(6, 2);

                entity.Property(e => e.Freight).IsFixedLength(true);

                entity.Property(e => e.OrderValue).HasPrecision(15, 2);

                entity.Property(e => e.SourceDoc).IsFixedLength(true);

                entity.Property(e => e.TaxAmount).HasPrecision(15, 2);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Purchaseorders)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Purchaseorders)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_BusinessUnits");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Purchaseorders)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_Stores");

                entity.HasOne(d => d.SupplierAcc)
                    .WithMany(p => p.Purchaseorders)
                    .HasForeignKey(d => d.SupplierAccId)
                    .HasConstraintName("FK_PurchaseOrder_Accounts");
            });

            modelBuilder.Entity<Purchaseorderdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AmountAfterDiscount).HasPrecision(15, 2);

                entity.Property(e => e.AmountAfterTax).HasPrecision(15, 2);

                entity.Property(e => e.AmountBeforeDiscount).HasPrecision(15, 2);

                entity.Property(e => e.Discount).HasPrecision(12, 2);

                entity.Property(e => e.DiscountPer).HasPrecision(6, 2);

                entity.Property(e => e.DistributedDiscount).HasPrecision(12, 2);

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.Property(e => e.Rate).HasPrecision(15, 2);

                entity.Property(e => e.RateAfterDiscount).HasPrecision(15, 2);

                entity.Property(e => e.RateAfterTax).HasPrecision(15, 2);

                entity.Property(e => e.RateBeforeTax).HasPrecision(15, 2);

                entity.Property(e => e.ReceivedQty).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Purchaseorderdetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetail_Items");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.Purchaseorderdetails)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetail_PurchaseOrder");

                entity.HasOne(d => d.TaxScheme)
                    .WithMany(p => p.Purchaseorderdetails)
                    .HasForeignKey(d => d.TaxSchemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetail_Tax");
            });

            modelBuilder.Entity<Purchaseorderdispatchschedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.HasOne(d => d.PurchaseOrderIdetail)
                    .WithMany(p => p.Purchaseorderdispatchschedules)
                    .HasForeignKey(d => d.PurchaseOrderIdetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDispatchSchedule_PurchaseOrderDetail");
            });

            modelBuilder.Entity<Purchaseorderremark>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.Purchaseorderremarks)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderRemark_PurchaseOrder");
            });

            modelBuilder.Entity<Purchaseordertaxdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasPrecision(15, 2);

                entity.Property(e => e.TaxPer).HasPrecision(6, 2);

                entity.HasOne(d => d.PurchaseOrderDetail)
                    .WithMany(p => p.Purchaseordertaxdetails)
                    .HasForeignKey(d => d.PurchaseOrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderTaxDetail_PurchaseOrderDetail");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.Purchaseordertaxdetails)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderTaxDetail_Tax");
            });

            modelBuilder.Entity<Purchasequotation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AmountAfterDiscount).HasPrecision(15, 2);

                entity.Property(e => e.AmountAfterTax).HasPrecision(15, 2);

                entity.Property(e => e.BasicAmount).HasPrecision(15, 2);

                entity.Property(e => e.BillDiscount).HasPrecision(12, 2);

                entity.Property(e => e.BillDiscountPer).HasPrecision(6, 2);

                entity.Property(e => e.SourceDoc).IsFixedLength(true);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Purchasequotations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseQuotation_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Purchasequotations)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .HasConstraintName("FK_PurchaseQuotation_BusinessUnits");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Purchasequotations)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_PurchaseQuotation_Stores");

                entity.HasOne(d => d.SupplierAcc)
                    .WithMany(p => p.Purchasequotations)
                    .HasForeignKey(d => d.SupplierAccId)
                    .HasConstraintName("FK_PurchaseQuotation_Accounts");
            });

            modelBuilder.Entity<Purchasequotationdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AmountAfterDiscount).HasPrecision(15, 2);

                entity.Property(e => e.AmountAfterTax).HasPrecision(15, 2);

                entity.Property(e => e.AmountBeforeDiscount).HasPrecision(15, 2);

                entity.Property(e => e.Discount).HasPrecision(12, 2);

                entity.Property(e => e.DiscountPer).HasPrecision(6, 2);

                entity.Property(e => e.DistributedDiscount).HasPrecision(12, 2);

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.Property(e => e.Rate).HasPrecision(15, 2);

                entity.Property(e => e.RateAfterDiscount).HasPrecision(15, 2);

                entity.Property(e => e.RateAfterTax).HasPrecision(15, 2);

                entity.Property(e => e.RateBeforeTax).HasPrecision(15, 2);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Purchasequotationdetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseQuotationDetail_Items");

                entity.HasOne(d => d.PurchaseQuotation)
                    .WithMany(p => p.Purchasequotationdetails)
                    .HasForeignKey(d => d.PurchaseQuotationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseQuotationDetail_PurchaseQuotation");

                entity.HasOne(d => d.TaxScheme)
                    .WithMany(p => p.Purchasequotationdetails)
                    .HasForeignKey(d => d.TaxSchemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseQuotationDetail_Tax");
            });

            modelBuilder.Entity<Purchasequotationremark>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.PurchaseQuotation)
                    .WithMany(p => p.Purchasequotationremarks)
                    .HasForeignKey(d => d.PurchaseQuotationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseQuotationRemark_PurchaseQuotation");
            });

            modelBuilder.Entity<Purchasequotationtaxdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasPrecision(15, 2);

                entity.Property(e => e.TaxPer).HasPrecision(6, 2);

                entity.HasOne(d => d.PurchaseQuotationDetail)
                    .WithMany(p => p.Purchasequotationtaxdetails)
                    .HasForeignKey(d => d.PurchaseQuotationDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseQuotationTaxDetail_PurchaseQuotationDetail");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.Purchasequotationtaxdetails)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseQuotationTaxDetail_Masters");
            });

            modelBuilder.Entity<Purchasereturn>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BasicAmount).HasPrecision(15, 2);

                entity.Property(e => e.ReturnAmount).HasPrecision(15, 2);

                entity.Property(e => e.ReturnType).IsFixedLength(true);

                entity.Property(e => e.TaxAmount).HasPrecision(15, 2);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Purchasereturns)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturn_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Purchasereturns)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturn_BusinessUnits");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Purchasereturns)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturn_Stores");

                entity.HasOne(d => d.SupplierAcc)
                    .WithMany(p => p.Purchasereturns)
                    .HasForeignKey(d => d.SupplierAccId)
                    .HasConstraintName("FK_PurchaseReturn_Accounts");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.Purchasereturns)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_PurchaseReturn_Voucher");
            });

            modelBuilder.Entity<Purchasereturndetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PurchaseRate).HasPrecision(15, 2);

                entity.Property(e => e.PurchaseRateAfterTax).HasPrecision(15, 2);

                entity.Property(e => e.PurchaseRateBeforeTax).HasPrecision(15, 2);

                entity.Property(e => e.ReturnAmount).HasPrecision(15, 2);

                entity.Property(e => e.ReturnQty).HasPrecision(15, 3);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Purchasereturndetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetail_Items");

                entity.HasOne(d => d.MaterialReceiptDetail)
                    .WithMany(p => p.Purchasereturndetails)
                    .HasForeignKey(d => d.MaterialReceiptDetailId)
                    .HasConstraintName("FK_PurchaseReturnDetail_MaterialReceiptDetail");

                entity.HasOne(d => d.PurchaseInvoiceDetail)
                    .WithMany(p => p.Purchasereturndetails)
                    .HasForeignKey(d => d.PurchaseInvoiceDetailId)
                    .HasConstraintName("FK_PurchaseReturnDetail_PurchaseInvoiceDetail");

                entity.HasOne(d => d.PurchaseReturn)
                    .WithMany(p => p.Purchasereturndetails)
                    .HasForeignKey(d => d.PurchaseReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetail_PurchaseReturn");

                entity.HasOne(d => d.TaxScheme)
                    .WithMany(p => p.Purchasereturndetails)
                    .HasForeignKey(d => d.TaxSchemeId)
                    .HasConstraintName("FK_PurchaseReturnDetail_Tax");
            });

            modelBuilder.Entity<Purchasereturntaxdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TaxAmount).HasPrecision(15, 2);

                entity.HasOne(d => d.PurchaseReturnDetail)
                    .WithMany(p => p.Purchasereturntaxdetails)
                    .HasForeignKey(d => d.PurchaseReturnDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnTaxDetail_PurchaseReturnDetail");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.Purchasereturntaxdetails)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnTaxDetail_Tax");
            });

            modelBuilder.Entity<Qpapertask>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AnsSheet).HasDefaultValueSql("'0'");

                entity.Property(e => e.QuePaper).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Qpapertasks)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_QPaperTask_Class");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Qpapertasks)
                    .HasForeignKey(d => d.ExamId)
                    .HasConstraintName("FK_QPaperTask_Exam");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Qpapertasks)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_QPaperTask_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Qpapertasks)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_QPaperTask_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Qpapertasks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_QPaperTask_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Qpapertasks)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_QPaperTask_BusinessUnits");
            });

            modelBuilder.Entity<Receiptseries>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Receiptseries)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptSeries_BusinessUnits");
            });

            modelBuilder.Entity<Receiptseriesclass>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Receiptseriesclasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptSeriesClass_Class");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.Receiptseriesclasses)
                    .HasForeignKey(d => d.SeriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptSeriesClass_ReceiptSeries");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Reportlist>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ResultClasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_Class");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_Exam");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK_Results_GradeDtl");

                entity.HasOne(d => d.ProClass)
                    .WithMany(p => p.ResultProClasses)
                    .HasForeignKey(d => d.ProClassId)
                    .HasConstraintName("FK_Results_Class1");

                entity.HasOne(d => d.ProSection)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.ProSectionId)
                    .HasConstraintName("FK_Results_Section");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_BusinessUnits");
            });

            modelBuilder.Entity<Resultcalpolicy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Resultcalpolicies)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResultCalPolicy_Class");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Resultcalpolicies)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResultCalPolicy_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Resultcalpolicies)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResultCalPolicy_BusinessUnits");
            });

            modelBuilder.Entity<Resultsdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttendanceStatus).IsFixedLength(true);

                entity.Property(e => e.GradeUpgrade).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Results)
                    .WithMany(p => p.Resultsdetails)
                    .HasForeignKey(d => d.ResultsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResultsDetails_Results");

                entity.HasOne(d => d.SubjectGrade)
                    .WithMany(p => p.ResultsdetailSubjectGrades)
                    .HasForeignKey(d => d.SubjectGradeId)
                    .HasConstraintName("FK_ResultsDetails_GradeDtl");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Resultsdetails)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResultsDetails_Subject");

                entity.HasOne(d => d.Type1Grade)
                    .WithMany(p => p.ResultsdetailType1Grades)
                    .HasForeignKey(d => d.Type1GradeId)
                    .HasConstraintName("FK_ResultsDetails_GradeDtl1");

                entity.HasOne(d => d.Type2Grade)
                    .WithMany(p => p.ResultsdetailType2Grades)
                    .HasForeignKey(d => d.Type2GradeId)
                    .HasConstraintName("FK_ResultsDetails_GradeDtl2");

                entity.HasOne(d => d.Type3Grade)
                    .WithMany(p => p.ResultsdetailType3Grades)
                    .HasForeignKey(d => d.Type3GradeId)
                    .HasConstraintName("FK_ResultsDetails_GradeDtl3");

                entity.HasOne(d => d.Type4Grade)
                    .WithMany(p => p.ResultsdetailType4Grades)
                    .HasForeignKey(d => d.Type4GradeId)
                    .HasConstraintName("FK_ResultsDetails_GradeDtl4");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.FloorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rooms_Masters");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rooms_BusinessUnits");
            });

            modelBuilder.Entity<Salaryhead>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PrintSeq).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Salaryheads)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_SalaryHeads_Accounts");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Salaryheads)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_SalaryHeads_BusinessUnits");
            });

            modelBuilder.Entity<Scholar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Disability).HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailAlerts).HasDefaultValueSql("'1'");

                entity.Property(e => e.Hostler).HasDefaultValueSql("'0'");

                entity.Property(e => e.IsMaritalStatus).HasDefaultValueSql("'0'");

                entity.Property(e => e.IsSpectacles).HasDefaultValueSql("'0'");

                entity.Property(e => e.OnlyGirlChild).HasDefaultValueSql("'0'");

                entity.Property(e => e.SendFeeReminder).HasDefaultValueSql("'1'");

                entity.Property(e => e.SiblingsInSchool).HasDefaultValueSql("'0'");

                entity.Property(e => e.SmsAlerts).HasDefaultValueSql("'1'");

                entity.Property(e => e.StaffWard).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.AdmissionClass)
                    .WithMany(p => p.Scholars)
                    .HasForeignKey(d => d.AdmissionClassId)
                    .HasConstraintName("FK_Scholar_Class");

                entity.HasOne(d => d.BloodGroup)
                    .WithMany(p => p.ScholarBloodGroups)
                    .HasForeignKey(d => d.BloodGroupId)
                    .HasConstraintName("FK_Scholar_Masters");

                entity.HasOne(d => d.DisabilityNavigation)
                    .WithMany(p => p.ScholarDisabilityNavigations)
                    .HasForeignKey(d => d.DisabilityId)
                    .HasConstraintName("FK_Scholar_Masters18");

                entity.HasOne(d => d.EnrolStatus)
                    .WithMany(p => p.ScholarEnrolStatuses)
                    .HasForeignKey(d => d.EnrolStatusId)
                    .HasConstraintName("FK_Scholar_Masters19");

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.Scholars)
                    .HasForeignKey(d => d.FamilyId)
                    .HasConstraintName("FK_Scholar_Family");

                entity.HasOne(d => d.Medium)
                    .WithMany(p => p.ScholarMedia)
                    .HasForeignKey(d => d.MediumId)
                    .HasConstraintName("FK_Scholar_Masters6");

                entity.HasOne(d => d.PresentArea)
                    .WithMany(p => p.ScholarPresentAreas)
                    .HasForeignKey(d => d.PresentAreaId)
                    .HasConstraintName("FK_Scholar_Masters13");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Scholars)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Scholar_BusinessUnits");
            });

            modelBuilder.Entity<Scholaractivity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Scholaractivities)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarActivity_Masters");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholaractivities)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarActivity_Scholar");

                entity.HasOne(d => d.Sess)
                    .WithMany(p => p.Scholaractivities)
                    .HasForeignKey(d => d.SessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarActivity_Session");
            });

            modelBuilder.Entity<Scholaractivityachievement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.EventLevel)
                    .WithMany(p => p.Scholaractivityachievements)
                    .HasForeignKey(d => d.EventLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarActivityAchievement_Masters");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholaractivityachievements)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarActivityAchievement_Scholar");
            });

            modelBuilder.Entity<Scholarattendance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Period).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholarattendances)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarAttendance_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Scholarattendances)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarAttendance_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Scholarattendances)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_ScholarAttendance_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Scholarattendances)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarAttendance_BusinessUnits");
            });

            modelBuilder.Entity<Scholardiscipline>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Scholardisciplines)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDiscipline_Masters");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholardisciplines)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDiscipline_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Scholardisciplines)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDiscipline_Session");
            });

            modelBuilder.Entity<Scholardocument>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Docs)
                    .WithMany(p => p.Scholardocuments)
                    .HasForeignKey(d => d.DocsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDocuments_Masters");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholardocuments)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDocuments_Scholar");
            });

            modelBuilder.Entity<Scholardtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FeeApplicable).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.ScholardtlCampuses)
                    .HasForeignKey(d => d.CampusId)
                    .HasConstraintName("FK_ScholarDtl_Masters");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Scholardtls)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDtl_Class");

                entity.HasOne(d => d.DropBusStop)
                    .WithMany(p => p.ScholardtlDropBusStops)
                    .HasForeignKey(d => d.DropBusStopId)
                    .HasConstraintName("FK_ScholarDtl_BusStop1");

                entity.HasOne(d => d.DropRoute)
                    .WithMany(p => p.ScholardtlDropRoutes)
                    .HasForeignKey(d => d.DropRouteId)
                    .HasConstraintName("FK_ScholarDtl_Masters2");

                entity.HasOne(d => d.DropShift)
                    .WithMany(p => p.ScholardtlDropShifts)
                    .HasForeignKey(d => d.DropShiftId)
                    .HasConstraintName("FK_ScholarDtl_Masters4");

                entity.HasOne(d => d.FeeGroup)
                    .WithMany(p => p.ScholardtlFeeGroups)
                    .HasForeignKey(d => d.FeeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDtl_Masters5");

                entity.HasOne(d => d.FeePaidMonth)
                    .WithMany(p => p.Scholardtls)
                    .HasForeignKey(d => d.FeePaidMonthId)
                    .HasConstraintName("FK_ScholarDtl_SessionDtl");

                entity.HasOne(d => d.House)
                    .WithMany(p => p.ScholardtlHouses)
                    .HasForeignKey(d => d.HouseId)
                    .HasConstraintName("FK_ScholarDtl_Masters7");

                entity.HasOne(d => d.PickupBusStop)
                    .WithMany(p => p.ScholardtlPickupBusStops)
                    .HasForeignKey(d => d.PickupBusStopId)
                    .HasConstraintName("FK_ScholarDtl_BusStop");

                entity.HasOne(d => d.PickupRoute)
                    .WithMany(p => p.ScholardtlPickupRoutes)
                    .HasForeignKey(d => d.PickupRouteId)
                    .HasConstraintName("FK_ScholarDtl_Masters1");

                entity.HasOne(d => d.PickupShift)
                    .WithMany(p => p.ScholardtlPickupShifts)
                    .HasForeignKey(d => d.PickupShiftId)
                    .HasConstraintName("FK_ScholarDtl_Masters3");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholardtls)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDtl_Scholar");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Scholardtls)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDtl_Section");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Scholardtls)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_ScholarDtl_Semester");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Scholardtls)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarDtl_Session");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.ScholardtlShifts)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK_ScholarDtl_Masters8");

                entity.HasOne(d => d.SubjectGroup)
                    .WithMany(p => p.ScholardtlSubjectGroups)
                    .HasForeignKey(d => d.SubjectGroupId)
                    .HasConstraintName("FK_ScholarDtl_Masters6");
            });

            modelBuilder.Entity<Scholarfee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.Scholarfees)
                    .HasForeignKey(d => d.FeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarFee_FeeHeads");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholarfees)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarFee_Scholar");

                entity.HasOne(d => d.Sess)
                    .WithMany(p => p.Scholarfees)
                    .HasForeignKey(d => d.SessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarFee_Session");
            });

            modelBuilder.Entity<Scholarfeedtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.Scholarfeedtls)
                    .HasForeignKey(d => d.InstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarFeeDtl_SessionDtl");

                entity.HasOne(d => d.ScholarFee)
                    .WithMany(p => p.Scholarfeedtls)
                    .HasForeignKey(d => d.ScholarFeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarFeeDtl_ScholarFee");
            });

            modelBuilder.Entity<Scholarhistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Scholarhistories)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_ScholarHistory_Class");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholarhistories)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarHistory_Scholar");

                entity.HasOne(d => d.Sess)
                    .WithMany(p => p.Scholarhistories)
                    .HasForeignKey(d => d.SessId)
                    .HasConstraintName("FK_ScholarHistory_Session");
            });

            modelBuilder.Entity<Scholarhosteldtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Hostel)
                    .WithMany(p => p.Scholarhosteldtls)
                    .HasForeignKey(d => d.HostelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarHostelDtl_Masters");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholarhosteldtls)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarHostelDtl_Scholar");
            });

            modelBuilder.Entity<Scholarleaveapp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholarleaveapps)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarLeaveApps_Scholar");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Scholarleaveapps)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarLeaveApps_BusinessUnits");
            });

            modelBuilder.Entity<Scholaroptfee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.Scholaroptfees)
                    .HasForeignKey(d => d.FeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarOptFee_FeeHeads");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholaroptfees)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarOptFee_Scholar");

                entity.HasOne(d => d.Sess)
                    .WithMany(p => p.Scholaroptfees)
                    .HasForeignKey(d => d.SessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarOptFee_Session");
            });

            modelBuilder.Entity<Scholaroptfeedtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.Scholaroptfeedtls)
                    .HasForeignKey(d => d.InstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarOptFeeDtl_SessionDtl");

                entity.HasOne(d => d.ScholarOptFee)
                    .WithMany(p => p.Scholaroptfeedtls)
                    .HasForeignKey(d => d.ScholarOptFeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarOptFeeDtl_ScholarOptFee");
            });

            modelBuilder.Entity<Scholarpreviousdue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeHead)
                    .WithMany(p => p.Scholarpreviousdues)
                    .HasForeignKey(d => d.FeeHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarPreviousDues_FeeHeads");

                entity.HasOne(d => d.Installment)
                    .WithMany(p => p.Scholarpreviousdues)
                    .HasForeignKey(d => d.InstallmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarPreviousDues_SessionDtl");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholarpreviousdues)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarPreviousDues_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Scholarpreviousdues)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarPreviousDues_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Scholarpreviousdues)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarPreviousDues_BusinessUnits");
            });

            modelBuilder.Entity<Scholarship>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.PrevCourse)
                    .WithMany(p => p.Scholarships)
                    .HasForeignKey(d => d.PrevCourseId)
                    .HasConstraintName("FK_ScholarShip_Class");

                entity.HasOne(d => d.PrevSession)
                    .WithMany(p => p.ScholarshipPrevSessions)
                    .HasForeignKey(d => d.PrevSessionId)
                    .HasConstraintName("FK_ScholarShip_Session1");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholarships)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarShip_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.ScholarshipSessions)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarShip_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Scholarships)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarShip_BusinessUnits");
            });

            modelBuilder.Entity<Scholarshippolicy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Scholarshippolicies)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarShipPolicy_Masters");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Scholarshippolicies)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarShipPolicy_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Scholarshippolicies)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarShipPolicy_BusinessUnits");
            });

            modelBuilder.Entity<Scholarsubject>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Scholarsubjects)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarSubject_Class");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Scholarsubjects)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarSubject_Scholar");

                entity.HasOne(d => d.Sess)
                    .WithMany(p => p.Scholarsubjects)
                    .HasForeignKey(d => d.SessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarSubject_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Scholarsubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScholarSubject_Subject");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.SectionsNavigation)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Section_Class");

                entity.HasOne(d => d.Msection)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.MsectionId)
                    .HasConstraintName("FK_Section_Masters");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Semesters)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Semester_Semester");

                entity.HasOne(d => d.SemesterNavigation)
                    .WithMany(p => p.Semesters)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Semester_Masters");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sessiondtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Sess)
                    .WithMany(p => p.Sessiondtls)
                    .HasForeignKey(d => d.SessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SessionDtl_Session");
            });

            modelBuilder.Entity<Smscontact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Smscontacts)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSContacts_Masters");
            });

            modelBuilder.Entity<Smssent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Smsuserinfo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Stockattribute>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

                entity.Property(e => e.Mrp).HasPrecision(15, 2);

                entity.Property(e => e.PurchaseRate).HasPrecision(15, 2);

                entity.Property(e => e.SaleRate).HasPrecision(15, 2);

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Stockattributes)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockAttribute_BusinessUnits");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Stockattributes)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockAttribute_Items");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.Stockattributes)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FK_StockAttribute_Tax");
            });

            modelBuilder.Entity<Stockdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.QtyIn).HasPrecision(18, 3);

                entity.Property(e => e.QtyOut).HasPrecision(18, 3);

                entity.Property(e => e.StockPostingType).IsFixedLength(true);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Stockdetails)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockDetails_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Stockdetails)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockDetails_BusinessUnits");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Stockdetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockDetails_Items");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Stockdetails)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockDetails_Stores");
            });

            modelBuilder.Entity<Stockreceive>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Stockreceives)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockReceive_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Stockreceives)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockReceive_BusinessUnits");

                entity.HasOne(d => d.FromStore)
                    .WithMany(p => p.StockreceiveFromStores)
                    .HasForeignKey(d => d.FromStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockReceive_Stores");

                entity.HasOne(d => d.ToStore)
                    .WithMany(p => p.StockreceiveToStores)
                    .HasForeignKey(d => d.ToStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockReceive_Stores1");
            });

            modelBuilder.Entity<Stockreceivedetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Stockreceivedetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockReceiveDetail_Items");

                entity.HasOne(d => d.StockReceive)
                    .WithMany(p => p.Stockreceivedetails)
                    .HasForeignKey(d => d.StockReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockReceiveDetail_StockReceive");

                entity.HasOne(d => d.StockTransferDetail)
                    .WithMany(p => p.Stockreceivedetails)
                    .HasForeignKey(d => d.StockTransferDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockReceiveDetail_StockTransferDetail");
            });

            modelBuilder.Entity<Stocktransfer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Stocktransfers)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransfer_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Stocktransfers)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransfer_BusinessUnits");

                entity.HasOne(d => d.FromStore)
                    .WithMany(p => p.StocktransferFromStores)
                    .HasForeignKey(d => d.FromStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransfer_Stores");

                entity.HasOne(d => d.ToStore)
                    .WithMany(p => p.StocktransferToStores)
                    .HasForeignKey(d => d.ToStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransfer_Stores1");
            });

            modelBuilder.Entity<Stocktransferdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Quantity).HasPrecision(15, 3);

                entity.Property(e => e.ReceivedQty).HasPrecision(15, 3);

                entity.Property(e => e.RejectedQty).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Stocktransferdetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransferDetail_Items");

                entity.HasOne(d => d.StockTransfer)
                    .WithMany(p => p.Stocktransferdetails)
                    .HasForeignKey(d => d.StockTransferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransferDetail_StockTransfer");

                entity.HasOne(d => d.StockTransferRequestDetail)
                    .WithMany(p => p.Stocktransferdetails)
                    .HasForeignKey(d => d.StockTransferRequestDetailId)
                    .HasConstraintName("FK_StockTransferDetail_StockTransferRequestDetail");
            });

            modelBuilder.Entity<Stocktransferrequest>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Stocktransferrequests)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransferRequest_Users");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Stocktransferrequests)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransferRequest_BusinessUnits");

                entity.HasOne(d => d.FromStore)
                    .WithMany(p => p.StocktransferrequestFromStores)
                    .HasForeignKey(d => d.FromStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransferRequest_Stores");

                entity.HasOne(d => d.ToStore)
                    .WithMany(p => p.StocktransferrequestToStores)
                    .HasForeignKey(d => d.ToStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransferRequest_Stores1");
            });

            modelBuilder.Entity<Stocktransferrequestdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IssuedQty).HasPrecision(15, 3);

                entity.Property(e => e.RejectedQty).HasPrecision(15, 3);

                entity.Property(e => e.RequestedQty).HasPrecision(15, 3);

                entity.Property(e => e.RowVersion).IsFixedLength(true);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Stocktransferrequestdetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransferRequestDetail_Items");

                entity.HasOne(d => d.StockTransferRequest)
                    .WithMany(p => p.Stocktransferrequestdetails)
                    .HasForeignKey(d => d.StockTransferRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTransferRequestDetail_StockTransferRequest");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stores_BusinessUnits");

                entity.HasOne(d => d.YearEndByNavigation)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.YearEndBy)
                    .HasConstraintName("FK_Stores_Users");
            });

            modelBuilder.Entity<Storestoremapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.StoreId1Navigation)
                    .WithMany(p => p.StorestoremappingStoreId1Navigations)
                    .HasForeignKey(d => d.StoreId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreStoreMapping_Stores");

                entity.HasOne(d => d.StoreId2Navigation)
                    .WithMany(p => p.StorestoremappingStoreId2Navigations)
                    .HasForeignKey(d => d.StoreId2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreStoreMapping_Stores1");
            });

            modelBuilder.Entity<Subdepartmentstoresmapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Stores)
                    .WithMany(p => p.Subdepartmentstoresmappings)
                    .HasForeignKey(d => d.StoresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubDepartmentStoresMapping_Stores");

                entity.HasOne(d => d.SubDepartment)
                    .WithMany(p => p.Subdepartmentstoresmappings)
                    .HasForeignKey(d => d.SubDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubDepartmentStoresMapping_Masters");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Subject_Masters");
            });

            modelBuilder.Entity<Taskquerydtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.Taskquerydtls)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskQueryDtl_TaskScheduler");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Taskquerydtls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskQueryDtl_Users");
            });

            modelBuilder.Entity<Taskscheduler>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AssignedBy)
                    .WithMany(p => p.TaskschedulerAssignedBies)
                    .HasForeignKey(d => d.AssignedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskSchedular_Users");

                entity.HasOne(d => d.AssignedTo)
                    .WithMany(p => p.TaskschedulerAssignedTos)
                    .HasForeignKey(d => d.AssignedToId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskSchedular_Users1");

                entity.HasOne(d => d.Inward)
                    .WithMany(p => p.Taskschedulers)
                    .HasForeignKey(d => d.InwardId)
                    .HasConstraintName("FK_TaskScheduler_Inward");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TaxPercentage)
                    .HasPrecision(15, 2)
                    .HasDefaultValueSql("'0.00'");

                entity.HasOne(d => d.TaxType)
                    .WithMany(p => p.Taxes)
                    .HasForeignKey(d => d.TaxTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_Masters");
            });

            modelBuilder.Entity<TblAllotment>(entity =>
            {
                entity.HasKey(e => e.AllotmentId)
                    .HasName("PRIMARY");

                entity.Property(e => e.AllotmentId).ValueGeneratedNever();

                entity.Property(e => e.Sequence).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.BifurcationDetails)
                    .WithMany(p => p.TblAllotments)
                    .HasForeignKey(d => d.BifurcationDetailsId)
                    .HasConstraintName("FK_tbl_allotment_tbl_lab_bifurcation_details");

                entity.HasOne(d => d.CombinedDetail)
                    .WithMany(p => p.TblAllotments)
                    .HasForeignKey(d => d.CombinedDetailId)
                    .HasConstraintName("FK_tbl_allotment_tbl_combined_teacher_class_details");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.TblAllotments)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_tbl_allotment_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.TblAllotments)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_tbl_allotment_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblAllotments)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_tbl_allotment_Subject");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblAllotments)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_allotment_BusinessUnits");
            });

            modelBuilder.Entity<TblCombinedTeacherClassDetail>(entity =>
            {
                entity.HasKey(e => e.CombinedDetailsId)
                    .HasName("PRIMARY");

                entity.Property(e => e.CombinedDetailsId).ValueGeneratedNever();

                entity.HasOne(d => d.CombinedMaster)
                    .WithMany(p => p.TblCombinedTeacherClassDetails)
                    .HasForeignKey(d => d.CombinedMasterId)
                    .HasConstraintName("FK_tbl_combined_teacher_class_details_tbl_combined_teacher_cla2");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.TblCombinedTeacherClassDetails)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_tbl_combined_teacher_class_details_Section");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblCombinedTeacherClassDetails)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_tbl_combined_teacher_class_details_Subject");
            });

            modelBuilder.Entity<TblCombinedTeacherClassMaster>(entity =>
            {
                entity.HasKey(e => e.CombinedMasterId)
                    .HasName("PRIMARY");

                entity.Property(e => e.CombinedMasterId).ValueGeneratedNever();

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.TblCombinedTeacherClassMasters)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_tbl_combined_teacher_class_master_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblCombinedTeacherClassMasters)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_combined_teacher_class_master_BusinessUnits");
            });

            modelBuilder.Entity<TblLabBifurcationDetail>(entity =>
            {
                entity.HasKey(e => e.BifurcationDetailsId)
                    .HasName("PRIMARY");

                entity.Property(e => e.BifurcationDetailsId).ValueGeneratedNever();

                entity.HasOne(d => d.BifurcationMaster)
                    .WithMany(p => p.TblLabBifurcationDetails)
                    .HasForeignKey(d => d.BifurcationMasterId)
                    .HasConstraintName("FK_tbl_lab_bifurcation_details_tbl_lab_bifurcation_master");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblLabBifurcationDetails)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_tbl_lab_bifurcation_details_Subject");
            });

            modelBuilder.Entity<TblLabBifurcationMaster>(entity =>
            {
                entity.HasKey(e => e.BifurcationMasterId)
                    .HasName("PRIMARY");

                entity.Property(e => e.BifurcationMasterId).ValueGeneratedNever();

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.TblLabBifurcationMasters)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_tbl_lab_bifurcation_master_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.TblLabBifurcationMasters)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_tbl_lab_bifurcation_master_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblLabBifurcationMasters)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_lab_bifurcation_master_BusinessUnits");
            });

            modelBuilder.Entity<TblTimetable>(entity =>
            {
                entity.HasKey(e => e.TimetableId)
                    .HasName("PRIMARY");

                entity.Property(e => e.TimetableId).ValueGeneratedNever();

                entity.HasOne(d => d.Allotment)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.AllotmentId)
                    .HasConstraintName("FK_tbl_timetable_tbl_allotment");

                entity.HasOne(d => d.BifurcationMaster)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.BifurcationMasterId)
                    .HasConstraintName("FK_tbl_timetable_tbl_lab_bifurcation_master");

                entity.HasOne(d => d.CombinedMaster)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.CombinedMasterId)
                    .HasConstraintName("FK_tbl_timetable_tbl_combined_teacher_class_master");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("FK_tbl_timetable_Masters");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_tbl_timetable_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_tbl_timetable_Session");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_tbl_timetable_Subject");

                entity.HasOne(d => d.Timetablemaster)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.TimetablemasterId)
                    .HasConstraintName("FK_tbl_timetable_tbl_timetable_master");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblTimetables)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_timetable_BusinessUnits");
            });

            modelBuilder.Entity<TblTimetableMaster>(entity =>
            {
                entity.HasKey(e => e.TimetablemasterId)
                    .HasName("PRIMARY");

                entity.Property(e => e.TimetablemasterId).ValueGeneratedNever();

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.TblTimetableMasters)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_tbl_timetable_master_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblTimetableMasters)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_timetable_master_BusinessUnits");
            });

            modelBuilder.Entity<Tblfavoritemenu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.LngMenu)
                    .WithMany(p => p.Tblfavoritemenus)
                    .HasForeignKey(d => d.LngMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFavoriteMenu_Menus");

                entity.HasOne(d => d.LngRole)
                    .WithMany(p => p.Tblfavoritemenus)
                    .HasForeignKey(d => d.LngRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFavoriteMenu_Role");

                entity.HasOne(d => d.LngUnit)
                    .WithMany(p => p.Tblfavoritemenus)
                    .HasForeignKey(d => d.LngUnitId)
                    .HasConstraintName("FK_tblFavoriteMenu_BusinessUnits");

                entity.HasOne(d => d.LngUser)
                    .WithMany(p => p.Tblfavoritemenus)
                    .HasForeignKey(d => d.LngUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFavoriteMenu_Users");
            });

            modelBuilder.Entity<Tbllog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Success).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Tblmasteritem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Buffer).HasPrecision(18, 4);

                entity.Property(e => e.LeadTime).HasPrecision(18, 2);

                entity.Property(e => e.Reprocurement).HasPrecision(18, 2);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.TblmasteritemAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .HasConstraintName("FK_tblMasterItem_Users");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.TblmasteritemItemCategories)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .HasConstraintName("FK_tblMasterItem_Masters");

                entity.HasOne(d => d.LastUpByNavigation)
                    .WithMany(p => p.TblmasteritemLastUpByNavigations)
                    .HasForeignKey(d => d.LastUpBy)
                    .HasConstraintName("FK_tblMasterItem_Users1");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Tblmasteritems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMasterItem_BusinessUnits");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.TblmasteritemUoms)
                    .HasForeignKey(d => d.Uomid)
                    .HasConstraintName("FK_tblMasterItem_Masters1");
            });

            modelBuilder.Entity<Tblmasteritembatchwise>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.Property(e => e.BlnDeleted).HasDefaultValueSql("'0'");

                entity.Property(e => e.DecAcceptedQty).HasPrecision(18, 4);

                entity.Property(e => e.DecAvailableQty).HasPrecision(18, 4);

                entity.HasOne(d => d.LngDeletedByNavigation)
                    .WithMany(p => p.Tblmasteritembatchwises)
                    .HasForeignKey(d => d.LngDeletedBy)
                    .HasConstraintName("FK_tblMasterItemBatchWise_Users");

                entity.HasOne(d => d.LngItem)
                    .WithMany(p => p.Tblmasteritembatchwises)
                    .HasForeignKey(d => d.LngItemId)
                    .HasConstraintName("FK_tblMasterItemBatchWise_tblMasterItem");
            });

            modelBuilder.Entity<Tblmaterialreceipt>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.HasOne(d => d.LastUpdatedByNavigation)
                    .WithMany(p => p.TblmaterialreceiptLastUpdatedByNavigations)
                    .HasForeignKey(d => d.LastUpdatedBy)
                    .HasConstraintName("FK_tblMaterialReceipt_Users1");

                entity.HasOne(d => d.LngCreatedByNavigation)
                    .WithMany(p => p.TblmaterialreceiptLngCreatedByNavigations)
                    .HasForeignKey(d => d.LngCreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMaterialReceipt_Users");

                entity.HasOne(d => d.LngDepartment)
                    .WithMany(p => p.Tblmaterialreceipts)
                    .HasForeignKey(d => d.LngDepartmentId)
                    .HasConstraintName("FK_tblMaterialReceipt_Masters1");

                entity.HasOne(d => d.LngSupplier)
                    .WithMany(p => p.Tblmaterialreceipts)
                    .HasForeignKey(d => d.LngSupplierId)
                    .HasConstraintName("FK_tblMaterialReceipt_Accounts");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Tblmaterialreceipts)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMaterialReceipt_BusinessUnits");
            });

            modelBuilder.Entity<Tblmaterialreceiptdetail>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.Property(e => e.BlnDeleted).HasDefaultValueSql("'0'");

                entity.Property(e => e.LngAcceptedQty).HasPrecision(18, 4);

                entity.Property(e => e.LngReceivedQty).HasPrecision(18, 4);

                entity.Property(e => e.LngRejectedQty).HasPrecision(18, 4);

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.Tblmaterialreceiptdetails)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("FK_tblMaterialReceiptDetail_Users1");

                entity.HasOne(d => d.LngBatchItem)
                    .WithMany(p => p.Tblmaterialreceiptdetails)
                    .HasForeignKey(d => d.LngBatchItemId)
                    .HasConstraintName("FK_tblMaterialReceiptDetail_tblMasterItemBatchWise");

                entity.HasOne(d => d.LngItem)
                    .WithMany(p => p.Tblmaterialreceiptdetails)
                    .HasForeignKey(d => d.LngItemId)
                    .HasConstraintName("FK_tblMaterialReceiptDetail_tblMasterItem1");

                entity.HasOne(d => d.LngReceipt)
                    .WithMany(p => p.Tblmaterialreceiptdetails)
                    .HasForeignKey(d => d.LngReceiptId)
                    .HasConstraintName("FK_tblMaterialReceiptDetail_tblMaterialReceipt");
            });

            modelBuilder.Entity<Tblmaterialrequisition>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.HasOne(d => d.LngApprovedByNavigation)
                    .WithMany(p => p.TblmaterialrequisitionLngApprovedByNavigations)
                    .HasForeignKey(d => d.LngApprovedBy)
                    .HasConstraintName("FK_tblMaterialRequisition_Users1");

                entity.HasOne(d => d.LngCreatedByNavigation)
                    .WithMany(p => p.TblmaterialrequisitionLngCreatedByNavigations)
                    .HasForeignKey(d => d.LngCreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMaterialRequisition_Users");

                entity.HasOne(d => d.LngDepartment)
                    .WithMany(p => p.Tblmaterialrequisitions)
                    .HasForeignKey(d => d.LngDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMaterialRequisition_Masters");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Tblmaterialrequisitions)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMaterialRequisition_BusinessUnits");
            });

            modelBuilder.Entity<Tblmaterialrequisitiondetail>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasDefaultValueSql("'0'");

                entity.Property(e => e.Qty).HasPrecision(18, 4);

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.Tblmaterialrequisitiondetails)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("FK_tblMaterialRequisitionDetail_Users");

                entity.HasOne(d => d.LngBatchItem)
                    .WithMany(p => p.Tblmaterialrequisitiondetails)
                    .HasForeignKey(d => d.LngBatchItemId)
                    .HasConstraintName("FK_tblMaterialRequisitionDetail_tblMasterItemBatchWise");

                entity.HasOne(d => d.LngItem)
                    .WithMany(p => p.Tblmaterialrequisitiondetails)
                    .HasForeignKey(d => d.LngItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMaterialRequisitionDetail_tblMasterItem");

                entity.HasOne(d => d.LngRequisition)
                    .WithMany(p => p.Tblmaterialrequisitiondetails)
                    .HasForeignKey(d => d.LngRequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMaterialRequisitionDetail_tblMaterialRequisition");
            });

            modelBuilder.Entity<Tblsetupchangelog>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.HasOne(d => d.LngUpdatedByNavigation)
                    .WithMany(p => p.Tblsetupchangelogs)
                    .HasForeignKey(d => d.LngUpdatedBy)
                    .HasConstraintName("FK_tblSetupChangeLog_Users");
            });

            modelBuilder.Entity<Tbltransaction>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.Tbltransactions)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_tblTransaction_Users");

                entity.HasOne(d => d.LngDocument)
                    .WithMany(p => p.Tbltransactions)
                    .HasForeignKey(d => d.LngDocumentId)
                    .HasConstraintName("FK_tblTransaction_tblMaterialRequisition");

                entity.HasOne(d => d.LngItem)
                    .WithMany(p => p.Tbltransactions)
                    .HasForeignKey(d => d.LngItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTransaction_tblMasterItem");

                entity.HasOne(d => d.LngReceipt)
                    .WithMany(p => p.Tbltransactions)
                    .HasForeignKey(d => d.LngReceiptId)
                    .HasConstraintName("FK_tblTransaction_tblMaterialReceipt");
            });

            modelBuilder.Entity<Tdsslab>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AssessmentYear)
                    .WithMany(p => p.Tdsslabs)
                    .HasForeignKey(d => d.AssessmentYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TDSSlab_FinancialYear");

                entity.HasOne(d => d.Tdscategory)
                    .WithMany(p => p.Tdsslabs)
                    .HasForeignKey(d => d.TdscategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TDSSlab_Masters");
            });

            modelBuilder.Entity<Teacherdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClassGroup)
                    .WithMany(p => p.Teacherdtls)
                    .HasForeignKey(d => d.ClassGroupId)
                    .HasConstraintName("FK_TeacherDtl_ClassGroup");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Teacherdtls)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherDtl_Session");

                entity.HasOne(d => d.TeacherClass)
                    .WithMany(p => p.Teacherdtls)
                    .HasForeignKey(d => d.TeacherClassId)
                    .HasConstraintName("FK_TeacherDtl_Class");

                entity.HasOne(d => d.TeacherSection)
                    .WithMany(p => p.Teacherdtls)
                    .HasForeignKey(d => d.TeacherSectionId)
                    .HasConstraintName("FK_TeacherDtl_Section");
            });

            modelBuilder.Entity<Temptran>(entity =>
            {
                entity.HasKey(e => e.LngId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LngId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tmpadmissionform>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasDefaultValueSql("'0'");

                entity.Property(e => e.Registration).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TmpadmissionformCities)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tmpAdmissionForm_Masters1");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Tmpadmissionforms)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_tmpAdmissionForm_Class");

                entity.HasOne(d => d.Medium)
                    .WithMany(p => p.TmpadmissionformMedia)
                    .HasForeignKey(d => d.MediumId)
                    .HasConstraintName("FK_tmpAdmissionForm_Masters");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Tmpadmissionforms)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmpAdmissionForm_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Tmpadmissionforms)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tmpAdmissionForm_BusinessUnits");
            });

            modelBuilder.Entity<Tmpfeereceipt>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BankId).HasDefaultValueSql("'0'");

                entity.Property(e => e.CashAmount).HasDefaultValueSql("'0'");

                entity.Property(e => e.ChequeAmount).HasDefaultValueSql("'0'");

                entity.Property(e => e.ChequeBranch).HasDefaultValueSql("'0'");

                entity.Property(e => e.ChequeNo).HasDefaultValueSql("'0'");

                entity.Property(e => e.InstallmentId).HasDefaultValueSql("'0'");

                entity.Property(e => e.ReceiptTotal).HasDefaultValueSql("'0'");

                entity.Property(e => e.ScholarId).HasDefaultValueSql("'0'");

                entity.Property(e => e.Status).HasDefaultValueSql("'0'");

                entity.Property(e => e.Submitted).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.AdmForm)
                    .WithMany(p => p.Tmpfeereceipts)
                    .HasForeignKey(d => d.AdmFormId)
                    .HasConstraintName("FK_tmpFeeReceipt_tmpAdmissionForm");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TmpfeereceiptBanks)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_tmpFeeReceipt_Masters1");

                entity.HasOne(d => d.ForClass)
                    .WithMany(p => p.Tmpfeereceipts)
                    .HasForeignKey(d => d.ForClassId)
                    .HasConstraintName("FK_tmpFeeReceipt_Class");

                entity.HasOne(d => d.ForFeeGroup)
                    .WithMany(p => p.TmpfeereceiptForFeeGroups)
                    .HasForeignKey(d => d.ForFeeGroupId)
                    .HasConstraintName("FK_tmpFeeReceipt_Masters2");

                entity.HasOne(d => d.Installment)
                    .WithMany(p => p.Tmpfeereceipts)
                    .HasForeignKey(d => d.InstallmentId)
                    .HasConstraintName("FK_tmpFeeReceipt_SessionDtl");

                entity.HasOne(d => d.Rseries)
                    .WithMany(p => p.Tmpfeereceipts)
                    .HasForeignKey(d => d.RseriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmpFeeReceipt_ReceiptSeries");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Tmpfeereceipts)
                    .HasForeignKey(d => d.ScholarId)
                    .HasConstraintName("FK_tmpFeeReceipt_Scholar");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Tmpfeereceipts)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmpFeeReceipt_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Tmpfeereceipts)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmpFeeReceipt_BusinessUnits");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tmpfeereceipts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_tmpFeeReceipt_Users");
            });

            modelBuilder.Entity<Tmpfeereceiptdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.FeeHead)
                    .WithMany(p => p.Tmpfeereceiptdtls)
                    .HasForeignKey(d => d.FeeHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmpFeeReceiptDtl_FeeHeads");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.Tmpfeereceiptdtls)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmpFeeReceiptDtl_tmpFeeReceipt");
            });

            modelBuilder.Entity<Updatecolumn>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Answer).HasDefaultValueSql("''");

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

                entity.Property(e => e.UserType).HasDefaultValueSql("'A'");

                entity.HasOne(d => d.DefaultBusinessUnit)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DefaultBusinessUnitId)
                    .HasConstraintName("FK_Users_BusinessUnits");

                entity.HasOne(d => d.DefaultFinYear)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DefaultFinYearId)
                    .HasConstraintName("FK_Users_FinancialYear");

                entity.HasOne(d => d.DefaultRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DefaultRoleId)
                    .HasConstraintName("FK_Users_Role");

                entity.HasOne(d => d.DefaultSession)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DefaultSessionId)
                    .HasConstraintName("FK_Users_Session");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Masters");
            });

            modelBuilder.Entity<Userbusinessunitrole>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.BusinessUnitRoles)
                    .WithMany(p => p.Userbusinessunitroles)
                    .HasForeignKey(d => d.BusinessUnitRolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserBusinessUnitRoles_BusinessUnitRoles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userbusinessunitroles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserBusinessUnitRoles_Users");
            });

            modelBuilder.Entity<Userdashboard>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DashBoard)
                    .WithMany(p => p.Userdashboards)
                    .HasForeignKey(d => d.DashBoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDashBoard_DashboardTemplates");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Userdashboards)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserDashBoard_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userdashboards)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDashBoard_Users");
            });

            modelBuilder.Entity<Userroledashboard>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DashBoard)
                    .WithMany(p => p.Userroledashboards)
                    .HasForeignKey(d => d.DashBoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleDashBoard_DashboardTemplates");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Userroledashboards)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleDashBoard_Role");
            });

            modelBuilder.Entity<Userstoremapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Userstoremappings)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserStoreMapping_Stores");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userstoremappings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserStoreMapping_Users");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FuelType).IsFixedLength(true);

                entity.HasOne(d => d.Conductor)
                    .WithMany(p => p.VehicleConductors)
                    .HasForeignKey(d => d.ConductorId)
                    .HasConstraintName("FK_Vehicle_Driver1");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.VehicleDrivers)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_Vehicle_Driver");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_Vehicle_Masters");
            });

            modelBuilder.Entity<Vehicleaccessory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.VehicleAccessories)
                    .WithMany(p => p.Vehicleaccessories)
                    .HasForeignKey(d => d.VehicleAccessoriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleAccessories_Masters");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Vehicleaccessories)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleAccessories_Vehicle");
            });

            modelBuilder.Entity<Vehiclemaintenance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ExpHead)
                    .WithMany(p => p.Vehiclemaintenances)
                    .HasForeignKey(d => d.ExpHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleMaintenance_Masters");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Vehiclemaintenances)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleMaintenance_Vehicle");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DocumentType).IsFixedLength(true);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Voucher_BusinessUnits");

                entity.HasOne(d => d.FinYear)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.FinYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Voucher_FinancialYear");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.ReceiptId)
                    .HasConstraintName("FK_Voucher_FeeReceipt");
            });

            modelBuilder.Entity<Voucherdtl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Voucherdtls)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoucherDtl_Accounts");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Voucherdtls)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_VoucherDtl_Masters");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.Voucherdtls)
                    .HasForeignKey(d => d.VoucherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoucherDtl_Voucher");
            });

            modelBuilder.Entity<Yearlyattendence>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Yearlyattendences)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YearlyAttendence_Class");

                entity.HasOne(d => d.Scholar)
                    .WithMany(p => p.Yearlyattendences)
                    .HasForeignKey(d => d.ScholarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YearlyAttendence_Scholar");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Yearlyattendences)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_YearlyAttendence_Section");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Yearlyattendences)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YearlyAttendence_Session");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Yearlyattendences)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_YearlyAttendence_BusinessUnits");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
