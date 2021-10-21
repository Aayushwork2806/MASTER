using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("admissiondocuments")]
    [Index(nameof(AdmFormId), Name = "FK_AdmissionDocuments_AdmissionForm")]
    public partial class Admissiondocument
    {
        [Key]
        public int Id { get; set; }
        public int AdmFormId { get; set; }
        public int DocsId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SubmitDate { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }
        [StringLength(100)]
        public string DocPath { get; set; }

        [ForeignKey(nameof(AdmFormId))]
        [InverseProperty(nameof(Admissionform.Admissiondocuments))]
        public virtual Admissionform AdmForm { get; set; }
    }
}
