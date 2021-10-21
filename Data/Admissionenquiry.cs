using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("admissionenquiry")]
    [Index(nameof(FormNoId), Name = "FK_AdmissionEnquiry_AdmissionForm")]
    [Index(nameof(UnitId), Name = "FK_AdmissionEnquiry_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_AdmissionEnquiry_Class")]
    [Index(nameof(CounsellorId), Name = "FK_AdmissionEnquiry_Employee")]
    [Index(nameof(MediumId), Name = "FK_AdmissionEnquiry_Masters")]
    [Index(nameof(CourseOfferedId), Name = "FK_AdmissionEnquiry_SClass1")]
    [Index(nameof(ScholarId), Name = "FK_AdmissionEnquiry_Scholar")]
    [Index(nameof(SemesterId), Name = "FK_AdmissionEnquiry_Semester")]
    [Index(nameof(SessionId), Name = "FK_AdmissionEnquiry_Session")]
    [Index(nameof(FacultyId), Name = "FK_AdmissionEnquiry_Teacher")]
    public partial class Admissionenquiry
    {
        public Admissionenquiry()
        {
            Marketingdata = new HashSet<Marketingdatum>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int EnquiryNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime EnquiryDate { get; set; }
        [StringLength(25)]
        public string EnquiryMode { get; set; }
        public int ClassId { get; set; }
        public int? MediumId { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(25)]
        public string FatherName { get; set; }
        [StringLength(25)]
        public string FatherLastName { get; set; }
        [StringLength(25)]
        public string FatherMobileNo { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public bool? FormIssued { get; set; }
        public int? FormNoId { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        public bool? Closed { get; set; }
        [StringLength(50)]
        public string ClosedRemark { get; set; }
        public bool Deleted { get; set; }
        public int? UnitId { get; set; }
        public bool? Advertisment { get; set; }
        public bool? Newspaper { get; set; }
        public bool? Radio { get; set; }
        public bool? Hoarding { get; set; }
        public bool? Seminar { get; set; }
        public bool? Teacher { get; set; }
        public bool? Friend { get; set; }
        public bool? Workshop { get; set; }
        [StringLength(25)]
        public string LandlineNo { get; set; }
        [Column("oldSchollCollege")]
        [StringLength(50)]
        public string OldSchollCollege { get; set; }
        [StringLength(25)]
        public string EmailId { get; set; }
        [StringLength(25)]
        public string MiddleName { get; set; }
        [StringLength(25)]
        public string MobileNo { get; set; }
        [StringLength(50)]
        public string Referredby { get; set; }
        public int? CourseOfferedId { get; set; }
        [StringLength(50)]
        public string AnySpecificRemark { get; set; }
        public int? CounsellorId { get; set; }
        public int? FacultyId { get; set; }
        public int? SemesterId { get; set; }
        [StringLength(25)]
        public string SocialMediaId { get; set; }
        public int? ScholarId { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public bool? IsSpectacles { get; set; }
        public bool? IsMaritalStatus { get; set; }
        [StringLength(70)]
        public string SpouseName { get; set; }
        [StringLength(70)]
        public string SpouseOccupation { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("AdmissionenquiryClasses")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(CounsellorId))]
        [InverseProperty(nameof(Employee.Admissionenquiries))]
        public virtual Employee Counsellor { get; set; }
        [ForeignKey(nameof(CourseOfferedId))]
        [InverseProperty("AdmissionenquiryCourseOffereds")]
        public virtual Class CourseOffered { get; set; }
        [ForeignKey(nameof(FormNoId))]
        [InverseProperty(nameof(Admissionform.Admissionenquiries))]
        public virtual Admissionform FormNo { get; set; }
        [ForeignKey(nameof(MediumId))]
        [InverseProperty(nameof(Master.Admissionenquiries))]
        public virtual Master Medium { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Admissionenquiries")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SemesterId))]
        [InverseProperty("Admissionenquiries")]
        public virtual Semester Semester { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Admissionenquiries")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Admissionenquiries))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Marketingdatum.Enquiry))]
        public virtual ICollection<Marketingdatum> Marketingdata { get; set; }
    }
}
