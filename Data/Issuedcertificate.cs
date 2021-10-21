using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("issuedcertificates")]
    [Index(nameof(UnitId), Name = "FK_IssuedCertificates_BusinessUnits")]
    [Index(nameof(CertificateId), Name = "FK_IssuedCertificates_Certificate")]
    [Index(nameof(ScholarId), Name = "FK_IssuedCertificates_Scholar")]
    [Index(nameof(SessionId), Name = "FK_IssuedCertificates_Session")]
    public partial class Issuedcertificate
    {
        [Key]
        public int Id { get; set; }
        public int CertificateId { get; set; }
        public int? IssueNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? IssueDate { get; set; }
        public int SessionId { get; set; }
        [StringLength(10)]
        public string RefNo { get; set; }
        public int ScholarId { get; set; }
        [StringLength(50)]
        public string DocHeading { get; set; }
        [StringLength(250)]
        public string DocText { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        public byte PrintCount { get; set; }
        public bool? Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(CertificateId))]
        [InverseProperty("Issuedcertificates")]
        public virtual Certificate Certificate { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Issuedcertificates")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Issuedcertificates")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Issuedcertificates))]
        public virtual Businessunit Unit { get; set; }
    }
}
