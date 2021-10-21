using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("bookbookings")]
    [Index(nameof(BookId), Name = "FK_BookBookings_BookTitles")]
    [Index(nameof(ScholarId), Name = "FK_BookBookings_Scholar")]
    [Index(nameof(FacultyId), Name = "FK_BookBookings_Teacher")]
    public partial class Bookbooking
    {
        [Key]
        public int Id { get; set; }
        public int BookingNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime BookingDate { get; set; }
        public int? ScholarId { get; set; }
        public int? FacultyId { get; set; }
        public int BookId { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty(nameof(Booktitle.Bookbookings))]
        public virtual Booktitle Book { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Bookbookings")]
        public virtual Scholar Scholar { get; set; }
    }
}
