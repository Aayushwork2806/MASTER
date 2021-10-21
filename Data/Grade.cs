using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("grade")]
    [Index(nameof(UnitId), Name = "FK_Grade_BusinessUnits")]
    [Index(nameof(ClassGroupId), Name = "FK_Grade_ClassGroup")]
    [Index(nameof(SessionId), Name = "FK_Grade_Session")]
    public partial class Grade
    {
        public Grade()
        {
            Gradedtls = new HashSet<Gradedtl>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ClassGroupId { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(ClassGroupId))]
        [InverseProperty(nameof(Classgroup.Grades))]
        public virtual Classgroup ClassGroup { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Grades")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Grades))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Gradedtl.GradeNavigation))]
        public virtual ICollection<Gradedtl> Gradedtls { get; set; }
    }
}
