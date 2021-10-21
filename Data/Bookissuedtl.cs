using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bookissuedtl")]
    [Index(nameof(BookIssueId), Name = "FK_BookIssueDtl_BookIssue")]
    [Index(nameof(BookCopyId), Name = "FK_BookIssueDtl_BookTitleDtl")]
    public partial class Bookissuedtl
    {
        [Key]
        public int Id { get; set; }
        public int BookIssueId { get; set; }
        public int BookCopyId { get; set; }
        [Column(TypeName = "date")]
        public DateTime IssueUpTo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReturnDate { get; set; }
        public int? LateDays { get; set; }
        public double? LateFine { get; set; }
        public bool? FineCollected { get; set; }
        public double? FineAmount { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey(nameof(BookCopyId))]
        [InverseProperty(nameof(Booktitledtl.Bookissuedtls))]
        public virtual Booktitledtl BookCopy { get; set; }
        [ForeignKey(nameof(BookIssueId))]
        [InverseProperty(nameof(Bookissue.Bookissuedtls))]
        public virtual Bookissue BookIssue { get; set; }
    }
}
