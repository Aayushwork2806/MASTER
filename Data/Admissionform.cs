using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("admissionform")]
    [Index(nameof(UnitId), Name = "FK_AdmissionForm_BusinessUnits")]
    [Index(nameof(CasteId), Name = "FK_AdmissionForm_Caste")]
    [Index(nameof(ClassId), Name = "FK_AdmissionForm_Class")]
    [Index(nameof(CategoryId), Name = "FK_AdmissionForm_Master5")]
    [Index(nameof(ReligionId), Name = "FK_AdmissionForm_Master6")]
    [Index(nameof(FatherOccupationId), Name = "FK_AdmissionForm_Master7")]
    [Index(nameof(MotherOccupationId), Name = "FK_AdmissionForm_Master8")]
    [Index(nameof(MediumId), Name = "FK_AdmissionForm_Masters")]
    [Index(nameof(CityId), Name = "FK_AdmissionForm_Masters1")]
    [Index(nameof(StateId), Name = "FK_AdmissionForm_Masters2")]
    [Index(nameof(BloodGroupId), Name = "FK_AdmissionForm_Masters3")]
    [Index(nameof(SemesterId), Name = "FK_AdmissionForm_Semester")]
    [Index(nameof(SessionId), Name = "FK_AdmissionForm_Session")]
    public partial class Admissionform
    {
        public Admissionform()
        {
            Admissiondocuments = new HashSet<Admissiondocument>();
            Admissionenquiries = new HashSet<Admissionenquiry>();
            Feereceipts = new HashSet<Feereceipt>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int FormNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; }
        public int? ClassId { get; set; }
        public int? MediumId { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string MiddleName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(25)]
        public string FatherName { get; set; }
        [StringLength(25)]
        public string FatherLastName { get; set; }
        [StringLength(25)]
        public string FatherMobileNo { get; set; }
        [StringLength(25)]
        public string MotherName { get; set; }
        [StringLength(25)]
        public string MotherLastName { get; set; }
        [StringLength(25)]
        public string MotherMobileNo { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public int? CityId { get; set; }
        [StringLength(25)]
        public string PhoneNo { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        public bool? Registration { get; set; }
        public int? RegistrationNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RegDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FormSubmitDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? InterViewDate { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        public bool Closed { get; set; }
        [StringLength(50)]
        public string ClosedRemark { get; set; }
        public bool? Deleted { get; set; }
        public int? UnitId { get; set; }
        public int? SemesterId { get; set; }
        [StringLength(50)]
        public string EmailId { get; set; }
        public int? StateId { get; set; }
        public int? BloodGroupId { get; set; }
        [StringLength(25)]
        public string StudentMoNo { get; set; }
        public int? CategoryId { get; set; }
        public int? CasteId { get; set; }
        public int? ReligionId { get; set; }
        public int? FatherOccupationId { get; set; }
        public int? MotherOccupationId { get; set; }
        public int? FatherAnnualIncome { get; set; }
        public int? MotherAnnualIncome { get; set; }
        [StringLength(100)]
        public string PreviousSchool { get; set; }
        public byte[] StudentPhoto { get; set; }
        [StringLength(7)]
        public string Gender { get; set; }
        [StringLength(10)]
        public string Pin { get; set; }
        [StringLength(2)]
        public string Mode { get; set; }
        public double? PassingPer { get; set; }
        public int? FamilyId { get; set; }

        [ForeignKey(nameof(BloodGroupId))]
        [InverseProperty(nameof(Master.AdmissionformBloodGroups))]
        public virtual Master BloodGroup { get; set; }
        [ForeignKey(nameof(CasteId))]
        [InverseProperty("Admissionforms")]
        public virtual Caste Caste { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.AdmissionformCategories))]
        public virtual Master Category { get; set; }
        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(Master.AdmissionformCities))]
        public virtual Master City { get; set; }
        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Admissionforms")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(FatherOccupationId))]
        [InverseProperty(nameof(Master.AdmissionformFatherOccupations))]
        public virtual Master FatherOccupation { get; set; }
        [ForeignKey(nameof(MediumId))]
        [InverseProperty(nameof(Master.AdmissionformMedia))]
        public virtual Master Medium { get; set; }
        [ForeignKey(nameof(MotherOccupationId))]
        [InverseProperty(nameof(Master.AdmissionformMotherOccupations))]
        public virtual Master MotherOccupation { get; set; }
        [ForeignKey(nameof(ReligionId))]
        [InverseProperty(nameof(Master.AdmissionformReligions))]
        public virtual Master Religion { get; set; }
        [ForeignKey(nameof(SemesterId))]
        [InverseProperty("Admissionforms")]
        public virtual Semester Semester { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Admissionforms")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(StateId))]
        [InverseProperty(nameof(Master.AdmissionformStates))]
        public virtual Master State { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Admissionforms))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Admissiondocument.AdmForm))]
        public virtual ICollection<Admissiondocument> Admissiondocuments { get; set; }
        [InverseProperty(nameof(Admissionenquiry.FormNo))]
        public virtual ICollection<Admissionenquiry> Admissionenquiries { get; set; }
        [InverseProperty(nameof(Feereceipt.AdmForm))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
    }
}
