using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bookissue")]
    [Index(nameof(UnitId), Name = "FK_BookIssue_BusinessUnits")]
    [Index(nameof(ScholarId), Name = "FK_BookIssue_Scholar")]
    [Index(nameof(FacultyId), Name = "FK_BookIssue_Teacher")]
    public partial class Bookissue
    {
        public Bookissue()
        {
            Bookissuedtls = new HashSet<Bookissuedtl>();
        }

        [Key]
        public int Id { get; set; }
        public int? ScholarId { get; set; }
        public int? FacultyId { get; set; }
        public int IssueNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Bookissues")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Bookissues))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Bookissuedtl.BookIssue))]
        public virtual ICollection<Bookissuedtl> Bookissuedtls { get; set; }
    }
}
