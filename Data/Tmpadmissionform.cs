using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tmpadmissionform")]
    [Index(nameof(UnitId), Name = "FK_tmpAdmissionForm_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_tmpAdmissionForm_Class")]
    [Index(nameof(MediumId), Name = "FK_tmpAdmissionForm_Masters")]
    [Index(nameof(CityId), Name = "FK_tmpAdmissionForm_Masters1")]
    [Index(nameof(SessionId), Name = "FK_tmpAdmissionForm_Session")]
    public partial class Tmpadmissionform
    {
        public Tmpadmissionform()
        {
            Tmpfeereceipts = new HashSet<Tmpfeereceipt>();
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

        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(Master.TmpadmissionformCities))]
        public virtual Master City { get; set; }
        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Tmpadmissionforms")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(MediumId))]
        [InverseProperty(nameof(Master.TmpadmissionformMedia))]
        public virtual Master Medium { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Tmpadmissionforms")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Tmpadmissionforms))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.AdmForm))]
        public virtual ICollection<Tmpfeereceipt> Tmpfeereceipts { get; set; }
    }
}
