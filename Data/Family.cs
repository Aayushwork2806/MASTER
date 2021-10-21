using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("family")]
    [Index(nameof(CasteId), Name = "FK_Family_Caste")]
    [Index(nameof(PresentCityId), Name = "FK_Family_Masters")]
    [Index(nameof(PresentStateId), Name = "FK_Family_Masters1")]
    [Index(nameof(NationalityId), Name = "FK_Family_Masters2")]
    [Index(nameof(PermanentCityId), Name = "FK_Family_Masters3")]
    [Index(nameof(PermanentStateId), Name = "FK_Family_Masters4")]
    [Index(nameof(CategoryId), Name = "FK_Family_Masters5")]
    [Index(nameof(ReligionId), Name = "FK_Family_Masters6")]
    [Index(nameof(MtongueId), Name = "FK_Family_Masters7")]
    public partial class Family
    {
        public Family()
        {
            Familydtls = new HashSet<Familydtl>();
            Scholars = new HashSet<Scholar>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FamilyName { get; set; }
        [StringLength(1)]
        public string FamilyType { get; set; }
        [Column("SSSMFamilyId")]
        [StringLength(20)]
        public string SssmfamilyId { get; set; }
        [StringLength(150)]
        public string PresentAddress { get; set; }
        public int? PresentCityId { get; set; }
        public int? PresentStateId { get; set; }
        [StringLength(6)]
        public string PresentPin { get; set; }
        public int? NationalityId { get; set; }
        [StringLength(150)]
        public string PermanentAddress { get; set; }
        public int? PermanentCityId { get; set; }
        public int? PermanentStateId { get; set; }
        [StringLength(6)]
        public string PermanentPin { get; set; }
        public int? CasteId { get; set; }
        public int? CategoryId { get; set; }
        public int? ReligionId { get; set; }
        [Column("MTongueId")]
        public int? MtongueId { get; set; }
        public bool Minority { get; set; }
        public bool Active { get; set; }
        [StringLength(25)]
        public string PresentPhone { get; set; }
        [StringLength(25)]
        public string PermanentPhone { get; set; }

        [ForeignKey(nameof(CasteId))]
        [InverseProperty("Families")]
        public virtual Caste Caste { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.FamilyCategories))]
        public virtual Master Category { get; set; }
        [ForeignKey(nameof(MtongueId))]
        [InverseProperty(nameof(Master.FamilyMtongues))]
        public virtual Master Mtongue { get; set; }
        [ForeignKey(nameof(NationalityId))]
        [InverseProperty(nameof(Master.FamilyNationalities))]
        public virtual Master Nationality { get; set; }
        [ForeignKey(nameof(PermanentCityId))]
        [InverseProperty(nameof(Master.FamilyPermanentCities))]
        public virtual Master PermanentCity { get; set; }
        [ForeignKey(nameof(PermanentStateId))]
        [InverseProperty(nameof(Master.FamilyPermanentStates))]
        public virtual Master PermanentState { get; set; }
        [ForeignKey(nameof(PresentCityId))]
        [InverseProperty(nameof(Master.FamilyPresentCities))]
        public virtual Master PresentCity { get; set; }
        [ForeignKey(nameof(PresentStateId))]
        [InverseProperty(nameof(Master.FamilyPresentStates))]
        public virtual Master PresentState { get; set; }
        [ForeignKey(nameof(ReligionId))]
        [InverseProperty(nameof(Master.FamilyReligions))]
        public virtual Master Religion { get; set; }
        [InverseProperty(nameof(Familydtl.Family))]
        public virtual ICollection<Familydtl> Familydtls { get; set; }
        [InverseProperty(nameof(Scholar.Family))]
        public virtual ICollection<Scholar> Scholars { get; set; }
    }
}
