using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("certificate")]
    public partial class Certificate
    {
        public Certificate()
        {
            Issuedcertificates = new HashSet<Issuedcertificate>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(2)]
        public string CertificateType { get; set; }
        [Required]
        [StringLength(30)]
        public string CertificateName { get; set; }

        [InverseProperty(nameof(Issuedcertificate.Certificate))]
        public virtual ICollection<Issuedcertificate> Issuedcertificates { get; set; }
    }
}
