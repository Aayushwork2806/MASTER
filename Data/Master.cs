using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("masters")]
    public partial class Master
    {
        public Master()
        {
            AccountsdtlCities = new HashSet<Accountsdtl>();
            AccountsdtlStates = new HashSet<Accountsdtl>();
            Admissionenquiries = new HashSet<Admissionenquiry>();
            AdmissionformBloodGroups = new HashSet<Admissionform>();
            AdmissionformCategories = new HashSet<Admissionform>();
            AdmissionformCities = new HashSet<Admissionform>();
            AdmissionformFatherOccupations = new HashSet<Admissionform>();
            AdmissionformMedia = new HashSet<Admissionform>();
            AdmissionformMotherOccupations = new HashSet<Admissionform>();
            AdmissionformReligions = new HashSet<Admissionform>();
            AdmissionformStates = new HashSet<Admissionform>();
            BooktitleBookSeries = new HashSet<Booktitle>();
            BooktitleCategories = new HashSet<Booktitle>();
            BooktitleLocations = new HashSet<Booktitle>();
            BooktitleMedia = new HashSet<Booktitle>();
            Busstops = new HashSet<Busstop>();
            Castes = new HashSet<Caste>();
            Classallotments = new HashSet<Classallotment>();
            Classfees = new HashSet<Classfee>();
            Classsubjectmarksprimaries = new HashSet<Classsubjectmarksprimary>();
            Classsubjectmarksprimarydtls = new HashSet<Classsubjectmarksprimarydtl>();
            Classsubjectprimaries = new HashSet<Classsubjectprimary>();
            Classsubjects = new HashSet<Classsubject>();
            Classsubjmarks = new HashSet<Classsubjmark>();
            Daywiseperiods = new HashSet<Daywiseperiod>();
            Departmentconsumptions = new HashSet<Departmentconsumption>();
            Despatches = new HashSet<Despatch>();
            Docclasses = new HashSet<Docclass>();
            Ebooks = new HashSet<Ebook>();
            EmployeeDepartments = new HashSet<Employee>();
            EmployeeDesignations = new HashSet<Employee>();
            EmployeeEmpCategories = new HashSet<Employee>();
            EmployeeEmployementStatuses = new HashSet<Employee>();
            EmployeeTdscategories = new HashSet<Employee>();
            EmployeeapplicationDesignations = new HashSet<Employeeapplication>();
            EmployeeapplicationQualifications = new HashSet<Employeeapplication>();
            Employeedocuments = new HashSet<Employeedocument>();
            EmployeesalaryBanks = new HashSet<Employeesalary>();
            EmployeesalaryCategories = new HashSet<Employeesalary>();
            FamilyCategories = new HashSet<Family>();
            FamilyMtongues = new HashSet<Family>();
            FamilyNationalities = new HashSet<Family>();
            FamilyPermanentCities = new HashSet<Family>();
            FamilyPermanentStates = new HashSet<Family>();
            FamilyPresentCities = new HashSet<Family>();
            FamilyPresentStates = new HashSet<Family>();
            FamilyReligions = new HashSet<Family>();
            FamilydtlOccupations = new HashSet<Familydtl>();
            FamilydtlQualifications = new HashSet<Familydtl>();
            Feegroupfeeheads = new HashSet<Feegroupfeehead>();
            Feeheads = new HashSet<Feehead>();
            FeereceiptBanks = new HashSet<Feereceipt>();
            FeereceiptForFeeGroups = new HashSet<Feereceipt>();
            Homeworks = new HashSet<Homework>();
            Inwards = new HashSet<Inward>();
            Inwardsubcategories = new HashSet<Inwardsubcategory>();
            ItemDrugCategories = new HashSet<Item>();
            ItemDrugGroups = new HashSet<Item>();
            ItemItemCategories = new HashSet<Item>();
            ItemManufacturers = new HashSet<Item>();
            ItemSubCategories = new HashSet<Item>();
            ItemUom1s = new HashSet<Item>();
            ItemUom2s = new HashSet<Item>();
            MarksclasswiseRemarkId1Navigations = new HashSet<Marksclasswise>();
            MarksclasswiseRemarkId2Navigations = new HashSet<Marksclasswise>();
            MarksclasswiseSubjectGroups = new HashSet<Marksclasswise>();
            MarksclasswiseprimaryRemarkId1Navigations = new HashSet<Marksclasswiseprimary>();
            MarksclasswiseprimaryRemarkId2Navigations = new HashSet<Marksclasswiseprimary>();
            Marksclasswiseprimarydtls = new HashSet<Marksclasswiseprimarydtl>();
            Materialissues = new HashSet<Materialissue>();
            Materialrequisitions = new HashSet<Materialrequisition>();
            Materialreturns = new HashSet<Materialreturn>();
            Parentcommunications = new HashSet<Parentcommunication>();
            Purchaseindents = new HashSet<Purchaseindent>();
            Purchasequotationtaxdetails = new HashSet<Purchasequotationtaxdetail>();
            Rooms = new HashSet<Room>();
            ScholarBloodGroups = new HashSet<Scholar>();
            ScholarDisabilityNavigations = new HashSet<Scholar>();
            ScholarEnrolStatuses = new HashSet<Scholar>();
            ScholarMedia = new HashSet<Scholar>();
            ScholarPresentAreas = new HashSet<Scholar>();
            Scholaractivities = new HashSet<Scholaractivity>();
            Scholaractivityachievements = new HashSet<Scholaractivityachievement>();
            Scholardisciplines = new HashSet<Scholardiscipline>();
            Scholardocuments = new HashSet<Scholardocument>();
            ScholardtlCampuses = new HashSet<Scholardtl>();
            ScholardtlDropRoutes = new HashSet<Scholardtl>();
            ScholardtlDropShifts = new HashSet<Scholardtl>();
            ScholardtlFeeGroups = new HashSet<Scholardtl>();
            ScholardtlHouses = new HashSet<Scholardtl>();
            ScholardtlPickupRoutes = new HashSet<Scholardtl>();
            ScholardtlPickupShifts = new HashSet<Scholardtl>();
            ScholardtlShifts = new HashSet<Scholardtl>();
            ScholardtlSubjectGroups = new HashSet<Scholardtl>();
            Scholarhosteldtls = new HashSet<Scholarhosteldtl>();
            Scholarshippolicies = new HashSet<Scholarshippolicy>();
            Sections = new HashSet<Section>();
            Semesters = new HashSet<Semester>();
            Smscontacts = new HashSet<Smscontact>();
            Subdepartmentstoresmappings = new HashSet<Subdepartmentstoresmapping>();
            Subjects = new HashSet<Subject>();
            Taxes = new HashSet<Tax>();
            TblTimetables = new HashSet<TblTimetable>();
            TblmasteritemItemCategories = new HashSet<Tblmasteritem>();
            TblmasteritemUoms = new HashSet<Tblmasteritem>();
            Tblmaterialreceipts = new HashSet<Tblmaterialreceipt>();
            Tblmaterialrequisitions = new HashSet<Tblmaterialrequisition>();
            Tdsslabs = new HashSet<Tdsslab>();
            TmpadmissionformCities = new HashSet<Tmpadmissionform>();
            TmpadmissionformMedia = new HashSet<Tmpadmissionform>();
            TmpfeereceiptBanks = new HashSet<Tmpfeereceipt>();
            TmpfeereceiptForFeeGroups = new HashSet<Tmpfeereceipt>();
            Users = new HashSet<User>();
            Vehicleaccessories = new HashSet<Vehicleaccessory>();
            Vehiclemaintenances = new HashSet<Vehiclemaintenance>();
            Vehicles = new HashSet<Vehicle>();
            Voucherdtls = new HashSet<Voucherdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int Type { get; set; }
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(320)]
        public string Value { get; set; }
        public bool Deleted { get; set; }
        public bool IsActive { get; set; }
        public int UnitId { get; set; }

        [InverseProperty(nameof(Accountsdtl.City))]
        public virtual ICollection<Accountsdtl> AccountsdtlCities { get; set; }
        [InverseProperty(nameof(Accountsdtl.State))]
        public virtual ICollection<Accountsdtl> AccountsdtlStates { get; set; }
        [InverseProperty(nameof(Admissionenquiry.Medium))]
        public virtual ICollection<Admissionenquiry> Admissionenquiries { get; set; }
        [InverseProperty(nameof(Admissionform.BloodGroup))]
        public virtual ICollection<Admissionform> AdmissionformBloodGroups { get; set; }
        [InverseProperty(nameof(Admissionform.Category))]
        public virtual ICollection<Admissionform> AdmissionformCategories { get; set; }
        [InverseProperty(nameof(Admissionform.City))]
        public virtual ICollection<Admissionform> AdmissionformCities { get; set; }
        [InverseProperty(nameof(Admissionform.FatherOccupation))]
        public virtual ICollection<Admissionform> AdmissionformFatherOccupations { get; set; }
        [InverseProperty(nameof(Admissionform.Medium))]
        public virtual ICollection<Admissionform> AdmissionformMedia { get; set; }
        [InverseProperty(nameof(Admissionform.MotherOccupation))]
        public virtual ICollection<Admissionform> AdmissionformMotherOccupations { get; set; }
        [InverseProperty(nameof(Admissionform.Religion))]
        public virtual ICollection<Admissionform> AdmissionformReligions { get; set; }
        [InverseProperty(nameof(Admissionform.State))]
        public virtual ICollection<Admissionform> AdmissionformStates { get; set; }
        [InverseProperty(nameof(Booktitle.BookSeries))]
        public virtual ICollection<Booktitle> BooktitleBookSeries { get; set; }
        [InverseProperty(nameof(Booktitle.Category))]
        public virtual ICollection<Booktitle> BooktitleCategories { get; set; }
        [InverseProperty(nameof(Booktitle.Location))]
        public virtual ICollection<Booktitle> BooktitleLocations { get; set; }
        [InverseProperty(nameof(Booktitle.Medium))]
        public virtual ICollection<Booktitle> BooktitleMedia { get; set; }
        [InverseProperty(nameof(Busstop.Route))]
        public virtual ICollection<Busstop> Busstops { get; set; }
        [InverseProperty(nameof(Caste.Category))]
        public virtual ICollection<Caste> Castes { get; set; }
        [InverseProperty(nameof(Classallotment.Day))]
        public virtual ICollection<Classallotment> Classallotments { get; set; }
        [InverseProperty(nameof(Classfee.FeeGroup))]
        public virtual ICollection<Classfee> Classfees { get; set; }
        [InverseProperty(nameof(Classsubjectmarksprimary.SubjectGroup))]
        public virtual ICollection<Classsubjectmarksprimary> Classsubjectmarksprimaries { get; set; }
        [InverseProperty(nameof(Classsubjectmarksprimarydtl.SubType))]
        public virtual ICollection<Classsubjectmarksprimarydtl> Classsubjectmarksprimarydtls { get; set; }
        [InverseProperty(nameof(Classsubjectprimary.SubType))]
        public virtual ICollection<Classsubjectprimary> Classsubjectprimaries { get; set; }
        [InverseProperty(nameof(Classsubject.SubjectGroup))]
        public virtual ICollection<Classsubject> Classsubjects { get; set; }
        [InverseProperty(nameof(Classsubjmark.SubjectGroup))]
        public virtual ICollection<Classsubjmark> Classsubjmarks { get; set; }
        [InverseProperty(nameof(Daywiseperiod.Day))]
        public virtual ICollection<Daywiseperiod> Daywiseperiods { get; set; }
        [InverseProperty(nameof(Departmentconsumption.SubDepartment))]
        public virtual ICollection<Departmentconsumption> Departmentconsumptions { get; set; }
        [InverseProperty(nameof(Despatch.Category))]
        public virtual ICollection<Despatch> Despatches { get; set; }
        [InverseProperty(nameof(Docclass.Docs))]
        public virtual ICollection<Docclass> Docclasses { get; set; }
        [InverseProperty(nameof(Ebook.Category))]
        public virtual ICollection<Ebook> Ebooks { get; set; }
        [InverseProperty(nameof(Employee.Department))]
        public virtual ICollection<Employee> EmployeeDepartments { get; set; }
        [InverseProperty(nameof(Employee.Designation))]
        public virtual ICollection<Employee> EmployeeDesignations { get; set; }
        [InverseProperty(nameof(Employee.EmpCategory))]
        public virtual ICollection<Employee> EmployeeEmpCategories { get; set; }
        [InverseProperty(nameof(Employee.EmployementStatus))]
        public virtual ICollection<Employee> EmployeeEmployementStatuses { get; set; }
        [InverseProperty(nameof(Employee.Tdscategory))]
        public virtual ICollection<Employee> EmployeeTdscategories { get; set; }
        [InverseProperty(nameof(Employeeapplication.Designation))]
        public virtual ICollection<Employeeapplication> EmployeeapplicationDesignations { get; set; }
        [InverseProperty(nameof(Employeeapplication.Qualification))]
        public virtual ICollection<Employeeapplication> EmployeeapplicationQualifications { get; set; }
        [InverseProperty(nameof(Employeedocument.Doc))]
        public virtual ICollection<Employeedocument> Employeedocuments { get; set; }
        [InverseProperty(nameof(Employeesalary.Bank))]
        public virtual ICollection<Employeesalary> EmployeesalaryBanks { get; set; }
        [InverseProperty(nameof(Employeesalary.Category))]
        public virtual ICollection<Employeesalary> EmployeesalaryCategories { get; set; }
        [InverseProperty(nameof(Family.Category))]
        public virtual ICollection<Family> FamilyCategories { get; set; }
        [InverseProperty(nameof(Family.Mtongue))]
        public virtual ICollection<Family> FamilyMtongues { get; set; }
        [InverseProperty(nameof(Family.Nationality))]
        public virtual ICollection<Family> FamilyNationalities { get; set; }
        [InverseProperty(nameof(Family.PermanentCity))]
        public virtual ICollection<Family> FamilyPermanentCities { get; set; }
        [InverseProperty(nameof(Family.PermanentState))]
        public virtual ICollection<Family> FamilyPermanentStates { get; set; }
        [InverseProperty(nameof(Family.PresentCity))]
        public virtual ICollection<Family> FamilyPresentCities { get; set; }
        [InverseProperty(nameof(Family.PresentState))]
        public virtual ICollection<Family> FamilyPresentStates { get; set; }
        [InverseProperty(nameof(Family.Religion))]
        public virtual ICollection<Family> FamilyReligions { get; set; }
        [InverseProperty(nameof(Familydtl.Occupation))]
        public virtual ICollection<Familydtl> FamilydtlOccupations { get; set; }
        [InverseProperty(nameof(Familydtl.Qualification))]
        public virtual ICollection<Familydtl> FamilydtlQualifications { get; set; }
        [InverseProperty(nameof(Feegroupfeehead.FeeGroup))]
        public virtual ICollection<Feegroupfeehead> Feegroupfeeheads { get; set; }
        [InverseProperty(nameof(Feehead.Branch))]
        public virtual ICollection<Feehead> Feeheads { get; set; }
        [InverseProperty(nameof(Feereceipt.Bank))]
        public virtual ICollection<Feereceipt> FeereceiptBanks { get; set; }
        [InverseProperty(nameof(Feereceipt.ForFeeGroup))]
        public virtual ICollection<Feereceipt> FeereceiptForFeeGroups { get; set; }
        [InverseProperty(nameof(Homework.CategorySrc))]
        public virtual ICollection<Homework> Homeworks { get; set; }
        [InverseProperty(nameof(Inward.Category))]
        public virtual ICollection<Inward> Inwards { get; set; }
        [InverseProperty(nameof(Inwardsubcategory.Category))]
        public virtual ICollection<Inwardsubcategory> Inwardsubcategories { get; set; }
        [InverseProperty(nameof(Item.DrugCategory))]
        public virtual ICollection<Item> ItemDrugCategories { get; set; }
        [InverseProperty(nameof(Item.DrugGroup))]
        public virtual ICollection<Item> ItemDrugGroups { get; set; }
        [InverseProperty(nameof(Item.ItemCategory))]
        public virtual ICollection<Item> ItemItemCategories { get; set; }
        [InverseProperty(nameof(Item.Manufacturer))]
        public virtual ICollection<Item> ItemManufacturers { get; set; }
        [InverseProperty(nameof(Item.SubCategory))]
        public virtual ICollection<Item> ItemSubCategories { get; set; }
        [InverseProperty(nameof(Item.Uom1))]
        public virtual ICollection<Item> ItemUom1s { get; set; }
        [InverseProperty(nameof(Item.Uom2))]
        public virtual ICollection<Item> ItemUom2s { get; set; }
        [InverseProperty(nameof(Marksclasswise.RemarkId1Navigation))]
        public virtual ICollection<Marksclasswise> MarksclasswiseRemarkId1Navigations { get; set; }
        [InverseProperty(nameof(Marksclasswise.RemarkId2Navigation))]
        public virtual ICollection<Marksclasswise> MarksclasswiseRemarkId2Navigations { get; set; }
        [InverseProperty(nameof(Marksclasswise.SubjectGroup))]
        public virtual ICollection<Marksclasswise> MarksclasswiseSubjectGroups { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimary.RemarkId1Navigation))]
        public virtual ICollection<Marksclasswiseprimary> MarksclasswiseprimaryRemarkId1Navigations { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimary.RemarkId2Navigation))]
        public virtual ICollection<Marksclasswiseprimary> MarksclasswiseprimaryRemarkId2Navigations { get; set; }
        [InverseProperty(nameof(Marksclasswiseprimarydtl.SubType))]
        public virtual ICollection<Marksclasswiseprimarydtl> Marksclasswiseprimarydtls { get; set; }
        [InverseProperty(nameof(Materialissue.ToSubDepartment))]
        public virtual ICollection<Materialissue> Materialissues { get; set; }
        [InverseProperty(nameof(Materialrequisition.FromSubDepartment))]
        public virtual ICollection<Materialrequisition> Materialrequisitions { get; set; }
        [InverseProperty(nameof(Materialreturn.FromSubDepartment))]
        public virtual ICollection<Materialreturn> Materialreturns { get; set; }
        [InverseProperty(nameof(Parentcommunication.Department))]
        public virtual ICollection<Parentcommunication> Parentcommunications { get; set; }
        [InverseProperty(nameof(Purchaseindent.SubDepartment))]
        public virtual ICollection<Purchaseindent> Purchaseindents { get; set; }
        [InverseProperty(nameof(Purchasequotationtaxdetail.Tax))]
        public virtual ICollection<Purchasequotationtaxdetail> Purchasequotationtaxdetails { get; set; }
        [InverseProperty(nameof(Room.Floor))]
        public virtual ICollection<Room> Rooms { get; set; }
        [InverseProperty(nameof(Scholar.BloodGroup))]
        public virtual ICollection<Scholar> ScholarBloodGroups { get; set; }
        [InverseProperty(nameof(Scholar.DisabilityNavigation))]
        public virtual ICollection<Scholar> ScholarDisabilityNavigations { get; set; }
        [InverseProperty(nameof(Scholar.EnrolStatus))]
        public virtual ICollection<Scholar> ScholarEnrolStatuses { get; set; }
        [InverseProperty(nameof(Scholar.Medium))]
        public virtual ICollection<Scholar> ScholarMedia { get; set; }
        [InverseProperty(nameof(Scholar.PresentArea))]
        public virtual ICollection<Scholar> ScholarPresentAreas { get; set; }
        [InverseProperty(nameof(Scholaractivity.Activity))]
        public virtual ICollection<Scholaractivity> Scholaractivities { get; set; }
        [InverseProperty(nameof(Scholaractivityachievement.EventLevel))]
        public virtual ICollection<Scholaractivityachievement> Scholaractivityachievements { get; set; }
        [InverseProperty(nameof(Scholardiscipline.Comment))]
        public virtual ICollection<Scholardiscipline> Scholardisciplines { get; set; }
        [InverseProperty(nameof(Scholardocument.Docs))]
        public virtual ICollection<Scholardocument> Scholardocuments { get; set; }
        [InverseProperty(nameof(Scholardtl.Campus))]
        public virtual ICollection<Scholardtl> ScholardtlCampuses { get; set; }
        [InverseProperty(nameof(Scholardtl.DropRoute))]
        public virtual ICollection<Scholardtl> ScholardtlDropRoutes { get; set; }
        [InverseProperty(nameof(Scholardtl.DropShift))]
        public virtual ICollection<Scholardtl> ScholardtlDropShifts { get; set; }
        [InverseProperty(nameof(Scholardtl.FeeGroup))]
        public virtual ICollection<Scholardtl> ScholardtlFeeGroups { get; set; }
        [InverseProperty(nameof(Scholardtl.House))]
        public virtual ICollection<Scholardtl> ScholardtlHouses { get; set; }
        [InverseProperty(nameof(Scholardtl.PickupRoute))]
        public virtual ICollection<Scholardtl> ScholardtlPickupRoutes { get; set; }
        [InverseProperty(nameof(Scholardtl.PickupShift))]
        public virtual ICollection<Scholardtl> ScholardtlPickupShifts { get; set; }
        [InverseProperty(nameof(Scholardtl.Shift))]
        public virtual ICollection<Scholardtl> ScholardtlShifts { get; set; }
        [InverseProperty(nameof(Scholardtl.SubjectGroup))]
        public virtual ICollection<Scholardtl> ScholardtlSubjectGroups { get; set; }
        [InverseProperty(nameof(Scholarhosteldtl.Hostel))]
        public virtual ICollection<Scholarhosteldtl> Scholarhosteldtls { get; set; }
        [InverseProperty(nameof(Scholarshippolicy.Category))]
        public virtual ICollection<Scholarshippolicy> Scholarshippolicies { get; set; }
        [InverseProperty(nameof(Section.Msection))]
        public virtual ICollection<Section> Sections { get; set; }
        [InverseProperty(nameof(Semester.SemesterNavigation))]
        public virtual ICollection<Semester> Semesters { get; set; }
        [InverseProperty(nameof(Smscontact.Group))]
        public virtual ICollection<Smscontact> Smscontacts { get; set; }
        [InverseProperty(nameof(Subdepartmentstoresmapping.SubDepartment))]
        public virtual ICollection<Subdepartmentstoresmapping> Subdepartmentstoresmappings { get; set; }
        [InverseProperty(nameof(Subject.Group))]
        public virtual ICollection<Subject> Subjects { get; set; }
        [InverseProperty(nameof(Tax.TaxType))]
        public virtual ICollection<Tax> Taxes { get; set; }
        [InverseProperty(nameof(TblTimetable.Day))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
        [InverseProperty(nameof(Tblmasteritem.ItemCategory))]
        public virtual ICollection<Tblmasteritem> TblmasteritemItemCategories { get; set; }
        [InverseProperty(nameof(Tblmasteritem.Uom))]
        public virtual ICollection<Tblmasteritem> TblmasteritemUoms { get; set; }
        [InverseProperty(nameof(Tblmaterialreceipt.LngDepartment))]
        public virtual ICollection<Tblmaterialreceipt> Tblmaterialreceipts { get; set; }
        [InverseProperty(nameof(Tblmaterialrequisition.LngDepartment))]
        public virtual ICollection<Tblmaterialrequisition> Tblmaterialrequisitions { get; set; }
        [InverseProperty(nameof(Tdsslab.Tdscategory))]
        public virtual ICollection<Tdsslab> Tdsslabs { get; set; }
        [InverseProperty(nameof(Tmpadmissionform.City))]
        public virtual ICollection<Tmpadmissionform> TmpadmissionformCities { get; set; }
        [InverseProperty(nameof(Tmpadmissionform.Medium))]
        public virtual ICollection<Tmpadmissionform> TmpadmissionformMedia { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.Bank))]
        public virtual ICollection<Tmpfeereceipt> TmpfeereceiptBanks { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.ForFeeGroup))]
        public virtual ICollection<Tmpfeereceipt> TmpfeereceiptForFeeGroups { get; set; }
        [InverseProperty(nameof(User.Question))]
        public virtual ICollection<User> Users { get; set; }
        [InverseProperty(nameof(Vehicleaccessory.VehicleAccessories))]
        public virtual ICollection<Vehicleaccessory> Vehicleaccessories { get; set; }
        [InverseProperty(nameof(Vehiclemaintenance.ExpHead))]
        public virtual ICollection<Vehiclemaintenance> Vehiclemaintenances { get; set; }
        [InverseProperty(nameof(Vehicle.Route))]
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        [InverseProperty(nameof(Voucherdtl.Bank))]
        public virtual ICollection<Voucherdtl> Voucherdtls { get; set; }
    }
}
