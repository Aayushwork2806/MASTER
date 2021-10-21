using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marketingdata")]
    [Index(nameof(EnquiryId), Name = "FK_MarketingData_AdmissionEnquiry")]
    [Index(nameof(SessionId), Name = "FK_MarketingData_Session")]
    public partial class Marketingdatum
    {
        public Marketingdatum()
        {
            Marketingdataallocations = new HashSet<Marketingdataallocation>();
        }

        [Key]
        public int Id { get; set; }
        public int? SessionId { get; set; }
        public int EnquiryNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime EnquiryDate { get; set; }
        [StringLength(50)]
        public string StudentName { get; set; }
        [StringLength(25)]
        public string MobileNo { get; set; }
        [StringLength(50)]
        public string FatherName { get; set; }
        [StringLength(50)]
        public string FatherMobileNo { get; set; }
        [StringLength(25)]
        public string LandlineNo { get; set; }
        [StringLength(25)]
        public string EmailId { get; set; }
        [StringLength(25)]
        public string Class { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(50)]
        public string SchoolName { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(25)]
        public string City { get; set; }
        [StringLength(50)]
        public string Source { get; set; }
        public bool Closed { get; set; }
        [StringLength(50)]
        public string ClosedRemark { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ClosingDate { get; set; }
        public bool? Allocated { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FollowupDate { get; set; }
        public int? EnquiryId { get; set; }

        [ForeignKey(nameof(EnquiryId))]
        [InverseProperty(nameof(Admissionenquiry.Marketingdata))]
        public virtual Admissionenquiry Enquiry { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Marketingdata")]
        public virtual Session Session { get; set; }
        [InverseProperty(nameof(Marketingdataallocation.MarketingData))]
        public virtual ICollection<Marketingdataallocation> Marketingdataallocations { get; set; }
    }
}
