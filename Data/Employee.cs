using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("employee")]
    [Index(nameof(CompanyId), Name = "FK_Employee_BusinessUnits")]
    [Index(nameof(ShiftId), Name = "FK_Employee_EmployeeShift")]
    [Index(nameof(DepartmentId), Name = "FK_Employee_Masters")]
    [Index(nameof(DesignationId), Name = "FK_Employee_Masters1")]
    [Index(nameof(EmpCategoryId), Name = "FK_Employee_Masters2")]
    [Index(nameof(EmployementStatusId), Name = "FK_Employee_Masters3")]
    [Index(nameof(TdscategoryId), Name = "FK_Employee_Masters4")]
    public partial class Employee
    {
        public Employee()
        {
            Admissionenquiries = new HashSet<Admissionenquiry>();
            Drivers = new HashSet<Driver>();
            Employeeadvances = new HashSet<Employeeadvance>();
            Employeeapplications = new HashSet<Employeeapplication>();
            Employeebonus = new HashSet<Employeebonu>();
            Employeedailyattendances = new HashSet<Employeedailyattendance>();
            Employeedocuments = new HashSet<Employeedocument>();
            Employeeeducationdtls = new HashSet<Employeeeducationdtl>();
            Employeeleaveapps = new HashSet<Employeeleaveapp>();
            Employeeleaves = new HashSet<Employeeleaf>();
            Employeeloans = new HashSet<Employeeloan>();
            Employeemonthlyattendances = new HashSet<Employeemonthlyattendance>();
            Employeesalaries = new HashSet<Employeesalary>();
            Employeesalarystructures = new HashSet<Employeesalarystructure>();
            Lkustorestostaffs = new HashSet<Lkustorestostaff>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        public string Initials { get; set; }
        public int EmployeeNo { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string MiddleName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string FatherName { get; set; }
        [StringLength(50)]
        public string MotherName { get; set; }
        [StringLength(50)]
        public string HusbandName { get; set; }
        [Column("DOJ", TypeName = "date")]
        public DateTime Doj { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(50)]
        public string PresentAddress1 { get; set; }
        [StringLength(50)]
        public string PresentAddress2 { get; set; }
        [StringLength(50)]
        public string PresentAddress3 { get; set; }
        [StringLength(30)]
        public string PresentCity { get; set; }
        [StringLength(25)]
        public string PresentPhone { get; set; }
        [StringLength(50)]
        public string PermanentAddress1 { get; set; }
        [StringLength(50)]
        public string PermanentAddress2 { get; set; }
        [StringLength(50)]
        public string PermanentAddress3 { get; set; }
        [StringLength(30)]
        public string PermanentCity { get; set; }
        [StringLength(25)]
        public string PermanentPhone { get; set; }
        [StringLength(10)]
        public string MobileNo { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public int EmpCategoryId { get; set; }
        public int DesignationId { get; set; }
        public int EmployementStatusId { get; set; }
        [StringLength(50)]
        public string Education { get; set; }
        public double? Experience { get; set; }
        [StringLength(1)]
        public string MaritalStatus { get; set; }
        [Column("DA")]
        public bool? Da { get; set; }
        [Column("DAPer")]
        public double? Daper { get; set; }
        [Column("DAAmt")]
        public double? Daamt { get; set; }
        [Column("HRA")]
        public bool? Hra { get; set; }
        [Column("HRAAmt")]
        public double? Hraamt { get; set; }
        [Column("PFApplicable")]
        public bool? Pfapplicable { get; set; }
        [Column("PFNo")]
        [StringLength(20)]
        public string Pfno { get; set; }
        [Column("PFStartDate", TypeName = "date")]
        public DateTime? PfstartDate { get; set; }
        [Column("PFPer")]
        public double? Pfper { get; set; }
        [Column("PFLimitApplicable")]
        public bool? PflimitApplicable { get; set; }
        [Column("CPFLimitApplicable")]
        public bool? CpflimitApplicable { get; set; }
        [Column("CPFPer")]
        public double? Cpfper { get; set; }
        [Column("ESIApplicable")]
        public bool? Esiapplicable { get; set; }
        [Column("ESINo")]
        [StringLength(10)]
        public string Esino { get; set; }
        [Column("ESIDispensary")]
        [StringLength(50)]
        public string Esidispensary { get; set; }
        public double? Basic { get; set; }
        public int? PrintSeq { get; set; }
        public double? AdvanceLimit { get; set; }
        public double? LoanLimit { get; set; }
        [StringLength(30)]
        public string Grade { get; set; }
        [Column("CTC")]
        public double? Ctc { get; set; }
        [Column("OTApplicable")]
        public bool? Otapplicable { get; set; }
        [Column("OTRatio")]
        public double? Otratio { get; set; }
        [StringLength(10)]
        public string WeekOff { get; set; }
        [StringLength(10)]
        public string PaymentType { get; set; }
        public int? BankId { get; set; }
        [StringLength(20)]
        public string BankAccNo { get; set; }
        [StringLength(1)]
        public string WorkingStatus { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ResignDate { get; set; }
        [StringLength(50)]
        public string ResignReason { get; set; }
        [StringLength(20)]
        public string EmployeeCardNo { get; set; }
        [Column("TDSCategoryId")]
        public int? TdscategoryId { get; set; }
        [Column("PANNo")]
        [StringLength(15)]
        public string Panno { get; set; }
        [StringLength(50)]
        public string Ward { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Anniversary { get; set; }
        public int? ShiftId { get; set; }
        public int CompanyId { get; set; }
        public byte[] Photo { get; set; }
        [StringLength(20)]
        public string AadharNo { get; set; }
        public double? Basic2 { get; set; }
        [StringLength(5)]
        public string EmpType { get; set; }
        [Column("UNNumber")]
        [StringLength(20)]
        public string Unnumber { get; set; }
        public double? GrossEarning { get; set; }
        [Column("IFSCNO")]
        [StringLength(50)]
        public string Ifscno { get; set; }
        public double? TotalDeduction { get; set; }
        public double? NetAmount { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Businessunit.Employees))]
        public virtual Businessunit Company { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Master.EmployeeDepartments))]
        public virtual Master Department { get; set; }
        [ForeignKey(nameof(DesignationId))]
        [InverseProperty(nameof(Master.EmployeeDesignations))]
        public virtual Master Designation { get; set; }
        [ForeignKey(nameof(EmpCategoryId))]
        [InverseProperty(nameof(Master.EmployeeEmpCategories))]
        public virtual Master EmpCategory { get; set; }
        [ForeignKey(nameof(EmployementStatusId))]
        [InverseProperty(nameof(Master.EmployeeEmployementStatuses))]
        public virtual Master EmployementStatus { get; set; }
        [ForeignKey(nameof(ShiftId))]
        [InverseProperty(nameof(Employeeshift.Employees))]
        public virtual Employeeshift Shift { get; set; }
        [ForeignKey(nameof(TdscategoryId))]
        [InverseProperty(nameof(Master.EmployeeTdscategories))]
        public virtual Master Tdscategory { get; set; }
        [InverseProperty(nameof(Admissionenquiry.Counsellor))]
        public virtual ICollection<Admissionenquiry> Admissionenquiries { get; set; }
        [InverseProperty(nameof(Driver.Employee))]
        public virtual ICollection<Driver> Drivers { get; set; }
        [InverseProperty(nameof(Employeeadvance.Employee))]
        public virtual ICollection<Employeeadvance> Employeeadvances { get; set; }
        [InverseProperty(nameof(Employeeapplication.Employee))]
        public virtual ICollection<Employeeapplication> Employeeapplications { get; set; }
        [InverseProperty(nameof(Employeebonu.Employee))]
        public virtual ICollection<Employeebonu> Employeebonus { get; set; }
        [InverseProperty(nameof(Employeedailyattendance.Employee))]
        public virtual ICollection<Employeedailyattendance> Employeedailyattendances { get; set; }
        [InverseProperty(nameof(Employeedocument.Employee))]
        public virtual ICollection<Employeedocument> Employeedocuments { get; set; }
        [InverseProperty(nameof(Employeeeducationdtl.Employee))]
        public virtual ICollection<Employeeeducationdtl> Employeeeducationdtls { get; set; }
        [InverseProperty(nameof(Employeeleaveapp.Employee))]
        public virtual ICollection<Employeeleaveapp> Employeeleaveapps { get; set; }
        [InverseProperty(nameof(Employeeleaf.Employee))]
        public virtual ICollection<Employeeleaf> Employeeleaves { get; set; }
        [InverseProperty(nameof(Employeeloan.Employee))]
        public virtual ICollection<Employeeloan> Employeeloans { get; set; }
        [InverseProperty(nameof(Employeemonthlyattendance.Employee))]
        public virtual ICollection<Employeemonthlyattendance> Employeemonthlyattendances { get; set; }
        [InverseProperty(nameof(Employeesalary.Employee))]
        public virtual ICollection<Employeesalary> Employeesalaries { get; set; }
        [InverseProperty(nameof(Employeesalarystructure.Employee))]
        public virtual ICollection<Employeesalarystructure> Employeesalarystructures { get; set; }
        [InverseProperty(nameof(Lkustorestostaff.Faculty))]
        public virtual ICollection<Lkustorestostaff> Lkustorestostaffs { get; set; }
    }
}
