using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("businessunitroles")]
    [Index(nameof(BusinessUnitId), Name = "FK_BusinessUnitRoles_BusinessUnits")]
    [Index(nameof(RoleId), Name = "FK_BusinessUnitRoles_Role")]
    public partial class Businessunitrole
    {
        public Businessunitrole()
        {
            Businessunitrolesmenus = new HashSet<Businessunitrolesmenu>();
            Userbusinessunitroles = new HashSet<Userbusinessunitrole>();
        }

        [Key]
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public int RoleId { get; set; }
        public bool? Deleted { get; set; }

        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Businessunitroles))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Businessunitroles")]
        public virtual Role Role { get; set; }
        [InverseProperty(nameof(Businessunitrolesmenu.BusinessUnitRoles))]
        public virtual ICollection<Businessunitrolesmenu> Businessunitrolesmenus { get; set; }
        [InverseProperty(nameof(Userbusinessunitrole.BusinessUnitRoles))]
        public virtual ICollection<Userbusinessunitrole> Userbusinessunitroles { get; set; }
    }
}
