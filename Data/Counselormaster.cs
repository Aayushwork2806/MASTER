using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("counselormaster")]
    [Index(nameof(UnitId), Name = "FK_CounselorMaster_BusinessUnits")]
    public partial class Counselormaster
    {
        public Counselormaster()
        {
            Counstoscholars = new HashSet<Counstoscholar>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string Cell1 { get; set; }
        [StringLength(15)]
        public string Cell2 { get; set; }
        [StringLength(50)]
        public string EmailId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [StringLength(50)]
        public string StrId { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Counselormasters))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Counstoscholar.Counselor))]
        public virtual ICollection<Counstoscholar> Counstoscholars { get; set; }
    }
}
