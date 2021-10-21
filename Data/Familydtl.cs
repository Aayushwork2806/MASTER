using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("familydtl")]
    [Index(nameof(FamilyId), Name = "FK_FamilyDtl_Family")]
    [Index(nameof(QualificationId), Name = "FK_FamilyDtl_Masters")]
    [Index(nameof(OccupationId), Name = "FK_FamilyDtl_Masters1")]
    public partial class Familydtl
    {
        [Key]
        public int Id { get; set; }
        public int FamilyId { get; set; }
        [Required]
        [StringLength(1)]
        public string ParentType { get; set; }
        public bool FirstParent { get; set; }
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        public int? QualificationId { get; set; }
        public int? OccupationId { get; set; }
        [StringLength(30)]
        public string Designation { get; set; }
        [StringLength(50)]
        public string OfficeName { get; set; }
        [StringLength(100)]
        public string OfficeAddress { get; set; }
        [StringLength(25)]
        public string OfficePhone { get; set; }
        [StringLength(25)]
        public string Mobile { get; set; }
        [StringLength(60)]
        public string Email { get; set; }
        public long? Income { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AnniversaryDate { get; set; }
        [StringLength(20)]
        public string BiometricId { get; set; }
        [StringLength(100)]
        public string GuardiansAddress { get; set; }
        [StringLength(25)]
        public string GuardiansRelation { get; set; }
        public byte[] Photo { get; set; }
        public bool Delete { get; set; }
        [StringLength(20)]
        public string AadharNo { get; set; }

        [ForeignKey(nameof(FamilyId))]
        [InverseProperty("Familydtls")]
        public virtual Family Family { get; set; }
        [ForeignKey(nameof(OccupationId))]
        [InverseProperty(nameof(Master.FamilydtlOccupations))]
        public virtual Master Occupation { get; set; }
        [ForeignKey(nameof(QualificationId))]
        [InverseProperty(nameof(Master.FamilydtlQualifications))]
        public virtual Master Qualification { get; set; }
    }
}
